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
    public partial class Form3 : Form
    {
        ServiceContractClient sc;

        public Form3(ServiceContractClient _sc)
        {
            InitializeComponent();
            sc = _sc;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
