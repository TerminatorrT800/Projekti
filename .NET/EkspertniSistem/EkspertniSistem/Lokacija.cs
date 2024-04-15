using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace EkspertniSistem
{
    public partial class Lokacija : Form
    {

        private string tipodabir;
        public Lokacija(string typeChoice)
        {
            InitializeComponent();
            tipodabir = typeChoice;
            objasnjenje1.Text = "Svrha ovog pitanje je da korisnik odabere lokaciju, preciznije rečeno grad u kome bi mu odgovaralo da se nalazi akademija/fakultet. U slučaju da to nije bitno korisniku, postoji opcija \"Svejedno\", u tom slučaju će korisniku biti ponuđene škole širom Srbije.";

            DBManager dbManager = DBManager.Instance;
            dbManager.openConn();

            if (tipodabir == "Nije bitno")
            {
                string query = "SELECT DISTINCT lokacija FROM Skola ORDER BY lokacija ASC";
                using (SQLiteCommand command = new SQLiteCommand(query, dbManager.Connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);

                        DataRow row = dt.NewRow();
                        row["lokacija"] = "Izaberite lokaciju";
                        dt.Rows.InsertAt(row, 0);

                        DataRow red = dt.NewRow();
                        red["lokacija"] = "Svejedno";
                        dt.Rows.Add(red);

                        comboBox1.DataSource = dt;
                        comboBox1.DisplayMember = "lokacija";
                    }
                }

            }
            else
            {

                string query = "SELECT DISTINCT lokacija FROM Skola WHERE tip = @odabir ORDER BY lokacija ASC";
                using (SQLiteCommand command = new SQLiteCommand(query, dbManager.Connection))
                {



                    command.Parameters.AddWithValue("@odabir", tipodabir);
                    using (SQLiteDataReader reader = command.ExecuteReader())

                    {
                        DataTable dt = new DataTable();


                        dt.Load(reader);

                        DataRow row = dt.NewRow();
                        row["lokacija"] = "Izaberite lokaciju";
                        dt.Rows.InsertAt(row, 0);


                        DataRow red = dt.NewRow();
                        red["lokacija"] = "Svejedno";
                        dt.Rows.Add(red);


                        comboBox1.DataSource = dt;
                        comboBox1.DisplayMember = "lokacija";


                    }



                }
            }
            dbManager.closeConn();
        }

        private void uvodbtnback_Click(object sender, EventArgs e)
        {
            FakultetIliAkademija fak = new FakultetIliAkademija();
            fak.Show();
            this.Hide();
        }
        private void FormClosedHandler(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void uvodbtnforw_Click(object sender, EventArgs e)
        {
            string lokacija = comboBox1.Text;

            if (lokacija == "Izaberite lokaciju")
            {
                MessageBox.Show("Morate odabrati jednu opciju.");
            }
            else
            {

                Master master = new Master(tipodabir, lokacija);
                this.Hide();
                master.Show();
            }

        }

        private void pitanje_Click(object sender, EventArgs e)
        {
            objasnjenje1.Show();
        }
    }
}
