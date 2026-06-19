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
            numberOneBox = new TextBox();
            numberTwoBox = new TextBox();
            addButton = new Button();
            minusButton = new Button();
            multiplyButton = new Button();
            divideButton = new Button();
            label1 = new Label();
            resultLabel = new Label();
            calcSymbol = new Label();
            SuspendLayout();
            // 
            // numberOneBox
            // 
            numberOneBox.Location = new Point(12, 12);
            numberOneBox.Name = "numberOneBox";
            numberOneBox.Size = new Size(125, 27);
            numberOneBox.TabIndex = 0;
            // 
            // numberTwoBox
            // 
            numberTwoBox.Location = new Point(168, 12);
            numberTwoBox.Name = "numberTwoBox";
            numberTwoBox.Size = new Size(125, 27);
            numberTwoBox.TabIndex = 1;
            // 
            // addButton
            // 
            addButton.Location = new Point(12, 68);
            addButton.Name = "addButton";
            addButton.Size = new Size(94, 29);
            addButton.TabIndex = 2;
            addButton.Text = "+";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // minusButton
            // 
            minusButton.Location = new Point(112, 68);
            minusButton.Name = "minusButton";
            minusButton.Size = new Size(94, 29);
            minusButton.TabIndex = 3;
            minusButton.Text = "-";
            minusButton.UseVisualStyleBackColor = true;
            minusButton.Click += minusButton_Click;
            // 
            // multiplyButton
            // 
            multiplyButton.Location = new Point(12, 103);
            multiplyButton.Name = "multiplyButton";
            multiplyButton.Size = new Size(94, 29);
            multiplyButton.TabIndex = 4;
            multiplyButton.Text = "*";
            multiplyButton.UseVisualStyleBackColor = true;
            multiplyButton.Click += multiplyButton_Click;
            // 
            // divideButton
            // 
            divideButton.Location = new Point(112, 103);
            divideButton.Name = "divideButton";
            divideButton.Size = new Size(94, 29);
            divideButton.TabIndex = 5;
            divideButton.Text = "/";
            divideButton.UseVisualStyleBackColor = true;
            divideButton.Click += divideButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 155);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 6;
            label1.Text = "Resultado:";
            // 
            // resultLabel
            // 
            resultLabel.AutoSize = true;
            resultLabel.Location = new Point(96, 155);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(0, 20);
            resultLabel.TabIndex = 7;
            // 
            // calcSymbol
            // 
            calcSymbol.AutoSize = true;
            calcSymbol.Location = new Point(143, 15);
            calcSymbol.Name = "calcSymbol";
            calcSymbol.Size = new Size(0, 20);
            calcSymbol.TabIndex = 8;
            calcSymbol.Click += label2_Click;
            // 
            // FormCalculadora
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(calcSymbol);
            Controls.Add(resultLabel);
            Controls.Add(label1);
            Controls.Add(divideButton);
            Controls.Add(multiplyButton);
            Controls.Add(minusButton);
            Controls.Add(addButton);
            Controls.Add(numberTwoBox);
            Controls.Add(numberOneBox);
            Name = "FormCalculadora";
            Text = "FormCalculadora";
            Load += FormCalculadora_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox numberOneBox;
        private TextBox numberTwoBox;
        private Button addButton;
        private Button minusButton;
        private Button multiplyButton;
        private Button divideButton;
        private Label label1;
        private Label resultLabel;
        private Label calcSymbol;
    }
}