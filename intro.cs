using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HranitelniDobavki
{
    public partial class intro : Form
    {
        public intro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AllData data = new AllData();
            data.Show();
            Visible = false; 
        }

        private void intro_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
