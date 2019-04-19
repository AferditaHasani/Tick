﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Tick.BO;

namespace Tick.DAL
{
 public   class TaskDAL
    {
        public bool Add(Task model)
        {
            try
            {
                using (SqlConnection conn= new   SqlConnection (@"data source=DESKTOP-U7DSAHH\SQLEXPRESS;initial catalog=Tick;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework"))
                {
                    String sql = "dbo.usp_Task_Insert";
                    using (SqlCommand command =new  SqlCommand(sql,conn))
                    {
                        conn.Open();
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add("@prmName" , SqlDbType.VarChar).Value = model.Name;
                        command.Parameters.Add("@prmDescription", SqlDbType.VarChar).Value = model.Description;
                        command.Parameters.Add("@prmColor", SqlDbType.VarChar).Value = model.Color;
                        command.Parameters.Add("@prmInsBy", SqlDbType.VarChar).Value = model.InsertBy;
                        


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