namespace StudentServis
{
    partial class frmRacuni
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRacuni));
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.dgvRacuni = new System.Windows.Forms.DataGridView();
            this.gpTroskovi = new System.Windows.Forms.GroupBox();
            this.lblUkupno = new System.Windows.Forms.Label();
            this.lblProvizija = new System.Windows.Forms.Label();
            this.lblZarada = new System.Windows.Forms.Label();
            this.lblFakulteti = new System.Windows.Forms.Label();
            this.btnIzmijeni = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSatnica = new System.Windows.Forms.TextBox();
            this.lblAdresa = new System.Windows.Forms.Label();
            this.txtPosao = new System.Windows.Forms.TextBox();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.dtPocetak = new System.Windows.Forms.DateTimePicker();
            this.dtZavrsetak = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbStudent = new System.Windows.Forms.ComboBox();
            this.cbPartner = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbZaposlenik = new System.Windows.Forms.ComboBox();
            this.lblZaradaBroj = new System.Windows.Forms.Label();
            this.lblProvizijaBroj = new System.Windows.Forms.Label();
            this.lblUkupnoBroj = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRacuni)).BeginInit();
            this.gpTroskovi.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnObrisi
            // 
            this.btnObrisi.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnObrisi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnObrisi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnObrisi.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnObrisi.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnObrisi.Location = new System.Drawing.Point(318, 555);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(119, 45);
            this.btnObrisi.TabIndex = 23;
            this.btnObrisi.Text = "Obriši";
            this.btnObrisi.UseVisualStyleBackColor = false;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnDodaj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDodaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodaj.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodaj.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnDodaj.Location = new System.Drawing.Point(257, 504);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(119, 45);
            this.btnDodaj.TabIndex = 21;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // dgvRacuni
            // 
            this.dgvRacuni.AllowUserToAddRows = false;
            this.dgvRacuni.AllowUserToDeleteRows = false;
            this.dgvRacuni.AllowUserToOrderColumns = true;
            this.dgvRacuni.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRacuni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRacuni.Location = new System.Drawing.Point(12, 99);
            this.dgvRacuni.Name = "dgvRacuni";
            this.dgvRacuni.ReadOnly = true;
            this.dgvRacuni.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRacuni.Size = new System.Drawing.Size(962, 152);
            this.dgvRacuni.TabIndex = 20;
            this.dgvRacuni.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRacuni_CellClick);
            // 
            // gpTroskovi
            // 
            this.gpTroskovi.Controls.Add(this.label11);
            this.gpTroskovi.Controls.Add(this.label10);
            this.gpTroskovi.Controls.Add(this.label9);
            this.gpTroskovi.Controls.Add(this.lblUkupnoBroj);
            this.gpTroskovi.Controls.Add(this.lblProvizijaBroj);
            this.gpTroskovi.Controls.Add(this.lblZaradaBroj);
            this.gpTroskovi.Controls.Add(this.lblUkupno);
            this.gpTroskovi.Controls.Add(this.lblProvizija);
            this.gpTroskovi.Controls.Add(this.lblZarada);
            this.gpTroskovi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.gpTroskovi.Location = new System.Drawing.Point(596, 301);
            this.gpTroskovi.Name = "gpTroskovi";
            this.gpTroskovi.Size = new System.Drawing.Size(350, 280);
            this.gpTroskovi.TabIndex = 26;
            this.gpTroskovi.TabStop = false;
            this.gpTroskovi.Text = "Troškovi";
            // 
            // lblUkupno
            // 
            this.lblUkupno.AutoSize = true;
            this.lblUkupno.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblUkupno.ForeColor = System.Drawing.Color.Black;
            this.lblUkupno.Location = new System.Drawing.Point(54, 206);
            this.lblUkupno.Name = "lblUkupno";
            this.lblUkupno.Size = new System.Drawing.Size(73, 23);
            this.lblUkupno.TabIndex = 2;
            this.lblUkupno.Text = "Ukupno:";
            // 
            // lblProvizija
            // 
            this.lblProvizija.AutoSize = true;
            this.lblProvizija.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblProvizija.ForeColor = System.Drawing.Color.Black;
            this.lblProvizija.Location = new System.Drawing.Point(47, 135);
            this.lblProvizija.Name = "lblProvizija";
            this.lblProvizija.Size = new System.Drawing.Size(80, 23);
            this.lblProvizija.TabIndex = 1;
            this.lblProvizija.Text = "Provizija:";
            // 
            // lblZarada
            // 
            this.lblZarada.AutoSize = true;
            this.lblZarada.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblZarada.ForeColor = System.Drawing.Color.Black;
            this.lblZarada.Location = new System.Drawing.Point(54, 69);
            this.lblZarada.Name = "lblZarada";
            this.lblZarada.Size = new System.Drawing.Size(69, 23);
            this.lblZarada.TabIndex = 0;
            this.lblZarada.Text = "Zarada:";
            // 
            // lblFakulteti
            // 
            this.lblFakulteti.AutoSize = true;
            this.lblFakulteti.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblFakulteti.ForeColor = System.Drawing.Color.Blue;
            this.lblFakulteti.Location = new System.Drawing.Point(431, 38);
            this.lblFakulteti.Name = "lblFakulteti";
            this.lblFakulteti.Size = new System.Drawing.Size(82, 29);
            this.lblFakulteti.TabIndex = 28;
            this.lblFakulteti.Text = "Računi";
            // 
            // btnIzmijeni
            // 
            this.btnIzmijeni.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnIzmijeni.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIzmijeni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIzmijeni.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIzmijeni.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnIzmijeni.Location = new System.Drawing.Point(382, 504);
            this.btnIzmijeni.Name = "btnIzmijeni";
            this.btnIzmijeni.Size = new System.Drawing.Size(119, 45);
            this.btnIzmijeni.TabIndex = 27;
            this.btnIzmijeni.Text = "Izmijeni";
            this.btnIzmijeni.UseVisualStyleBackColor = false;
            this.btnIzmijeni.Click += new System.EventHandler(this.btnIzmijeni_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(220, 436);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Partner:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(220, 409);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Student:";
            // 
            // txtSatnica
            // 
            this.txtSatnica.Location = new System.Drawing.Point(270, 327);
            this.txtSatnica.Name = "txtSatnica";
            this.txtSatnica.Size = new System.Drawing.Size(56, 20);
            this.txtSatnica.TabIndex = 32;
            // 
            // lblAdresa
            // 
            this.lblAdresa.AutoSize = true;
            this.lblAdresa.Location = new System.Drawing.Point(218, 330);
            this.lblAdresa.Name = "lblAdresa";
            this.lblAdresa.Size = new System.Drawing.Size(46, 13);
            this.lblAdresa.TabIndex = 31;
            this.lblAdresa.Text = "Satnica:";
            // 
            // txtPosao
            // 
            this.txtPosao.Location = new System.Drawing.Point(270, 301);
            this.txtPosao.Name = "txtPosao";
            this.txtPosao.Size = new System.Drawing.Size(202, 20);
            this.txtPosao.TabIndex = 30;
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Location = new System.Drawing.Point(205, 304);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(59, 13);
            this.lblNaziv.TabIndex = 29;
            this.lblNaziv.Text = "Opis posla:";
            // 
            // dtPocetak
            // 
            this.dtPocetak.Location = new System.Drawing.Point(270, 353);
            this.dtPocetak.Name = "dtPocetak";
            this.dtPocetak.Size = new System.Drawing.Size(200, 20);
            this.dtPocetak.TabIndex = 37;
            // 
            // dtZavrsetak
            // 
            this.dtZavrsetak.Location = new System.Drawing.Point(270, 379);
            this.dtZavrsetak.Name = "dtZavrsetak";
            this.dtZavrsetak.Size = new System.Drawing.Size(200, 20);
            this.dtZavrsetak.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(102, 353);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 13);
            this.label4.TabIndex = 40;
            this.label4.Text = "Datum početka obavljanja posla:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 380);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 13);
            this.label3.TabIndex = 41;
            this.label3.Text = "Datum završetka obavljanja posla:";
            // 
            // cbStudent
            // 
            this.cbStudent.FormattingEnabled = true;
            this.cbStudent.Location = new System.Drawing.Point(270, 406);
            this.cbStudent.Name = "cbStudent";
            this.cbStudent.Size = new System.Drawing.Size(200, 21);
            this.cbStudent.TabIndex = 42;
            // 
            // cbPartner
            // 
            this.cbPartner.FormattingEnabled = true;
            this.cbPartner.Location = new System.Drawing.Point(270, 433);
            this.cbPartner.Name = "cbPartner";
            this.cbPartner.Size = new System.Drawing.Size(200, 21);
            this.cbPartner.TabIndex = 43;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(110, 463);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 13);
            this.label5.TabIndex = 44;
            this.label5.Text = "Odgovorna osoba za izdavanje:";
            // 
            // cbZaposlenik
            // 
            this.cbZaposlenik.FormattingEnabled = true;
            this.cbZaposlenik.Location = new System.Drawing.Point(270, 460);
            this.cbZaposlenik.Name = "cbZaposlenik";
            this.cbZaposlenik.Size = new System.Drawing.Size(200, 21);
            this.cbZaposlenik.TabIndex = 45;
            // 
            // lblZaradaBroj
            // 
            this.lblZaradaBroj.AutoSize = true;
            this.lblZaradaBroj.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblZaradaBroj.ForeColor = System.Drawing.Color.Red;
            this.lblZaradaBroj.Location = new System.Drawing.Point(129, 69);
            this.lblZaradaBroj.Name = "lblZaradaBroj";
            this.lblZaradaBroj.Size = new System.Drawing.Size(20, 23);
            this.lblZaradaBroj.TabIndex = 3;
            this.lblZaradaBroj.Text = "0";
            // 
            // lblProvizijaBroj
            // 
            this.lblProvizijaBroj.AutoSize = true;
            this.lblProvizijaBroj.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblProvizijaBroj.ForeColor = System.Drawing.Color.Red;
            this.lblProvizijaBroj.Location = new System.Drawing.Point(133, 135);
            this.lblProvizijaBroj.Name = "lblProvizijaBroj";
            this.lblProvizijaBroj.Size = new System.Drawing.Size(20, 23);
            this.lblProvizijaBroj.TabIndex = 4;
            this.lblProvizijaBroj.Text = "0";
            // 
            // lblUkupnoBroj
            // 
            this.lblUkupnoBroj.AutoSize = true;
            this.lblUkupnoBroj.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblUkupnoBroj.ForeColor = System.Drawing.Color.Red;
            this.lblUkupnoBroj.Location = new System.Drawing.Point(133, 206);
            this.lblUkupnoBroj.Name = "lblUkupnoBroj";
            this.lblUkupnoBroj.Size = new System.Drawing.Size(20, 23);
            this.lblUkupnoBroj.TabIndex = 5;
            this.lblUkupnoBroj.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(241, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 23);
            this.label9.TabIndex = 6;
            this.label9.Text = "HRK";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(241, 135);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 23);
            this.label10.TabIndex = 7;
            this.label10.Text = "HRK";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(241, 206);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 23);
            this.label11.TabIndex = 8;
            this.label11.Text = "HRK";
            // 
            // frmRacuni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(986, 626);
            this.Controls.Add(this.cbZaposlenik);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbPartner);
            this.Controls.Add(this.cbStudent);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtZavrsetak);
            this.Controls.Add(this.dtPocetak);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSatnica);
            this.Controls.Add(this.lblAdresa);
            this.Controls.Add(this.txtPosao);
            this.Controls.Add(this.lblNaziv);
            this.Controls.Add(this.lblFakulteti);
            this.Controls.Add(this.btnIzmijeni);
            this.Controls.Add(this.gpTroskovi);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.dgvRacuni);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRacuni";
            this.Text = "Računi";
            this.Load += new System.EventHandler(this.frmRacuni_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRacuni)).EndInit();
            this.gpTroskovi.ResumeLayout(false);
            this.gpTroskovi.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.DataGridView dgvRacuni;
        private System.Windows.Forms.GroupBox gpTroskovi;
        private System.Windows.Forms.Label lblUkupno;
        private System.Windows.Forms.Label lblProvizija;
        private System.Windows.Forms.Label lblZarada;
        private System.Windows.Forms.Label lblFakulteti;
        private System.Windows.Forms.Button btnIzmijeni;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSatnica;
        private System.Windows.Forms.Label lblAdresa;
        private System.Windows.Forms.TextBox txtPosao;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.DateTimePicker dtPocetak;
        private System.Windows.Forms.DateTimePicker dtZavrsetak;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbStudent;
        private System.Windows.Forms.ComboBox cbPartner;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbZaposlenik;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblUkupnoBroj;
        private System.Windows.Forms.Label lblProvizijaBroj;
        private System.Windows.Forms.Label lblZaradaBroj;
    }
}