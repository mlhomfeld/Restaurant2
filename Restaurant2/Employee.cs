using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data;
using System.Net.Mail;
using System.IO;


namespace Restaurant2
{
    
    public class Employee
    {
        
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
                                ManagerForm man = new ManagerForm();
                                man.Show();
                                //RandomChallenge(employeeID);
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

                
                con.Close();
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
       //  in the employee class, unless we decided to rebuild the table and include email addresses. Code
       //  should also be commented out.  

        public void RandomChallenge(int employeeID)
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

                    //updateManager.CommandText = "update dbo.Employee set Passcode = @Passcode where Role = Manager;";
                    updateManager.CommandText = "update dbo.Employee set Passcode = @Passcode where employeeID = " + employeeID +" ;";
                    //var role = new SqlParameter("Role", "Manager");
                    var challenge = new SqlParameter("Passcode", SqlDbType.Int) { Value = randoNum };
                    
                    updateManager.Parameters.Add(challenge);

                    updateManager.ExecuteNonQuery();
                   
                }

                // Added code to test pulling email address from DB instead of hardcoding. Need to add varchar field to Employee Table to work.
                // May need to modify index location, think it should end up being 7. 

                //using (SqlCommand readEmployeeRecords = con.CreateCommand())
                //{

                //    readEmployeeRecords.CommandText = "select * from dbo.Employee where employeeID = @employeeID;";
                //    var empID = new SqlParameter("employeeID", employeeID);
                //    readEmployeeRecords.Parameters.Add(empID);

                //    using (SqlDataReader reader = readEmployeeRecords.ExecuteReader())
                //    {
                //        string email = "";
                //        while (reader.Read())
                //        {
                //            email = reader.GetString(7);
                //        }
                //    }

                //}

                        con.Close();

                SmtpClient client = new SmtpClient();
                string from = "bjbrooks17@gmail.com";
                string to = "7193228584@vtext.com";
                // string to = email;
                string subject = "Your one-time passcode is: " + randoNum.ToString();
                string body = "";
                client.Host = "smtp.gmail.com";
                client.Port = 587;
                client.EnableSsl = true;
                client.UseDefaultCredentials = false;
                client.Credentials = new System.Net.NetworkCredential(from, "nyfzafnzohxaycik"); // this password can't be used interactively, it's controlled for app use only
                client.Timeout = 10000;
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
                con.Close();
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

        // This method will timestamp activities that employees perform during their day.
        public void Timestamp(int employeeID, string activity)
        {
            try
            {

                string date = "";
                date = System.DateTime.Now.ToString();

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Server=cis1.actx.edu;Database=project2;User Id=db2;Password = db20;";
                con.Open();

                
                using (SqlCommand timeStampActivity = con.CreateCommand())
                {
                    timeStampActivity.CommandText = "insert into dbo.EmployeeTimeStamps values (@EmployeeID, @Activity, @DateTime);";
                    var empID = new SqlParameter("EmployeeID", SqlDbType.Int) { Value = employeeID };
                    var action = new SqlParameter("Activity", SqlDbType.VarChar) { Value = activity };
                    var time = new SqlParameter("DateTime", SqlDbType.VarChar) { Value = date };
                    timeStampActivity.Parameters.Add(empID);
                    timeStampActivity.Parameters.Add(action);
                    timeStampActivity.Parameters.Add(time);
                    timeStampActivity.ExecuteNonQuery();
                }

                con.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }

        }
        //This method refreshes table status for all table-inclusive classes
        public List<string> RefreshTableStatuses()
        {
            List<string> status = new List<string>();
            try
            {
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = "Server=cis1.actx.edu;Database=project2;User Id=db2;Password = db20;";
                connection.Open();
                using (SqlCommand readTableStatus = connection.CreateCommand())
                {
                    for (int i = 1; i < 8; i++)
                    {
                        readTableStatus.CommandText = "select * from dbo.SeatingArea where SeatingAreaID = @SeatingAreaID" + i.ToString() + ";";
                        var idParam = new SqlParameter("SeatingAreaID" + i.ToString(), i);
                        //var fnameParam = new SqlParameter("TableID", SqlDbType.VarChar) { Value = i };
                        readTableStatus.Parameters.Add(idParam);

                        using (SqlDataReader reader = readTableStatus.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                status.Add(reader.GetString(1));
                            }
                        }

                    }
                }
                connection.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            return status;
        }


        // This will be called during login and will create a text file with the employees ID so it can be referenced
        // later and used to insert the employeeID into the timestamp field of the DB record... it's ugly but 
        // it works. 
        public void SessionID(int employeeID)
        {
                        
            bool appendToContent = false;

            try
            {

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Server=cis1.actx.edu;Database=project2;User Id=db2;Password = db20;";
                con.Open();

                using (SqlCommand readEmployeeRecords = con.CreateCommand())
                {

                    readEmployeeRecords.CommandText = "select * from dbo.Employee where EmployeeID = "+ employeeID+";";
                    var empID = new SqlParameter("EmployeeID", employeeID);
                    readEmployeeRecords.Parameters.Add(empID);

                    using (SqlDataReader reader = readEmployeeRecords.ExecuteReader())
                    {
                        string role = "";
                        while (reader.Read())
                        {
                            role = reader.GetString(5);
                        }

                        string path = role + ".txt";

                        using (StreamWriter writer = new StreamWriter(path, appendToContent))
                        {
                            writer.WriteLine(employeeID);
                        }
                    }

  
                }
                con.Close();
                            
            }

            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }

        }
    }
}