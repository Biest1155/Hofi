using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Net.Mail;
using System.ComponentModel;

namespace Hofi
{
    class InstructorRepo
    {
        //private static string connectionString = "Server=EALSQL1.eal.local; Database= DB2017_A28; User ID = USER_A28; Password=SesamLukOp_28;";


        //public void AddInstructorSQL()
        //{
        //    Console.Write("Indtast medlemsnr(hofiXXXX): ");
        //    string Medlemsnr = Console.ReadLine();
        //    Console.Write("Indtast navn: ");
        //    string Navn = Console.ReadLine();
        //    Console.Write("Indtast Email: ");
        //    string Email = Console.ReadLine();
        //    Console.Write("Indtast dato for ansættelse(dd.mm.yyyy): ");
        //    string Ansat = Console.ReadLine();

        //    using (SqlConnection con = new SqlConnection(connectionString))
        //    {


        //        try
        //        {
        //            con.Open();

        //            SqlCommand AddInstructor = new SqlCommand("spAddInstructor", con);
        //            AddInstructor.CommandType = System.Data.CommandType.StoredProcedure;
        //            AddInstructor.Parameters.Add(new SqlParameter("@Medlemsnr", Medlemsnr));
        //            AddInstructor.Parameters.Add(new SqlParameter("@Navn", Navn));
        //            AddInstructor.Parameters.Add(new SqlParameter("@Email", Email));
        //            AddInstructor.Parameters.Add(new SqlParameter("@Ansat", Ansat));

        //            AddInstructor.ExecuteNonQuery();

        //            Console.WriteLine("Instruktør tilføjet!");
        //            Console.ReadLine();

        //            Menu mainmenu = new Menu();
        //            mainmenu.MainMenu();

        //        }
        //        catch (SqlException e)
        //        {
        //            Console.WriteLine("FEJL: " + e.Message);
        //        }
        //    }






        //}
        //public void GetMail(string medlemsnr, string date)
        //{
        //    string instructorEmail = "";

        //    using (SqlConnection con = new SqlConnection(connectionString))
        //    {
        //        try
        //        {

        //            con.Open();

        //            SqlCommand getEmploymentDate = new SqlCommand("spGetMail", con);
        //            getEmploymentDate.CommandType = CommandType.StoredProcedure;
        //            getEmploymentDate.Parameters.Add(new SqlParameter("@Medlemsnr", medlemsnr));

        //            SqlDataReader reader = getEmploymentDate.ExecuteReader();

        //            if (reader.HasRows)
        //            {
        //                while (reader.Read())
        //                {
        //                    instructorEmail = reader["Email"].ToString();
        //                }
        //            }
        //        }
        //        catch (SqlException m)
        //        {
        //            Console.WriteLine("FEJL: " + m.Message);
        //        }


        //        try
        //        {
        //            MailMessage mail = new MailMessage();
        //            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com", 587);

        //            mail.From = new MailAddress("hofiregistrering@gmail.com");
        //            mail.To.Add(instructorEmail);
        //            mail.Subject = "Kvittering for registrering af vagt d. " + date;
        //            mail.Body = "Din vagt er nu registreret";

        //            SmtpServer.Port = 587;
        //            SmtpServer.Credentials = new System.Net.NetworkCredential("Hofiregistrering@gmail.com", "hsgfitness");
        //            SmtpServer.EnableSsl = true;

        //            SmtpServer.Send(mail);
        //            Console.WriteLine("Mailkvittering er sendt til " + instructorEmail);
        //        }
        //        catch (Exception e)
        //        {
        //            Console.WriteLine("Der skete en uventet fejl, mailen er ikke sendt. Fejlkode: " + e.Message);
        //        }
        //    }
        //}
    }
}
