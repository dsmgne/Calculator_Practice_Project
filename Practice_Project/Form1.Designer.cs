namespace Practice_Project
{
    partial class Calculator
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
            Addition = new Button();
            Subtract = new Button();
            Multiply = new Button();
            divide = new Button();
            CalculatorHeading = new Label();
            FirstNumber = new Label();
            SecondNumber = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            result = new Label();
            SuspendLayout();
            // 
            // Addition
            // 
            Addition.BackColor = Color.Red;
            Addition.ForeColor = SystemColors.ControlText;
            Addition.Location = new Point(29, 231);
            Addition.Margin = new Padding(3, 2, 3, 2);
            Addition.Name = "Addition";
            Addition.Size = new Size(65, 29);
            Addition.TabIndex = 0;
            Addition.Text = "Add";
            Addition.UseVisualStyleBackColor = false;
            Addition.Click += Addition_Click;
            // 
            // Subtract
            // 
            Subtract.BackColor = Color.Red;
            Subtract.ForeColor = SystemColors.ControlText;
            Subtract.Location = new Point(111, 231);
            Subtract.Margin = new Padding(3, 2, 3, 2);
            Subtract.Name = "Subtract";
            Subtract.Size = new Size(65, 29);
            Subtract.TabIndex = 1;
            Subtract.Text = "Sub";
            Subtract.UseVisualStyleBackColor = false;
            Subtract.Click += button1_Click;
            // 
            // Multiply
            // 
            Multiply.BackColor = Color.Red;
            Multiply.ForeColor = SystemColors.ControlText;
            Multiply.Location = new Point(196, 231);
            Multiply.Margin = new Padding(3, 2, 3, 2);
            Multiply.Name = "Multiply";
            Multiply.Size = new Size(65, 29);
            Multiply.TabIndex = 2;
            Multiply.Text = "Multiply";
            Multiply.UseVisualStyleBackColor = false;
            Multiply.Click += Multiply_Click;
            // 
            // divide
            // 
            divide.BackColor = Color.Red;
            divide.ForeColor = SystemColors.ControlText;
            divide.Location = new Point(281, 231);
            divide.Margin = new Padding(3, 2, 3, 2);
            divide.Name = "divide";
            divide.Size = new Size(65, 29);
            divide.TabIndex = 3;
            divide.Text = "Divide";
            divide.UseVisualStyleBackColor = false;
            divide.Click += Divide_Click;
            // 
            // CalculatorHeading
            // 
            CalculatorHeading.AutoSize = true;
            CalculatorHeading.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            CalculatorHeading.Location = new Point(147, 9);
            CalculatorHeading.Name = "CalculatorHeading";
            CalculatorHeading.Size = new Size(88, 21);
            CalculatorHeading.TabIndex = 4;
            CalculatorHeading.Text = "Calculator";
            CalculatorHeading.Click += label1_Click;
            // 
            // FirstNumber
            // 
            FirstNumber.AutoSize = true;
            FirstNumber.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            FirstNumber.Location = new Point(43, 62);
            FirstNumber.Name = "FirstNumber";
            FirstNumber.Size = new Size(109, 21);
            FirstNumber.TabIndex = 5;
            FirstNumber.Text = "First Number";
            // 
            // SecondNumber
            // 
            SecondNumber.AutoSize = true;
            SecondNumber.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            SecondNumber.Location = new Point(43, 124);
            SecondNumber.Name = "SecondNumber";
            SecondNumber.Size = new Size(133, 21);
            SecondNumber.TabIndex = 6;
            SecondNumber.Text = "Second Number";
            SecondNumber.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(179, 60);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(177, 23);
            textBox1.TabIndex = 7;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(179, 122);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(177, 23);
            textBox2.TabIndex = 8;
            // 
            // result
            // 
            result.AutoSize = true;
            result.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            result.Location = new Point(126, 304);
            result.Name = "result";
            result.Size = new Size(0, 21);
            result.TabIndex = 9;
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 361);
            Controls.Add(result);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(SecondNumber);
            Controls.Add(FirstNumber);
            Controls.Add(CalculatorHeading);
            Controls.Add(divide);
            Controls.Add(Multiply);
            Controls.Add(Subtract);
            Controls.Add(Addition);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Calculator";
            Text = "Calculator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Addition;
        private Button Subtract;
        private Button Multiply;
        private Button divide;
        private Label CalculatorHeading;
        private Label FirstNumber;
        private Label SecondNumber;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label result;
    }
}