namespace SistemaDeLogin
{
    partial class MenuPrincipal
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
            bemVindoLabel = new Label();
            SuspendLayout();
            // 
            // bemVindoLabel
            // 
            bemVindoLabel.AutoSize = true;
            bemVindoLabel.Location = new Point(0, 0);
            bemVindoLabel.Name = "bemVindoLabel";
            bemVindoLabel.Size = new Size(50, 20);
            bemVindoLabel.TabIndex = 0;
            bemVindoLabel.Text = "label1";
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(bemVindoLabel);
            Name = "MenuPrincipal";
            Text = "Menu Principal";
            Load += MenuPrincipal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label bemVindoLabel;
    }
}