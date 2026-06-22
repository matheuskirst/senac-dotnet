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
            modulusButton = new Button();
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
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            entryBox = new TextBox();
            expressionBox = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // modulusButton
            // 
            modulusButton.BackColor = SystemColors.ButtonFace;
            modulusButton.Dock = DockStyle.Fill;
            modulusButton.Font = new Font("Segoe UI", 15.75F);
            modulusButton.Location = new Point(3, 144);
            modulusButton.Margin = new Padding(3, 2, 3, 2);
            modulusButton.Name = "modulusButton";
            modulusButton.Size = new Size(72, 49);
            modulusButton.TabIndex = 1;
            modulusButton.Text = "%";
            modulusButton.UseVisualStyleBackColor = false;
            modulusButton.Click += modulusButton_Click;
            // 
            // clearEntryButton
            // 
            clearEntryButton.BackColor = SystemColors.ButtonFace;
            clearEntryButton.Dock = DockStyle.Fill;
            clearEntryButton.Font = new Font("Segoe UI", 15.75F);
            clearEntryButton.Location = new Point(81, 144);
            clearEntryButton.Margin = new Padding(3, 2, 3, 2);
            clearEntryButton.Name = "clearEntryButton";
            clearEntryButton.Size = new Size(72, 49);
            clearEntryButton.TabIndex = 2;
            clearEntryButton.Text = "CE";
            clearEntryButton.UseVisualStyleBackColor = false;
            clearEntryButton.Click += clearEntryButton_Click;
            // 
            // clearAllButton
            // 
            clearAllButton.BackColor = SystemColors.ButtonFace;
            clearAllButton.Dock = DockStyle.Fill;
            clearAllButton.Font = new Font("Segoe UI", 15.75F);
            clearAllButton.Location = new Point(159, 144);
            clearAllButton.Margin = new Padding(3, 2, 3, 2);
            clearAllButton.Name = "clearAllButton";
            clearAllButton.Size = new Size(72, 49);
            clearAllButton.TabIndex = 3;
            clearAllButton.Text = "C";
            clearAllButton.UseVisualStyleBackColor = false;
            clearAllButton.Click += clearAllButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.BackColor = SystemColors.ButtonFace;
            deleteButton.Dock = DockStyle.Fill;
            deleteButton.Font = new Font("Segoe UI", 15.75F);
            deleteButton.Location = new Point(237, 144);
            deleteButton.Margin = new Padding(3, 2, 3, 2);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(74, 49);
            deleteButton.TabIndex = 4;
            deleteButton.Text = "⌫";
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += deleteButton_Click;
            // 
            // divideButton
            // 
            divideButton.BackColor = SystemColors.ButtonFace;
            divideButton.Dock = DockStyle.Fill;
            divideButton.Font = new Font("Segoe UI", 15.75F);
            divideButton.Location = new Point(237, 197);
            divideButton.Margin = new Padding(3, 2, 3, 2);
            divideButton.Name = "divideButton";
            divideButton.Size = new Size(74, 49);
            divideButton.TabIndex = 8;
            divideButton.Text = "÷";
            divideButton.UseVisualStyleBackColor = false;
            divideButton.Click += divideButton_Click;
            // 
            // button6
            // 
            button6.BackColor = SystemColors.ButtonFace;
            button6.Dock = DockStyle.Fill;
            button6.Font = new Font("Segoe UI", 15.75F);
            button6.Location = new Point(159, 197);
            button6.Margin = new Padding(3, 2, 3, 2);
            button6.Name = "button6";
            button6.Size = new Size(72, 49);
            button6.TabIndex = 7;
            button6.Text = "²√x";
            button6.UseVisualStyleBackColor = false;
            // 
            // squareButton
            // 
            squareButton.BackColor = SystemColors.ButtonFace;
            squareButton.Dock = DockStyle.Fill;
            squareButton.Font = new Font("Segoe UI", 15.75F);
            squareButton.Location = new Point(81, 197);
            squareButton.Margin = new Padding(3, 2, 3, 2);
            squareButton.Name = "squareButton";
            squareButton.Size = new Size(72, 49);
            squareButton.TabIndex = 6;
            squareButton.Text = "x²";
            squareButton.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            button8.BackColor = SystemColors.ButtonFace;
            button8.Dock = DockStyle.Fill;
            button8.Font = new Font("Segoe UI", 15.75F);
            button8.Location = new Point(3, 197);
            button8.Margin = new Padding(3, 2, 3, 2);
            button8.Name = "button8";
            button8.Size = new Size(72, 49);
            button8.TabIndex = 5;
            button8.Text = "¹/x";
            button8.UseVisualStyleBackColor = false;
            // 
            // multiplyButton
            // 
            multiplyButton.BackColor = SystemColors.ButtonFace;
            multiplyButton.Dock = DockStyle.Fill;
            multiplyButton.Font = new Font("Segoe UI", 15.75F);
            multiplyButton.Location = new Point(237, 250);
            multiplyButton.Margin = new Padding(3, 2, 3, 2);
            multiplyButton.Name = "multiplyButton";
            multiplyButton.Size = new Size(74, 49);
            multiplyButton.TabIndex = 12;
            multiplyButton.Text = "x";
            multiplyButton.UseVisualStyleBackColor = false;
            multiplyButton.Click += multiplyButton_Click;
            // 
            // numberNineButton
            // 
            numberNineButton.Dock = DockStyle.Fill;
            numberNineButton.Font = new Font("Segoe UI", 15.75F);
            numberNineButton.Location = new Point(159, 250);
            numberNineButton.Margin = new Padding(3, 2, 3, 2);
            numberNineButton.Name = "numberNineButton";
            numberNineButton.Size = new Size(72, 49);
            numberNineButton.TabIndex = 11;
            numberNineButton.Text = "9";
            numberNineButton.UseVisualStyleBackColor = true;
            numberNineButton.Click += numberNineButton_Click;
            // 
            // numberEightButton
            // 
            numberEightButton.Dock = DockStyle.Fill;
            numberEightButton.Font = new Font("Segoe UI", 15.75F);
            numberEightButton.Location = new Point(81, 250);
            numberEightButton.Margin = new Padding(3, 2, 3, 2);
            numberEightButton.Name = "numberEightButton";
            numberEightButton.Size = new Size(72, 49);
            numberEightButton.TabIndex = 10;
            numberEightButton.Text = "8";
            numberEightButton.UseVisualStyleBackColor = true;
            numberEightButton.Click += numberEightButton_Click;
            // 
            // numberSevenButton
            // 
            numberSevenButton.Dock = DockStyle.Fill;
            numberSevenButton.Font = new Font("Segoe UI", 15.75F);
            numberSevenButton.Location = new Point(3, 250);
            numberSevenButton.Margin = new Padding(3, 2, 3, 2);
            numberSevenButton.Name = "numberSevenButton";
            numberSevenButton.Size = new Size(72, 49);
            numberSevenButton.TabIndex = 9;
            numberSevenButton.Text = "7";
            numberSevenButton.UseVisualStyleBackColor = true;
            numberSevenButton.Click += numberSevenButton_Click;
            // 
            // subtractButton
            // 
            subtractButton.BackColor = SystemColors.ButtonFace;
            subtractButton.Dock = DockStyle.Fill;
            subtractButton.Font = new Font("Segoe UI", 15.75F);
            subtractButton.Location = new Point(237, 303);
            subtractButton.Margin = new Padding(3, 2, 3, 2);
            subtractButton.Name = "subtractButton";
            subtractButton.Size = new Size(74, 49);
            subtractButton.TabIndex = 16;
            subtractButton.Text = "-";
            subtractButton.UseVisualStyleBackColor = false;
            subtractButton.Click += subtractButton_Click;
            // 
            // numberSixButton
            // 
            numberSixButton.Dock = DockStyle.Fill;
            numberSixButton.Font = new Font("Segoe UI", 15.75F);
            numberSixButton.Location = new Point(159, 303);
            numberSixButton.Margin = new Padding(3, 2, 3, 2);
            numberSixButton.Name = "numberSixButton";
            numberSixButton.Size = new Size(72, 49);
            numberSixButton.TabIndex = 15;
            numberSixButton.Text = "6";
            numberSixButton.UseVisualStyleBackColor = true;
            numberSixButton.Click += numberSixButton_Click;
            // 
            // numberFiveButton
            // 
            numberFiveButton.Dock = DockStyle.Fill;
            numberFiveButton.Font = new Font("Segoe UI", 15.75F);
            numberFiveButton.Location = new Point(81, 303);
            numberFiveButton.Margin = new Padding(3, 2, 3, 2);
            numberFiveButton.Name = "numberFiveButton";
            numberFiveButton.Size = new Size(72, 49);
            numberFiveButton.TabIndex = 14;
            numberFiveButton.Text = "5";
            numberFiveButton.UseVisualStyleBackColor = true;
            numberFiveButton.Click += numberFiveButton_Click;
            // 
            // numberFourButton
            // 
            numberFourButton.Dock = DockStyle.Fill;
            numberFourButton.Font = new Font("Segoe UI", 15.75F);
            numberFourButton.Location = new Point(3, 303);
            numberFourButton.Margin = new Padding(3, 2, 3, 2);
            numberFourButton.Name = "numberFourButton";
            numberFourButton.Size = new Size(72, 49);
            numberFourButton.TabIndex = 13;
            numberFourButton.Text = "4";
            numberFourButton.UseVisualStyleBackColor = true;
            numberFourButton.Click += numberFourButton_Click;
            // 
            // addButton
            // 
            addButton.BackColor = SystemColors.ButtonFace;
            addButton.Dock = DockStyle.Fill;
            addButton.Font = new Font("Segoe UI", 15.75F);
            addButton.Location = new Point(237, 356);
            addButton.Margin = new Padding(3, 2, 3, 2);
            addButton.Name = "addButton";
            addButton.Size = new Size(74, 49);
            addButton.TabIndex = 20;
            addButton.Text = "+";
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += addButton_Click;
            // 
            // numberThreeButton
            // 
            numberThreeButton.Dock = DockStyle.Fill;
            numberThreeButton.Font = new Font("Segoe UI", 15.75F);
            numberThreeButton.Location = new Point(159, 356);
            numberThreeButton.Margin = new Padding(3, 2, 3, 2);
            numberThreeButton.Name = "numberThreeButton";
            numberThreeButton.Size = new Size(72, 49);
            numberThreeButton.TabIndex = 19;
            numberThreeButton.Text = "3";
            numberThreeButton.UseVisualStyleBackColor = true;
            numberThreeButton.Click += numberThreeButton_Click;
            // 
            // numberTwoButton
            // 
            numberTwoButton.Dock = DockStyle.Fill;
            numberTwoButton.Font = new Font("Segoe UI", 15.75F);
            numberTwoButton.Location = new Point(81, 356);
            numberTwoButton.Margin = new Padding(3, 2, 3, 2);
            numberTwoButton.Name = "numberTwoButton";
            numberTwoButton.Size = new Size(72, 49);
            numberTwoButton.TabIndex = 18;
            numberTwoButton.Text = "2";
            numberTwoButton.UseVisualStyleBackColor = true;
            numberTwoButton.Click += numberTwoButton_Click;
            // 
            // numberOneButton
            // 
            numberOneButton.Dock = DockStyle.Fill;
            numberOneButton.Font = new Font("Segoe UI", 15.75F);
            numberOneButton.Location = new Point(3, 356);
            numberOneButton.Margin = new Padding(3, 2, 3, 2);
            numberOneButton.Name = "numberOneButton";
            numberOneButton.Size = new Size(72, 49);
            numberOneButton.TabIndex = 17;
            numberOneButton.Text = "1";
            numberOneButton.UseVisualStyleBackColor = true;
            numberOneButton.Click += numberOneButton_Click;
            // 
            // equalsButton
            // 
            equalsButton.BackColor = Color.DeepSkyBlue;
            equalsButton.Dock = DockStyle.Fill;
            equalsButton.Font = new Font("Segoe UI", 15.75F);
            equalsButton.Location = new Point(237, 409);
            equalsButton.Margin = new Padding(3, 2, 3, 2);
            equalsButton.Name = "equalsButton";
            equalsButton.Size = new Size(74, 50);
            equalsButton.TabIndex = 24;
            equalsButton.Text = "=";
            equalsButton.UseVisualStyleBackColor = false;
            equalsButton.Click += equalsButton_Click;
            // 
            // commaButton
            // 
            commaButton.Dock = DockStyle.Fill;
            commaButton.Font = new Font("Segoe UI", 15.75F);
            commaButton.Location = new Point(159, 409);
            commaButton.Margin = new Padding(3, 2, 3, 2);
            commaButton.Name = "commaButton";
            commaButton.Size = new Size(72, 50);
            commaButton.TabIndex = 23;
            commaButton.Text = ",";
            commaButton.UseVisualStyleBackColor = true;
            // 
            // zeroButton
            // 
            zeroButton.Dock = DockStyle.Fill;
            zeroButton.Font = new Font("Segoe UI", 15.75F);
            zeroButton.Location = new Point(81, 409);
            zeroButton.Margin = new Padding(3, 2, 3, 2);
            zeroButton.Name = "zeroButton";
            zeroButton.Size = new Size(72, 50);
            zeroButton.TabIndex = 22;
            zeroButton.Text = "0";
            zeroButton.UseVisualStyleBackColor = true;
            // 
            // moreOrLessButton
            // 
            moreOrLessButton.Dock = DockStyle.Fill;
            moreOrLessButton.Font = new Font("Segoe UI", 15.75F);
            moreOrLessButton.Location = new Point(3, 409);
            moreOrLessButton.Margin = new Padding(3, 2, 3, 2);
            moreOrLessButton.Name = "moreOrLessButton";
            moreOrLessButton.Size = new Size(72, 50);
            moreOrLessButton.TabIndex = 21;
            moreOrLessButton.Text = "+/-";
            moreOrLessButton.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(moreOrLessButton, 0, 6);
            tableLayoutPanel1.Controls.Add(clearAllButton, 2, 1);
            tableLayoutPanel1.Controls.Add(deleteButton, 3, 1);
            tableLayoutPanel1.Controls.Add(divideButton, 3, 2);
            tableLayoutPanel1.Controls.Add(zeroButton, 1, 6);
            tableLayoutPanel1.Controls.Add(clearEntryButton, 1, 1);
            tableLayoutPanel1.Controls.Add(button6, 2, 2);
            tableLayoutPanel1.Controls.Add(modulusButton, 0, 1);
            tableLayoutPanel1.Controls.Add(commaButton, 2, 6);
            tableLayoutPanel1.Controls.Add(squareButton, 1, 2);
            tableLayoutPanel1.Controls.Add(equalsButton, 3, 6);
            tableLayoutPanel1.Controls.Add(button8, 0, 2);
            tableLayoutPanel1.Controls.Add(addButton, 3, 5);
            tableLayoutPanel1.Controls.Add(numberThreeButton, 2, 5);
            tableLayoutPanel1.Controls.Add(numberTwoButton, 1, 5);
            tableLayoutPanel1.Controls.Add(numberOneButton, 0, 5);
            tableLayoutPanel1.Controls.Add(subtractButton, 3, 4);
            tableLayoutPanel1.Controls.Add(multiplyButton, 3, 3);
            tableLayoutPanel1.Controls.Add(numberSixButton, 2, 4);
            tableLayoutPanel1.Controls.Add(numberNineButton, 2, 3);
            tableLayoutPanel1.Controls.Add(numberFiveButton, 1, 4);
            tableLayoutPanel1.Controls.Add(numberEightButton, 1, 3);
            tableLayoutPanel1.Controls.Add(numberFourButton, 0, 4);
            tableLayoutPanel1.Controls.Add(numberSevenButton, 0, 3);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 31F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.5F));
            tableLayoutPanel1.Size = new Size(314, 461);
            tableLayoutPanel1.TabIndex = 25;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = SystemColors.ControlLight;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel1.SetColumnSpan(tableLayoutPanel2, 4);
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(entryBox, 0, 1);
            tableLayoutPanel2.Controls.Add(expressionBox, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 45.108696F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 54.891304F));
            tableLayoutPanel2.Size = new Size(308, 136);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // entryBox
            // 
            entryBox.BackColor = SystemColors.ButtonHighlight;
            entryBox.BorderStyle = BorderStyle.None;
            entryBox.Dock = DockStyle.Bottom;
            entryBox.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            entryBox.Location = new Point(3, 63);
            entryBox.Margin = new Padding(3, 2, 3, 2);
            entryBox.Name = "entryBox";
            entryBox.Size = new Size(302, 86);
            entryBox.TabIndex = 1;
            entryBox.TextAlign = HorizontalAlignment.Right;
            entryBox.KeyPress += entryBox_KeyPress;
            // 
            // expressionBox
            // 
            expressionBox.BackColor = SystemColors.ButtonHighlight;
            expressionBox.BorderStyle = BorderStyle.None;
            expressionBox.Dock = DockStyle.Bottom;
            expressionBox.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            expressionBox.ForeColor = Color.FromArgb(64, 64, 64);
            expressionBox.Location = new Point(3, 16);
            expressionBox.Margin = new Padding(3, 2, 3, 2);
            expressionBox.Name = "expressionBox";
            expressionBox.ReadOnly = true;
            expressionBox.Size = new Size(302, 43);
            expressionBox.TabIndex = 0;
            expressionBox.TextAlign = HorizontalAlignment.Right;
            // 
            // FormCalculadora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(314, 461);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(330, 500);
            Name = "FormCalculadora";
            Text = "Calculadora";
            KeyDown += FormCalculadora_KeyDown;
            KeyPress += FormCalculadora_KeyPress;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button modulusButton;
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
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox entryBox;
        private TextBox expressionBox;
        private TableLayoutPanel tableLayoutPanel2;
    }
}
