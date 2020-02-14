namespace StudentServis
{
    partial class frmPartneri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPartneri));
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnIzmijeni = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.dgvPartneri = new System.Windows.Forms.DataGridView();
            this.lblPartneri = new System.Windows.Forms.Label();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.lblAdresa = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.txtOib = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIban = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPartneri)).BeginInit();
            this.SuspendLayout();
            // 
            // btnObrisi
            // 
            this.btnObrisi.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnObrisi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnObrisi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnObrisi.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnObrisi.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnObrisi.Location = new System.Drawing.Point(95, 443);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(95, 45);
            this.btnObrisi.TabIndex = 17;
            this.btnObrisi.Text = "Obriši";
            this.btnObrisi.UseVisualStyleBackColor = false;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // btnIzmijeni
            // 
            this.btnIzmijeni.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnIzmijeni.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIzmijeni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIzmijeni.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIzmijeni.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnIzmijeni.Location = new System.Drawing.Point(153, 392);
            this.btnIzmijeni.Name = "btnIzmijeni";
            this.btnIzmijeni.Size = new System.Drawing.Size(95, 45);
            this.btnIzmijeni.TabIndex = 16;
            this.btnIzmijeni.Text = "Izmijeni";
            this.btnIzmijeni.UseVisualStyleBackColor = false;
            this.btnIzmijeni.Click += new System.EventHandler(this.btnIzmijeni_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnDodaj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDodaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodaj.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodaj.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnDodaj.Location = new System.Drawing.Point(46, 392);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(95, 45);
            this.btnDodaj.TabIndex = 15;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // dgvPartneri
            // 
            this.dgvPartneri.AllowUserToAddRows = false;
            this.dgvPartneri.AllowUserToDeleteRows = false;
            this.dgvPartneri.AllowUserToOrderColumns = true;
            this.dgvPartneri.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPartneri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPartneri.Location = new System.Drawing.Point(300, 95);
            this.dgvPartneri.Name = "dgvPartneri";
            this.dgvPartneri.ReadOnly = true;
            this.dgvPartneri.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPartneri.Size = new System.Drawing.Size(621, 374);
            this.dgvPartneri.TabIndex = 14;
            this.dgvPartneri.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPartneri_CellClick);
            // 
            // lblPartneri
            // 
            this.lblPartneri.AutoSize = true;
            this.lblPartneri.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPartneri.ForeColor = System.Drawing.Color.Blue;
            this.lblPartneri.Location = new System.Drawing.Point(429, 30);
            this.lblPartneri.Name = "lblPartneri";
            this.lblPartneri.Size = new System.Drawing.Size(93, 29);
            this.lblPartneri.TabIndex = 24;
            this.lblPartneri.Text = "Partneri";
            // 
            // txtAdresa
            // 
            this.txtAdresa.Location = new System.Drawing.Point(46, 152);
            this.txtAdresa.Multiline = true;
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(202, 96);
            this.txtAdresa.TabIndex = 23;
            // 
            // lblAdresa
            // 
            this.lblAdresa.AutoSize = true;
            this.lblAdresa.Location = new System.Drawing.Point(43, 136);
            this.lblAdresa.Name = "lblAdresa";
            this.lblAdresa.Size = new System.Drawing.Size(43, 13);
            this.lblAdresa.TabIndex = 22;
            this.lblAdresa.Text = "Adresa:";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(46, 97);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(202, 20);
            this.txtNaziv.TabIndex = 21;
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Location = new System.Drawing.Point(43, 81);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(37, 13);
            this.lblNaziv.TabIndex = 20;
            this.lblNaziv.Text = "Naziv:";
            // 
            // txtOib
            // 
            this.txtOib.Location = new System.Drawing.Point(46, 279);
            this.txtOib.Name = "txtOib";
            this.txtOib.Size = new System.Drawing.Size(202, 20);
            this.txtOib.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "OIB:";
            // 
            // txtIban
            // 
            this.txtIban.Location = new System.Drawing.Point(46, 333);
            this.txtIban.Name = "txtIban";
            this.txtIban.Size = new System.Drawing.Size(202, 20);
            this.txtIban.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 317);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "IBAN:";
            // 
            // frmPartneri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(957, 519);
            this.Controls.Add(this.txtIban);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtOib);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPartneri);
            this.Controls.Add(this.txtAdresa);
            this.Controls.Add(this.lblAdresa);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.lblNaziv);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnIzmijeni);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.dgvPartneri);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPartneri";
            this.Text = "Partneri";
            this.Load += new System.EventHandler(this.frmPartneri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPartneri)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnIzmijeni;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.DataGridView dgvPartneri;
        private System.Windows.Forms.Label lblPartneri;
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.Label lblAdresa;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.TextBox txtOib;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIban;
        private System.Windows.Forms.Label label2;
    }
}