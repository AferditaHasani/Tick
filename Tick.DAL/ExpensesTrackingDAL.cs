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
                    String sql = "dbo.usp_ETracking_Insert";
                    using (SqlCommand command = new SqlCommand(sql, conn))
                    {
                        conn.Open();
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add("@prmAmound", SqlDbType.VarChar).Value = model.Amount;
                        command.Parameters.Add("@prmCategory", SqlDbType.VarChar).Value = model.CategoryID;
                        command.Parameters.Add("@prmDescription", SqlDbType.VarChar).Value = model.Description;
                        command.Parameters.Add("@prmInsBy", SqlDbType.Int).Value = model.InsertBy;



                        var result = command.ExecuteNonQuery();
                        return result >= 0;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }

        public DataTable GetAll()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(@"data source=DESKTOP-U7DSAHH\SQLEXPRESS;initial catalog=Tick;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework"))
                {
                    String sql = "dbo.usp_ETracking_GetAll";
                    using (SqlCommand command = new SqlCommand(sql, conn))
                    {
                        conn.Open();



                        SqlDataAdapter sqlDataAdap = new SqlDataAdapter(command);

                        DataTable dtRecord = new DataTable();
                        sqlDataAdap.Fill(dtRecord);


                        return dtRecord;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }

        public bool Update(ExpensesTracking model)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(@"data source=DESKTOP-U7DSAHH\SQLEXPRESS;initial catalog=Tick;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework"))
                {
                    String sql = "dbo.usp_ETracking_Update";
                    using (SqlCommand command = new SqlCommand(sql, conn))
                    {
                        conn.Open();
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add("@prmAmound", SqlDbType.VarChar).Value = model.Amount;
                        command.Parameters.Add("@prmCategory", SqlDbType.VarChar).Value = model.CategoryID;
                        command.Parameters.Add("@prmDescription", SqlDbType.VarChar).Value = model.Description;
                        command.Parameters.Add("@prmLUB", SqlDbType.Int).Value = 1;



                        var result = command.ExecuteNonQuery();
                        return result >= 0;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }

        public bool Delete(ExpensesTracking model)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(@"data source=DESKTOP-U7DSAHH\SQLEXPRESS;initial catalog=Tick;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework"))
                {
                    String sql = "dbo.usp_ETracking_Delete";
                    using (SqlCommand command = new SqlCommand(sql, conn))
                    {
                        conn.Open();
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add("@prmETrackingID", SqlDbType.Int).Value = model.ETrackingID;




                        var result = command.ExecuteNonQuery();
                        return result >= 0;
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
