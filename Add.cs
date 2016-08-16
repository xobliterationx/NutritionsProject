using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace HranitelniDobavki
{
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
        }

        private void Add_Load(object sender, EventArgs e)
        {
         

    }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to preserve data?", "conservation", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                FileStream fs = new FileStream(@"D:\HranitelniDobavki.dat", FileMode.OpenOrCreate);
                BinaryWriter bw = new BinaryWriter(fs);
                fs.Seek(0, SeekOrigin.End);
                bw.Write(naimenovanie.SelectedItem.ToString());
                bw.Write(grupa.Text.ToString());
                bw.Write(proizvoditel.SelectedItem.ToString());
                bw.Write(double.Parse(cena.Text));
                bw.Write(int.Parse(nalichnost.Text));
                fs.Close();
                this.Close();
                MessageBox.Show("Data were stored successfully");
                AllData m = new AllData();
                m.Visible = true;
            }
            }

        private void naimenovanie_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
    }
}
