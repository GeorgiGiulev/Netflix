namespace Netflix
{
    partial class Form2
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
            userName = new TextBox();
            passWord = new TextBox();
            label1 = new Label();
            usernameValid = new Label();
            passwordValid = new Label();
            loginButton = new Button();
            rePassword = new TextBox();
            buttonGoLogin = new Button();
            SuspendLayout();
            // 
            // userName
            // 
            userName.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            userName.Location = new Point(318, 161);
            userName.Name = "userName";
            userName.PlaceholderText = "Username";
            userName.Size = new Size(126, 25);
            userName.TabIndex = 0;
            userName.TextChanged += userName_TextChanged;
            userName.Validating += uNameTxt_Validating;
            // 
            // passWord
            // 
            passWord.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            passWord.Location = new Point(318, 243);
            passWord.Name = "passWord";
            passWord.PasswordChar = '*';
            passWord.PlaceholderText = "Password";
            passWord.Size = new Size(126, 25);
            passWord.TabIndex = 1;
            passWord.TextChanged += passWord_TextChanged;
            passWord.Validating += passwordTxt_Validating;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(315, 108);
            label1.Name = "label1";
            label1.Size = new Size(129, 25);
            label1.TabIndex = 2;
            label1.Text = "Welcome User";
            label1.Click += label1_Click;
            // 
            // usernameValid
            // 
            usernameValid.AutoSize = true;
            usernameValid.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            usernameValid.Location = new Point(281, 205);
            usernameValid.Name = "usernameValid";
            usernameValid.Size = new Size(212, 17);
            usernameValid.TabIndex = 3;
            usernameValid.Text = "Username has at least 5 characters";
            // 
            // passwordValid
            // 
            passwordValid.AutoSize = true;
            passwordValid.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            passwordValid.Location = new Point(191, 283);
            passwordValid.Name = "passwordValid";
            passwordValid.Size = new Size(402, 17);
            passwordValid.TabIndex = 4;
            passwordValid.Text = "Password has over 8 characters and contains upper and lower case";
            passwordValid.TextChanged += passwordLabel;
            // 
            // loginButton
            // 
            loginButton.Location = new Point(340, 361);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(75, 23);
            loginButton.TabIndex = 5;
            loginButton.Text = "Sign In";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // rePassword
            // 
            rePassword.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            rePassword.Location = new Point(318, 316);
            rePassword.Name = "rePassword";
            rePassword.PasswordChar = '*';
            rePassword.PlaceholderText = "Retype Password";
            rePassword.Size = new Size(126, 25);
            rePassword.TabIndex = 6;
            // 
            // buttonGoLogin
            // 
            buttonGoLogin.Location = new Point(340, 404);
            buttonGoLogin.Name = "buttonGoLogin";
            buttonGoLogin.Size = new Size(75, 23);
            buttonGoLogin.TabIndex = 7;
            buttonGoLogin.Text = "Login";
            buttonGoLogin.UseVisualStyleBackColor = true;
            buttonGoLogin.Click += buttonGoLogin_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonGoLogin);
            Controls.Add(rePassword);
            Controls.Add(loginButton);
            Controls.Add(passwordValid);
            Controls.Add(usernameValid);
            Controls.Add(label1);
            Controls.Add(passWord);
            Controls.Add(userName);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox userName;
        private TextBox passWord;
        private Label label1;
        private Label usernameLabel;
        private Label passwordValid;
        private Button loginButton;
        private TextBox rePassword;
        private Label usernameValid;
        private Button buttonGoLogin;
    }
}