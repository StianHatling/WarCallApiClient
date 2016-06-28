using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;
using WarCallApiClient.Models;

namespace WarCallApiClient
{
    public partial class ClientForm : Form
    {
        public ClientForm()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            //var http = "Https://api.instech.no/WarCall/Insurance/SaveInsurance";
            var http = "http://localhost:4504/WarCall/Insurance/SaveInsurance";
            var insurance = Insurance.GetTestInsurance();
            var content = JsonConvert.SerializeObject(insurance);
            var data = Encoding.UTF8.GetBytes(content);
            var token = GetJwt();

            var response = RunPost(http, content, token);

        }

        private string RunPost(string http, string body, string token)
        {
            var data = Encoding.UTF8.GetBytes(body);
            var request = (HttpWebRequest)WebRequest.Create(http);
            //request.
            request.Method = "POST";
            request.ContentType = "application/json";
            request.ContentLength = data.Length;

            if (token != "")
            {
                token = "Bearer " + token;
                request.Headers.Add("Authorization", token);
            }

            using (var stream = request.GetRequestStream())
            {
                stream.Write(data, 0, data.Length);
            }

            try
            {
                var response = request.GetResponse();

                var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
                return responseString;
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }



        private string GetJwt()
        {
            
            string http = "https://norclub.eu.auth0.com/delegation";

            string clientId = "CN4LzJigtNdjvRJGYlP6tCcTA0ahSg8P";
            string grantType = "urn:ietf:params:oauth:grant-type:jwt-bearer";
            string refreshtoken = "YSEo0NbzuHQklmlwoObppDqvndarzwlG0nmR5G8cRheDY";
            string scope = "openid profile offline_access";
            string apiType = "INS2000";

            string body = GetJwtBody(clientId, grantType, refreshtoken, scope, apiType);

            var response = RunPost(http, body, "");
            var array = response.Split(new Char[] { '{', ',', '}' });

            foreach (var s in array)
            {
                if (s.Contains("id_token"))
                {
                    var subArray = s.Split(new Char[] { ':' });
                    var token = subArray[subArray.Length - 1];
                    return token.Replace('"',' ');
                }
            }

            return "";
        }

        private string GetJwtBody(string clientId, string grantType, string refreshtoken, string scope, string apiType)
        {
            Dictionary<String, string> list = new Dictionary<string, string>();
            list.Add("client_id", clientId);
            list.Add("grant_type", grantType);
            list.Add("refresh_token", refreshtoken);
            list.Add("scope", scope);
            list.Add("api_type", apiType);
            return JsonConvert.SerializeObject(list);
        }

        private void byId_Click(object sender, EventArgs e)
        {
            int id = 1;
           // var http = "Https://api.instech.no/WarCall/Insurance/ById/"+id.ToString();
            var http = "http://localhost:4504/WarCall/Insurance/ById/" + id.ToString();
            var token = GetJwt();      

            var request = (HttpWebRequest)WebRequest.Create(http);

            if (token != "")
            {
                token = "Bearer " + token;
                request.Headers.Add("Authorization", token);
            }
            var response = request.GetResponse();

            var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
        }

        private void btnGetFailed_Click(object sender, EventArgs e)
        {
            var http = "http://localhost:4504/WarCall/Insurance/GetFailedImports";
            var token = GetJwt();
            var request = (HttpWebRequest)WebRequest.Create(http);

            if (token != "")
            {
                token = "Bearer " + token;
                request.Headers.Add("Authorization", token);
            }
            var response = request.GetResponse();

            var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();

        }
    }
}
