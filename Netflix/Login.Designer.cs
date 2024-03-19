namespace Netflix
{
    partial class Login
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
            label1 = new Label();
            userName = new TextBox();
            passWord = new TextBox();
            loginButton = new Button();
            backButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(352, 183);
            label1.Name = "label1";
            label1.Size = new Size(64, 30);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // userName
            // 
            userName.Location = new Point(337, 230);
            userName.Name = "userName";
            userName.PlaceholderText = "Username";
            userName.Size = new Size(100, 23);
            userName.TabIndex = 1;
            // 
            // passWord
            // 
            passWord.Location = new Point(337, 289);
            passWord.Name = "passWord";
            passWord.PasswordChar = '*';
            passWord.PlaceholderText = "Password";
            passWord.Size = new Size(100, 23);
            passWord.TabIndex = 2;
            // 
            // loginButton
            // 
            loginButton.Location = new Point(352, 352);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(75, 23);
            loginButton.TabIndex = 3;
            loginButton.Text = "Enter";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // backButton
            // 
            backButton.Location = new Point(352, 393);
            backButton.Name = "backButton";
            backButton.Size = new Size(75, 23);
            backButton.TabIndex = 4;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(800, 450);
            Controls.Add(backButton);
            Controls.Add(loginButton);
            Controls.Add(passWord);
            Controls.Add(userName);
            Controls.Add(label1);
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox userName;
        private TextBox passWord;
        private Button loginButton;
        private Button backButton;
    }
}