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
                using (SqlConnection conn = new SqlConnection(@"data source=ACER-LE6JSUV\SQLEXPRESS;initial catalog=Tick;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework"))
                //  using (SqlConnection conn = new SqlConnection(@"data source=DESKTOP-U7DSAHH\SQLEXPRESS;initial catalog=Tick;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework"))
                {
                    String sql = "dbo.usp_ExpensesTracking_Insert";
                    using (SqlCommand command = new SqlCommand(sql, conn))
                    {
                        conn.Open();
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add("@prmUserID", SqlDbType.Int).Value = model.UserID;
                        command.Parameters.Add("@prmAmount", SqlDbType.VarChar).Value = model.Amount;
                        command.Parameters.Add("@prmCategoryID", SqlDbType.VarChar).Value = model.CategoryID;
                        command.Parameters.Add("@prmDescription", SqlDbType.VarChar).Value = model.Description;
                        command.Parameters.Add("@prmDate", SqlDbType.DateTime).Value = model.Date;
                        command.Parameters.Add("@prmInsertBy", SqlDbType.Int).Value = model.InsertBy;



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

        public DataTable GetAll(int id)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(@"data source=DESKTOP-U7DSAHH\SQLEXPRESS;initial catalog=Tick;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework"))
                {
                    String sql = "dbo.usp_ETracking_GetAll";
                    using (SqlCommand command = new SqlCommand(sql, conn))
                    {
                        conn.Open();
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add("@prmUserID", SqlDbType.Int).Value = id;


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
        public DataTable GetComboBox(int id)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(@"data source=DESKTOP-U7DSAHH\SQLEXPRESS;initial catalog=Tick;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework"))
                {
                    String sql = "dbo.usp_GetComboBox";
                    using (SqlCommand command = new SqlCommand(sql, conn))
                    {
                        conn.Open();
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add("@prmUserID", SqlDbType.Int).Value = id;


                        SqlDataReader reader;

                        reader = command.ExecuteReader();
                        DataTable dt = new DataTable();
                        dt.Columns.Add("CategoryID", typeof(int));
                        dt.Columns.Add("Name", typeof(string));
                        dt.Load(reader);


                        return dt;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }
        //Kqyre
        public bool Update(ExpensesTracking model)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(@"data source=ACER-LE6JSUV\SQLEXPRESS;initial catalog=Tick;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework"))
                //using (SqlConnection conn = new SqlConnection(@"data source=DESKTOP-U7DSAHH\SQLEXPRESS;initial catalog=Tick;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework"))
                {
                    String sql = "dbo.usp_ETracking_Update";
                    using (SqlCommand command = new SqlCommand(sql, conn))
                    {
                        conn.Open();
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add("@prmExpensesID", SqlDbType.Int).Value = model.ETrackingID;
                        command.Parameters.Add("@prmAmount", SqlDbType.Decimal).Value = model.Amount;
                        command.Parameters.Add("@prmCategoryID", SqlDbType.VarChar).Value = model.CategoryID;
                        command.Parameters.Add("@prmDescription", SqlDbType.VarChar).Value = model.Description;
                        command.Parameters.Add("@prmDate", SqlDbType.DateTime).Value = model.Date;
                        command.Parameters.Add("@prmLUB", SqlDbType.Int).Value = model.UserID;



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
                using (SqlConnection conn = new SqlConnection(@"data source=ACER-LE6JSUV\SQLEXPRESS;initial catalog=Tick;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework"))
                //using (SqlConnection conn = new SqlConnection(@"data source=DESKTOP-U7DSAHH\SQLEXPRESS;initial catalog=Tick;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework"))
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
        public DataTable GetByMonth(DateTime dt, int id)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(
                    @"data source=DESKTOP-U7DSAHH\SQLEXPRESS;initial catalog=Tick;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework")
                )
                {
                    String sql = "dbo.usp_ExpensesTracking_ByMonth";
                    using (SqlCommand command = new SqlCommand(sql, conn))
                    {
                        conn.Open();

                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add("@prmMonth", SqlDbType.DateTime).Value = dt;
                        command.Parameters.Add("@prmUserID", SqlDbType.Int).Value = id;
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

        public DataTable GetForPie(DateTime dt, int id)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(
                    @"data source=DESKTOP-U7DSAHH\SQLEXPRESS;initial catalog=Tick;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework")
                )
                {
                    String sql = "dbo.usp_ExpensesTracking_PieChart";
                    using (SqlCommand command = new SqlCommand(sql, conn))
                    {
                        conn.Open();

                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add("@prmDate", SqlDbType.DateTime).Value = dt;
                        command.Parameters.Add("@prmUserID", SqlDbType.Int).Value = id;
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

    }
}
public DataTable GetByDate(DateTime dt)
{
try
{
using (SqlConnection conn = new SqlConnection(@"data source=ACER-LE6JSUV\SQLEXPRESS;initial catalog=Tick;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework"))
//using (SqlConnection conn = new SqlConnection(@"data source=DESKTOP-U7DSAHH\SQLEXPRESS;initial catalog=Tick;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework") )
{
String sql = "dbo.usp_ExpensesTracking_ByDate";
    using (SqlCommand command = new SqlCommand(sql, conn))
{
    conn.Open();

    command.CommandType = CommandType.StoredProcedure;
    command.Parameters.Add("@prmDate", SqlDbType.DateTime).Value = dt;

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