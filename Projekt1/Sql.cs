using System;
using System.Text;
using System.Data.SqlClient;


namespace Projekt1 {
    class Sql {
        static readonly string connectionString = "Data Source=DESKTOP-7TDH2OL\\SQLEXPRESS;Initial Catalog=Flood;Integrated Security=SSPI";
        SqlConnection connection = new SqlConnection(connectionString);


        public Sql() {



        }


        public int maxY() {

            connection.Open();
            StringBuilder sb = new StringBuilder();
            sb.Append("SELECT TOP 1 PositionY FROM Location ORDER BY PositionY DESC; ");
            string com = sb.ToString();
            SqlCommand command = new SqlCommand(com, connection);
            int wynik = (int)command.ExecuteScalar();
            connection.Close();
            return wynik;
        }

        public int maxX() {

            connection.Open();
            StringBuilder sb = new StringBuilder();
            sb.Append("SELECT TOP 1 PositionX FROM Location ORDER BY PositionX DESC; ");
            string com = sb.ToString();
            SqlCommand command = new SqlCommand(com, connection);
            int wynik = (int)command.ExecuteScalar();
            connection.Close();
            return wynik;
        }

        public int[] GetTerrain(int x, int y) {

            StringBuilder sb = new StringBuilder();
            sb.Append("SELECT * FROM dbo.Location WHERE PositionX = '");
            sb.Append(x);
            sb.Append("' AND PositionY = '");
            sb.Append(y);
            sb.Append("';");

            connection.Open();
            string com = sb.ToString();
            SqlCommand command = new SqlCommand(com, connection);
            SqlDataReader reader = command.ExecuteReader();

            reader.Read();

            int[] tab = new int[8];
            for (int i = 0; i < 8; i++) {
                tab[i] = (int)reader[i + 1];
            }
            connection.Close();
            return tab;


        }

        public int getUserLocation(string imie, string nazwisko) {
            StringBuilder sb = new StringBuilder();
            sb.Append("SELECT COUNT(LocationID) FROM [User] WHERE FirstName = '");
            sb.Append(imie);
            sb.Append("' AND SecondName = '");
            sb.Append(nazwisko);
            sb.Append("';");
            string com = sb.ToString();


            connection.Open();

            SqlCommand command = new SqlCommand(com, connection);
            int wynik = 0;
            wynik = (Int32)command.ExecuteScalar();

            if (wynik == 1) wynik = (int)command.ExecuteScalar();
            else {
                Console.WriteLine("\n\nNie ma takiego uzytkownika lub uzytkowników jest więcej!\n");
                return 0;
            }
            StringBuilder sb2 = new StringBuilder();
            sb2.Append("SELECT LocationID FROM [User] WHERE FirstName = '");
            sb2.Append(imie);
            sb2.Append("' AND SecondName = '");
            sb2.Append(nazwisko);
            sb2.Append("';");
            string com2 = sb2.ToString();
            SqlCommand command2 = new SqlCommand(com2, connection);
            wynik = (Int32)command2.ExecuteScalar();
            connection.Close();

            return wynik;
        }

        public int[] getRainfallOnDate(string date) {

            StringBuilder sb = new StringBuilder();
            sb.Append("SELECT Rainfall, LocationID FROM dbo.Forecast WHERE Date = '");
            sb.Append(date);
            sb.Append("';");

            connection.Close();
            connection.Open();
            string com = sb.ToString();
            SqlCommand command = new SqlCommand(com, connection);
            SqlDataReader reader = command.ExecuteReader();

            int[] wyniki = new int[17];
            for (int i = 1; i < 17; i++) wyniki[i] = 0;

            while (reader.Read()) {
                wyniki[(int)reader[1]] = (int)reader[0];
            }
            connection.Close();

            return wyniki;
        }
    }
}
