using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Hofi
{
    class InstructorRepo
    {
        private static string connectionString = "Server=ealdb1.eal.local; Database= DB2017_A28; User ID=USER_A28; Password=SesamLukOp_28;";
        
        
        private string Navn = Console.ReadLine();
        private string Email = Console.ReadLine();
        private string Ansat = Console.ReadLine();

        private void AddInstructorSQL()
        {
            Console.Write("Indtast medlemsnr: ");
            string Medlemsnr = Console.ReadLine();
            Console.Write("Indtast navn: ");
            string Navn = Console.ReadLine();
            Console.Write("Indtast Email: ");
            string Email = Console.ReadLine();
            Console.Write("Indtast dato for ansættelse");
            string Ansat = Console.ReadLine();

            using (SqlConnection con = new SqlConnection(connectionString))
            {


                try
                {
                    con.Open();

                    SqlCommand AddInstructor = new SqlCommand("spAddInstructor", con);
                    AddInstructor.CommandType = System.Data.CommandType.StoredProcedure;
                    AddInstructor.Parameters.Add(new SqlParameter("@Medlemsnr", Medlemsnr));
                    AddInstructor.Parameters.Add(new SqlParameter("@Navn", Navn));
                    AddInstructor.Parameters.Add(new SqlParameter("@Email", Email));
                    AddInstructor.Parameters.Add(new SqlParameter("@Ansat", Ansat));

                    AddInstructor.ExecuteNonQuery();
                }
                catch (SqlException e)
                {
                    Console.WriteLine("FEJL: " + e.Message);
                }
            }



        
            

        }
    }
}
