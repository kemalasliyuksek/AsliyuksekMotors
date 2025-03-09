namespace AsliyuksekMotorsDesktop
{
    partial class LoginForm
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
            txtBoxPassword = new TextBox();
            txtBoxUsername = new TextBox();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // txtBoxPassword
            // 
            txtBoxPassword.BorderStyle = BorderStyle.FixedSingle;
            txtBoxPassword.Font = new Font("Segoe UI", 12F);
            txtBoxPassword.Location = new Point(250, 244);
            txtBoxPassword.Name = "txtBoxPassword";
            txtBoxPassword.PasswordChar = '*';
            txtBoxPassword.Size = new Size(300, 29);
            txtBoxPassword.TabIndex = 0;
            txtBoxPassword.TextAlign = HorizontalAlignment.Center;
            // 
            // txtBoxUsername
            // 
            txtBoxUsername.BorderStyle = BorderStyle.FixedSingle;
            txtBoxUsername.Font = new Font("Segoe UI", 12F);
            txtBoxUsername.Location = new Point(250, 178);
            txtBoxUsername.Name = "txtBoxUsername";
            txtBoxUsername.Size = new Size(300, 29);
            txtBoxUsername.TabIndex = 1;
            txtBoxUsername.TextAlign = HorizontalAlignment.Center;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Segoe UI", 12F);
            btnLogin.Location = new Point(350, 305);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(100, 30);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Giriş Yap";
            btnLogin.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLogin);
            Controls.Add(txtBoxUsername);
            Controls.Add(txtBoxPassword);
            Name = "LoginForm";
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBoxPassword;
        private TextBox txtBoxUsername;
        private Button btnLogin;
    }
}