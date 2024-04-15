using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EkspertniSistem
{
    public partial class Cena : Form
    {
        private int doctor;
        private int masterStudije;
        private string tipOdabir;
        private string lokacija;
        int maxCena;
        public Cena(string typeChoice, string location, int master, int doktor)
        {
            InitializeComponent();
            DBManager dbManager = DBManager.Instance;
            dbManager.openConn();
            doctor = doktor;
            masterStudije = master;
            tipOdabir = typeChoice;
            lokacija = location;
            objasnjenje1.Text = "Ova cifra prestavlja cenu jedne školske godine osnovnih studija. " +
                "Korisnik ne može dobiti kao rezultat školu čija cena je veća od ovde izabrane vrednosti.";
            bool uslov = false;


            string MAXquery = "SELECT MAX(cena) AS maxCena FROM Studije JOIN Skola ON Studije.skolaId = Skola.id";
            string MINquery = "SELECT MIN(cena) AS minCena FROM Studije JOIN Skola ON Studije.skolaId = Skola.id";

            if (tipOdabir != "Nije bitno")
            {
                MAXquery += " WHERE Skola.tip = @tip";
                MINquery += " WHERE Skola.tip = @tip";
                uslov = true;

            }
            if (lokacija != "Svejedno")
            {
                if (uslov == true)
                {
                    MAXquery += " AND";
                    MINquery += " AND";
                }
                else
                {
                    MAXquery += " WHERE";
                    MINquery += " WHERE";
                }
                MAXquery += " Skola.lokacija = @lokacija";
                MINquery += " Skola.lokacija = @lokacija";
                uslov = true;
            }
            if (masterStudije == 1)
            {
                if (uslov == true)
                {
                    MAXquery += " AND";
                    MINquery += " AND";
                }
                else
                {
                    MAXquery += " WHERE";
                    MINquery += " WHERE";
                }
                MAXquery += " Skola.master = @master";
                MINquery += " Skola.master = @master";
                uslov = true;
            }
            if (doctor == 1)
            {
                if (uslov == true)
                {
                    MAXquery += " AND";
                    MINquery += " AND";
                }
                else
                {
                    MAXquery += " WHERE";
                    MINquery += " WHERE";
                }
                MAXquery += " Skola.doktor = @doktor";
                MINquery += " Skola.doktor = @doktor";
            }

                using (SQLiteCommand command = new SQLiteCommand(MAXquery, dbManager.Connection))
            {
                command.Parameters.AddWithValue("@tip", tipOdabir);
                command.Parameters.AddWithValue("@lokacija", lokacija);
                command.Parameters.AddWithValue("@master", masterStudije);
                command.Parameters.AddWithValue("@doktor", doctor);
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        maxCena = Convert.ToInt32(reader["maxCena"]);
                        trackBar1.Maximum = maxCena;
                        trackBar1.Value = maxCena;
                    }
                }
            }
            using (SQLiteCommand command2 = new SQLiteCommand(MINquery, dbManager.Connection))
            {
                command2.Parameters.AddWithValue("@tip", tipOdabir);
                command2.Parameters.AddWithValue("@lokacija", lokacija);
                command2.Parameters.AddWithValue("@master", masterStudije);
                command2.Parameters.AddWithValue("@doktor", doctor);
                using (SQLiteDataReader reader = command2.ExecuteReader())

                {
                    if (reader.Read())
                    {
                        int minCena = Convert.ToInt32(reader["minCena"]);
                        trackBar1.Minimum = minCena;
                        trackBar1.SmallChange = (maxCena - minCena) / 10;
                        trackBar1.TickFrequency = trackBar1.SmallChange;
                        trackBar1.TickStyle = TickStyle.BottomRight;
                    }

                }
            }
            dbManager.closeConn();
        }


        public Cena(string typeChoice, string location, int master)
        {
            InitializeComponent();
            DBManager dbManager = DBManager.Instance;
            dbManager.openConn();
            bool uslov = false;
            doctor = 2;
            masterStudije = master;
            tipOdabir = typeChoice;
            lokacija = location;
            objasnjenje1.Text = "Ova cifra prestavlja cenu jedne školske godine osnovnih studija. " +
                "Korisnik ne može dobiti kao rezultat školu čija cena je veća od ovde izabrane vrednosti.";

            string MAXquery = "SELECT MAX(cena) AS maxCena FROM Studije JOIN Skola ON Studije.skolaId = Skola.id";
            string MINquery = "SELECT MIN(cena) AS minCena FROM Studije JOIN Skola ON Studije.skolaId = Skola.id";

            if (tipOdabir != "Nije bitno")
            {
                MAXquery += " WHERE Skola.tip = @tip";
                MINquery += " WHERE Skola.tip = @tip";
                uslov = true;

            }
            if (lokacija != "Svejedno")
            {
                if (uslov == true)
                {
                    MAXquery += " AND";
                    MINquery += " AND";
                }
                else
                {
                    MAXquery += " WHERE";
                    MINquery += " WHERE";
                }
                MAXquery += " Skola.lokacija = @lokacija";
                MINquery += " Skola.lokacija = @lokacija";
                uslov = true;
            }
            using (SQLiteCommand command = new SQLiteCommand(MAXquery, dbManager.Connection))
            {
                command.Parameters.AddWithValue("@tip", tipOdabir);
                command.Parameters.AddWithValue("@lokacija", lokacija);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {

                    if (reader.Read())
                    {

                        maxCena = Convert.ToInt32(reader["maxCena"]);
                        trackBar1.Maximum = maxCena;
                    }
                }
            }
            using (SQLiteCommand command = new SQLiteCommand(MINquery, dbManager.Connection))
            {
                command.Parameters.AddWithValue("@tip", tipOdabir);
                command.Parameters.AddWithValue("@lokacija", lokacija);
                command.Parameters.AddWithValue("@master", masterStudije);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {

                    if (reader.Read())
                    {
                        int minCena = Convert.ToInt32(reader["minCena"]);
                        trackBar1.Minimum = minCena;
                        trackBar1.SmallChange = (maxCena - minCena) / 10;
                        trackBar1.TickFrequency = trackBar1.SmallChange;
                        trackBar1.TickStyle = TickStyle.BottomRight;
                    }

                }
            }
            dbManager.closeConn();
        }

        private void uvodbtnback_Click(object sender, EventArgs e)
        {
           
                Master masterForm = new Master(tipOdabir, lokacija);
                this.Hide();
                masterForm.Show();           
        
        }
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label1.Text = trackBar1.Value.ToString() + " din";

        }

        private void Cena_Load(object sender, EventArgs e)
        {
            label1.Text = trackBar1.Value.ToString() + " din";
        }
        private void FormClosedHandler(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void pitanje_Click(object sender, EventArgs e)
        {
            objasnjenje1.Show();
        }

        private void uvodbtnforw_Click(object sender, EventArgs e)
        {

            int cena = trackBar1.Value;
            brojGod brojGod = new brojGod(tipOdabir, lokacija, masterStudije, doctor, cena);
            this.Hide();
            brojGod.Show();
        }
    }
}