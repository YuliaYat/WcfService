using ClientService.ServiceContext;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientService
{
    public partial class Form4 : Form
    {
        ServiceContractClient sc;

        public Form4(ServiceContractClient _sc)
        {
            InitializeComponent();
            sc = _sc;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Autorization autorization = new Autorization() { login = textBox1.Text, password = textBox2.Text };
            string s = sc.Autorization(autorization).message;
            if (s == "Password or login not founded")
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
