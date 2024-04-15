using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EkspertniSistem
{
    public partial class Master : Form
    {

        private string tipOdabir;
        private int master;
        private string lokacija;
        DBManager database = DBManager.Instance;
        
        public Master(string typeChoice, string location)
        {
            tipOdabir = typeChoice;
            lokacija = location;
            database.openConn();

            InitializeComponent();

            objasnjenje1.Text = "Odabirom opcije 'Ne', " +
                "preskače se pitanje povodom doktorskih studija, odabirom opcije 'Da', " +
                "isključuju se sve akademije/fakulteti koji ne pružaju master studije.";

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
            if (!radioButton1.Checked && !radioButton2.Checked && !radioButton3.Checked)
            {
                MessageBox.Show("Morate odabrati jednu opciju.");
            }
            else if (radioButton1.Checked)
            {                
                master = 1;
                provera();
                
                
            }
            else if (radioButton2.Checked)
            {
                master = 0;
                Cena cena = new Cena(tipOdabir, lokacija, master);
                this.Hide();
                cena.Show();
            }
            else
            {
                master = 2;
                provera();

            }

        }

        private void uvodbtnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            Lokacija lokacijaform = new Lokacija(tipOdabir);
            lokacijaform.Show();
        }

        private void provera()
        {
            int broj;
            String upit = "SELECT COUNT(doktor) as brojDoktora FROM Skola WHERE doktor = 1";
            if (tipOdabir != "Nije bitno")
            {
                upit += " AND tip = @tip";
            }
            if (lokacija != "Svejedno")
            {
                upit += " AND lokacija = @lokacija";
            }

            using (SQLiteCommand command = new SQLiteCommand(upit, database.Connection))
            {
                command.Parameters.AddWithValue("@tip", tipOdabir);
                command.Parameters.AddWithValue("@lokacija", lokacija);
                broj = Convert.ToInt32(command.ExecuteScalar());

            }
            if (broj > 0)
            {
                Doktor doktor = new Doktor(tipOdabir, lokacija, master);
                this.Hide();
                doktor.Show();
            }
            else
            {
                Cena cena = new Cena(tipOdabir, lokacija, master);
                this.Hide();
                cena.Show();
            }
        }

    }
}
