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
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        private void Search_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.Parse(priceFromTB.Text) >=0 && int.Parse(priceToTB.Text) <=1000 )
            {
                dataGridView1.Rows.Clear();
                FileStream fs = new FileStream(@"D:\HranitelniDobavki.dat", FileMode.Open);
                BinaryReader br = new BinaryReader(fs);
                double from = double.Parse(priceFromTB.Text);
                double to = double.Parse(priceToTB.Text);
                while (fs.Position < fs.Length)
                {
                    string article = br.ReadString();
                    string brand = br.ReadString();
                    string type = br.ReadString();
                    double pr = br.ReadDouble();
                    int st = br.ReadInt32();
                    if (pr >= from && pr <= to)
                        dataGridView1.Rows.Add(article, brand, type, pr, st);
                }
                fs.Close();
            }
            else MessageBox.Show("Add Price");
            dataGridView1.Sort(dataGridView1.Columns["Column4"], ListSortDirection.Ascending);
        }
    }
    }


