namespace StudentServis
{
    partial class frmGlavna
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGlavna));
            this.lblStudentServis = new System.Windows.Forms.Label();
            this.btnRacuni = new System.Windows.Forms.Button();
            this.btnStudenti = new System.Windows.Forms.Button();
            this.btnPartneri = new System.Windows.Forms.Button();
            this.btnFakulteti = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblStudentServis
            // 
            this.lblStudentServis.AutoSize = true;
            this.lblStudentServis.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentServis.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblStudentServis.Location = new System.Drawing.Point(232, 41);
            this.lblStudentServis.Name = "lblStudentServis";
            this.lblStudentServis.Size = new System.Drawing.Size(176, 34);
            this.lblStudentServis.TabIndex = 0;
            this.lblStudentServis.Text = "Student servis";
            // 
            // btnRacuni
            // 
            this.btnRacuni.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnRacuni.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRacuni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRacuni.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRacuni.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnRacuni.Location = new System.Drawing.Point(322, 224);
            this.btnRacuni.Name = "btnRacuni";
            this.btnRacuni.Size = new System.Drawing.Size(278, 99);
            this.btnRacuni.TabIndex = 1;
            this.btnRacuni.Text = "Računi";
            this.btnRacuni.UseVisualStyleBackColor = false;
            this.btnRacuni.Click += new System.EventHandler(this.btnRacuni_Click);
            // 
            // btnStudenti
            // 
            this.btnStudenti.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnStudenti.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStudenti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudenti.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnStudenti.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnStudenti.Location = new System.Drawing.Point(38, 119);
            this.btnStudenti.Name = "btnStudenti";
            this.btnStudenti.Size = new System.Drawing.Size(278, 99);
            this.btnStudenti.TabIndex = 2;
            this.btnStudenti.Text = "Studenti";
            this.btnStudenti.UseVisualStyleBackColor = false;
            this.btnStudenti.Click += new System.EventHandler(this.btnStudenti_Click);
            // 
            // btnPartneri
            // 
            this.btnPartneri.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnPartneri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPartneri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPartneri.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPartneri.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnPartneri.Location = new System.Drawing.Point(38, 224);
            this.btnPartneri.Name = "btnPartneri";
            this.btnPartneri.Size = new System.Drawing.Size(278, 99);
            this.btnPartneri.TabIndex = 3;
            this.btnPartneri.Text = "Partneri";
            this.btnPartneri.UseVisualStyleBackColor = false;
            this.btnPartneri.Click += new System.EventHandler(this.btnPartneri_Click);
            // 
            // btnFakulteti
            // 
            this.btnFakulteti.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnFakulteti.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFakulteti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFakulteti.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnFakulteti.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnFakulteti.Location = new System.Drawing.Point(322, 119);
            this.btnFakulteti.Name = "btnFakulteti";
            this.btnFakulteti.Size = new System.Drawing.Size(278, 99);
            this.btnFakulteti.TabIndex = 4;
            this.btnFakulteti.Text = "Fakulteti";
            this.btnFakulteti.UseVisualStyleBackColor = false;
            this.btnFakulteti.Click += new System.EventHandler(this.btnFakulteti_Click);
            // 
            // frmGlavna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(638, 384);
            this.Controls.Add(this.btnFakulteti);
            this.Controls.Add(this.btnPartneri);
            this.Controls.Add(this.btnStudenti);
            this.Controls.Add(this.btnRacuni);
            this.Controls.Add(this.lblStudentServis);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGlavna";
            this.Text = "Student servis";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStudentServis;
        private System.Windows.Forms.Button btnRacuni;
        private System.Windows.Forms.Button btnStudenti;
        private System.Windows.Forms.Button btnPartneri;
        private System.Windows.Forms.Button btnFakulteti;
    }
}

