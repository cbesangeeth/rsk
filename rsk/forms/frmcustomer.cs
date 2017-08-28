using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using rsk.Dbclass;
using System.Data.SqlClient;

namespace rsk
{
    public partial class frmcustomer : Form
    {
        public frmcustomer()
        {
            InitializeComponent();
            refresh();
        }
        private void refresh()
        {
            fillcombo1();
            fillcombo2();
           cmbAutono.Visible = false;
             txtCustomername.Text = "";
             txtAddress.Text = "";
             lbCustomercode.Text = "";
             txtPhoneno.Text = "";
             cmbAutono.Text = null;
             btnAddnew.Enabled = true;
             btnEdit.Text = "Edit";
             
        }

        private void frmcustomer_Load(object sender, EventArgs e)
        {
            loadState();
        }
        void loadState()
        {
            gbDetails.Enabled = false;
            btnSave.Enabled = false;
            btnDelete.Enabled = false;
            btnCancel.Enabled = false;
            btnEdit.Enabled = false;
        }
        void fillcombo1()
        {
            SqlConnection conn = DBConnection.getDBConnection();
            SqlDataAdapter da = new SqlDataAdapter("select * from customer_master_tb", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbAutono.DisplayMember = "auto_no";
            cmbAutono.DataSource = dt;
        }
        void fillcombo2()
        {

            SqlConnection conn = DBConnection.getDBConnection();
            SqlDataAdapter da = new SqlDataAdapter("select * from customer_master_tb", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            lstCustomerlist.DisplayMember = "customer_name";
            lstCustomerlist.DataSource = dt;


        }
       

        private void cmbAutono_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAddnew_Click(object sender, EventArgs e)
        {
                gbDetails.Enabled = true;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            btnAddnew.Enabled = false;
            txtCustomername.Text = "";
            txtAddress.Text = "";
            lbCustomercode.Text = "";
            txtPhoneno.Text = "";

            cmbAutono.Text = null;
            try
            {
         
            SqlDataAdapter myreader;
            DataSet ds=new DataSet();

            SqlConnection conn = DBConnection.getDBConnection();
            string query = "select max(customer_code)+1 as customer_code from customer_master_tb ";
            myreader = new SqlDataAdapter(query, conn);
            ds.Clear();
            myreader.Fill(ds);
            

                lbCustomercode.Text = ds.Tables[0].Rows[0]["customer_code"].ToString();
                if (lbCustomercode.Text == "")
                    lbCustomercode.Text = "1";
          

            

        }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
          

            
        

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            gbDetails.Enabled = false;
            btnSave.Enabled = false;
            btnDelete.Enabled = false;
            btnCancel.Enabled = false;
            btnEdit.Enabled = false;
            btnAddnew.Enabled = true;
            lbCustomercode.Text = "";
            txtPhoneno.Text = "";
            btnEdit.Text = "Edit";
            txtCustomername.Text = "";
            txtAddress.Text = "";

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (btnEdit.Text == "Edit")
            {
                gbDetails.Enabled = true;
                btnDelete.Enabled = false;
                // btnEdit.Enabled = false;
                btnEdit.Text = "Update";
                //btnSave.Enabled = true;
            }
            else
            {
                SqlConnection conn = DBConnection.getDBConnection();
                string query = "update  customer_master_tb set phone_number='" + txtPhoneno.Text + "',customer_code='" + lbCustomercode.Text + "',customer_name='" + txtCustomername.Text + "',address='" + txtAddress.Text + "'where auto_no=" + cmbAutono.Text + "";
                SqlCommand sc = new SqlCommand(query, conn);
                try
                {
                    conn.Open();
                    sc.ExecuteReader();
                    MessageBox.Show("Updated Sucessfully");
                    refresh();
                    gbDetails.Enabled = false;
                    btnSave.Enabled = false;
                    btnDelete.Enabled = false;
                    btnCancel.Enabled = false;
                    btnEdit.Enabled = false;
                    btnAddnew.Enabled = true;
                    btnEdit.Text = "Edit";
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
        }

        private void lstCustomerlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection conn = DBConnection.getDBConnection();

            string query = "select * from customer_master_tb where customer_name='" +  lstCustomerlist.Text + "'";
           
            SqlCommand sc = new SqlCommand(query, conn);
            SqlDataReader myreader;


            try
            {
                conn.Open();
                myreader = sc.ExecuteReader();
                while (myreader.Read())
                {
                    string code = myreader["customer_code"].ToString();
                    string name = myreader["customer_name"].ToString();
                    string address = myreader["address"].ToString();
                    string autoid = myreader["auto_no"].ToString();
                    string phoneno = myreader["phone_number"].ToString();

                    lbCustomercode.Text = code;
                    txtCustomername.Text = name;
                    txtAddress.Text = address;
                    cmbAutono.Text = autoid;
                    txtPhoneno.Text = phoneno;


                    btnEdit.Enabled = true;
                    btnDelete.Enabled = true;
                    btnCancel.Enabled = true;
                    btnAddnew.Enabled = false;
                    gbDetails.Enabled = false;
                    btnSave.Enabled = false;
                    btnEdit.Text = "Edit";
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtCustomername.Text.Length == 0 || txtAddress.Text.Length == 0 || txtPhoneno.Text.Length == 0  )                  //group_name is null then return error message
            {
                MessageBox.Show("Please fill all fields!");
            }

            else                                           //used to save group_name and des in db
            {
                save();
                refresh();
                gbDetails.Enabled = false;
                btnSave.Enabled = false;
                btnDelete.Enabled = false;
                btnCancel.Enabled = false;
                btnEdit.Enabled = false;
                btnAddnew.Enabled = true;
            }
        }
        void save()
        {
            SqlConnection conn = DBConnection.getDBConnection();
            string query = "insert into customer_master_tb values('" + lbCustomercode.Text + "','" + txtCustomername.Text + "','" + txtPhoneno.Text + "','" + txtAddress.Text + "');";
            SqlCommand sc = new SqlCommand(query, conn);
            SqlDataReader myreader;
            try
            {
                conn.Open();
                myreader = sc.ExecuteReader();
                MessageBox.Show("Saved Sucessfully");

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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtCustomername.Text.Length == 0)                  //group_name is null then return error message
            {
                MessageBox.Show("Please select Customer to Delete!");
                //cmbTaxList.Focus();
            }

            else                                           //used to save group_name and des in db
            {
                if (MessageBox.Show("Are You sure Want To Delete? ", "Conform Delete", MessageBoxButtons.YesNo) == (DialogResult.Yes))
                {

                    delete();
                    refresh();
                    btnDelete.Enabled = false;
                    btnEdit.Enabled = false;
                    btnCancel.Enabled = false;
                   

                }
                else
                {

                }

            }
        }
        void delete()
        {
            SqlConnection conn = DBConnection.getDBConnection();
             string query = "delete from customer_master_tb where auto_no=('" + cmbAutono.Text + "');";
            SqlCommand sc = new SqlCommand(query, conn);
            SqlDataReader myreader;
            try
            {
                conn.Open();
                if (lstCustomerlist.Text == txtCustomername.Text)
                {
                    myreader = sc.ExecuteReader();
                    MessageBox.Show("Deleted Sucessfully");
                }
                else
                {
                    string error = "Name you entered not in Database";
                    MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    refresh();
                    //txtPercentage.Focus();
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

        private void txtPhoneno_TextChanged(object sender, EventArgs e)
        {
            string t = txtPhoneno.Text;
                if (t.Trim() == "")
                return;
            for (int i = 0; i < t.Length; i++)
            {
                if (!char.IsNumber(t[i]))
                {
                    MessageBox.Show("Please enter number");
                    txtPhoneno.Text = "";
                    return;
                }
            }
        }
    }
}
