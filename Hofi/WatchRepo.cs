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
            int salary = 0;
            string startDate = "";

            Console.Write("Indtast medlemsnr(hofiXXXX): ");
            string medlemsnr = Console.ReadLine();
            Console.Write("Indtast dato(dd.mm.yyyy): ");
            string date = Console.ReadLine();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {

                    con.Open();

                    //startDate for employee

                    SqlCommand getStartDate = new SqlCommand("spGetStartDate", con);
                    getStartDate.CommandType = CommandType.StoredProcedure;
                    getStartDate.Parameters.Add(new SqlParameter("@Medlemsnr", medlemsnr));

                    SqlDataReader reader = getStartDate.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            startDate = reader["Ansat"].ToString();
                        }
                    }

                    reader.Close();

                    DateTime employmentDate = DateTime.Parse(startDate);

                    DateTime watchDate = DateTime.Parse(date);

                    watchDate = watchDate.AddYears(-3);

                    if (employmentDate <= watchDate)
                    {
                        salary = 100;

                    }
                    else
                    {
                        salary = 75;
                    }


                        SqlCommand spinningWatch = new SqlCommand("spRegisterWatch", con);
                        spinningWatch.CommandType = System.Data.CommandType.StoredProcedure;
                        spinningWatch.Parameters.Add(new SqlParameter("@Medlemsnr", medlemsnr));
                        spinningWatch.Parameters.Add(new SqlParameter("@Type", "Spinning"));
                        spinningWatch.Parameters.Add(new SqlParameter("@Dato", date));
                        spinningWatch.Parameters.Add(new SqlParameter("@Honorar", salary));

                        spinningWatch.ExecuteNonQuery();

                        Console.Clear();
                        Console.WriteLine("Vagt tilføjet");

                    
                }
                catch (SqlException e)
                {
                    Console.WriteLine("FEJL: " + e.Message);
                }
            }
        }
    }
    }