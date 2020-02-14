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
    public partial class frmStudenti : Form
    {
        private string connectionString = String.Format("Server={0};Port={1};" +
            "User Id={2};Password={3};Database={4};",
            "localhost", 5432, "postgres",
            "Cibalia1", "StudentServis");
        private NpgsqlConnection conn;
        private string sql;
        private NpgsqlCommand cmd;
        private DataTable dt;

        public frmStudenti()
        {
            InitializeComponent();
        }

        public void OsvjeziStudente()
        {
            conn = new NpgsqlConnection(connectionString);
            conn.Open();

            sql = @"SELECT * FROM student";
            cmd = new NpgsqlCommand(sql, conn);
            dt = new DataTable();
            dt.Load(cmd.ExecuteReader());

            conn.Close();

            dgvStudenti.DataSource = null;
            dgvStudenti.DataSource = dt;
        }



        private void frmStudenti_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connectionString);
            conn.Open();

            sql = @"SELECT * FROM student";
            cmd = new NpgsqlCommand(sql, conn);
            dt = new DataTable();
            dt.Load(cmd.ExecuteReader());

            conn.Close();

            dgvStudenti.DataSource = null;
            dgvStudenti.DataSource = dt;

            conn = new NpgsqlConnection(connectionString);
            conn.Open();

            sql = @"SELECT naziv FROM fakultet;";
            cmd = new NpgsqlCommand(sql, conn);
            dt = new DataTable();
            dt.Load(cmd.ExecuteReader());

            conn.Close();

            cbFakultet.DataSource = dt;
            cbFakultet.DisplayMember = "naziv";

        }

        private void dgvStudenti_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIme.Text = dgvStudenti.Rows[e.RowIndex].Cells["ime"].Value.ToString();
            txtPrezime.Text = dgvStudenti.Rows[e.RowIndex].Cells["prezime"].Value.ToString();
            txtJmbag.Text = dgvStudenti.Rows[e.RowIndex].Cells["jmbag"].Value.ToString();
            txtIban.Text = dgvStudenti.Rows[e.RowIndex].Cells["iban"].Value.ToString();
            int pomocna = int.Parse(dgvStudenti.Rows[e.RowIndex].Cells["vk_fakultet"].Value.ToString());

            conn = new NpgsqlConnection(connectionString);
            conn.Open();

            sql = @"SELECT naziv FROM fakultet WHERE id_fakultet=" + pomocna + ";";
            cmd = new NpgsqlCommand(sql, conn);
            dt = new DataTable();
            dt.Load(cmd.ExecuteReader());

            conn.Close();

            cbFakultet.DataSource = dt;
            cbFakultet.DisplayMember = "naziv";

            
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            int rezultat = 0;
            var pomocna = cbFakultet.Text;
            conn = new NpgsqlConnection(connectionString);
            conn.Open();
            sql = @"SELECT id_fakultet FROM fakultet WHERE naziv = '"+pomocna+"';";
            cmd = new NpgsqlCommand(sql, conn);
            dt = new DataTable();
            dt.Load(cmd.ExecuteReader());

            foreach (DataRow row in dt.Rows)
            {
                    rezultat =int.Parse(row["id_fakultet"].ToString());
            }

            conn.Close();

            conn = new NpgsqlConnection(connectionString);
            conn.Open();
            sql = @"INSERT INTO student (ime, prezime, jmbag, iban, vk_fakultet) VALUES ('" + txtIme.Text + "', '" + txtPrezime.Text + "', '" + txtJmbag.Text + "', '" + txtIban.Text + "', "+rezultat+");";
            cmd = new NpgsqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();

            OsvjeziStudente();
            txtIme.Text = null;
            txtPrezime.Text = null;
            txtJmbag.Text = null;
            txtIban.Text = null;
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connectionString);
            conn.Open();
            sql = @"DELETE FROM student WHERE id_student=" + dgvStudenti.SelectedCells[0].Value + ";";
            cmd = new NpgsqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();

            OsvjeziStudente();
            txtIme.Text = null;
            txtPrezime.Text = null;
            txtJmbag.Text = null;
            txtIban.Text = null;
        }

        private void btnIzmijeni_Click(object sender, EventArgs e)
        {
            int rezultat = 0;
            var pomocna = cbFakultet.Text;
            conn = new NpgsqlConnection(connectionString);
            conn.Open();
            sql = @"SELECT id_fakultet FROM fakultet WHERE naziv = '" + pomocna + "';";
            cmd = new NpgsqlCommand(sql, conn);
            dt = new DataTable();
            dt.Load(cmd.ExecuteReader());

            foreach (DataRow row in dt.Rows)
            {
                rezultat = int.Parse(row["id_fakultet"].ToString());
            }

            conn.Close();

            conn = new NpgsqlConnection(connectionString);
            conn.Open();
            sql = @"UPDATE student SET ime='" + txtIme.Text + "',prezime='" + txtPrezime.Text + "',jmbag=" + int.Parse(txtJmbag.Text) + ",iban='" + txtIban.Text + "', vk_fakultet="+rezultat+" WHERE id_student=" + dgvStudenti.SelectedCells[0].Value + ";";
            cmd = new NpgsqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();

            OsvjeziStudente();
            txtIme.Text = null;
            txtPrezime.Text = null;
            txtJmbag.Text = null;
            txtIban.Text = null;
        }
    }
}
