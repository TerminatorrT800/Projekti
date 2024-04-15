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

namespace EkspertniSistem
{
    public partial class brojGod : Form
    {
        private int doctor;
        private int masterStudije;
        private string tipOdabir;
        private string lokacija;
        private int cena;
        public brojGod(string typeChoice, string location, int master, int doktor, int price)
        {
            InitializeComponent();
            doctor = doktor;
            tipOdabir = typeChoice;
            lokacija = location;
            cena = price;
            masterStudije = master;
            objasnjenje1.Text = "Broj godina studiranja.\nVažno je napomenuti da većina akademija pruža trogodišnje školovanje, a većina fakulteta četvorogodišnje.";
            bool uslov = false;
            DBManager db = DBManager.Instance;
            db.openConn();

            String upit = "SELECT DISTINCT brojgod FROM STUDIJE JOIN Skola ON skolaID = Skola.id";

            if (tipOdabir != "Nije bitno")
            {
                upit += " WHERE Skola.tip = @tip";
                uslov = true;

            }
            if (lokacija != "Svejedno")
            {
                if (uslov == true)
                {
                    upit += " AND";
                }
                else
                {
                    upit += " WHERE";
                }
                upit += " Skola.lokacija = @lokacija";
                uslov = true;
            }
            if (cena != 0)
            {
                if (uslov == true)
                {
                    upit += " AND";
                }
                else
                {
                    upit += " WHERE";
                }
                upit += " Studije.cena >= @cena";
                uslov = true;
            }
            if (masterStudije == 1)
            {
                if (uslov == true)
                {
                    upit += " AND";
                }
                else
                {
                    upit += " WHERE";
                }
                upit += " Skola.master = @master";
                uslov = true;
            }
            if (doctor == 1)
            {
                if (uslov == true)
                {
                    upit += " AND";
                }
                else
                {
                    upit += " WHERE";

                }
                upit += " Skola.doktor = @doktor";
            }
            upit += " ORDER BY brojgod ASC";


            using (SQLiteCommand command = new SQLiteCommand(upit, db.Connection))
            {
                command.Parameters.AddWithValue("@tip", tipOdabir);
                command.Parameters.AddWithValue("@lokacija", lokacija);
                command.Parameters.AddWithValue("@cena", cena);
                command.Parameters.AddWithValue("@master", masterStudije);
                command.Parameters.AddWithValue("@doktor", doctor);
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);

                    DataRow row = dt.NewRow();
                    row["brojgod"] = "Odaberite broj godina";
                    dt.Rows.InsertAt(row, 0);

                    DataRow red = dt.NewRow();
                    red["brojgod"] = "Svejedno";
                    dt.Rows.Add(red);

                    comboBox1.DataSource = dt;
                    comboBox1.DisplayMember = "brojgod";
                }
            }

        }

        private void uvodbtnback_Click(object sender, EventArgs e)
        {
            Cena cena = new Cena(tipOdabir, lokacija, masterStudije, doctor);
            this.Hide();
            cena.Show();
        }

        private void pitanje_Click(object sender, EventArgs e)
        {
            objasnjenje1.Show();
        }

        private void FormClosedHandler(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void uvodbtnforw_Click(object sender, EventArgs e)
        {
            string brojgod = comboBox1.Text;
            if (brojgod == "Odaberite broj godina")
            {
                MessageBox.Show("Odaberite jednu od opcija!");
            }
            else
            {
                VrsteSmerova smer = new VrsteSmerova(tipOdabir, lokacija, masterStudije, doctor, cena, brojgod);
                this.Hide();
                smer.Show();
            }
        }
    }
}
