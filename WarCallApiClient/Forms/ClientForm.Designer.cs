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
            this.btnInsertVisit = new System.Windows.Forms.Button();
            this.lblWarCall = new System.Windows.Forms.Label();
            this.lblVisit = new System.Windows.Forms.Label();
            this.btnUpdateVisit = new System.Windows.Forms.Button();
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
            // btnInsertVisit
            // 
            this.btnInsertVisit.Location = new System.Drawing.Point(44, 230);
            this.btnInsertVisit.Name = "btnInsertVisit";
            this.btnInsertVisit.Size = new System.Drawing.Size(234, 32);
            this.btnInsertVisit.TabIndex = 3;
            this.btnInsertVisit.Text = "Insert Visit";
            this.btnInsertVisit.UseVisualStyleBackColor = true;
            this.btnInsertVisit.Click += new System.EventHandler(this.btnInsertVisit_Click);
            // 
            // lblWarCall
            // 
            this.lblWarCall.AutoSize = true;
            this.lblWarCall.Location = new System.Drawing.Point(41, 9);
            this.lblWarCall.Name = "lblWarCall";
            this.lblWarCall.Size = new System.Drawing.Size(47, 13);
            this.lblWarCall.TabIndex = 4;
            this.lblWarCall.Text = "War Call";
            // 
            // lblVisit
            // 
            this.lblVisit.AutoSize = true;
            this.lblVisit.Location = new System.Drawing.Point(41, 214);
            this.lblVisit.Name = "lblVisit";
            this.lblVisit.Size = new System.Drawing.Size(31, 13);
            this.lblVisit.TabIndex = 5;
            this.lblVisit.Text = "Visits";
            // 
            // btnUpdateVisit
            // 
            this.btnUpdateVisit.Location = new System.Drawing.Point(44, 268);
            this.btnUpdateVisit.Name = "btnUpdateVisit";
            this.btnUpdateVisit.Size = new System.Drawing.Size(234, 32);
            this.btnUpdateVisit.TabIndex = 6;
            this.btnUpdateVisit.Text = "Update Visit";
            this.btnUpdateVisit.UseVisualStyleBackColor = true;
            this.btnUpdateVisit.Click += new System.EventHandler(this.btnUpdateVisit_Click);
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 312);
            this.Controls.Add(this.btnUpdateVisit);
            this.Controls.Add(this.lblVisit);
            this.Controls.Add(this.lblWarCall);
            this.Controls.Add(this.btnInsertVisit);
            this.Controls.Add(this.btnGetFailed);
            this.Controls.Add(this.byId);
            this.Controls.Add(this.btnSaveIns);
            this.Name = "ClientForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSaveIns;
        private System.Windows.Forms.Button byId;
        private System.Windows.Forms.Button btnGetFailed;
        private System.Windows.Forms.Button btnInsertVisit;
        private System.Windows.Forms.Label lblWarCall;
        private System.Windows.Forms.Label lblVisit;
        private System.Windows.Forms.Button btnUpdateVisit;
    }
}

