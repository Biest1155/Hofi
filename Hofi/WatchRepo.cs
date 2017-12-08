using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Net.Mail;

namespace Hofi
{
    //class WatchRepo
    //{
    //    private static string connectionString = "Server=EALSQL1.eal.local; Database= DB2017_A28; User ID = USER_A28; Password=SesamLukOp_28;";

    //    public void RegisterWatch(string fitnessOrSpinning)
    //    {

    //        string type = fitnessOrSpinning;
    //        int salary = 0;
    //        string startDate = "";

    //        Console.Write("Indtast medlemsnr(hofiXXXX): ");
    //        string medlemsnr = Console.ReadLine();
    //        Console.Write("Indtast dato(dd.mm.yyyy): ");
    //        string date = Console.ReadLine();

    //        using (SqlConnection con = new SqlConnection(connectionString))
    //        {
    //            try
    //            {

    //                con.Open();

    //                SqlCommand getEmploymentDate = new SqlCommand("spGetStartDate", con);
    //                getEmploymentDate.CommandType = CommandType.StoredProcedure;
    //                getEmploymentDate.Parameters.Add(new SqlParameter("@Medlemsnr", medlemsnr));

    //                SqlDataReader reader = getEmploymentDate.ExecuteReader();

    //                if (reader.HasRows)
    //                {
    //                    while (reader.Read())
    //                    {
    //                        startDate = reader["Ansat"].ToString();
    //                    }
    //                }

    //                reader.Close();

    //                DateTime employmentDate = DateTime.Parse(startDate);

    //                DateTime watchDate = DateTime.Parse(date);

    //                watchDate = watchDate.AddYears(-3);

    //                if (employmentDate <= watchDate)
    //                {
    //                    salary = 100;

    //                }
    //                else
    //                {
    //                    salary = 75;
    //                }


    //                SqlCommand spinningWatch = new SqlCommand("spRegisterWatch", con);
    //                spinningWatch.CommandType = System.Data.CommandType.StoredProcedure;
    //                spinningWatch.Parameters.Add(new SqlParameter("@Medlemsnr", medlemsnr));
    //                spinningWatch.Parameters.Add(new SqlParameter("@Type", type));
    //                spinningWatch.Parameters.Add(new SqlParameter("@Dato", date));
    //                spinningWatch.Parameters.Add(new SqlParameter("@Honorar", salary));

    //                spinningWatch.ExecuteNonQuery();

    //                Console.Clear();
    //                Console.WriteLine("Vagt tilføjet");

    //                InstructorRepo I_repo2 = new InstructorRepo();
    //                I_repo2.GetMail(medlemsnr, date);
    //            }
    //            catch (SqlException e)
    //            {
    //                Console.WriteLine("FEJL: " + e.Message);
    //            }
    //            catch (FormatException e1)
    //            {
    //                Console.WriteLine("FEJL: " + e1.Message);
    //                RegisterWatch(fitnessOrSpinning);
    //            }
    //        }
    //    }



    //}
}