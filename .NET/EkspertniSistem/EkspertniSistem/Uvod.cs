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
    public partial class Uvod : Form
    {

        int brojpitanja = 6;
        public Uvod()
        {
            InitializeComponent();
            this.FormClosed += new FormClosedEventHandler(FormClosedHandler);
            richTextBox1.Text = "Svrha ovog programa ogleda se u pružanju pomoći korisnicima pri odabiru savršenog fakulteta ili akademije. Mnogi srednjoškolci suočavaju se s izazovom donošenja odluke o nastavku obrazovanja nakon završetka srednje škole." +
                "\nKoisnik će biti suočen sa određenim brojem pitanja. Svako pitanje će imati svoje predefinisane odgovore, na osnovu odabranih odgovora, program će na kraju da prikaže određeni rezultat. Rezultat može biti: \n\n" +
                "-Idealni fakultet/akademija - fakultet/akademija koji odgovara svim odgovorima koje je korisnik izabrao.\n\n" +
                "-Alternativne opcije - u slučaju da ne postoji fakultet ili akademija koja odgovara svim izabranim odgovorima, korisnik će kao rezultat dobiti nekoliko sličnih fakulteta/akademija.\n\n";
        }

        private void FormClosedHandler(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void uvodbtnback_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void uvodbtnforw_Click(object sender, EventArgs e)
        {
            FakultetIliAkademija fak = new FakultetIliAkademija();
            fak.Show();
            this.Hide();
        }
    }
}

