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
    public class ExpensesTrackingDAL
    {
        public bool Add(ExpensesTracking model)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(@"data source=DESKTOP-U7DSAHH\SQLEXPRESS;initial catalog=Tick;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework"))
                {
                    String sql = "dbo.usp_ExpensesTracking_Insert";
                    using (SqlCommand command = new SqlCommand(sql, conn))
                    {
                        conn.Open();
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add("@prmAmound", SqlDbType.VarChar).Value = model.Amount;
                        command.Parameters.Add("@prmDescription", SqlDbType.VarChar).Value = model.Description;
                        command.Parameters.Add("@prmInsBy", SqlDbType.VarChar).Value = 1;
                        command.Parameters.Add("@prmRole", SqlDbType.VarChar).Value = 2;



                        model.ETrackingID = command.ExecuteNonQuery();
                        return model.ETrackingID > 0;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }
        public bool GetTransaction(ExpensesTracking model)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(@"data source=DESKTOP-U7DSAHH\SQLEXPRESS;initial catalog=Tick;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework"))
                {
                    String sql = "dbo.usp_Transaction_Get";
                    using (SqlCommand command = new SqlCommand(sql, conn))
                    {
                        conn.Open();
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.Add("@prmAmount", SqlDbType.VarChar).Value = model.Amount;
                        command.Parameters.Add("@prmDescription", SqlDbType.VarChar).Value = model.Description;

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
