namespace Calculadora
{
    partial class FormCalculadora
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
            numeroUmBox = new TextBox();
            numeroDoisBox = new TextBox();
            addButton = new Button();
            minusButton = new Button();
            multiplyButton = new Button();
            divideButton = new Button();
            label1 = new Label();
            resultLabel = new Label();
            calcSymbol = new Label();
            panel1 = new Panel();
            closeButton = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // numeroUmBox
            // 
            numeroUmBox.Anchor = AnchorStyles.None;
            numeroUmBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numeroUmBox.Location = new Point(10, 53);
            numeroUmBox.Name = "numeroUmBox";
            numeroUmBox.Size = new Size(124, 39);
            numeroUmBox.TabIndex = 0;
            // 
            // numeroDoisBox
            // 
            numeroDoisBox.Anchor = AnchorStyles.None;
            numeroDoisBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numeroDoisBox.Location = new Point(167, 53);
            numeroDoisBox.Name = "numeroDoisBox";
            numeroDoisBox.Size = new Size(125, 39);
            numeroDoisBox.TabIndex = 1;
            // 
            // addButton
            // 
            addButton.Anchor = AnchorStyles.None;
            addButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addButton.Location = new Point(14, 147);
            addButton.Name = "addButton";
            addButton.Size = new Size(121, 45);
            addButton.TabIndex = 2;
            addButton.Text = "+";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // minusButton
            // 
            minusButton.Anchor = AnchorStyles.None;
            minusButton.Font = new Font("Segoe UI", 11.25F);
            minusButton.Location = new Point(167, 147);
            minusButton.Name = "minusButton";
            minusButton.Size = new Size(121, 45);
            minusButton.TabIndex = 3;
            minusButton.Text = "-";
            minusButton.UseVisualStyleBackColor = true;
            minusButton.Click += minusButton_Click;
            // 
            // multiplyButton
            // 
            multiplyButton.Anchor = AnchorStyles.None;
            multiplyButton.Font = new Font("Segoe UI", 11.25F);
            multiplyButton.Location = new Point(14, 211);
            multiplyButton.Name = "multiplyButton";
            multiplyButton.Size = new Size(121, 45);
            multiplyButton.TabIndex = 4;
            multiplyButton.Text = "*";
            multiplyButton.UseVisualStyleBackColor = true;
            multiplyButton.Click += multiplyButton_Click;
            // 
            // divideButton
            // 
            divideButton.Anchor = AnchorStyles.None;
            divideButton.Font = new Font("Segoe UI", 11.25F);
            divideButton.Location = new Point(167, 211);
            divideButton.Name = "divideButton";
            divideButton.Size = new Size(121, 45);
            divideButton.TabIndex = 5;
            divideButton.Text = "/";
            divideButton.UseVisualStyleBackColor = true;
            divideButton.Click += divideButton_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(3, 15);
            label1.Name = "label1";
            label1.Size = new Size(102, 28);
            label1.TabIndex = 6;
            label1.Text = "Resultado:";
            // 
            // resultLabel
            // 
            resultLabel.Anchor = AnchorStyles.None;
            resultLabel.AutoSize = true;
            resultLabel.Font = new Font("Segoe UI", 12F);
            resultLabel.Location = new Point(104, 15);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(0, 28);
            resultLabel.TabIndex = 7;
            // 
            // calcSymbol
            // 
            calcSymbol.Anchor = AnchorStyles.None;
            calcSymbol.AutoSize = true;
            calcSymbol.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            calcSymbol.Location = new Point(137, 57);
            calcSymbol.Name = "calcSymbol";
            calcSymbol.Size = new Size(0, 32);
            calcSymbol.TabIndex = 8;
            calcSymbol.Click += label2_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(resultLabel);
            panel1.Location = new Point(10, 281);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(278, 96);
            panel1.TabIndex = 9;
            // 
            // closeButton
            // 
            closeButton.Location = new Point(198, 387);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(94, 29);
            closeButton.TabIndex = 10;
            closeButton.Text = "Fechar";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // FormCalculadora
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(302, 428);
            Controls.Add(closeButton);
            Controls.Add(panel1);
            Controls.Add(calcSymbol);
            Controls.Add(divideButton);
            Controls.Add(multiplyButton);
            Controls.Add(minusButton);
            Controls.Add(addButton);
            Controls.Add(numeroDoisBox);
            Controls.Add(numeroUmBox);
            Name = "FormCalculadora";
            Text = "FormCalculadora";
            Load += FormCalculadora_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox numeroUmBox;
        private TextBox numeroDoisBox;
        private Button addButton;
        private Button minusButton;
        private Button multiplyButton;
        private Button divideButton;
        private Label label1;
        private Label resultLabel;
        private Label calcSymbol;
        private Panel panel1;
        private Button closeButton;
    }
}