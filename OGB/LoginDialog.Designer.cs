namespace OGB
{
    partial class LoginDialog
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
            this.BTN_Send = new System.Windows.Forms.Button();
            this.TB_Server = new System.Windows.Forms.TextBox();
            this.TB_Username = new System.Windows.Forms.TextBox();
            this.TB_Password = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BTN_Send
            // 
            this.BTN_Send.Location = new System.Drawing.Point(12, 91);
            this.BTN_Send.Name = "BTN_Send";
            this.BTN_Send.Size = new System.Drawing.Size(260, 23);
            this.BTN_Send.TabIndex = 0;
            this.BTN_Send.Text = "Send";
            this.BTN_Send.UseVisualStyleBackColor = true;
            this.BTN_Send.Click += new System.EventHandler(this.BTN_Send_Click);
            // 
            // TB_Server
            // 
            this.TB_Server.Location = new System.Drawing.Point(13, 13);
            this.TB_Server.Name = "TB_Server";
            this.TB_Server.Size = new System.Drawing.Size(259, 20);
            this.TB_Server.TabIndex = 1;
            this.TB_Server.Text = "Server name";
            // 
            // TB_Username
            // 
            this.TB_Username.Location = new System.Drawing.Point(12, 39);
            this.TB_Username.Name = "TB_Username";
            this.TB_Username.Size = new System.Drawing.Size(259, 20);
            this.TB_Username.TabIndex = 2;
            this.TB_Username.Text = "Username";
            // 
            // TB_Password
            // 
            this.TB_Password.Location = new System.Drawing.Point(12, 65);
            this.TB_Password.Name = "TB_Password";
            this.TB_Password.Size = new System.Drawing.Size(259, 20);
            this.TB_Password.TabIndex = 3;
            this.TB_Password.Text = "Password";
            this.TB_Password.UseSystemPasswordChar = true;
            // 
            // LoginDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 124);
            this.ControlBox = false;
            this.Controls.Add(this.TB_Password);
            this.Controls.Add(this.TB_Username);
            this.Controls.Add(this.TB_Server);
            this.Controls.Add(this.BTN_Send);
            this.Name = "LoginDialog";
            this.Text = "Login data";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_Send;
        private System.Windows.Forms.TextBox TB_Server;
        private System.Windows.Forms.TextBox TB_Username;
        private System.Windows.Forms.TextBox TB_Password;
    }
}