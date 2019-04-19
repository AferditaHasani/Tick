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
        public bool Add(User model)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(@"data source=DESKTOP-U7DSAHH\SQLEXPRESS;initial catalog=Tick;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework"))
                {
                    String sql = "dbo.usp_User_Insert";
                    using (SqlCommand command = new SqlCommand(sql, conn))
                    {
                        conn.Open();
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add("@prmName", SqlDbType.VarChar).Value = model.Name;
                        command.Parameters.Add("@prmLastname", SqlDbType.VarChar).Value = model.Lastname;
                        command.Parameters.Add("@prmUsername", SqlDbType.VarChar).Value = model.Username;
                        command.Parameters.Add("@prmPassword", SqlDbType.VarChar).Value = model.Password;
                        command.Parameters.Add("@prmInsBy", SqlDbType.VarChar).Value = 1;
                        command.Parameters.Add("@prmRole", SqlDbType.VarChar).Value = 2;



                       model.UserID = command.ExecuteNonQuery();
                        return model.UserID > 0;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }
        public bool GetLogIn(User model)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(@"data source=DESKTOP-U7DSAHH\SQLEXPRESS;initial catalog=Tick;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework"))
                {
                    String sql = "dbo.uso_User_Get";
                    using (SqlCommand command = new SqlCommand(sql, conn))
                    {
                        conn.Open();
                        command.CommandType = CommandType.StoredProcedure;
                     
                        command.Parameters.Add("@prmUsername", SqlDbType.VarChar).Value = model.Username;
                        command.Parameters.Add("@prmPassword", SqlDbType.VarChar).Value = model.Password;

                        int count=0;
                        foreach (var item in command.ExecuteReader())
                        {
                            count++;
                        }
                        return count >=1;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }
    }
}
