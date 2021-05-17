using MongoDB.Driver.Core.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.NewFolder1
{
    public class DataExtract
    {
        public string nume { get; set; }
        public string nume2 { get; set; }
        public string numar { get; set; }
        public string nrtel { get; set; }
        public string gen { get; set; }

        static string myconnstrg = ConfigurationManager.ConnectionStrings["connstrg"].ConnectionString;

        public DataTable Select()
        {

            SqlConnection conn = new SqlConnection(myconnstrg);
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT * FROM Table_11";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {


            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        public bool Insert(DataExtract c)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstrg);
            try
            {
                string sql = "INSERT INTO Table_11 (nume,nume2,nrtel,gen) VALUES(@nume,@nume2,@nrtel,@gen)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@nume", c.nume);
                cmd.Parameters.AddWithValue("@nume2", c.nume2);
                cmd.Parameters.AddWithValue("@nrtel", c.nrtel);
                cmd.Parameters.AddWithValue("@gen", c.gen);
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {


            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }


        public bool Update(DataExtract c)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrg);
            try
            {
                string sql = "UPDATE Table_11 SET nume=@nume, nume2=@nume2, nrtel=@nrtel, gen=@gen WHERE numar=@numar";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@numar", c.numar);
                cmd.Parameters.AddWithValue("@nume", c.nume);
                cmd.Parameters.AddWithValue("@nume2", c.nume2);
                cmd.Parameters.AddWithValue("@nrtel", c.nrtel);
                cmd.Parameters.AddWithValue("@gen", c.gen);
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {


            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }


        public bool Delete(DataExtract c)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrg);
            try
            {
                string sql = "DELETE FROM Table_11 WHERE numar=@numar";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@numar", c.numar);
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {


            }
            finally
            {
                conn.Close();
            }




            return isSuccess;

        }
    }
}
