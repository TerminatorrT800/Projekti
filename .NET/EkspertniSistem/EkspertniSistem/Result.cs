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
    public partial class Result : Form
    {
        private int doctor;
        private int masterStudije;
        private string tipOdabir;
        private string lokacija;
        private int cena;
        private string brojgod;
        private string tip;
        private string smer;

        public Result(string typeChoice, string location, int master, int doktor, int price, string numberyr, string type, string studije)
        {
            InitializeComponent();

            doctor = doktor;
            tipOdabir = typeChoice;
            lokacija = location;
            cena = price;
            masterStudije = master;
            brojgod = numberyr;
            smer = studije;
            tip = type;
            bool uslov = false;
            DBManager db = DBManager.Instance;

            string upit = "SELECT * FROM Skola JOIN Studije ON Skola.id = Studije.skolaID";
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

            if (brojgod == "3" || brojgod == "4")
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

            if (smer != "Svejedno")
            {
                if (uslov == true)
                {
                    upit += " AND";
                }
                else
                {
                    upit += " WHERE";
                }
                upit += " Studije.naziv = @naziv";
                uslov = true;
            }
            List<Dictionary<string, string>> results = new List<Dictionary<string, string>>();

            using (SQLiteCommand command = new SQLiteCommand(upit, db.Connection))
            {
                command.Parameters.AddWithValue("@tip", tipOdabir);
                command.Parameters.AddWithValue("@lokacija", lokacija);
                command.Parameters.AddWithValue("@doktor", doctor);
                command.Parameters.AddWithValue("@cena", cena);
                command.Parameters.AddWithValue("@brojgod", brojgod);
                command.Parameters.AddWithValue("@vrsta", tip);
                command.Parameters.AddWithValue("@naziv", smer);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Dictionary<string, string> row = new Dictionary<string, string>();

                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            row.Add(reader.GetName(i), reader[i].ToString());
                        }

                        results.Add(row);
                    }
                }
            }
            Random random = new Random();
            var uniqueResults = results.GroupBy(x => x["ime"]).Select(group => group.First()).ToList();

            if (uniqueResults.Count == 1)
            {
                DisplaySingleResult(results);
            }
            else
            {
                DisplayMultipleResults(results);

            }
        }

        Font naslovFont = new Font("Unispace", 20);
        Font tekstFont = new Font("Unispace", 10);

        private void DisplaySingleResult(List<Dictionary<string, string>> result)
        {
            var uniqueResults = result.GroupBy(x => x["ime"]).Select(group => group.First()).ToList();

            naslov.Text = "Na osnovu vaših odgovora, kao rezultat ste dobili:";


            GroupBox groupBox = new GroupBox
            {
                Text = uniqueResults[0]["ime"],
                Width = 750,
                Height = 650,
                Margin = new Padding(10),
                Padding = new Padding(10),
                Location = new Point(10, 10),
                Font = naslovFont,
            };

            Label tipLabel = new Label
            {
                Width = 750,
                Height = 30,
                Text = uniqueResults[0]["tip"],
                Location = new Point(10, 80),
                Font = new Font("Unispace", 14),
                
            };

            Label lokacijaLabel = new Label
            {
                Width = 750,
                Height = 50,
                Text = uniqueResults[0]["lokacija"],
                Location = new Point(10, 110),
                Font = new Font("Unispace", 12),
            };

            Label adresaLabel = new Label
            {
                Width = 750,
                Height = 40,
                Text = uniqueResults[0]["adresa"],
                Location = new Point(10, 160),
                Font = tekstFont,
            };

            Label kontaktLabel = new Label
            {
                Width = 750,
                Height = 40,
                Text = uniqueResults[0]["telefon"],
                Location = new Point(10, 200),
                Font = tekstFont,
            };

            List<Dictionary<string, string>> lista = new List<Dictionary<string, string>>();
            foreach (var rez in result)
            {
                if (rez["ime"] == uniqueResults[0]["ime"])
                {
                    Dictionary<string, string> row = new Dictionary<string, string>();
                    row.Add("naziv", rez["naziv"]);
                    row.Add("cena", rez["cena"]);
                    lista.Add(row);
                }
            }

            int offset = 270;
            foreach (var item in lista)
            {
                Label smerLabel = new Label
                {
                    Width = 750,
                    Height = 50,
                    Text = item["naziv"] + " " + item["cena"] + " din",
                    Location = new Point(10, offset),
                    Font = tekstFont,
                };
                groupBox.Controls.Add(smerLabel);
                offset += 50;
            }


            groupBox.Controls.Add(tipLabel);
            groupBox.Controls.Add(lokacijaLabel);
            groupBox.Controls.Add(adresaLabel);
            groupBox.Controls.Add(kontaktLabel);

            flowLayoutPanel1.Width = 800;
            flowLayoutPanel1.Location = new Point((this.ClientSize.Width - flowLayoutPanel1.Width) / 2, 130);
            flowLayoutPanel1.Controls.Add(groupBox);
        }


        private void DisplayMultipleResults(List<Dictionary<string, string>> results)
        {
            Random random = new Random();

            var uniqueResults = results.GroupBy(x => x["ime"]).Select(group => group.First()).ToList();
            var randomResults = uniqueResults.OrderBy(x => random.Next()).Take(3).ToList();
            if (uniqueResults.Count > 3)
            {
                naslov.Text = "Kao rezultat ste dobili 3 škole koje odgovaraju vašem odabiru.";
                podnaslov.Text = "Napomena, broj škola koji odgovara vašem rezultatu je " + uniqueResults.Count + ", ali zbog preglednosti, " +
                    "rezultat je uvek 3 nasumično izvučene škole.";
            }
            else
            {
                naslov.Text = "Kao rezultat ste dobili 3 škole koje odgovaraju vašem odabiru.";

            }

            foreach (var result in randomResults)
            {
                GroupBox groupBox = new GroupBox
                {
                    Text = result["ime"],
                    Width = 350,
                    Height = 500,
                    Margin = new Padding(10),
                    Padding = new Padding(10),
                    Font = new Font("Unispace", 12),
                };

                Label tipLabel = new Label
                {
                    Width = 350,
                    Height = 40,
                    Text = result["tip"],
                    Location = new Point(10, 80),
                    Font = tekstFont,
                };

                Label lokacijaLabel = new Label
                {
                    Width = 350,
                    Height = 40,
                    Text = result["lokacija"],
                    Location = new Point(10, 120),
                    Font = tekstFont,
                };

                Label adresaLabel = new Label
                {
                    Width = 350,
                    Height = 40,
                    Text = result["adresa"],
                    Location = new Point(10, 160),
                    Font = tekstFont,
                };

                Label kontaktLabel = new Label
                {
                    Width = 350,
                    Height = 40,
                    Text = result["telefon"],
                    Location = new Point(10, 200),
                    Font = tekstFont,
                };
                string tekst;
                if (result["brojgod"] == "3")
                {
                    tekst = " godina studiranja";
                }
                else
                {
                    tekst = " godine studiranja";
                }

                List<Dictionary<string, string>> lista = new List<Dictionary<string, string>>();
                foreach (var rez in results)
                {
                    if (rez["ime"] == result["ime"])
                    {
                        Dictionary<string, string> row = new Dictionary<string, string>();
                        row.Add("naziv", rez["naziv"]);
                        row.Add("cena", rez["cena"]);
                        lista.Add(row);
                    }
                }

                int offset = 240;
                foreach (var item in lista)
                {
                    Label smerLabel = new Label
                    {
                        Width = 340,
                        Height = 38,
                        Text = item["naziv"] + " " + item["cena"] + " din",
                        Location = new Point(10, offset),
                        Font = tekstFont,
                    };
                    groupBox.Controls.Add(smerLabel);
                    offset += 38;
                }


                groupBox.Controls.Add(tipLabel);
                groupBox.Controls.Add(lokacijaLabel);
                groupBox.Controls.Add(adresaLabel);
                groupBox.Controls.Add(kontaktLabel);


                flowLayoutPanel1.Controls.Add(groupBox);
            }
        }


        private void FormClosedHandler(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Result_Load(object sender, EventArgs e)
        {

        }
    }
}
