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
    public partial class smer : Form
    {
        private int doctor;
        private int masterStudije;
        private string tipOdabir;
        private string lokacija;
        private int cena;
        private string brojgod;
        private string tip;
        public smer(string typeChoice, string location, int master, int doktor, int price, string numberyr, string type)
        {
            InitializeComponent();
            doctor = doktor;
            tipOdabir = typeChoice;
            lokacija = location;
            cena = price;
            masterStudije = master;
            brojgod = numberyr;
            tip = type;
            bool uslov = false;
            objasnjenje1.Text = "Ovde možete odabrati smer/studije koje želite studirati." +
                " Nije preporučljivo ići dalje sa opcijom \" Svejedno\" jer postoji mogućnost " +
                "da broj škola koji ispunjava vaše prethodne uslove je veliki, samim tim rešenje ne može biti jedinstveno.";
            DBManager db = DBManager.Instance;
            db.openConn();

            string upit = "SELECT DISTINCT Studije.naziv FROM Studije JOIN Skola ON skolaID = Skola.id";

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

            if (brojgod != "Svejedno")
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
            if (tip != "Svejedno")
            {
                if (uslov == true)
                {
                    upit += " AND";
                }
                else
                {
                    upit += " WHERE";
                }
                upit += " Studije.vrsta = @vrsta";
                uslov = true;
            }

            upit += " ORDER BY Studije.naziv ASC";

            using (SQLiteCommand command = new SQLiteCommand(upit, db.Connection))
            {
                command.Parameters.AddWithValue("@tip", tipOdabir);
                command.Parameters.AddWithValue("@lokacija", lokacija);
                command.Parameters.AddWithValue("@doktor", doctor);
                command.Parameters.AddWithValue("@cena", cena);
                command.Parameters.AddWithValue("@brojgod", brojgod);
                command.Parameters.AddWithValue("@vrsta", tip);
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);

                    DataRow row = dt.NewRow();
                    row["naziv"] = "Odaberite studije";
                    dt.Rows.InsertAt(row, 0);

                    DataRow red = dt.NewRow();
                    red["naziv"] = "Svejedno";
                    dt.Rows.Add(red);

                    comboBox1.DataSource = dt;
                    comboBox1.DisplayMember = "naziv";
                }
            }
        }

        private void pitanje_Click(object sender, EventArgs e)
        {
            objasnjenje1.Show();
        }

        private void uvodbtnback_Click(object sender, EventArgs e)
        {
            brojGod brojgod = new brojGod(tipOdabir, lokacija, masterStudije, doctor, cena);
            this.Hide();
            brojgod.Show();
        }

        private void uvodbtnforw_Click(object sender, EventArgs e)
        {
            string smer = comboBox1.Text;
            if (smer == "Odaberite studije")
            {
                MessageBox.Show("Morate odabrati jednu od ponuđenih opcija!");
            }
            else
            {
                Result rez = new Result(tipOdabir, lokacija, masterStudije, doctor, cena, brojgod, tip, smer);
                this.Hide();
                rez.Show();
            }

        }
        private void FormClosedHandler(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
