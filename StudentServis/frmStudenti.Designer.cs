namespace StudentServis
{
    partial class frmStudenti
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStudenti));
            this.dgvStudenti = new System.Windows.Forms.DataGridView();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnIzmijeni = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.txtIban = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtJmbag = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPartneri = new System.Windows.Forms.Label();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbFakultet = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudenti)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStudenti
            // 
            this.dgvStudenti.AllowUserToAddRows = false;
            this.dgvStudenti.AllowUserToDeleteRows = false;
            this.dgvStudenti.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStudenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudenti.Location = new System.Drawing.Point(317, 112);
            this.dgvStudenti.Name = "dgvStudenti";
            this.dgvStudenti.ReadOnly = true;
            this.dgvStudenti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudenti.Size = new System.Drawing.Size(621, 391);
            this.dgvStudenti.TabIndex = 0;
            this.dgvStudenti.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudenti_CellClick);
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnDodaj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDodaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodaj.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodaj.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnDodaj.Location = new System.Drawing.Point(49, 398);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(107, 48);
            this.btnDodaj.TabIndex = 3;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnIzmijeni
            // 
            this.btnIzmijeni.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnIzmijeni.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIzmijeni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIzmijeni.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIzmijeni.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnIzmijeni.Location = new System.Drawing.Point(162, 400);
            this.btnIzmijeni.Name = "btnIzmijeni";
            this.btnIzmijeni.Size = new System.Drawing.Size(107, 46);
            this.btnIzmijeni.TabIndex = 4;
            this.btnIzmijeni.Text = "Izmijeni";
            this.btnIzmijeni.UseVisualStyleBackColor = false;
            this.btnIzmijeni.Click += new System.EventHandler(this.btnIzmijeni_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnObrisi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnObrisi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnObrisi.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnObrisi.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnObrisi.Location = new System.Drawing.Point(100, 452);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(107, 48);
            this.btnObrisi.TabIndex = 5;
            this.btnObrisi.Text = "Obriši";
            this.btnObrisi.UseVisualStyleBackColor = false;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // txtIban
            // 
            this.txtIban.Location = new System.Drawing.Point(56, 290);
            this.txtIban.Name = "txtIban";
            this.txtIban.Size = new System.Drawing.Size(202, 20);
            this.txtIban.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "IBAN:";
            // 
            // txtJmbag
            // 
            this.txtJmbag.Location = new System.Drawing.Point(56, 236);
            this.txtJmbag.Name = "txtJmbag";
            this.txtJmbag.Size = new System.Drawing.Size(202, 20);
            this.txtJmbag.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "JMBAG:";
            // 
            // lblPartneri
            // 
            this.lblPartneri.AutoSize = true;
            this.lblPartneri.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPartneri.ForeColor = System.Drawing.Color.Blue;
            this.lblPartneri.Location = new System.Drawing.Point(424, 41);
            this.lblPartneri.Name = "lblPartneri";
            this.lblPartneri.Size = new System.Drawing.Size(95, 29);
            this.lblPartneri.TabIndex = 33;
            this.lblPartneri.Text = "Studenti";
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(56, 184);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(202, 20);
            this.txtPrezime.TabIndex = 30;
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Location = new System.Drawing.Point(53, 168);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(47, 13);
            this.lblNaziv.TabIndex = 29;
            this.lblNaziv.Text = "Prezime:";
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(56, 128);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(202, 20);
            this.txtIme.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "Ime:";
            // 
            // cbFakultet
            // 
            this.cbFakultet.FormattingEnabled = true;
            this.cbFakultet.Location = new System.Drawing.Point(56, 352);
            this.cbFakultet.Name = "cbFakultet";
            this.cbFakultet.Size = new System.Drawing.Size(202, 21);
            this.cbFakultet.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 336);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 41;
            this.label4.Text = "Fakultet:";
            // 
            // frmStudenti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(969, 557);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbFakultet);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIban);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtJmbag);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPartneri);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.lblNaziv);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnIzmijeni);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.dgvStudenti);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmStudenti";
            this.Text = "Studenti";
            this.Load += new System.EventHandler(this.frmStudenti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudenti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStudenti;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnIzmijeni;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.TextBox txtIban;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtJmbag;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPartneri;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbFakultet;
        private System.Windows.Forms.Label label4;
    }
}