using ClientService.ServiceContext;
using System;
using System.Windows.Forms;

namespace ClientService
{
    public partial class Form1 : Form
    {
        ServiceContractClient sc;
        public Form1()
        {
            InitializeComponent();
            sc = new ServiceContractClient();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(sc);
            form2.Show();
        }
    }
}
