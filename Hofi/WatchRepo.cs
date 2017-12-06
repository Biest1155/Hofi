using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Hofi
{
    class WatchRepo
    {
        private static string connectionString = "Server=EALSQL1.eal.local; Database= DB2017_A28; User ID = USER_A28; Password=SesamLukOp_28;";


      

        public void RegisterFitnessWatch()
        {
            Console.Write("Indtast medlemsnr(hofiXXXX): ");
            string medlemsnr = Console.ReadLine();
            Console.Write("Indtast dato(dd.mm.yyyy): ");
            string dato = Console.ReadLine();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                   SqlCommand FitnessWatch = new SqlCommand("spRegisterWatch", con);
                    FitnessWatch.CommandType = System.Data.CommandType.StoredProcedure;
                    FitnessWatch.Parameters.Add(new SqlParameter("@Medlemsnr", medlemsnr));
                    FitnessWatch.Parameters.Add(new SqlParameter("@Type", "Fitness"));
                    FitnessWatch.Parameters.Add(new SqlParameter("@Dato", dato));
                    FitnessWatch.Parameters.Add(new SqlParameter("@Honorar", "75"));

                    FitnessWatch.ExecuteNonQuery();

                    Console.Clear();
                    Console.WriteLine("Fitnessvagt tilføjet for " + medlemsnr + ".");

                    Menu mainmenu = new Menu();
                    mainmenu.MainMenu();
                }
                catch (SqlException e)
                {
                    Console.WriteLine("FEJL: " + e.Message);
                }
            }
        }
        public void RegisterSpinningWatch()
        {
            Console.Write("Indtast medlemsnr(hofiXXXX): ");
            string medlemsnr = Console.ReadLine();
            Console.Write("Indtast dato(dd.mm.yyyy): ");
            string dato = Console.ReadLine();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    SqlCommand SpinningWatch = new SqlCommand("spRegisterWatch", con);
                    SpinningWatch.CommandType = System.Data.CommandType.StoredProcedure;
                    SpinningWatch.Parameters.Add(new SqlParameter("@Medlemsnr", medlemsnr));
                    SpinningWatch.Parameters.Add(new SqlParameter("@Type", "Spinning"));
                    SpinningWatch.Parameters.Add(new SqlParameter("@Dato", dato));
                    SpinningWatch.Parameters.Add(new SqlParameter("@Honorar", "75"));

                    SpinningWatch.ExecuteNonQuery();
                }
                catch (SqlException e)
                {
                    Console.WriteLine("FEJL: " + e.Message);
                }
            }
        }
    }
    }