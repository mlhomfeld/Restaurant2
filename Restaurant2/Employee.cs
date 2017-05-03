using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data;
using System.Net.Mail;


namespace Restaurant2
{

    // Making a comment
    public class Employee
    {

      //  bool tryAgain = true;

        //public void TimeClock()
        //{
         
        //}

           // This will receive input (employeeID and password) from LoginForm and pass it into the below SQL statement
           public void LogIn(int employeeID, string password)
        {
            try
            {
                
                // This will look up employeeID and password based on input from LoginForm. If both match
                // the database entries, then based on the role associated with that employee,
                // the required form will open for the employee to perform their job. 

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Server=cis1.actx.edu;Database=project2;User Id=db2;Password = db20;";
                con.Open();

                using (SqlCommand readEmployeeRecords = con.CreateCommand())
                {

                    readEmployeeRecords.CommandText = "select * from dbo.Employee where employeeID = @employeeID and password = @password;";
                    var empID = new SqlParameter("employeeID", employeeID);
                    var pass = new SqlParameter("password", password);
                    readEmployeeRecords.Parameters.Add(empID);
                    readEmployeeRecords.Parameters.Add(pass);

                    using (SqlDataReader reader = readEmployeeRecords.ExecuteReader())
                    {
                        string rec = "";
                        while (reader.Read())
                        {
                            rec = reader.GetString(5);
                        }

                        switch(rec)
                        {
                            case "Busboy":
                                BusboyForm bus = new BusboyForm();
                                bus.Show();
                                break;
                            case "Waiter":
                                WaiterForm wait = new WaiterForm();
                                wait.Show();
                                break;
                            case "Manager":
                                RandomChallenge();
                                break;
                            case "Host":
                                HostForm host = new HostForm();
                                host.Show();
                                break;
                            case "Cook":
                                CookForm cookie = new CookForm();
                                cookie.Show();
                                break;
                        }

                    }

                }


            }

            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

       //  The below generates a random number for the manager to provide a second factor of authentication
       //  The first is the password (something you know), second is challenge email (something you have).
       //  The random number will be emailed / sms'ed to the manager. After sending the random challenge, the 
       //  manager will be presented the SecureLogin form. The Manager's email will need to be maintained here
       //  in the employee class, one of the many shortcomings. 

        public void RandomChallenge()
        {

            try
            {
                int randoNum;
                Random rng = new Random();
                randoNum = rng.Next(100000, 999999);

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Server=cis1.actx.edu;Database=project2;User Id=db2;Password = db20;";
                con.Open();
                using (SqlCommand updateManager = con.CreateCommand())
                {

                    updateManager.CommandText = "update dbo.Employee set Passcode = @Passcode where ID = @ID;";
                    var challenge = new SqlParameter("Passcode", SqlDbType.Int) { Value = randoNum };
                    var idParam = new SqlParameter("ID", SqlDbType.Int) { Value = 4 }; // valule needs to match manager's ID. I don't recall what it was.
                    updateManager.Parameters.Add(challenge);

                    updateManager.ExecuteNonQuery();
                   
                }

                con.Close();

                SmtpClient client = new SmtpClient();
                string from = "bjbrooks17@gmail.com";
                string to = "7193228584@vtext.com";
                string subject = randoNum.ToString();
                string body = "";
                client.Host = "smtp.gmail.com";
                client.Port = 587;
                client.EnableSsl = true;
                client.UseDefaultCredentials = false;
                client.Credentials = new System.Net.NetworkCredential(from, "nyfzafnzohxaycik"); // this password can't be used interactively, it's controlled for app use only
                client.Timeout = 100;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                MailMessage challengeMail = new MailMessage(from, to, subject, body);
                client.Send(challengeMail);

                SecureLogin mgr = new SecureLogin();
                mgr.Show();

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }


        }

        
        // The manager response is similar to the login for normal employees, but this time we
        // are looking for a passcode / challenge instead of employeeID and password. 
        // The manager is the only one that will have a passcode so the switch statement below
        // must match up with the manager role as well...a dumbed-down, simplistic 2-in-1 validation. 
        // Upon meeting the challenge, the manager form will launch. All this should prevent 
        // normal users from doing things they shouldn't unless they steal the manager's phone too. 
        
        public void ManagerResponse(int passcode)
        {
            try
            {

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Server=cis1.actx.edu;Database=project2;User Id=db2;Password = db20;";
                con.Open();

                using (SqlCommand readEmployeeRecords = con.CreateCommand())
                {

                    readEmployeeRecords.CommandText = "select * from dbo.Employee where Passcode = @Passcode;";
                    var pass = new SqlParameter("passcode", passcode);
                    readEmployeeRecords.Parameters.Add(pass);


                    using (SqlDataReader reader = readEmployeeRecords.ExecuteReader())
                    {
                        string rec = "";
                        while (reader.Read())
                        {
                            rec = reader.GetString(5);
                        }

                        switch (rec)
                        {
                            case "Manager":
                                ManagerForm man = new ManagerForm();
                                man.Show();
                                break;
                        }

                    }

                }


            }

            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        // If any user hits the logout button on their home form, it will restart the application.
        public void LogOut()
        {
           Application.Restart();
        }

        //public void Timestamp(string target, int order)
        //{
        //    try
        //    {
        //        string date = "";
        //        date = System.DateTime.Now.ToString();
        //        SqlConnection con = new SqlConnection();
        //        con.ConnectionString = "Server=cis1.actx.edu;Database=project2;User Id=db2;Password = db20;";
        //        con.Open();
        //        using (SqlCommand stampIt = con.CreateCommand())
        //        {
        //            stampIt.CommandText = "update TABLE" + target + "set " + date + " where " + order + " = " + order + ";";
        //            var timeStamp = new SqlParameter("TimeStamp", SqlDbType.Date) { Value = date };
        //            stampIt.Parameters.Add(timeStamp);
        //            stampIt.ExecuteNonQuery();
        //        }
        //    }
        //    catch (Exception err)
        //    {
        //        MessageBox.Show(err.Message);
        //    }

        //}
    }
}