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
    public partial class frmFakulteti : Form
    {
        private string connectionString = String.Format("Server={0};Port={1};" +
            "User Id={2};Password={3};Database={4};",
            "localhost", 5432, "postgres",
            "Cibalia1", "StudentServis");
        private NpgsqlConnection conn;
        private string sql;
        private NpgsqlCommand cmd;
        private DataTable dt;

        public frmFakulteti()
        {
            InitializeComponent();
        }

        public void OsvjeziFakultete()
        {
            conn = new NpgsqlConnection(connectionString);
            conn.Open();

            sql = @"SELECT * FROM fakultet";
            cmd = new NpgsqlCommand(sql, conn);
            dt = new DataTable();
            dt.Load(cmd.ExecuteReader());

            conn.Close();

            dgvFakulteti.DataSource = null;
            dgvFakulteti.DataSource = dt;
        }

        private void frmFakulteti_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connectionString);
            conn.Open();

            sql = @"SELECT * FROM fakultet";
            cmd = new NpgsqlCommand(sql, conn);
            dt = new DataTable();
            dt.Load(cmd.ExecuteReader());

            conn.Close();

            dgvFakulteti.DataSource = null;
            dgvFakulteti.DataSource = dt;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connectionString);
            conn.Open();
            sql = @"INSERT INTO fakultet (naziv, adresa) VALUES ('"+txtNaziv.Text+"', '"+txtAdresa.Text+"');";
            cmd = new NpgsqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();

            OsvjeziFakultete();
            txtNaziv.Text = null;
            txtAdresa.Text = null;
        }

        private void btnIzmijeni_Click(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connectionString);
            conn.Open();
            sql = @"UPDATE fakultet SET naziv = '"+txtNaziv.Text+ "', adresa='"+txtAdresa.Text+"' WHERE id_fakultet="+dgvFakulteti.SelectedCells[0].Value+";";
            cmd = new NpgsqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();

            OsvjeziFakultete();
            txtNaziv.Text = null;
            txtAdresa.Text = null;
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connectionString);
            conn.Open();
            sql = @"DELETE FROM fakultet WHERE id_fakultet=" + dgvFakulteti.SelectedCells[0].Value + ";";
            cmd = new NpgsqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();

            OsvjeziFakultete();
            txtNaziv.Text = null;
            txtAdresa.Text = null;
        }

        private void dgvFakulteti_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNaziv.Text = dgvFakulteti.Rows[e.RowIndex].Cells["naziv"].Value.ToString();
            txtAdresa.Text = dgvFakulteti.Rows[e.RowIndex].Cells["adresa"].Value.ToString();
        }
    }
}
