using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace EkspertniSistem
{
    public partial class VrsteSmerova : Form
    {
        private int doctor;
        private int masterStudije;
        private string tipOdabir;
        private string lokacija;
        private int cena;
        private string brojgod;
        public VrsteSmerova(string typeChoice, string location, int master, int doktor, int price, string numberyr)
        {
            InitializeComponent();
            objasnjenje1.Text = "Ovde su smerovi klasifikovani u grupama. Klasifikacija je izvršena radi lakše preglednosti smerova, odabirom jedne od ovih opcija, " +
                "postiže se filtiranje smerova na sledećoj formi. Ako se ne odlučite ni za jednu grupu, u sledećoj formi će vam se prikazati " +
                "svi smerovi koji odgovaraju dosad odabranim odgovorima.";

            doctor = doktor;
            tipOdabir = typeChoice;
            lokacija = location;
            cena = price;
            masterStudije = master;
            this.brojgod = numberyr;
            bool uslov = false;
            DBManager db = DBManager.Instance;
            db.openConn();

            string upit = "SELECT DISTINCT Studije.vrsta FROM Studije JOIN Skola ON Studije.skolaID = Skola.id";
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

            if (brojgod !="Svejedno")
            {
                if (uslov == true)
                {
                    upit += " AND";
                }
                else
                {
                    upit += " WHERE";
                }
                upit += " Studije.brojgod = @brojgod";
                uslov = true;
            }
            upit += " ORDER BY Studije.vrsta ASC";

            using (SQLiteCommand command = new SQLiteCommand(upit, db.Connection))
            {
                command.Parameters.AddWithValue("@tip", tipOdabir);
                command.Parameters.AddWithValue("@lokacija", lokacija);
                command.Parameters.AddWithValue("@doktor", doctor);
                command.Parameters.AddWithValue("@cena", cena);
                command.Parameters.AddWithValue("@brojgod", brojgod);
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);

                    DataRow row = dt.NewRow();
                    row["vrsta"] = "Odaberite studije";
                    dt.Rows.InsertAt(row, 0);

                    DataRow red = dt.NewRow();
                    red["vrsta"] = "Svejedno";
                    dt.Rows.Add(red);

                    comboBox1.DataSource = dt;
                    comboBox1.DisplayMember = "vrsta";
                }
            }
        }
        private void uvodbtnback_Click(object sender, EventArgs e)
        {
            brojGod brojgod = new brojGod(tipOdabir, lokacija, masterStudije, doctor, cena);
            this.Hide();
            brojgod.Show();
        }

        private void uvodbtnforw_Click(object sender, EventArgs e)
        {
            string tip = comboBox1.Text;
            if (tip == "Odaberite studije")
            {
                MessageBox.Show("Morate odabrati jednu od ponuđenih opcija!");
            }
            else
            {
                smer rez = new smer(tipOdabir, lokacija, masterStudije, doctor, cena, brojgod, tip);
                this.Hide();
                rez.Show();
            }

        }
        private void FormClosedHandler(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void pitanje_Click(object sender, EventArgs e)
        {
            objasnjenje1.Show();
        }
    }
}
