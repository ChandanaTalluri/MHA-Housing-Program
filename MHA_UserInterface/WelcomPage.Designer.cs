namespace MHA_UserInterface
{
    partial class WelcomPage
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
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_UserID = new System.Windows.Forms.Label();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.txt_userID = new System.Windows.Forms.TextBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.btn_Login = new System.Windows.Forms.Button();
            this.txt_DatabaseName = new System.Windows.Forms.TextBox();
            this.txt_ServerName = new System.Windows.Forms.TextBox();
            this.lbl_ServerName = new System.Windows.Forms.Label();
            this.lbl_DatabaseName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(306, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Please enter login credentials.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_UserID
            // 
            this.lbl_UserID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_UserID.Location = new System.Drawing.Point(12, 39);
            this.lbl_UserID.Name = "lbl_UserID";
            this.lbl_UserID.Size = new System.Drawing.Size(100, 20);
            this.lbl_UserID.TabIndex = 2;
            this.lbl_UserID.Text = "UserID:";
            // 
            // lbl_Password
            // 
            this.lbl_Password.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_Password.Location = new System.Drawing.Point(12, 65);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(100, 20);
            this.lbl_Password.TabIndex = 3;
            this.lbl_Password.Text = "Password:";
            // 
            // txt_userID
            // 
            this.txt_userID.Location = new System.Drawing.Point(118, 39);
            this.txt_userID.Name = "txt_userID";
            this.txt_userID.Size = new System.Drawing.Size(200, 20);
            this.txt_userID.TabIndex = 4;
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(118, 65);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PasswordChar = '*';
            this.txt_Password.Size = new System.Drawing.Size(200, 20);
            this.txt_Password.TabIndex = 5;
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(12, 143);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(306, 22);
            this.btn_Login.TabIndex = 6;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // txt_DatabaseName
            // 
            this.txt_DatabaseName.Location = new System.Drawing.Point(118, 117);
            this.txt_DatabaseName.Name = "txt_DatabaseName";
            this.txt_DatabaseName.Size = new System.Drawing.Size(200, 20);
            this.txt_DatabaseName.TabIndex = 7;
            // 
            // txt_ServerName
            // 
            this.txt_ServerName.Location = new System.Drawing.Point(118, 91);
            this.txt_ServerName.Name = "txt_ServerName";
            this.txt_ServerName.Size = new System.Drawing.Size(200, 20);
            this.txt_ServerName.TabIndex = 8;
            // 
            // lbl_ServerName
            // 
            this.lbl_ServerName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_ServerName.Location = new System.Drawing.Point(12, 91);
            this.lbl_ServerName.Name = "lbl_ServerName";
            this.lbl_ServerName.Size = new System.Drawing.Size(100, 20);
            this.lbl_ServerName.TabIndex = 9;
            this.lbl_ServerName.Text = "Server Name";
            // 
            // lbl_DatabaseName
            // 
            this.lbl_DatabaseName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_DatabaseName.Location = new System.Drawing.Point(12, 117);
            this.lbl_DatabaseName.Name = "lbl_DatabaseName";
            this.lbl_DatabaseName.Size = new System.Drawing.Size(100, 20);
            this.lbl_DatabaseName.TabIndex = 10;
            this.lbl_DatabaseName.Text = "Database Name";
            // 
            // WelcomPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 177);
            this.Controls.Add(this.lbl_DatabaseName);
            this.Controls.Add(this.lbl_ServerName);
            this.Controls.Add(this.txt_ServerName);
            this.Controls.Add(this.txt_DatabaseName);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.txt_userID);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.lbl_UserID);
            this.Controls.Add(this.label2);
            this.MaximumSize = new System.Drawing.Size(342, 216);
            this.MinimumSize = new System.Drawing.Size(342, 216);
            this.Name = "WelcomPage";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.WelcomPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_UserID;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.TextBox txt_userID;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.TextBox txt_DatabaseName;
        private System.Windows.Forms.TextBox txt_ServerName;
        private System.Windows.Forms.Label lbl_ServerName;
        private System.Windows.Forms.Label lbl_DatabaseName;
    }
}