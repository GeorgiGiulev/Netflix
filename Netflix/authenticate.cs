using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Netflix;

namespace Netflix
{
    // Authentication class
    public class authenticate
    {

        public class User
        {
            public string Username { get; set; } 

            public string Email { get; set; }

        }

     
        public class DatabaseManager
        {

            public static User AuthenticateUser(string username, string password)
            {
                User user = RetrieveUserInformation(username, password);
                return user;
            }

            private static User RetrieveUserInformation(string username, string password)
            {
                using (SqlConnection sqlCon = new SqlConnection(@"Data Source=LAB109PC12\SQLEXPRESS; Initial Catalog=userRecords; Integrated Security=True;"))
                {
                    sqlCon.Open(); 

                    string loginQuery = "SELECT COUNT(1) FROM Register WHERE Username=@Username AND Password=@Password";


                    using (SqlCommand loginCmd = new SqlCommand(loginQuery, sqlCon))
                    {
                        
                            loginCmd.CommandType = CommandType.Text;


                            loginCmd.Parameters.AddWithValue("@Username", username);
                            loginCmd.Parameters.AddWithValue("@Password", password);

                            int count = Convert.ToInt32(loginCmd.ExecuteScalar());

                           
                        
                        return null;

                    }
                }
            }
        }

    }
}