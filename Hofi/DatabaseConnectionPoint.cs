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
    class DatabaseConnectionPoint
    {
        private static string connectionString = "Server=EALSQL1.eal.local; Database= DB2017_A28; User ID = USER_A28; Password=SesamLukOp_28;";



        public void RegisterWatch(Watch shift, Instructor instructor)
        {

            int salary = shift.Salary;
            string startDate = instructor.HireDate;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {

                    con.Open();

                    SqlCommand getEmploymentDate = new SqlCommand("spGetStartDate", con);
                    getEmploymentDate.CommandType = CommandType.StoredProcedure;
                    getEmploymentDate.Parameters.Add(new SqlParameter("@Medlemsnr", instructor.MemberNumber));

                    SqlDataReader reader = getEmploymentDate.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            startDate = reader["Ansat"].ToString();
                        }
                    }

                    reader.Close();

                    DateTime employmentDate = DateTime.Parse(startDate);

                    DateTime watchDate = DateTime.Parse(shift.Date);

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
                    spinningWatch.Parameters.Add(new SqlParameter("@Medlemsnr", instructor.MemberNumber));
                    spinningWatch.Parameters.Add(new SqlParameter("@Type", shift.Type));
                    spinningWatch.Parameters.Add(new SqlParameter("@Dato", shift.Date));
                    spinningWatch.Parameters.Add(new SqlParameter("@Honorar", salary));

                    spinningWatch.ExecuteNonQuery();

                    //Sending mail here:
                    GetMail(instructor.MemberNumber, shift.Date);



                }
                catch (SqlException e)
                {
                    Console.WriteLine("FEJL: " + e.Message);
                }
                catch (FormatException e1)
                {
                    Console.WriteLine("FEJL: " + e1.Message);
                    RegisterWatch (shift, instructor);
                }
            }
        }

        public void AddInstructorSQL(Instructor instructor)
        {

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    SqlCommand AddInstructor = new SqlCommand("spAddInstructor", con);
                    AddInstructor.CommandType = System.Data.CommandType.StoredProcedure;
                    AddInstructor.Parameters.Add(new SqlParameter("@Medlemsnr", instructor.MemberNumber));
                    AddInstructor.Parameters.Add(new SqlParameter("@Navn", instructor.Name));
                    AddInstructor.Parameters.Add(new SqlParameter("@Email", instructor.Mail));
                    AddInstructor.Parameters.Add(new SqlParameter("@Ansat", instructor.HireDate));

                    AddInstructor.ExecuteNonQuery();

                    Menu mainmenu = new Menu();
                    mainmenu.MainMenu();

                }
                catch (SqlException e)
                {
                    Console.WriteLine("FEJL: " + e.Message);
                }
            }

        }
        public void GetMail(string medlemsnr, string date)
        {
            string instructorEmail = "";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {

                    con.Open();

                    SqlCommand getEmploymentDate = new SqlCommand("spGetMail", con);
                    getEmploymentDate.CommandType = CommandType.StoredProcedure;
                    getEmploymentDate.Parameters.Add(new SqlParameter("@Medlemsnr", medlemsnr));

                    SqlDataReader reader = getEmploymentDate.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            instructorEmail = reader["Email"].ToString();
                        }
                    }
                }
                catch (SqlException m)
                {
                    Console.WriteLine("FEJL: " + m.Message);
                }


                try
                {
                    MailMessage mail = new MailMessage();
                    SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com", 587);

                    mail.From = new MailAddress("hofiregistrering@gmail.com");
                    mail.To.Add(instructorEmail);
                    mail.Subject = "Kvittering for registrering af vagt d. " + date;
                    mail.Body = "Din vagt er nu registreret";

                    SmtpServer.Port = 587;
                    SmtpServer.Credentials = new System.Net.NetworkCredential("Hofiregistrering@gmail.com", "hsgfitness");
                    SmtpServer.EnableSsl = true;

                    SmtpServer.Send(mail);
                    Console.WriteLine("Mailkvittering er sendt til " + instructorEmail);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Der skete en uventet fejl, mailen er ikke sendt. Fejlkode: " + e.Message);
                }
            }
        }


    }

}

