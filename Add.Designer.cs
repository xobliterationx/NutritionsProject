namespace HranitelniDobavki
{
    partial class Add
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.naimenovanie = new System.Windows.Forms.ComboBox();
            this.proizvoditel = new System.Windows.Forms.ComboBox();
            this.grupa = new System.Windows.Forms.TextBox();
            this.cena = new System.Windows.Forms.TextBox();
            this.nalichnost = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ProductName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Group";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Manufacturer";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "InStock";
            // 
            // naimenovanie
            // 
            this.naimenovanie.FormattingEnabled = true;
            this.naimenovanie.Items.AddRange(new object[] {
            "Whey Protein",
            "Glutamine",
            "Creatine",
            "BCAA"});
            this.naimenovanie.Location = new System.Drawing.Point(151, 19);
            this.naimenovanie.Name = "naimenovanie";
            this.naimenovanie.Size = new System.Drawing.Size(121, 21);
            this.naimenovanie.TabIndex = 5;
            this.naimenovanie.SelectedIndexChanged += new System.EventHandler(this.naimenovanie_SelectedIndexChanged);
            // 
            // proizvoditel
            // 
            this.proizvoditel.FormattingEnabled = true;
            this.proizvoditel.Items.AddRange(new object[] {
            "Animal",
            "BSN",
            "Gold Standart",
            "BioTech",
            "MuscleTech"});
            this.proizvoditel.Location = new System.Drawing.Point(151, 83);
            this.proizvoditel.Name = "proizvoditel";
            this.proizvoditel.Size = new System.Drawing.Size(121, 21);
            this.proizvoditel.TabIndex = 6;
            // 
            // grupa
            // 
            this.grupa.Location = new System.Drawing.Point(151, 53);
            this.grupa.Name = "grupa";
            this.grupa.Size = new System.Drawing.Size(121, 20);
            this.grupa.TabIndex = 7;
            // 
            // cena
            // 
            this.cena.Location = new System.Drawing.Point(151, 113);
            this.cena.Name = "cena";
            this.cena.Size = new System.Drawing.Size(121, 20);
            this.cena.TabIndex = 8;
            // 
            // nalichnost
            // 
            this.nalichnost.Location = new System.Drawing.Point(151, 147);
            this.nalichnost.Name = "nalichnost";
            this.nalichnost.Size = new System.Drawing.Size(121, 20);
            this.nalichnost.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(79, 203);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 24);
            this.button1.TabIndex = 10;
            this.button1.Text = "Add to catalog";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 271);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nalichnost);
            this.Controls.Add(this.cena);
            this.Controls.Add(this.grupa);
            this.Controls.Add(this.proizvoditel);
            this.Controls.Add(this.naimenovanie);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Add";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dobavqne";
            this.Load += new System.EventHandler(this.Add_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox naimenovanie;
        private System.Windows.Forms.ComboBox proizvoditel;
        private System.Windows.Forms.TextBox grupa;
        private System.Windows.Forms.TextBox cena;
        private System.Windows.Forms.TextBox nalichnost;
        private System.Windows.Forms.Button button1;
    }
}