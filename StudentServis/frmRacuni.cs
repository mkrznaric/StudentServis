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
    public partial class frmRacuni : Form
    {
        private string connectionString = String.Format("Server={0};Port={1};" +
            "User Id={2};Password={3};Database={4};",
            "localhost", 5432, "postgres",
            "Cibalia1", "StudentServis");
        private NpgsqlConnection conn;
        private string sql;
        private NpgsqlCommand cmd;
        private DataTable dt;

        public frmRacuni()
        {
            InitializeComponent();
        }

        public void OsvjeziRacune()
        {
            conn = new NpgsqlConnection(connectionString);
            conn.Open();

            sql = @"SELECT * FROM racun;";
            cmd = new NpgsqlCommand(sql, conn);
            dt = new DataTable();
            dt.Load(cmd.ExecuteReader());

            conn.Close();

            dgvRacuni.DataSource = null;
            dgvRacuni.DataSource = dt;
        }

        private void frmRacuni_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connectionString);
            conn.Open();

            sql = @"SELECT * FROM racun";
            cmd = new NpgsqlCommand(sql, conn);
            dt = new DataTable();
            dt.Load(cmd.ExecuteReader());

            conn.Close();

            dgvRacuni.DataSource = null;
            dgvRacuni.DataSource = dt;

            conn = new NpgsqlConnection(connectionString);
            conn.Open();

            sql = @"SELECT prezime FROM student;";
            cmd = new NpgsqlCommand(sql, conn);
            dt = new DataTable();
            dt.Load(cmd.ExecuteReader());

            conn.Close();

            cbStudent.DataSource = dt;
            cbStudent.DisplayMember = "prezime";

            conn = new NpgsqlConnection(connectionString);
            conn.Open();

            sql = @"SELECT naziv FROM partner;";
            cmd = new NpgsqlCommand(sql, conn);
            dt = new DataTable();
            dt.Load(cmd.ExecuteReader());

            conn.Close();

            cbPartner.DataSource = dt;
            cbPartner.DisplayMember = "naziv";

            conn = new NpgsqlConnection(connectionString);
            conn.Open();

            sql = @"SELECT korime FROM zaposlenik;";
            cmd = new NpgsqlCommand(sql, conn);
            dt = new DataTable();
            dt.Load(cmd.ExecuteReader());

            conn.Close();

            cbZaposlenik.DataSource = dt;
            cbZaposlenik.DisplayMember = "korime";
        }

        private void dgvRacuni_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtPosao.Text = dgvRacuni.Rows[e.RowIndex].Cells["opis_posla"].Value.ToString();
            txtSatnica.Text = dgvRacuni.Rows[e.RowIndex].Cells["satnica"].Value.ToString();
            dtPocetak.Value = Convert.ToDateTime(dgvRacuni.Rows[e.RowIndex].Cells["datum_pocetka"].Value.ToString());
            dtZavrsetak.Value = Convert.ToDateTime(dgvRacuni.Rows[e.RowIndex].Cells["datum_zavrsetka"].Value.ToString());
            int pomocna = int.Parse(dgvRacuni.Rows[e.RowIndex].Cells["vk_student"].Value.ToString());
            int druga_pomocna = int.Parse(dgvRacuni.Rows[e.RowIndex].Cells["vk_partner"].Value.ToString());
            int treca_pomocna = int.Parse(dgvRacuni.Rows[e.RowIndex].Cells["vk_zaposlenik"].Value.ToString());

            var satnica = float.Parse(dgvRacuni.Rows[e.RowIndex].Cells["satnica"].Value.ToString());
            var datum_pocetka = Convert.ToDateTime(dgvRacuni.Rows[e.RowIndex].Cells["datum_pocetka"].Value.ToString());
            var datum_zavrsetka = Convert.ToDateTime(dgvRacuni.Rows[e.RowIndex].Cells["datum_zavrsetka"].Value.ToString());
            var razlika_dana = (datum_zavrsetka - datum_pocetka).TotalDays;

            var zarada = razlika_dana * 8 * satnica;
            var provizija = zarada * 0.18;
            var ukupno = zarada + provizija;

            lblZaradaBroj.Text = zarada.ToString("N2");
            lblProvizijaBroj.Text = provizija.ToString("N2");
            lblUkupnoBroj.Text = ukupno.ToString("N2");

            conn = new NpgsqlConnection(connectionString);
            conn.Open();

            sql = @"SELECT prezime FROM student WHERE id_student=" + pomocna + ";";
            cmd = new NpgsqlCommand(sql, conn);
            dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            cbStudent.DataSource = dt;
            cbStudent.DisplayMember = "prezime";
            conn.Close();

            conn = new NpgsqlConnection(connectionString);
            conn.Open();

            sql = @"SELECT naziv FROM partner WHERE id_partner=" + druga_pomocna + ";";
            cmd = new NpgsqlCommand(sql, conn);
            dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            cbPartner.DataSource = dt;
            cbPartner.DisplayMember = "naziv";
            conn.Close();

            conn = new NpgsqlConnection(connectionString);
            conn.Open();

            sql = @"SELECT korime FROM zaposlenik WHERE id_zaposlenik=" + treca_pomocna + ";";
            cmd = new NpgsqlCommand(sql, conn);
            dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            cbZaposlenik.DataSource = dt;
            cbZaposlenik.DisplayMember = "korime";
            conn.Close();

        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            int rezultat = 0;
            var pomocna = cbStudent.Text;
            conn = new NpgsqlConnection(connectionString);
            conn.Open();
            sql = @"SELECT id_student FROM student WHERE prezime = '" + pomocna + "';";
            cmd = new NpgsqlCommand(sql, conn);
            dt = new DataTable();
            dt.Load(cmd.ExecuteReader());

            foreach (DataRow row in dt.Rows)
            {
                rezultat = int.Parse(row["id_student"].ToString());
            }

            conn.Close();

            int drugi_rezultat = 0;
            var druga_pomocna = cbPartner.Text;
            conn = new NpgsqlConnection(connectionString);
            conn.Open();
            sql = @"SELECT id_partner FROM partner WHERE naziv = '" + druga_pomocna + "';";
            cmd = new NpgsqlCommand(sql, conn);
            dt = new DataTable();
            dt.Load(cmd.ExecuteReader());

            foreach (DataRow row in dt.Rows)
            {
                drugi_rezultat = int.Parse(row["id_partner"].ToString());
            }

            conn.Close();

            int treci_rezultat = 0;
            var treca_pomocna = cbZaposlenik.Text;
            conn = new NpgsqlConnection(connectionString);
            conn.Open();
            sql = @"SELECT id_zaposlenik FROM zaposlenik WHERE korime = '" + treca_pomocna + "';";
            cmd = new NpgsqlCommand(sql, conn);
            dt = new DataTable();
            dt.Load(cmd.ExecuteReader());

            foreach (DataRow row in dt.Rows)
            {
                treci_rezultat = int.Parse(row["id_zaposlenik"].ToString());
            }

            conn.Close();


            conn = new NpgsqlConnection(connectionString);
            conn.Open();
            sql = @"INSERT INTO racun (datum_izrade, opis_posla, satnica, datum_pocetka, datum_zavrsetka, vk_zaposlenik, vk_student, vk_partner) VALUES ('"+DateTime.Now.ToShortDateString()+"', '" + txtPosao.Text + "', '" + txtSatnica.Text + "', '" +dtPocetak.Value.ToShortDateString()+ "', '" + dtZavrsetak.Value.ToShortDateString() + "','"+treci_rezultat+"', '"+rezultat+"', '"+drugi_rezultat+"');";
            cmd = new NpgsqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();

            OsvjeziRacune();
            txtPosao.Text = null;
            txtSatnica.Text = null;
            dtPocetak.Value = DateTime.Now;
            dtZavrsetak.Value = DateTime.Now;
        }

        private void btnIzmijeni_Click(object sender, EventArgs e)
        {
            int rezultat = 0;
            var pomocna = cbStudent.Text;
            conn = new NpgsqlConnection(connectionString);
            conn.Open();
            sql = @"SELECT id_student FROM student WHERE prezime = '" + pomocna + "';";
            cmd = new NpgsqlCommand(sql, conn);
            dt = new DataTable();
            dt.Load(cmd.ExecuteReader());

            foreach (DataRow row in dt.Rows)
            {
                rezultat = int.Parse(row["id_student"].ToString());
            }

            conn.Close();

            int drugi_rezultat = 0;
            var druga_pomocna = cbPartner.Text;
            conn = new NpgsqlConnection(connectionString);
            conn.Open();
            sql = @"SELECT id_partner FROM partner WHERE naziv = '" + druga_pomocna + "';";
            cmd = new NpgsqlCommand(sql, conn);
            dt = new DataTable();
            dt.Load(cmd.ExecuteReader());

            foreach (DataRow row in dt.Rows)
            {
                drugi_rezultat = int.Parse(row["id_partner"].ToString());
            }

            conn.Close();

            int treci_rezultat = 0;
            var treca_pomocna = cbZaposlenik.Text;
            conn = new NpgsqlConnection(connectionString);
            conn.Open();
            sql = @"SELECT id_zaposlenik FROM zaposlenik WHERE korime = '" + treca_pomocna + "';";
            cmd = new NpgsqlCommand(sql, conn);
            dt = new DataTable();
            dt.Load(cmd.ExecuteReader());

            foreach (DataRow row in dt.Rows)
            {
                treci_rezultat = int.Parse(row["id_zaposlenik"].ToString());
            }

            conn.Close();

            //opis_posla, satnica, datum_pocetka, datum_zavrsetka, vk_zaposlenik, vk_student, vk_partner) VALUES(

            conn = new NpgsqlConnection(connectionString);
            conn.Open();
            sql = @"UPDATE racun SET datum_izrade='" + DateTime.Now.ToShortDateString() + "', opis_posla='" + txtPosao.Text + "', satnica='" + txtSatnica.Text + "', datum_pocetka='" + dtPocetak.Value.ToShortDateString() + "', datum_zavrsetka='" + dtZavrsetak.Value.ToShortDateString() + "', vk_zaposlenik='"+treci_rezultat+"', vk_student='"+rezultat+"', vk_partner='"+drugi_rezultat+ "' WHERE id_racun=" + dgvRacuni.SelectedCells[0].Value + ";";
            cmd = new NpgsqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();

            OsvjeziRacune();
            txtPosao.Text = null;
            txtSatnica.Text = null;
            dtPocetak.Value = DateTime.Now;
            dtZavrsetak.Value = DateTime.Now;
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connectionString);
            conn.Open();
            sql = @"DELETE FROM racun WHERE id_racun=" + dgvRacuni.SelectedCells[0].Value + ";";
            cmd = new NpgsqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();

            OsvjeziRacune();
            txtPosao.Text = null;
            txtSatnica.Text = null;
            dtPocetak.Value = DateTime.Now;
            dtZavrsetak.Value = DateTime.Now;
        }
    }
}
