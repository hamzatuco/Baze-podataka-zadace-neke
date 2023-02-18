using System;
using System.Data.SqlClient;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string connString = @"Data Source = HAMZA-PC\SQLEXPRESS;" +
                                "Initial Catalog = ZADACE;" +
                                "Integrated Security = SSPI;";

            string sqlComm = "INSERT INTO Stanovi " +
                              "(Ime_stanara,Prezime_stanara,JMBG,Sprat,Broj_stana,Datum_useljenja,Broj_soba,Posjedovanje_ljubimca,Cijene_rezija_mjesecno) " +
                              "VALUES('Meho','Mujic','7839103471824',1,4,'07/04/2019',2,1,85.98)";

            SqlConnection sqlCon = new SqlConnection(connString);
            SqlCommand sqlComa = new SqlCommand(sqlComm, sqlCon);


            
            try
            {
                Console.WriteLine("Otvaram konekciju...");
                sqlCon.Open();
                Console.WriteLine("Konekcija uspjesno otvorena!");
                Console.WriteLine("------------------------------");
                Console.WriteLine("Izvrsavam naredbu...");
                sqlComa.ExecuteNonQuery();
                Console.WriteLine("Naredba izvrsena!");
                Console.WriteLine("------------------------------");
                Console.ReadKey();
                
            }

            catch (Exception e)
            {
                Console.WriteLine("Greska " + e.Message);
            }

            finally
            {
                sqlCon.Close();
            }





        }
    }
}
