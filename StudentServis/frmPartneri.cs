using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentServis
{
    public partial class frmPartneri : Form
    {
        private string connectionString = String.Format("Server={0};Port={1};" +
            "User Id={2};Password={3};Database={4};",
            "localhost", 5432, "postgres",
            "Cibalia1", "StudentServis");
        private NpgsqlConnection conn;
        private string sql;
        private NpgsqlCommand cmd;
        private DataTable dt;

        public frmPartneri()
        {
            InitializeComponent();
        }

        public void OsvjeziPartnere()
        {
            conn = new NpgsqlConnection(connectionString);
            conn.Open();

            sql = @"SELECT * FROM partner";
            cmd = new NpgsqlCommand(sql, conn);
            dt = new DataTable();
            dt.Load(cmd.ExecuteReader());

            conn.Close();

            dgvPartneri.DataSource = null;
            dgvPartneri.DataSource = dt;
        }

        private void frmPartneri_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connectionString);
            conn.Open();

            sql = @"SELECT * FROM partner";
            cmd = new NpgsqlCommand(sql, conn);
            dt = new DataTable();
            dt.Load(cmd.ExecuteReader());

            conn.Close();

            dgvPartneri.DataSource = null;
            dgvPartneri.DataSource = dt;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connectionString);
            conn.Open();
            sql = @"INSERT INTO partner (naziv, adresa, oib, iban) VALUES ('" + txtNaziv.Text + "', '" + txtAdresa.Text + "', '" + txtOib.Text + "', '" + txtIban.Text + "');";
            cmd = new NpgsqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();

            OsvjeziPartnere();
            txtNaziv.Text = null;
            txtAdresa.Text = null;
            txtOib.Text = null;
            txtIban.Text = null;
        }

        private void btnIzmijeni_Click(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connectionString);
            conn.Open();
            sql = @"UPDATE partner SET naziv='"+txtNaziv.Text+"',adresa='"+txtAdresa.Text+"',oib="+int.Parse(txtOib.Text)+",iban='"+txtIban.Text+"' WHERE id_partner="+dgvPartneri.SelectedCells[0].Value+";";
            cmd = new NpgsqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();

            OsvjeziPartnere();
            txtNaziv.Text = null;
            txtAdresa.Text = null;
            txtOib.Text = null;
            txtIban.Text = null;
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connectionString);
            conn.Open();
            sql = @"DELETE FROM partner WHERE id_partner=" + dgvPartneri.SelectedCells[0].Value + ";";
            cmd = new NpgsqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();

            OsvjeziPartnere();
            txtNaziv.Text = null;
            txtAdresa.Text = null;
            txtOib.Text = null;
            txtIban.Text = null;
        }

        private void dgvPartneri_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNaziv.Text = dgvPartneri.Rows[e.RowIndex].Cells["naziv"].Value.ToString();
            txtAdresa.Text = dgvPartneri.Rows[e.RowIndex].Cells["adresa"].Value.ToString();
            txtOib.Text = dgvPartneri.Rows[e.RowIndex].Cells["oib"].Value.ToString();
            txtIban.Text = dgvPartneri.Rows[e.RowIndex].Cells["iban"].Value.ToString();
        }
    }
}
