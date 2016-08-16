namespace HranitelniDobavki
{
    partial class Search
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.priceToTB = new System.Windows.Forms.TextBox();
            this.priceFromTB = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.naimenovanie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grupa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proizvoditel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nalichnost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "cenaOT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(274, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "cenaDO";
            // 
            // priceToTB
            // 
            this.priceToTB.Location = new System.Drawing.Point(371, 5);
            this.priceToTB.Name = "priceToTB";
            this.priceToTB.Size = new System.Drawing.Size(100, 20);
            this.priceToTB.TabIndex = 2;
            // 
            // priceFromTB
            // 
            this.priceFromTB.Location = new System.Drawing.Point(101, 2);
            this.priceFromTB.Name = "priceFromTB";
            this.priceFromTB.Size = new System.Drawing.Size(100, 20);
            this.priceFromTB.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(538, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "showBtn";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.naimenovanie,
            this.grupa,
            this.proizvoditel,
            this.cena,
            this.nalichnost});
            this.dataGridView1.Location = new System.Drawing.Point(42, 84);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(642, 203);
            this.dataGridView1.TabIndex = 5;
            // 
            // naimenovanie
            // 
            this.naimenovanie.HeaderText = "naimenovanie";
            this.naimenovanie.Name = "naimenovanie";
            this.naimenovanie.ReadOnly = true;
            // 
            // grupa
            // 
            this.grupa.HeaderText = "grupa";
            this.grupa.Name = "grupa";
            this.grupa.ReadOnly = true;
            // 
            // proizvoditel
            // 
            this.proizvoditel.HeaderText = "proizvoditel";
            this.proizvoditel.Name = "proizvoditel";
            this.proizvoditel.ReadOnly = true;
            // 
            // cena
            // 
            this.cena.HeaderText = "cena";
            this.cena.Name = "cena";
            this.cena.ReadOnly = true;
            // 
            // nalichnost
            // 
            this.nalichnost.HeaderText = "nalichnost";
            this.nalichnost.Name = "nalichnost";
            this.nalichnost.ReadOnly = true;
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 394);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.priceFromTB);
            this.Controls.Add(this.priceToTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Search";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tursene";
            this.Load += new System.EventHandler(this.Search_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox priceToTB;
        private System.Windows.Forms.TextBox priceFromTB;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn naimenovanie;
        private System.Windows.Forms.DataGridViewTextBoxColumn grupa;
        private System.Windows.Forms.DataGridViewTextBoxColumn proizvoditel;
        private System.Windows.Forms.DataGridViewTextBoxColumn cena;
        private System.Windows.Forms.DataGridViewTextBoxColumn nalichnost;
    }
}