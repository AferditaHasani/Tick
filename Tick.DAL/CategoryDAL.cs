using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tick.BO;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace Tick.DAL
{
    public class CategoryDAL
    {
        public bool Add(Category model)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(@"data source=DESKTOP-U7DSAHH\SQLEXPRESS;initial catalog=Tick;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework"))
                {
                    String sql = "dbo.usp_Category_Insert";
                    using (SqlCommand command = new SqlCommand(sql, conn))
                    {
                        conn.Open();
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add("@prmName", SqlDbType.VarChar).Value = model.Name;
                        command.Parameters.Add("@prmIsExpenses", SqlDbType.VarChar).Value = model.IsExpenses;
                        command.Parameters.Add("@prmInsBy", SqlDbType.VarChar).Value = 1;
                        command.Parameters.Add("@prmRole", SqlDbType.VarChar).Value = 2;



                        model.CategoryID = command.ExecuteNonQuery();
                        return model.CategoryID > 0;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }
        public bool GetCategory(Category model)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(@"data source=DESKTOP-U7DSAHH\SQLEXPRESS;initial catalog=Tick;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework"))
                {
                    String sql = "dbo.usp_Category_Get";
                    using (SqlCommand command = new SqlCommand(sql, conn))
                    {
                        conn.Open();
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.Add("@prmName", SqlDbType.VarChar).Value = model.Name;
                        command.Parameters.Add("@prmIsExpenses", SqlDbType.VarChar).Value = model.IsExpenses;

                        int count = 0;
                        foreach (var item in command.ExecuteReader())
                        {
                            count++;
                        }
                        return count >= 1;
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
