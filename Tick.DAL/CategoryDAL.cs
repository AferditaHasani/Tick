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
                        command.Parameters.Add("@prmInsertBy", SqlDbType.VarChar).Value = 1;


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
                    String sql = "dbo.usp_Category_GetAll";
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

        public bool Update(Category model)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(@"data source=DESKTOP-U7DSAHH\SQLEXPRESS;initial catalog=Tick;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework"))
                {
                    String sql = "dbo.usp_Category_Update";
                    using (SqlCommand command = new SqlCommand(sql, conn))
                    {
                        MessageBox.Show($"ID {model.CategoryID}   {model.Name}   {model.IsExpenses} ");
                        conn.Open();
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add("@prmCategoryID", SqlDbType.Int).Value = model.CategoryID;
                        command.Parameters.Add("@prmName", SqlDbType.VarChar).Value = model.Name;
                        command.Parameters.Add("@prmIsExpenses", SqlDbType.VarChar).Value = model.IsExpenses;
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
        public bool Delete(Category model)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(@"data source=DESKTOP-U7DSAHH\SQLEXPRESS;initial catalog=Tick;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework"))
                {
                    String sql = "dbo.usp_Category_Delete";
                    using (SqlCommand command = new SqlCommand(sql, conn))
                    {
                        conn.Open();
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add("@prmCategoryID", SqlDbType.Int).Value = model.CategoryID;




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
