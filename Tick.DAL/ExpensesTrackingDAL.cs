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
        public bool Add(ExpensesTracking expensesTracking)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Connection.GetConnectionString))
                {
                    String sql = "dbo.usp_ExpensesTracking_Insert";
                    using (SqlCommand command = new SqlCommand(sql, conn))
                    {
                        conn.Open();
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add("@prmUserID", SqlDbType.Int).Value = expensesTracking.UserID;
                        command.Parameters.Add("@prmAmount", SqlDbType.Decimal).Value = expensesTracking.Amount;
                        command.Parameters.Add("@prmCategoryID", SqlDbType.VarChar).Value = expensesTracking.CategoryID;
                        command.Parameters.Add("@prmDescription", SqlDbType.VarChar).Value = expensesTracking.Description;
                        command.Parameters.Add("@prmDate", SqlDbType.DateTime).Value = expensesTracking.Date;
                        command.Parameters.Add("@prmInsertBy", SqlDbType.Int).Value = expensesTracking.InsertBy;



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
                using (SqlConnection conn = new SqlConnection(Connection.GetConnectionString))
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
                using (SqlConnection conn = new SqlConnection(Connection.GetConnectionString))
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

        public bool Update(ExpensesTracking expensesTracking)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Connection.GetConnectionString))
                {
                    String sql = "dbo.usp_ETracking_Update";
                    using (SqlCommand command = new SqlCommand(sql, conn))
                    {
                        conn.Open();
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add("@prmExpensesID", SqlDbType.Int).Value = expensesTracking.ETrackingID;
                        command.Parameters.Add("@prmAmount", SqlDbType.Decimal).Value = expensesTracking.Amount;
                        command.Parameters.Add("@prmCategoryID", SqlDbType.Int).Value = expensesTracking.CategoryID;
                        command.Parameters.Add("@prmDescription", SqlDbType.VarChar).Value = expensesTracking.Description;
                        command.Parameters.Add("@prmDate", SqlDbType.DateTime).Value = expensesTracking.Date;
                        command.Parameters.Add("@prmLUB", SqlDbType.Int).Value = expensesTracking.UserID;



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

        public bool Delete(ExpensesTracking expensesTracking)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Connection.GetConnectionString))
                {
                    String sql = "dbo.usp_ETracking_Delete";
                    using (SqlCommand command = new SqlCommand(sql, conn))
                    {
                        conn.Open();
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add("@prmETrackingID", SqlDbType.Int).Value = expensesTracking.ETrackingID;




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
                using (SqlConnection conn = new SqlConnection(Connection.GetConnectionString))
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
                using (SqlConnection conn = new SqlConnection(Connection.GetConnectionString))
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
        public DataTable GetByDate(DateTime dt, int id)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Connection.GetConnectionString))
               {
                    String sql = "dbo.usp_ExpensesTracking_ByDate";
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

        public decimal GetIncome(int id)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Connection.GetConnectionString))
                {
                    String sql = "dbo.usp_ETracking_GetIncome";
                    using (SqlCommand command = new SqlCommand(sql, conn))
                    {
                        conn.Open();

                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add("@prmUserID", SqlDbType.Int).Value = id;

                        using (var reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {

                                return reader.GetDecimal(0);
                            }
                            return 0;

                        }



                    }
                }
            }
            catch (Exception e)
            {

                return 0;
            }
        }
        public decimal GetExpenses(int id)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Connection.GetConnectionString))
                {
                    String sql = "dbo.usp_ETracking_GetExpenses";
                    using (SqlCommand command = new SqlCommand(sql, conn))
                    {
                        conn.Open();

                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add("@prmUserID", SqlDbType.Int).Value = id;


                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {

                                return reader.GetDecimal(0);
                            }
                            return 0;


                        }
                    }
                }
            }
            catch (Exception e)
            {

                return 0;
            }
        }
    }
}
