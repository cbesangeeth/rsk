using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using rsk.Dbclass;


namespace rsk
{
    public partial class frmtax : Form
    {
        public frmtax()
        {
            InitializeComponent();
            refresh();
        }
        private void refresh()
        {
            fillcombo1();
            fillcombo2();
            cmbAutono.Visible = false;
            txtPercentage.Text = "";
            txtDesc.Text = "";
            btnSave.Text = "&Save";
            btnClear.Text = "&Clear";
            cmbTaxList.Text = null;
            cmbAutono.Text = null;
        }
        void fillcombo2()
        {
            SqlConnection conn = DBConnection.getDBConnection();
            SqlDataAdapter da = new SqlDataAdapter("select * from tax_master_tb", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbAutono.DisplayMember = "auto_no";
            cmbAutono.DataSource = dt;
        }

        
        void fillcombo1()
        {

            SqlConnection conn = DBConnection.getDBConnection();
            SqlDataAdapter da = new SqlDataAdapter("select * from tax_master_tb", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbTaxList.DisplayMember = "tax_percentage";
            cmbTaxList.DataSource = dt;
        }
        private void frmtax_Load(object sender, EventArgs e)
        {

        }

        void delete()
        {
            //string constring = "Data Source=SANGEETH-PC\\SQLEXPRESS;Initial Catalog=rsk_db;Integrated Security=True";
            SqlConnection conn = DBConnection.getDBConnection();

            string query = "delete from tax_master_tb where auto_no=('" + cmbAutono.Text + "');";
            //SqlConnection con = new SqlConnection(constring);
            SqlCommand sc = new SqlCommand(query, conn);
            SqlDataReader myreader;
            try
            {
                conn.Open();
                if (cmbTaxList .Text == txtPercentage.Text)
                {
                    myreader = sc.ExecuteReader();
                    MessageBox.Show("Deleted Sucessfully");
                }
                else
                {
                    string error = "Name you entered not in Database";
                    MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    refresh();
                    txtPercentage.Focus();
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtPercentage.Text.Length == 0)                  //group_name is null then return error message
            {
                MessageBox.Show("Please select Tax to Delete!");
                cmbTaxList.Focus();
            }

            else                                           //used to save group_name and des in db
            {
                if (MessageBox.Show("Are You sure Want To Delete? ", "Conform Delete", MessageBoxButtons.YesNo) == (DialogResult.Yes))
                {

                    delete();
                    refresh();
                    txtPercentage.Focus();

                }
                else
                {

                }

            }

        }




        public class ReadData                                  //this class used to execute stored procedure in sqlserever
        {
            public bool FindString(string myString)
            {
                // DBConnection connection = new DBConnection();
                // SqlConnection connection = new SqlConnection("Data Source=SANGEETH-PC\\SQLEXPRESS;Initial Catalog=rsk_db;Integrated Security=True");
                SqlConnection conn = DBConnection.getDBConnection();

                SqlCommand command = new SqlCommand();

                command.Connection = conn;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "FindStringtax";
                command.Parameters.AddWithValue("@MyStringtax", myString);
                try
                {
                    conn.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    if (conn.State == ConnectionState.Open)
                        conn.Close();
                }
                return false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ReadData r = new ReadData();

            if (r.FindString(txtPercentage.Text))    //checking database if groupname already exits or not
            {
                
                MessageBox.Show("Name already exists ");
                txtPercentage.Focus();
            }
            else if (txtPercentage.Text.Length == 0)                  //group_name is null then return error message
            {
                MessageBox.Show("Please enter Tax!");
                txtPercentage.Focus();
            }

            else if (btnSave.Text == "&Save")                                          //used to save   and des in db
            {
                string Error = "";
                DBProductMaster saveobj = new DBProductMaster();
                saveobj.savetax(txtPercentage.Text,  txtDesc .Text, ref Error);
                if (Error != "")
                {
                    MessageBox.Show(Error);
                }
                else
                {

                    MessageBox.Show("Saved Sucessfully");
                    fillcombo1();
                    refresh();
                }
            }
            else if (btnSave.Text == "&Update")
            {
                string Error = "";
                DBProductMaster updateobj = new DBProductMaster();
                updateobj.updatetax(txtPercentage.Text, txtDesc.Text, cmbAutono.Text , ref Error);
                if (Error != "")
                {
                    MessageBox.Show(Error);
                }
                else
                {

                    MessageBox.Show("Updated Sucessfully");
                    refresh();
                }
                // refresh();
            }

        }

        private void cmbTaxList_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection conn = DBConnection.getDBConnection();

            string query = "select * from tax_master_tb where tax_percentage='" + cmbTaxList.Text + "'";
            //  SqlConnection con = new SqlConnection(conn);
            SqlCommand sc = new SqlCommand(query, conn);
            SqlDataReader myreader;
            SqlDataAdapter my = new SqlDataAdapter(query, conn);

            try
            {
                conn.Open();
                myreader = sc.ExecuteReader();
                while (myreader.Read())
                {
                    string name = myreader["tax_percentage"].ToString();
                    string desc = myreader["tax_describtion"].ToString();
                    string autoid = myreader["auto_no"].ToString();
                    txtPercentage.Text = name;
                    txtDesc.Text = desc;
                    cmbAutono.Text = autoid;
                    btnSave.Text = "&Update";
                   btnClear.Text = "&Add New";
                    btnSave.Enabled = true;

                }

            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
          

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            refresh();
            btnSave.Focus();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbAutono_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
        

    }
}
