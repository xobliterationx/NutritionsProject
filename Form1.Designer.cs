namespace HranitelniDobavki
{
    partial class AllData
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.allDataDGV = new System.Windows.Forms.DataGridView();
            this.Naimenovanie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grupa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Proizvoditel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nalichnost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.statsLB = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.allDataDGV)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // allDataDGV
            // 
            this.allDataDGV.AccessibleName = "allDataDGV";
            this.allDataDGV.AllowUserToDeleteRows = false;
            this.allDataDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.allDataDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Naimenovanie,
            this.Grupa,
            this.Proizvoditel,
            this.Cena,
            this.Nalichnost});
            this.allDataDGV.Location = new System.Drawing.Point(12, 27);
            this.allDataDGV.Name = "allDataDGV";
            this.allDataDGV.Size = new System.Drawing.Size(546, 150);
            this.allDataDGV.TabIndex = 1;
            this.allDataDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Naimenovanie
            // 
            this.Naimenovanie.HeaderText = "Naimenovanie";
            this.Naimenovanie.Name = "Naimenovanie";
            this.Naimenovanie.ReadOnly = true;
            // 
            // Grupa
            // 
            this.Grupa.HeaderText = "Grupa";
            this.Grupa.Name = "Grupa";
            this.Grupa.ReadOnly = true;
            // 
            // Proizvoditel
            // 
            this.Proizvoditel.HeaderText = "Proizvoditel";
            this.Proizvoditel.Name = "Proizvoditel";
            this.Proizvoditel.ReadOnly = true;
            // 
            // Cena
            // 
            this.Cena.HeaderText = "Cena";
            this.Cena.Name = "Cena";
            this.Cena.ReadOnly = true;
            // 
            // Nalichnost
            // 
            this.Nalichnost.HeaderText = "Nalichnost";
            this.Nalichnost.Name = "Nalichnost";
            this.Nalichnost.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Statistika";
            // 
            // statsLB
            // 
            this.statsLB.FormattingEnabled = true;
            this.statsLB.Location = new System.Drawing.Point(231, 209);
            this.statsLB.Name = "statsLB";
            this.statsLB.Size = new System.Drawing.Size(120, 95);
            this.statsLB.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.reportToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(584, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click_1);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.reportToolStripMenuItem.Text = "Report";
            this.reportToolStripMenuItem.Click += new System.EventHandler(this.reportToolStripMenuItem_Click_1);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.searchToolStripMenuItem.Text = "Search";
            this.searchToolStripMenuItem.Click += new System.EventHandler(this.searchToolStripMenuItem_Click_1);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click_1);
            // 
            // AllData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.statsLB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.allDataDGV);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(600, 500);
            this.MinimumSize = new System.Drawing.Size(600, 500);
            this.Name = "AllData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HranitelniDobavki";
            this.Load += new System.EventHandler(this.AllData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.allDataDGV)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView allDataDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naimenovanie;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grupa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proizvoditel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cena;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nalichnost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox statsLB;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

