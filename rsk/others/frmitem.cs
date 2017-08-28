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
    public partial class frmitem : Form
    {
        public frmitem()
        {
            InitializeComponent();

             refresh();
        }
        void fillcombo1()
        {
            SqlConnection conn = DBConnection.getDBConnection();

            SqlDataAdapter da = new SqlDataAdapter("select * from group_master_tb", conn);
            DataTable dt = new DataTable();
            
            da.Fill(dt);
            cmbgroup.DisplayMember = "group_name";
            cmbgroup.DataSource = dt;
        }
        void fillcombo2()
        {
            SqlConnection conn = DBConnection.getDBConnection();

            SqlDataAdapter da = new SqlDataAdapter("select * from tax_master_tb", conn);
            DataTable dt = new DataTable();

            da.Fill(dt);
            cmbTax.DisplayMember = "tax_percentage";
            cmbTax.DataSource = dt;
        }
        void fillcombo3()
        {

            SqlConnection conn = DBConnection.getDBConnection();
            SqlDataAdapter da = new SqlDataAdapter("select * from item_master_tb", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            lstItembox.DisplayMember = "item_name";
            lstItembox.DataSource = dt;

           
        }
        void fillcombo4()
        {
            SqlConnection conn = DBConnection.getDBConnection();
            SqlDataAdapter da = new SqlDataAdapter("select * from item_master_tb", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbAutono.DisplayMember = "auto_no";
            cmbAutono.DataSource = dt;
        }
        private void Form1_Load(object sender, EventArgs e)
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            frmgroup myform = new frmgroup();
            myform.ShowDialog();
            

            

        }
        
        private void combgroupname_Click(object sender, EventArgs e)
        {
           
           
        }

        private void btnAddnew_Click(object sender, EventArgs e)
        {
            gbDetails.Enabled = true;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            btnAddnew.Enabled = false;
            refresh();
        //  int a;
            SqlConnection conn = DBConnection.getDBConnection();
            string query = "select item_code from item_master_tb";
            SqlDataAdapter my = new SqlDataAdapter(query,conn);
         //   try
          //  {
           //     conn.Open();
                
               /*      if (my != null)
                    {
                        a= Convert.ToString(my+1);
                    }
                    else
                        a =  Convert.ToString(1) ;
                */

           //  }
          

            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            gbDetails.Enabled = false;
            btnSave.Enabled = false;
            btnDelete.Enabled = false;
            btnCancel.Enabled = false;
            btnEdit.Enabled = false;
            btnAddnew.Enabled = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

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

        private void refresh()
        {
            fillcombo1();
            fillcombo2();
            fillcombo3();
            fillcombo4();
          //  cmbAutono.Visible = false;
            txtItemname.Text = "";
            txtDesc.Text = "";
            txtRate.Text = "";
            txtReorderqty.Text = "";
            txtMinimumOrderQty.Text = "";
            txtSellingprice.Text = "";
           lbItemcode.Text = "1";
            lbPurchaseprice.Text = "44";
            cmbTax.Text = null;    
            cmbgroup .Text = null;
            cmbAutono.Text = null;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            ReadData r = new ReadData();

            if (r.FindString(txtItemname .Text))    //checking database if groupname already exits or not
            {
                MessageBox.Show("Name already exists ");
                

            }

            else if (txtItemname.Text.Length == 0 || txtMinimumOrderQty.Text.Length==0||txtRate.Text.Length==0 || txtReorderqty.Text.Length==0||txtSellingprice.Text.Length==0)                  //group_name is null then return error message
            {
                MessageBox.Show("Please enter all fields!");
            }

            else                                           //used to save group_name and des in db
            {
                save();
                refresh();
                loadState();
            }
            
        }
       
        
        void save()
        {
            SqlConnection conn = DBConnection.getDBConnection();
            string query = "insert into item_master_tb values('" + lbItemcode.Text + "','" + txtItemname.Text + "','" + cmbgroup.Text + "','" + txtDesc.Text + "','" + txtRate.Text + "','" + cmbTax.Text + "','" + lbPurchaseprice.Text + "','" + txtSellingprice.Text + "','" + txtReorderqty.Text + "','" + txtMinimumOrderQty.Text + "');";
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
      
        
       

        private void button8_Click(object sender, EventArgs e)
        {
            frmtax myform = new frmtax();
            myform.ShowDialog();

        }

        private void lbPurchaseprice_Click(object sender, EventArgs e)
        {

        }
        double a, b,c;
        private double pay(double a, double b)
        {
            double d,e;

            if (a == 0)
            {
               // lbPurchaseprice.Text = "";

                MessageBox.Show("zero value not allowed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return (-1);
            }
            else
            {

                e = b / 100;
                d = (double)a * e;
                return (a + d);
            }
        }
        private void cmbTax_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtRate.Text) && !string.IsNullOrEmpty(cmbTax.Text))
            {
                a = Convert.ToDouble(txtRate.Text);
                b = Convert.ToDouble(cmbTax.Text);
                
                    c = pay(a, b);
                    if (c > 0)
                        // lbPurchaseprice.Text = c.ToString();
                        lbPurchaseprice.Text = String.Format("{0:f2}", c);
                    else
                        txtRate.Focus();
                }
            
            else
            {
                lbPurchaseprice.Text = "";
            }


        }
        private void txtRate_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtRate.Text) && !string.IsNullOrEmpty(cmbTax.Text))
            {
                a = Convert.ToDouble(txtRate.Text);
                b = Convert.ToDouble(cmbTax.Text);

                c = pay(a, b);
                if (c > 0)
                    // lbPurchaseprice.Text = c.ToString();
                    lbPurchaseprice.Text = String.Format("{0:f2}", c);
                else
                    txtRate.Focus();
            }

            else
            {
                lbPurchaseprice.Text = "";
            }
            
        }

        private void lstItembox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection conn = DBConnection.getDBConnection();

            string query = "select * from item_master_tb where item_name='" +  lstItembox.Text + "'";
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
                    string code = myreader["item_code"].ToString();
                    string name = myreader["item_name"].ToString();
                    string desc = myreader["descripition"].ToString();
                    string autoid = myreader["auto_no"].ToString();


                    string group = myreader["group_name"].ToString();
                    lbItemcode.Text = code;
                     txtItemname.Text = name;
                    txtDesc.Text = desc;
                    cmbAutono.Text = autoid;
                    cmbgroup.Text = group;
                    
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
    }


}
