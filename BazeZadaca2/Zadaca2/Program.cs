using System;
using System.Data.SqlClient;
using System.Data;

namespace Zadaca2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            DataSet Zadaca = new DataSet();
            
            DataTable STANOVI = Zadaca.Tables.Add("STANOVI");
            
            DataColumn Stan_ID = new DataColumn("Stan_ID", System.Type.GetType("System.Int32"));
            Stan_ID.AutoIncrement = true;
            Stan_ID.AllowDBNull = false;
            STANOVI.Columns.Add(Stan_ID);


            DataColumn Ime_stanara = new DataColumn("Ime_stanara", System.Type.GetType("System.String"));
            Ime_stanara.MaxLength = 20;
            Ime_stanara.AllowDBNull = false;
            STANOVI.Columns.Add(Ime_stanara);


            DataColumn Prezime_stanara = new DataColumn("Prezime_stanara", System.Type.GetType("System.String"));
            Prezime_stanara.MaxLength = 20;
            Prezime_stanara.AllowDBNull = false;
            STANOVI.Columns.Add(Prezime_stanara);


            DataColumn JMBG = new DataColumn("JMBG", System.Type.GetType("System.String"));
            JMBG.MaxLength = 13;
            STANOVI.Columns.Add(JMBG);


            DataColumn Sprat = new DataColumn("Sprat", System.Type.GetType("System.Int16"));
            STANOVI.Columns.Add(Sprat);


            DataColumn Broj_stana = new DataColumn("Broj_stana", System.Type.GetType("System.Int32"));
            STANOVI.Columns.Add(Broj_stana);


            DataColumn Datum_useljenja = new DataColumn("Datum_useljenja", System.Type.GetType("System.DateTime"));
            STANOVI.Columns.Add(Datum_useljenja);


            DataColumn Broj_soba = new DataColumn("Broj_soba", System.Type.GetType("System.Int16"));
            STANOVI.Columns.Add(Broj_soba);


            DataColumn Posjedovanje_ljubimca = new DataColumn("Posjedovanje_ljubimca", System.Type.GetType("System.Boolean"));
            STANOVI.Columns.Add(Posjedovanje_ljubimca);


            DataColumn Cijene_rezija_mjesecno = new DataColumn("Cijene_rezija_mjesecno", System.Type.GetType("System.Decimal"));
            STANOVI.Columns.Add(Cijene_rezija_mjesecno);




            SqlConnection sqlKonekcija = Konekcija();

            SqlCommand selektKomanda = new SqlCommand("SELECT * FROM STANOVI", sqlKonekcija);
            SqlDataAdapter Adapter = new SqlDataAdapter(selektKomanda);


            Adapter.Fill(STANOVI);
            foreach (DataColumn Adaptercol in STANOVI.Columns)
            {
                
                Console.Write(Adaptercol.ColumnName.ToString() + " | ");
            }
            Console.WriteLine();
            Console.WriteLine();
            foreach (DataRow AdapterRw in STANOVI.Rows)
            {
                foreach (var item in AdapterRw.ItemArray)
                {
                    Console.Write(item.ToString() + " | ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }



        private static SqlConnection Konekcija()
        {
            string konekcioniString = @"Data Source = HAMZA-PC\SQLEXPRESS;" +
                                 "Initial Catalog = ZADACE;" +
                                 "Integrated Security = SSPI;";
            SqlConnection sqlKonekcija = new SqlConnection(konekcioniString);
            
            
            try
            {
                Console.WriteLine("Otvaram konekciju...");
                sqlKonekcija.Open();
                Console.WriteLine("Konekcija uspjesno otvorena!");
                Console.WriteLine("------------------------------");

            }
            catch (Exception e)
            {
                Console.WriteLine("Greska " + e.Message);
            }
            return sqlKonekcija;
        }
    }
}
