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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace EkspertniSistem
{
    public partial class FakultetIliAkademija : Form
    {
        public FakultetIliAkademija()
        {
            InitializeComponent();
            int yOffset = 50;

            RadioButton radioButton1 = new RadioButton();
            radioButton1.Text = "Nije bitno";
            radioButton1.Name = "rtbnNB";
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Unicode", 12, radioButton1.Font.Style);
            radioButton1.Location = new Point(10, yOffset);
            yOffset += 25;
            LokacijaBox.Controls.Add(radioButton1);

            DBManager dbManager = DBManager.Instance;
            dbManager.openConn();

            objasnjenje1.Text = "Razlika između akademije i fakulteta leži u tome što se ljudi sa visokih škola opremaju znanjima i " +
                "veštinama na taj način da što pre uđu na tržište rada i počnu da rade u nekoj konkretnoj oblasti.\r\n\r\nZnanje koje stičemo na fakultetu," +
                " dakle, pretpostavlja izučavanje materije koja nije direktno primenjiva u praksi i zahteva mnogo više vremena. Sa druge strane," +
                " usvajanje znanja na visokoj školi zahteva manje vremena i direktno je primenjivo u praksi.";

            string query = "SELECT DISTINCT tip FROM Skola";
            using (SQLiteCommand command = new SQLiteCommand(query, dbManager.Connection))
            {
                using (SQLiteDataReader reader = command.ExecuteReader())

                    while (reader.Read())
                    {
                        RadioButton radioButton = new RadioButton();
                        var rez = reader["tip"].ToString();
                        radioButton.Text = rez;
                        radioButton.Name = "rbtn" + rez;
                        radioButton.AutoSize = true;
                        radioButton.Font = new Font("Unicode", 12, radioButton.Font.Style);
                        radioButton.Location = new Point(10, yOffset);
                        yOffset += 25;
                        LokacijaBox.Controls.Add(radioButton);
                    }
            }
            dbManager.closeConn();
        }
        private void FormClosedHandler(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void uvodbtnback_Click(object sender, EventArgs e)
        {
            Uvod uvod = new Uvod();
            uvod.Show();
            this.Hide();
        }

        private void uvodbtnforw_Click(object sender, EventArgs e)
        {
            bool poruka = false;

            foreach (RadioButton radioButton in LokacijaBox.Controls.OfType<RadioButton>())
            {
                if (radioButton.Checked)
                {
                    string tipOdabir = radioButton.Text;

                    Lokacija lokacija = new Lokacija(tipOdabir);
                    lokacija.Show();
                    this.Hide();
                    poruka = true;

                }

            }
            if (poruka == false)
            {
                MessageBox.Show("Morate odabrati jednu opciju.");
            }



        }
        private void pitanje_Click(object sender, EventArgs e)
        {
            objasnjenje1.Show();
        }

    }
}
