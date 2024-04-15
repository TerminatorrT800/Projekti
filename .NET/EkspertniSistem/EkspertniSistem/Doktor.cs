using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EkspertniSistem
{
    public partial class Doktor : Form
    {
        private int masterStudije;
        private string tipOdabir;
        private string lokacija;
        private int doktor;

        public Doktor(string typeChoice, string location, int master)
        {
            masterStudije = master;
            tipOdabir = typeChoice;
            lokacija = location;

            InitializeComponent();
            objasnjenje1.Text = "Odabirom opcije 'Da', " +
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
            if (!radioButton1.Checked && !radioButton3.Checked)
            {
                MessageBox.Show("Morate odabrati jednu opciju.");
            }
            else if (radioButton1.Checked)
            {
                doktor = 1;
                Cena cena = new Cena(tipOdabir, lokacija, masterStudije, doktor);
                this.Hide();
                cena.Show();
            }           
            else
            {
                doktor = 2;
                Cena cena = new Cena(tipOdabir, lokacija, masterStudije, doktor);
                this.Hide();
                cena.Show();

            }

        }

        private void uvodbtnback_Click(object sender, EventArgs e)
        {
            Master master = new Master(tipOdabir, lokacija);
            this.Hide();
            master.Show();
        }
    }
}
