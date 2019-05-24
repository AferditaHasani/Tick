﻿using System;
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
    public class TimeTrackingDAL
    {
        public bool Add(BO.TimeTracking model)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(@"data source=ACER-LE6JSUV\SQLEXPRESS;initial catalog=Tick;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework"))
               // using (SqlConnection conn = new SqlConnection(@"data source=DESKTOP-U7DSAHH\SQLEXPRESS;initial catalog=Tick;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework")    )
                {
                   
                    String sql = "dbo.usp_TimeTracking_Insert";
                    using (SqlCommand command = new SqlCommand(sql, conn))
                    {
                        conn.Open();
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add("@prmUserID", SqlDbType.Int).Value = model.UserID;
                        command.Parameters.Add("@prmInsertBy", SqlDbType.Int).Value = model.InsertBy;
                        command.Parameters.Add("@prmTaskID", SqlDbType.Int).Value = model.TaskID;
                        command.Parameters.Add("@prmDescription", SqlDbType.VarChar).Value = model.Description;
                       command.Parameters.Add("@prmDate", SqlDbType.DateTime).Value = model.Date;
                       command.Parameters.Add("@prmStartTime", SqlDbType.DateTime).Value = model.StartTime;
                        command.Parameters.Add("@prmEndTime", SqlDbType.DateTime).Value = model.EndTime;


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

        public DataTable GetByDate(DateTime dt,int id)
        {
            try { 
            using (SqlConnection conn = new SqlConnection(@"data source=ACER-LE6JSUV\SQLEXPRESS;initial catalog=Tick;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework"))
            //using (SqlConnection conn = new SqlConnection(@"data source=DESKTOP-U7DSAHH\SQLEXPRESS;initial catalog=Tick;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework") )
            {
                String sql = "dbo.usp_TimeTrackin_ByDate";
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

        public bool Update(BO.TimeTracking model)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(@"data source=ACER-LE6JSUV\SQLEXPRESS;initial catalog=Tick;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework"))
               // using (SqlConnection conn = new SqlConnection( @"data source=DESKTOP-U7DSAHH\SQLEXPRESS;initial catalog=Tick;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework"))
                {
                    String sql = "dbo.usp_TimeTracking_Update";
                    using (SqlCommand command = new SqlCommand(sql, conn))
                    {
                        conn.Open();
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.Add("@prmTTrackingID", SqlDbType.Int).Value = model.TTrackingID;

                        command.Parameters.Add("@prmTaskID", SqlDbType.Int).Value = model.TaskID;
                        command.Parameters.Add("@prmDescription", SqlDbType.VarChar).Value = model.Description;
                        command.Parameters.Add("@prmDate", SqlDbType.DateTime).Value = model.Date;
                        command.Parameters.Add("@prmStartTime", SqlDbType.DateTime).Value = model.StartTime;
                        command.Parameters.Add("@prmEndTime", SqlDbType.DateTime).Value = model.EndTime;


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

        public bool Delete(TimeTracking model)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(@"data source=ACER-LE6JSUV\SQLEXPRESS;initial catalog=Tick;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework"))
                //  using (SqlConnection conn = new SqlConnection(@"data source=DESKTOP-U7DSAHH\SQLEXPRESS;initial catalog=Tick;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework") )
                {
                    String sql = "dbo.usp_TimeTrackin_Delete";
                    using (SqlCommand command = new SqlCommand(sql, conn))
                    {
                        conn.Open();
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add("@prmTTID", SqlDbType.Int).Value = model.TTrackingID;




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

        public DataTable GetComboBox(int id)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(@"data source=ACER-LE6JSUV\SQLEXPRESS;initial catalog=Tick;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework"))
               // using (SqlConnection conn = new SqlConnection( @"data source=DESKTOP-U7DSAHH\SQLEXPRESS;initial catalog=Tick;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework"))
                {
                    String sql = "dbo.usp_Task_GetComboBox";
                    using (SqlCommand command = new SqlCommand(sql, conn))
                    {
                        conn.Open();
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add("@prmUserID", SqlDbType.Int).Value = id;


                        SqlDataReader reader;

                        reader = command.ExecuteReader();
                        DataTable dt = new DataTable();
                        dt.Columns.Add("TaskID", typeof(int));
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

        public DataTable GetByMonth(DateTime dt, int id)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(@"data source=ACER-LE6JSUV\SQLEXPRESS;initial catalog=Tick;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework"))
                //     using (SqlConnection conn = new SqlConnection(@"data source=DESKTOP-U7DSAHH\SQLEXPRESS;initial catalog=Tick;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework") )
                {
                    String sql = "dbo.usp_TimeTrackin_ByMonth";
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
                using (SqlConnection conn = new SqlConnection(@"data source=ACER-LE6JSUV\SQLEXPRESS;initial catalog=Tick;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework"))
          //      using (SqlConnection conn = new SqlConnection( @"data source=DESKTOP-U7DSAHH\SQLEXPRESS;initial catalog=Tick;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework") )
                {
                    String sql = "dbo.usp_TimeTrackin_PieChart";
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
