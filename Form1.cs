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
    public partial class AllData : Form
    {
        public AllData()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AllData_Load(object sender, EventArgs e)
        {
            FileStream fs;
            if (!File.Exists(@"D:\hranitelnidobavki.dat"))
            {

                fs = new FileStream(@"D:\hranitelnidobavki.dat", FileMode.CreateNew);
                BinaryWriter bw = new BinaryWriter(fs);
                bw.Write("6400");
                bw.Write("BCAA");
                bw.Write("Scitec Nutrition");
                bw.Write(50.00);
                bw.Write(375);
                fs.Close();
            }
            string[] prod = new string[10];
            int[] broi = new int[10];
            int r = 0;
            fs = new FileStream(@"D:\hranitelnidobavki.dat", FileMode.Open);
            BinaryReader br = new BinaryReader(fs);
            while (fs.Position < fs.Length)
            {
                string name = br.ReadString();
                string gr = br.ReadString();
                string pn = br.ReadString();
                double pr = br.ReadDouble();
                int st = br.ReadInt32();
                allDataDGV.Rows.Add(name, gr, pn, pr, st);
                bool flag = false;
                int pos = 0;
                for (int i = 0; i < r; i++)
                {
                    if (prod[i] == pn)
                    {
                        flag = true;
                        pos = i;
                    }
                    if (flag == true)
                        broi[pos]++;
                    else
                    {
                        prod[r] = pn;
                        broi[r]++;
                        r++;
                    }
                }
            }

            fs.Close();
            int all = 0;
            statsLB.Items.Clear();
            for (int i = 0; i < r; i++)
            {
                statsLB.Items.Add(prod[i] + "=" + broi[i]);
                all += broi[i];
            }
            statsLB.Items.Add("---------------");
            statsLB.Items.Add("Total in catalog:" + all);
           

        }

        private void AddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void ReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void SearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void addToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Add add = new Add();
            add.Show();
            Visible = false;
        }

        private void reportToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Report rep = new Report();
            rep.Show();

        }

        private void searchToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Search s = new Search();
            s.Show();
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to close this app???", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
