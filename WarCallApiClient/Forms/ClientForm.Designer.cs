namespace WarCallApiClient
{
    partial class ClientForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSaveIns = new System.Windows.Forms.Button();
            this.byId = new System.Windows.Forms.Button();
            this.btnGetFailed = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSaveIns
            // 
            this.btnSaveIns.Location = new System.Drawing.Point(44, 27);
            this.btnSaveIns.Name = "btnSaveIns";
            this.btnSaveIns.Size = new System.Drawing.Size(234, 33);
            this.btnSaveIns.TabIndex = 0;
            this.btnSaveIns.Text = "Save Insurance";
            this.btnSaveIns.UseVisualStyleBackColor = true;
            this.btnSaveIns.Click += new System.EventHandler(this.btn_Click);
            // 
            // byId
            // 
            this.byId.Location = new System.Drawing.Point(44, 82);
            this.byId.Name = "byId";
            this.byId.Size = new System.Drawing.Size(234, 34);
            this.byId.TabIndex = 1;
            this.byId.Text = "Get Insurance from ID 1";
            this.byId.UseVisualStyleBackColor = true;
            this.byId.Click += new System.EventHandler(this.byId_Click);
            // 
            // btnGetFailed
            // 
            this.btnGetFailed.Location = new System.Drawing.Point(44, 140);
            this.btnGetFailed.Name = "btnGetFailed";
            this.btnGetFailed.Size = new System.Drawing.Size(234, 32);
            this.btnGetFailed.TabIndex = 2;
            this.btnGetFailed.Text = "Get Failed Imports";
            this.btnGetFailed.UseVisualStyleBackColor = true;
            this.btnGetFailed.Click += new System.EventHandler(this.btnGetFailed_Click);
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 312);
            this.Controls.Add(this.btnGetFailed);
            this.Controls.Add(this.byId);
            this.Controls.Add(this.btnSaveIns);
            this.Name = "ClientForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSaveIns;
        private System.Windows.Forms.Button byId;
        private System.Windows.Forms.Button btnGetFailed;
    }
}

