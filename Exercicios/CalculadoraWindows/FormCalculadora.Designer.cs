namespace CalculadoraWindows
{
    partial class FormCalculadora
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
            panel1 = new Panel();
            entryBox = new TextBox();
            expressionBox = new TextBox();
            percentageButton = new Button();
            clearEntryButton = new Button();
            clearAllButton = new Button();
            deleteButton = new Button();
            divideButton = new Button();
            button6 = new Button();
            squareButton = new Button();
            button8 = new Button();
            multiplyButton = new Button();
            numberNineButton = new Button();
            numberEightButton = new Button();
            numberSevenButton = new Button();
            subtractButton = new Button();
            numberSixButton = new Button();
            numberFiveButton = new Button();
            numberFourButton = new Button();
            addButton = new Button();
            numberThreeButton = new Button();
            numberTwoButton = new Button();
            numberOneButton = new Button();
            equalsButton = new Button();
            commaButton = new Button();
            zeroButton = new Button();
            moreOrLessButton = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(entryBox);
            panel1.Controls.Add(expressionBox);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(396, 130);
            panel1.TabIndex = 0;
            // 
            // entryBox
            // 
            entryBox.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            entryBox.Location = new Point(3, 70);
            entryBox.Name = "entryBox";
            entryBox.Size = new Size(390, 57);
            entryBox.TabIndex = 1;
            entryBox.TextAlign = HorizontalAlignment.Right;
            // 
            // expressionBox
            // 
            expressionBox.Location = new Point(3, 25);
            expressionBox.Name = "expressionBox";
            expressionBox.ReadOnly = true;
            expressionBox.Size = new Size(390, 27);
            expressionBox.TabIndex = 0;
            expressionBox.TextAlign = HorizontalAlignment.Right;
            // 
            // percentageButton
            // 
            percentageButton.Font = new Font("Segoe UI", 13.8F);
            percentageButton.Location = new Point(3, 174);
            percentageButton.Name = "percentageButton";
            percentageButton.Size = new Size(99, 65);
            percentageButton.TabIndex = 1;
            percentageButton.Text = "%";
            percentageButton.UseVisualStyleBackColor = true;
            // 
            // clearEntryButton
            // 
            clearEntryButton.Font = new Font("Segoe UI", 13.8F);
            clearEntryButton.Location = new Point(108, 174);
            clearEntryButton.Name = "clearEntryButton";
            clearEntryButton.Size = new Size(99, 65);
            clearEntryButton.TabIndex = 2;
            clearEntryButton.Text = "CE";
            clearEntryButton.UseVisualStyleBackColor = true;
            clearEntryButton.Click += clearEntryButton_Click;
            // 
            // clearAllButton
            // 
            clearAllButton.Font = new Font("Segoe UI", 13.8F);
            clearAllButton.Location = new Point(213, 174);
            clearAllButton.Name = "clearAllButton";
            clearAllButton.Size = new Size(99, 65);
            clearAllButton.TabIndex = 3;
            clearAllButton.Text = "C";
            clearAllButton.UseVisualStyleBackColor = true;
            clearAllButton.Click += clearAllButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Font = new Font("Segoe UI", 13.8F);
            deleteButton.Location = new Point(318, 174);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(99, 65);
            deleteButton.TabIndex = 4;
            deleteButton.Text = "⌫";
            deleteButton.UseVisualStyleBackColor = true;
            // 
            // divideButton
            // 
            divideButton.Font = new Font("Segoe UI", 13.8F);
            divideButton.Location = new Point(318, 257);
            divideButton.Name = "divideButton";
            divideButton.Size = new Size(99, 65);
            divideButton.TabIndex = 8;
            divideButton.Text = "÷";
            divideButton.UseVisualStyleBackColor = true;
            divideButton.Click += divideButton_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 13.8F);
            button6.Location = new Point(213, 257);
            button6.Name = "button6";
            button6.Size = new Size(99, 65);
            button6.TabIndex = 7;
            button6.Text = "²√x";
            button6.UseVisualStyleBackColor = true;
            // 
            // squareButton
            // 
            squareButton.Font = new Font("Segoe UI", 13.8F);
            squareButton.Location = new Point(108, 257);
            squareButton.Name = "squareButton";
            squareButton.Size = new Size(99, 65);
            squareButton.TabIndex = 6;
            squareButton.Text = "x²";
            squareButton.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI", 13.8F);
            button8.Location = new Point(3, 257);
            button8.Name = "button8";
            button8.Size = new Size(99, 65);
            button8.TabIndex = 5;
            button8.Text = "¹/x";
            button8.UseVisualStyleBackColor = true;
            // 
            // multiplyButton
            // 
            multiplyButton.Font = new Font("Segoe UI", 13.8F);
            multiplyButton.Location = new Point(318, 340);
            multiplyButton.Name = "multiplyButton";
            multiplyButton.Size = new Size(99, 65);
            multiplyButton.TabIndex = 12;
            multiplyButton.Text = "x";
            multiplyButton.UseVisualStyleBackColor = true;
            multiplyButton.Click += multiplyButton_Click;
            // 
            // numberNineButton
            // 
            numberNineButton.Font = new Font("Segoe UI", 13.8F);
            numberNineButton.Location = new Point(213, 340);
            numberNineButton.Name = "numberNineButton";
            numberNineButton.Size = new Size(99, 65);
            numberNineButton.TabIndex = 11;
            numberNineButton.Text = "9";
            numberNineButton.UseVisualStyleBackColor = true;
            numberNineButton.Click += numberNineButton_Click;
            // 
            // numberEightButton
            // 
            numberEightButton.Font = new Font("Segoe UI", 13.8F);
            numberEightButton.Location = new Point(108, 340);
            numberEightButton.Name = "numberEightButton";
            numberEightButton.Size = new Size(99, 65);
            numberEightButton.TabIndex = 10;
            numberEightButton.Text = "8";
            numberEightButton.UseVisualStyleBackColor = true;
            numberEightButton.Click += numberEightButton_Click;
            // 
            // numberSevenButton
            // 
            numberSevenButton.Font = new Font("Segoe UI", 13.8F);
            numberSevenButton.Location = new Point(3, 340);
            numberSevenButton.Name = "numberSevenButton";
            numberSevenButton.Size = new Size(99, 65);
            numberSevenButton.TabIndex = 9;
            numberSevenButton.Text = "7";
            numberSevenButton.UseVisualStyleBackColor = true;
            numberSevenButton.Click += numberSevenButton_Click;
            // 
            // subtractButton
            // 
            subtractButton.Font = new Font("Segoe UI", 13.8F);
            subtractButton.Location = new Point(318, 422);
            subtractButton.Name = "subtractButton";
            subtractButton.Size = new Size(99, 65);
            subtractButton.TabIndex = 16;
            subtractButton.Text = "-";
            subtractButton.UseVisualStyleBackColor = true;
            subtractButton.Click += subtractButton_Click;
            // 
            // numberSixButton
            // 
            numberSixButton.Font = new Font("Segoe UI", 13.8F);
            numberSixButton.Location = new Point(213, 422);
            numberSixButton.Name = "numberSixButton";
            numberSixButton.Size = new Size(99, 65);
            numberSixButton.TabIndex = 15;
            numberSixButton.Text = "6";
            numberSixButton.UseVisualStyleBackColor = true;
            numberSixButton.Click += numberSixButton_Click;
            // 
            // numberFiveButton
            // 
            numberFiveButton.Font = new Font("Segoe UI", 13.8F);
            numberFiveButton.Location = new Point(108, 422);
            numberFiveButton.Name = "numberFiveButton";
            numberFiveButton.Size = new Size(99, 65);
            numberFiveButton.TabIndex = 14;
            numberFiveButton.Text = "5";
            numberFiveButton.UseVisualStyleBackColor = true;
            numberFiveButton.Click += numberFiveButton_Click;
            // 
            // numberFourButton
            // 
            numberFourButton.Font = new Font("Segoe UI", 13.8F);
            numberFourButton.Location = new Point(3, 422);
            numberFourButton.Name = "numberFourButton";
            numberFourButton.Size = new Size(99, 65);
            numberFourButton.TabIndex = 13;
            numberFourButton.Text = "4";
            numberFourButton.UseVisualStyleBackColor = true;
            numberFourButton.Click += numberFourButton_Click;
            // 
            // addButton
            // 
            addButton.Font = new Font("Segoe UI", 13.8F);
            addButton.Location = new Point(318, 501);
            addButton.Name = "addButton";
            addButton.Size = new Size(99, 65);
            addButton.TabIndex = 20;
            addButton.Text = "+";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // numberThreeButton
            // 
            numberThreeButton.Font = new Font("Segoe UI", 13.8F);
            numberThreeButton.Location = new Point(213, 501);
            numberThreeButton.Name = "numberThreeButton";
            numberThreeButton.Size = new Size(99, 65);
            numberThreeButton.TabIndex = 19;
            numberThreeButton.Text = "3";
            numberThreeButton.UseVisualStyleBackColor = true;
            numberThreeButton.Click += numberThreeButton_Click;
            // 
            // numberTwoButton
            // 
            numberTwoButton.Font = new Font("Segoe UI", 13.8F);
            numberTwoButton.Location = new Point(108, 501);
            numberTwoButton.Name = "numberTwoButton";
            numberTwoButton.Size = new Size(99, 65);
            numberTwoButton.TabIndex = 18;
            numberTwoButton.Text = "2";
            numberTwoButton.UseVisualStyleBackColor = true;
            numberTwoButton.Click += numberTwoButton_Click;
            // 
            // numberOneButton
            // 
            numberOneButton.Font = new Font("Segoe UI", 13.8F);
            numberOneButton.Location = new Point(3, 501);
            numberOneButton.Name = "numberOneButton";
            numberOneButton.Size = new Size(99, 65);
            numberOneButton.TabIndex = 17;
            numberOneButton.Text = "1";
            numberOneButton.UseVisualStyleBackColor = true;
            numberOneButton.Click += numberOneButton_Click;
            // 
            // equalsButton
            // 
            equalsButton.Font = new Font("Segoe UI", 13.8F);
            equalsButton.Location = new Point(318, 586);
            equalsButton.Name = "equalsButton";
            equalsButton.Size = new Size(99, 65);
            equalsButton.TabIndex = 24;
            equalsButton.Text = "=";
            equalsButton.UseVisualStyleBackColor = true;
            equalsButton.Click += equalsButton_Click;
            // 
            // commaButton
            // 
            commaButton.Font = new Font("Segoe UI", 13.8F);
            commaButton.Location = new Point(213, 586);
            commaButton.Name = "commaButton";
            commaButton.Size = new Size(99, 65);
            commaButton.TabIndex = 23;
            commaButton.Text = ",";
            commaButton.UseVisualStyleBackColor = true;
            // 
            // zeroButton
            // 
            zeroButton.Font = new Font("Segoe UI", 13.8F);
            zeroButton.Location = new Point(108, 586);
            zeroButton.Name = "zeroButton";
            zeroButton.Size = new Size(99, 65);
            zeroButton.TabIndex = 22;
            zeroButton.Text = "0";
            zeroButton.UseVisualStyleBackColor = true;
            // 
            // moreOrLessButton
            // 
            moreOrLessButton.Font = new Font("Segoe UI", 13.8F);
            moreOrLessButton.Location = new Point(3, 586);
            moreOrLessButton.Name = "moreOrLessButton";
            moreOrLessButton.Size = new Size(99, 65);
            moreOrLessButton.TabIndex = 21;
            moreOrLessButton.Text = "+/-";
            moreOrLessButton.UseVisualStyleBackColor = true;
            // 
            // FormCalculadora
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(420, 663);
            Controls.Add(equalsButton);
            Controls.Add(commaButton);
            Controls.Add(zeroButton);
            Controls.Add(moreOrLessButton);
            Controls.Add(addButton);
            Controls.Add(numberThreeButton);
            Controls.Add(numberTwoButton);
            Controls.Add(numberOneButton);
            Controls.Add(subtractButton);
            Controls.Add(numberSixButton);
            Controls.Add(numberFiveButton);
            Controls.Add(numberFourButton);
            Controls.Add(multiplyButton);
            Controls.Add(numberNineButton);
            Controls.Add(numberEightButton);
            Controls.Add(numberSevenButton);
            Controls.Add(divideButton);
            Controls.Add(button6);
            Controls.Add(squareButton);
            Controls.Add(button8);
            Controls.Add(deleteButton);
            Controls.Add(clearAllButton);
            Controls.Add(clearEntryButton);
            Controls.Add(percentageButton);
            Controls.Add(panel1);
            Name = "FormCalculadora";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button percentageButton;
        private Button clearEntryButton;
        private Button clearAllButton;
        private Button deleteButton;
        private Button divideButton;
        private Button button6;
        private Button squareButton;
        private Button button8;
        private Button multiplyButton;
        private Button numberNineButton;
        private Button numberEightButton;
        private Button numberSevenButton;
        private Button subtractButton;
        private Button numberSixButton;
        private Button numberFiveButton;
        private Button numberFourButton;
        private Button addButton;
        private Button numberThreeButton;
        private Button numberTwoButton;
        private Button numberOneButton;
        private Button equalsButton;
        private Button commaButton;
        private Button zeroButton;
        private Button moreOrLessButton;
        private TextBox entryBox;
        private TextBox expressionBox;
    }
}
