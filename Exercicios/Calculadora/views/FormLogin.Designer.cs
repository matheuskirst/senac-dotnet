namespace Calculadora
{
    partial class FormLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            userNameLabel = new Label();
            userNameBox = new TextBox();
            passwordBox = new TextBox();
            passwordLabel = new Label();
            buttonLogin = new Button();
            SuspendLayout();
            // 
            // userNameLabel
            // 
            userNameLabel.AutoSize = true;
            userNameLabel.Font = new Font("Segoe UI", 12F);
            userNameLabel.Location = new Point(12, 9);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new Size(83, 28);
            userNameLabel.TabIndex = 0;
            userNameLabel.Text = "Usuário:";
            // 
            // userNameBox
            // 
            userNameBox.Location = new Point(119, 13);
            userNameBox.Name = "userNameBox";
            userNameBox.Size = new Size(125, 27);
            userNameBox.TabIndex = 1;
            // 
            // passwordBox
            // 
            passwordBox.Location = new Point(119, 65);
            passwordBox.Name = "passwordBox";
            passwordBox.Size = new Size(125, 27);
            passwordBox.TabIndex = 2;
            passwordBox.UseSystemPasswordChar = true;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Segoe UI", 12F);
            passwordLabel.Location = new Point(12, 61);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(69, 28);
            passwordLabel.TabIndex = 3;
            passwordLabel.Text = "Senha:";
            // 
            // buttonLogin
            // 
            buttonLogin.Location = new Point(12, 130);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(94, 29);
            buttonLogin.TabIndex = 4;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += ButtonLogin_Click;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(860, 499);
            Controls.Add(buttonLogin);
            Controls.Add(passwordLabel);
            Controls.Add(passwordBox);
            Controls.Add(userNameBox);
            Controls.Add(userNameLabel);
            Name = "FormLogin";
            Text = "Sistema de Login";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label userNameLabel;
        private TextBox userNameBox;
        private TextBox passwordBox;
        private Label passwordLabel;
        private Button buttonLogin;
    }
}
