﻿using System;
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
        public bool Add(Category category)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Connection.GetConnectionString))
                {
                    String sql = "dbo.usp_Category_Insert";
                    using (SqlCommand command = new SqlCommand(sql, conn))
                    {
                        conn.Open();
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add("@prmName", SqlDbType.VarChar).Value = category.Name;
                        command.Parameters.Add("@prmIsExpenses", SqlDbType.VarChar).Value = category.IsExpenses;
                        command.Parameters.Add("@prmColor", SqlDbType.VarChar).Value = category.Color;
                        command.Parameters.Add("@prmInsertBy", SqlDbType.VarChar).Value = category.InsertBy;



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

                    String sql = "dbo.usp_Category_GetAll";
                    using (SqlCommand command = new SqlCommand(sql, conn))
                    {
                        conn.Open();

                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add("@prmUserId", SqlDbType.Int).Value = id;

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

        public bool Update(Category category)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Connection.GetConnectionString))
                {
                    String sql = "dbo.usp_Category_Update";
                    using (SqlCommand command = new SqlCommand(sql, conn))
                    {
                        MessageBox.Show($"ID {category.CategoryID}   {category.Name}   {category.IsExpenses} ");
                        conn.Open();
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add("@prmCategoryID", SqlDbType.Int).Value = category.CategoryID;
                        command.Parameters.Add("@prmName", SqlDbType.VarChar).Value = category.Name;
                        command.Parameters.Add("@prmIsExpenses", SqlDbType.VarChar).Value = category.IsExpenses;
                        command.Parameters.Add("@prmColor", SqlDbType.VarChar).Value = category.Color;
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
        public bool Delete(Category category)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Connection.GetConnectionString))
                {
                    String sql = "dbo.usp_Category_Delete";
                    using (SqlCommand command = new SqlCommand(sql, conn))
                    {
                        conn.Open();
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add("@prmCategoryID", SqlDbType.Int).Value = category.CategoryID;

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
