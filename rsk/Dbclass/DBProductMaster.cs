using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using rsk.Dbclass;
using System.Data;



namespace rsk.Dbclass
{
    class DBProductMaster
    {
        //------------------------------------------------------------------------------------------------------
        //                                         Group   save function
        //------------------------------------------------------------------------------------------------------

        public void savegroup(string GroupName,string Description,ref string Error)
        {
            SqlConnection conn = DBConnection.getDBConnection();
                
            try{
                string query = "insert into group_master_tb values('" + GroupName + "','" + Description + "');";
           
                conn.Open();
                SqlCommand sc = new SqlCommand(query, conn);

               // sc.ExecuteNonQuery();
                sc.ExecuteReader();

            }

            catch (Exception ex)
            {
                Error=ex.Message;
            }           

            finally
            { 
               if (conn.State == ConnectionState.Open)
                   conn.Close();
            }
        }
        //end of save


        //------------------------------------------------------------------------------------------------------
        //                                          Group  update function
        //------------------------------------------------------------------------------------------------------

        
        public void updategroup(string GroupName,string desc,string autono,ref string Error)
        {
            SqlConnection conn = DBConnection.getDBConnection();
            string query = "update  group_master_tb set group_name='" + GroupName + "',description='" + desc + "'where auto_no=" + autono + "";
            SqlCommand sc = new SqlCommand(query, conn);
            try
            {
                conn.Open();
               sc.ExecuteReader();
            }

            catch (Exception ex)
            {
                Error=ex.Message;
            }

            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }

        //------------------------------------------------------------------------------------------------------
        //                                         Tax  save function
        //------------------------------------------------------------------------------------------------------

        public void savetax(string TaxPercentage, string Description, ref string Error)
        {
            SqlConnection conn = DBConnection.getDBConnection();

            try
            {
                string query = "insert into tax_master_tb values('" + TaxPercentage + "','" + Description + "');";

                conn.Open();
                SqlCommand sc = new SqlCommand(query, conn);

                // sc.ExecuteNonQuery();
                sc.ExecuteReader();

            }

            catch (Exception ex)
            {
                Error = ex.Message;
            }

            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }
        //end of save

        //------------------------------------------------------------------------------------------------------
        //                                          Tax  update function
        //------------------------------------------------------------------------------------------------------


        public void updatetax(string Taxpercentage, string desc, string autono, ref string Error)
        {
            SqlConnection conn = DBConnection.getDBConnection();
            string query = "update  tax_master_tb set tax_percentage='" + Taxpercentage + "',tax_describtion='" + desc + "'where auto_no=" + autono + "";
            SqlCommand sc = new SqlCommand(query, conn);
            try
            {
                conn.Open();
                sc.ExecuteReader();
            }

            catch (Exception ex)
            {
                Error = ex.Message;
            }

            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }
    }
}
