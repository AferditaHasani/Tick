using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tick.BO;

namespace Tick.DAL
{
   public class UserDAL
    {
        public bool Add(User user)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Connection.GetConnectionString))
                {
                    String sql = "dbo.usp_User_Insert";
                    using (SqlCommand command = new SqlCommand(sql, conn))
                    {
                        conn.Open();
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add("@prmName", SqlDbType.VarChar).Value = user.Name;
                        command.Parameters.Add("@prmLastname", SqlDbType.VarChar).Value = user.Lastname;
                        command.Parameters.Add("@prmUsername", SqlDbType.VarChar).Value = user.Username;
                        command.Parameters.Add("@prmPassword", SqlDbType.VarChar).Value = user.Password;
                        command.Parameters.Add("@prmInsBy", SqlDbType.VarChar).Value = 1;
                        command.Parameters.Add("@prmRole", SqlDbType.VarChar).Value = 2;



                       user.UserID = command.ExecuteNonQuery();
                        return user.UserID > 0;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }
        public User GetLogIn(User u)
        {
            try
            {
               
                using (SqlConnection conn = new SqlConnection(Connection.GetConnectionString))
                {
                    SqlDataReader rdr = null;
                    String sql = "dbo.uso_User_Get";
                    using (SqlCommand command = new SqlCommand(sql, conn))
                    {
                        conn.Open();
                        command.CommandType = CommandType.StoredProcedure;
                     
                        command.Parameters.Add("@prmUsername", SqlDbType.VarChar).Value = u.Username;
                        command.Parameters.Add("@prmPassword", SqlDbType.VarChar).Value = u.Password;

                        rdr = command.ExecuteReader();

                        User user = new User();
                        while (rdr.Read())
                        {
                            user.Name = rdr["Name"].ToString();
                           user.UserID=int.Parse( rdr["UserID"].ToString());
                        }

                        user.Username = u.Username;
                        user.Password = u.Password;

                        return user;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }
    }
}
