namespace finaluriMelashvili
{
    public partial class Form1 : Form
    {
        public bool firstName;
        public bool lastName;
        public bool number;
        public bool password;
        public bool user;
        public bool checker;
        public bool graphChecker;
        public int totalPrice = 3500;

        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (firstName && lastName && number && password && user && checker && graphChecker)
            {
                MessageBox.Show($"registration was successful and your monthly payment will be {totalPrice / 10}");
            } else
            if (firstName && lastName && number && password && user && checker)
            {
                MessageBox.Show("registration was successful");
            } 
            else
            {
                MessageBox.Show("insufficient information.");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox1.Checked)
            {
                checker = false;
                MessageBox.Show("CheckBox is not checked. Please check the box.");
            }
            else
            {
                checker = true;
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                password = false;
            }
            if (textBox2.Text.Length >= 8)
            {
                password = true;
            }
            else
            {
                password = false;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                number = false;
            }
            if (textBox1.Text.Length >= 9)
            {
                number = true;
            }
            else
            {
                number = false;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                firstName = false;
            }
            else
            {
                firstName = true;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                lastName = false;
            }
            else
            {
                lastName = true;
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (textBox5.Text == "")
            {
                user = false;
            }
            else
            {
                user = true;
            }
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox2.Checked)
            {
                graphChecker = false;
            }
            else
            {
                graphChecker = true;
            }
        }
    }
}