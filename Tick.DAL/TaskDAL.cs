using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Tick.BO;

namespace Tick.DAL
{
    public class TaskDAL
    {
        public bool Add(Task task)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Connection.GetConnectionString))
                {
                    String sql = "dbo.usp_Task_Insert";
                    using (SqlCommand command = new SqlCommand(sql, conn))
                    {
                        conn.Open();
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add("@prmName", SqlDbType.VarChar).Value = task.Name;
                        command.Parameters.Add("@prmDescription", SqlDbType.VarChar).Value = task.Description;
                        command.Parameters.Add("@prmColor", SqlDbType.VarChar).Value = task.Color;
                        command.Parameters.Add("@prmInsBy", SqlDbType.Int).Value = task.InsertBy;



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
                    String sql = "dbo.usp_Task_GetAll";
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

        public bool Update(Task task)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Connection.GetConnectionString))
                {
                    String sql = "dbo.usp_Task_Update";
                    using (SqlCommand command = new SqlCommand(sql, conn))
                    {
                        conn.Open();
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add("@prmTasID", SqlDbType.Int).Value = task.TaskID;
                        command.Parameters.Add("@prmName", SqlDbType.VarChar).Value = task.Name;
                        command.Parameters.Add("@prmDescription", SqlDbType.VarChar).Value = task.Description;
                        command.Parameters.Add("@prmColor", SqlDbType.VarChar).Value = task.Color;
                        command.Parameters.Add("@prmLUB", SqlDbType.Int).Value =1;



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

        public bool Delete(Task task)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Connection.GetConnectionString))
                {
                    String sql = "dbo.usp_Task_Delete";
                    using (SqlCommand command = new SqlCommand(sql, conn))
                    {
                        conn.Open();
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add("@prmTasID", SqlDbType.Int).Value = task.TaskID;
                    



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
