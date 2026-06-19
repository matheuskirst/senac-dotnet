namespace SistemaDeLogin
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
            userNameLabel.Anchor = AnchorStyles.None;
            userNameLabel.AutoSize = true;
            userNameLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userNameLabel.Location = new Point(43, 90);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new Size(62, 20);
            userNameLabel.TabIndex = 0;
            userNameLabel.Text = "Usuário:";
            // 
            // userNameBox
            // 
            userNameBox.Anchor = AnchorStyles.None;
            userNameBox.Location = new Point(111, 91);
            userNameBox.Margin = new Padding(3, 2, 3, 2);
            userNameBox.Name = "userNameBox";
            userNameBox.Size = new Size(110, 23);
            userNameBox.TabIndex = 1;
            // 
            // passwordBox
            // 
            passwordBox.Anchor = AnchorStyles.None;
            passwordBox.Location = new Point(111, 126);
            passwordBox.Margin = new Padding(3, 2, 3, 2);
            passwordBox.Name = "passwordBox";
            passwordBox.Size = new Size(110, 23);
            passwordBox.TabIndex = 2;
            passwordBox.UseSystemPasswordChar = true;
            // 
            // passwordLabel
            // 
            passwordLabel.Anchor = AnchorStyles.None;
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordLabel.Location = new Point(43, 129);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(52, 20);
            passwordLabel.TabIndex = 3;
            passwordLabel.Text = "Senha:";
            // 
            // buttonLogin
            // 
            buttonLogin.Anchor = AnchorStyles.None;
            buttonLogin.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonLogin.Location = new Point(91, 260);
            buttonLogin.Margin = new Padding(3, 2, 3, 2);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(82, 35);
            buttonLogin.TabIndex = 4;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += ButtonLogin_Click;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(264, 321);
            Controls.Add(buttonLogin);
            Controls.Add(passwordLabel);
            Controls.Add(passwordBox);
            Controls.Add(userNameBox);
            Controls.Add(userNameLabel);
            Margin = new Padding(3, 2, 3, 2);
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
