using System.Data.SQLite;


namespace EkspertniSistem
{


    public partial class Home : Form

    {
        private string ime;
        private string br;

        public Home()
        {
            InitializeComponent();

        
        }


        private void pocetakBtn_Click(object sender, EventArgs e)
        {
            Uvod uvod = new Uvod();
            uvod.Show();
            this.Hide();
        }

        private void FormClosedHandler(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

    }
}