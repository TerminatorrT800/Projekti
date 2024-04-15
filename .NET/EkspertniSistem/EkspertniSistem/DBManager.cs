using System.Data.SQLite;

namespace EkspertniSistem
{
    public class DBManager
    {
        private static DBManager instance;
        private static SQLiteConnection conn;

        private DBManager()
        {
            string connectionString = "Data source=EkspertniSistemBaza.db;Version=3;";
            conn = new SQLiteConnection(connectionString);
        }
        public static DBManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DBManager();
                }
                return instance;
            }

        }
        public SQLiteConnection Connection
        {
            get { return conn; }
        }
        public void openConn()
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                {
                    conn.Open();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Greska pri povezivanju sa bazom" + e.Message);
            }
            
        }
        public void closeConn()
        {
            if (conn.State != System.Data.ConnectionState.Closed)
            {
                conn.Close();
            }
        }
    }

}

