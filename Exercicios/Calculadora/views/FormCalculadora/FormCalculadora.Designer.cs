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
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // numeroUmBox
            // 
            numeroUmBox.Anchor = AnchorStyles.None;
            numeroUmBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numeroUmBox.Location = new Point(9, 40);
            numeroUmBox.Margin = new Padding(3, 2, 3, 2);
            numeroUmBox.Name = "numeroUmBox";
            numeroUmBox.Size = new Size(109, 33);
            numeroUmBox.TabIndex = 0;
            // 
            // numeroDoisBox
            // 
            numeroDoisBox.Anchor = AnchorStyles.None;
            numeroDoisBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numeroDoisBox.Location = new Point(146, 40);
            numeroDoisBox.Margin = new Padding(3, 2, 3, 2);
            numeroDoisBox.Name = "numeroDoisBox";
            numeroDoisBox.Size = new Size(110, 33);
            numeroDoisBox.TabIndex = 1;
            // 
            // addButton
            // 
            addButton.Anchor = AnchorStyles.None;
            addButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addButton.Location = new Point(12, 110);
            addButton.Margin = new Padding(3, 2, 3, 2);
            addButton.Name = "addButton";
            addButton.Size = new Size(106, 34);
            addButton.TabIndex = 2;
            addButton.Text = "+";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // minusButton
            // 
            minusButton.Anchor = AnchorStyles.None;
            minusButton.Font = new Font("Segoe UI", 11.25F);
            minusButton.Location = new Point(146, 110);
            minusButton.Margin = new Padding(3, 2, 3, 2);
            minusButton.Name = "minusButton";
            minusButton.Size = new Size(106, 34);
            minusButton.TabIndex = 3;
            minusButton.Text = "-";
            minusButton.UseVisualStyleBackColor = true;
            minusButton.Click += minusButton_Click;
            // 
            // multiplyButton
            // 
            multiplyButton.Anchor = AnchorStyles.None;
            multiplyButton.Font = new Font("Segoe UI", 11.25F);
            multiplyButton.Location = new Point(12, 158);
            multiplyButton.Margin = new Padding(3, 2, 3, 2);
            multiplyButton.Name = "multiplyButton";
            multiplyButton.Size = new Size(106, 34);
            multiplyButton.TabIndex = 4;
            multiplyButton.Text = "*";
            multiplyButton.UseVisualStyleBackColor = true;
            multiplyButton.Click += multiplyButton_Click;
            // 
            // divideButton
            // 
            divideButton.Anchor = AnchorStyles.None;
            divideButton.Font = new Font("Segoe UI", 11.25F);
            divideButton.Location = new Point(146, 158);
            divideButton.Margin = new Padding(3, 2, 3, 2);
            divideButton.Name = "divideButton";
            divideButton.Size = new Size(106, 34);
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
            label1.Location = new Point(3, 17);
            label1.Name = "label1";
            label1.Size = new Size(82, 21);
            label1.TabIndex = 6;
            label1.Text = "Resultado:";
            // 
            // resultLabel
            // 
            resultLabel.Anchor = AnchorStyles.None;
            resultLabel.AutoSize = true;
            resultLabel.Font = new Font("Segoe UI", 12F);
            resultLabel.Location = new Point(91, 17);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(0, 21);
            resultLabel.TabIndex = 7;
            // 
            // calcSymbol
            // 
            calcSymbol.Anchor = AnchorStyles.None;
            calcSymbol.AutoSize = true;
            calcSymbol.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            calcSymbol.Location = new Point(120, 43);
            calcSymbol.Name = "calcSymbol";
            calcSymbol.Size = new Size(0, 25);
            calcSymbol.TabIndex = 8;
            calcSymbol.Click += label2_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(resultLabel);
            panel1.Location = new Point(9, 224);
            panel1.Name = "panel1";
            panel1.Size = new Size(243, 85);
            panel1.TabIndex = 9;
            // 
            // FormCalculadora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(264, 321);
            Controls.Add(panel1);
            Controls.Add(calcSymbol);
            Controls.Add(divideButton);
            Controls.Add(multiplyButton);
            Controls.Add(minusButton);
            Controls.Add(addButton);
            Controls.Add(numeroDoisBox);
            Controls.Add(numeroUmBox);
            Margin = new Padding(3, 2, 3, 2);
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
    }
}