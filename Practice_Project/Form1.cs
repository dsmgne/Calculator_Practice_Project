namespace Practice_Project
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" & textBox2.Text != "")
            {
                int value1, value2;
                int finalResult;

                value1 = int.Parse(textBox1.Text);
                value2 = int.Parse(textBox2.Text);

                finalResult = value1 - value2;

                result.Text = "Subtration is:" + finalResult.ToString();
            }
            else
            {
                if (textBox1.Text != "" & textBox2.Text == "")
                {
                    result.Text = "Please add value 2";
                }
                if (textBox2.Text != "" & textBox1.Text == "")
                {
                    result.Text = "Please add value 1";
                }
                if (textBox1.Text == "" & textBox2.Text == "")
                {
                    result.Text = "Please fill value 1 and value 2";
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Addition_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" & textBox2.Text != "")
            {
                int value1, value2;
                int finalResult;

                value1 = int.Parse(textBox1.Text);
                value2 = int.Parse(textBox2.Text);

                finalResult = value1 + value2;

                result.Text = "Addition is:" + finalResult.ToString();
            }
            else
            {
                if (textBox1.Text != "" & textBox2.Text == "")
                {
                    result.Text = "Please add value 2";
                }
                if (textBox2.Text != "" & textBox1.Text == "")
                {
                    result.Text = "Please add value 1";
                }
                if (textBox1.Text == "" & textBox2.Text == "")
                {
                    result.Text = "Please fill value 1 and value 2";
                }
            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Multiply_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" & textBox2.Text != "")
            {
                int value1, value2;
                int finalResult;

                value1 = int.Parse(textBox1.Text);
                value2 = int.Parse(textBox2.Text);

                finalResult = value1 * value2;

                result.Text = "Multiplication is:" + finalResult.ToString();
            }
            else
            {
                if (textBox1.Text != "" & textBox2.Text == "")
                {
                    result.Text = "Please add value 2";
                }
                if (textBox2.Text != "" & textBox1.Text == "")
                {
                    result.Text = "Please add value 1";
                }
                if (textBox1.Text == "" & textBox2.Text == "")
                {
                    result.Text = "Please fill value 1 and value 2";
                }
            }
        }

        private void Divide_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" & textBox2.Text != "")
            {
                int value1, value2;
                int finalResult;

                value1 = int.Parse(textBox1.Text);
                value2 = int.Parse(textBox2.Text);

                finalResult = value1 / value2;

                result.Text = "Division is:" + finalResult.ToString();
            }
            else
            {
                if (textBox1.Text != "" & textBox2.Text == "")
                {
                    result.Text = "Please add value 2";
                }
                if (textBox2.Text != "" & textBox1.Text == "")
                {
                    result.Text = "Please add value 1";
                }
                if (textBox1.Text == "" & textBox2.Text == "")
                {
                    result.Text = "Please fill value 1 and value 2";
                }
            }
        }
    }
}