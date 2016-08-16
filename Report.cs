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
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }

        private void Report_Load(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            FileStream p = new FileStream(@"D:\HranitelniDobavki.dat", FileMode.Open);
            BinaryReader br = new BinaryReader(p);
            dataGridView1.Visible = true;
            dataGridView1.Rows.Clear();
            using (br)
            {
                while (p.Position < p.Length)
                {
                    string name = br.ReadString();
                    string gr = br.ReadString();
                    string pn = br.ReadString();
                    double pr = br.ReadDouble();
                    int st = br.ReadInt32();
                    if (comboBox1.Text == pn)
                    {
                        dataGridView1.Rows.Add(name, gr, pn, pr, st);
                    }
                }
            }
        }
    }
}
