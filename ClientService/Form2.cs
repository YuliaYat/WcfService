

using ClientService.ServiceContext;
using System;
using System.Windows.Forms;

namespace ClientService
{
    public partial class Form2 : Form
    {
        ServiceContractClient sc;
        public Form2(ServiceContractClient _sc)
        {
            InitializeComponent();
            sc = _sc;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Registration registration = new Registration() { login = textBox1.Text, password = textBox2.Text, numbers = textBox3.Text };
            string s = sc.Registration(registration).message;
            if (s == "Account with this username already exists!")
            {
                MessageBox.Show(s);
            }
            else
            {
                MessageBox.Show(s);
                Form3 form3 = new Form3(sc);
                form3.Show();
            }
                
        }
    }
}
