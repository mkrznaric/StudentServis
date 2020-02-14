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
    public partial class frmPrijava : Form
    {
        private string connectionString = String.Format("Server={0};Port={1};" +
            "User Id={2};Password={3};Database={4};",
            "localhost", 5432, "postgres",
            "Cibalia1", "StudentServis");
        private NpgsqlConnection conn;
        private string sql;
        private NpgsqlCommand cmd;
        private DataTable dt;

        public frmPrijava()
        {
            InitializeComponent();
        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connectionString);
            conn.Open();
            sql = @"SELECT * FROM zaposlenik WHERE korime ='"+txtKorime.Text+"' AND lozinka='"+txtLozinka.Text+"';";
            cmd = new NpgsqlCommand(sql, conn);
            dt = new DataTable();
            dt.Load(cmd.ExecuteReader());

            if (dt.Rows.Count == 1)
            {
                frmGlavna glavna = new frmGlavna();
                this.Hide();
                glavna.Show();
            }
            else
            {
                MessageBox.Show("Neispravni korisničko ime ili lozinka!");
            }
            conn.Close();
        }
    }
}
