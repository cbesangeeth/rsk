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
           // SqlConnection conn = DBConnection.getDBConnection();

            /*SqlDataAdapter da = new SqlDataAdapter("select * from group_master_tb", conn);
            DataTable dt = new DataTable();
            
            da.Fill(dt);
            cmbgroup.DisplayMember = "group_name";
            cmbgroup.DataSource = dt;*/

            SqlDataAdapter myreader;
            DataSet ds = new DataSet();

            SqlConnection conn = DBConnection.getDBConnection();
            string query = "select * from group_master_tb";
            myreader = new SqlDataAdapter(query, conn);
            ds.Clear();
            myreader.Fill(ds);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
               
                cmbgroup.Items.Add(ds.Tables[0].Rows[i]["group_name"].ToString());

            }
       
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
           cmbgroup.Click +=new EventHandler(btnGroupId_click);
          cmbTax.Click +=new EventHandler(cmbTax_Click);

            loadState();
            
        }
        void btnGroupId_click(object sender, EventArgs e)
        {
            ComboBox n = (ComboBox)sender;

            //Button cl = (Button)sender;
            this.fillcombo1();

        }
        void cmbTax_Click(object sender, EventArgs e)
        {
            ComboBox n = (ComboBox)sender;
            this.fillcombo2();
        }
        void loadState()
        {
            gbDetails.Enabled = false;
            btnSave.Enabled = false;
            btnDelete.Enabled = false;
            btnCancel.Enabled = false;
            btnEdit.Enabled = false;
        }

       

        private void button7_Click(object sender, EventArgs e)
        {
            frmgroup myform = new frmgroup();
            myform.ShowDialog();
            
        }

        private void combgroupname_GotFocus(object sender, EventArgs e)
        {
            fillcombo1();
           
        }

        private void btnAddnew_Click(object sender, EventArgs e)
        {
            gbDetails.Enabled = true;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            btnAddnew.Enabled = false;
         // refresh();
            txtItemname.Text = "";
            txtDesc.Text = "";
            txtRate.Text = "";
            txtReorderqty.Text = "";
            txtMinimumOrderQty.Text = "";
            txtSellingprice.Text = "";
            lbItemcode.Text = "";
            lbPurchaseprice.Text = "";
            cmbTax.Text = null;
            cmbgroup.Text = null;
            cmbAutono.Text = null;
          //  lstItembox.Enabled = true;
         //   int a;
            /*
           / a=lstItembox.Items.Count;

            txtSellingprice.Text = (a+1).ToString();
            */

            try
            {
         
            SqlDataAdapter myreader;
            DataSet ds=new DataSet();

            SqlConnection conn = DBConnection.getDBConnection();
            string query = "select max(item_code)+1 as item_code from item_master_tb ";
            myreader = new SqlDataAdapter(query, conn);
            ds.Clear();
            myreader.Fill(ds);
            //if (myreader =="NULL")

                lbItemcode.Text = ds.Tables[0].Rows[0]["item_code"].ToString();
                if (lbItemcode.Text == "")
                    lbItemcode.Text = "1";
           // else
             //   lbItemcode.Text = "1" ;

         // SqlCommand sc = new SqlCommand(query,conn);
          //SqlDataReader myreader;
           // myreader = sc.ExecuteNonQuery();
           //lbItemcode.Text =sc.ExecuteNonQuery  ;

            

        }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
          

            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            lbItemcode.Text = "";
            
            gbDetails.Enabled = false;
            btnSave.Enabled = false;
            btnDelete.Enabled = false;
            btnCancel.Enabled = false;
            btnEdit.Enabled = false;
            btnAddnew.Enabled = true;
            btnEdit.Text = "Edit";
           
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }

       /* public class ReadData                                  //this class used to execute stored procedure in sqlserever
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
        * */

        private void refresh()
        {
           fillcombo1();
            fillcombo2();
            fillcombo3();
            fillcombo4();
           cmbAutono.Visible = false;
            txtItemname.Text = "";
            txtDesc.Text = "";
            txtRate.Text = "";
            txtReorderqty.Text = "";
            txtMinimumOrderQty.Text = "";
            txtSellingprice.Text = "";
           lbItemcode.Text = "";
            lbPurchaseprice.Text = "";
            cmbTax.Text = null;    
            cmbgroup .Text = null;
            cmbAutono.Text = null;
            btnAddnew.Enabled = true;
            btnEdit.Text = "Edit";
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
          //  ReadData r = new ReadData();
           
           // if (r.FindString(txtItemname.Text))    //checking database if groupname already exits or not
           // {
           //     MessageBox.Show("Name already exists ");
                

           // }

             if (txtItemname.Text.Length == 0 || txtMinimumOrderQty.Text.Length==0||txtRate.Text.Length==0 || txtReorderqty.Text.Length==0||txtSellingprice.Text.Length==0)                  //group_name is null then return error message
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

            string t = txtRate.Text;
            if (t.Trim() == "")
                return;
            for (int i = 0; i < t.Length; i++)
            {
                if (!char.IsNumber(t[i]))
                {
                    MessageBox.Show("Please enter number");
                    txtRate.Text = "";
                    lbPurchaseprice.Text = "";
                    return;
                }
            }
           

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
           
            SqlCommand sc = new SqlCommand(query, conn);
            SqlDataReader myreader;
           

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
                    string reorder = myreader["reorder_qty"].ToString();
                    string minimum = myreader["minimum_qty"].ToString();
                    string rate = myreader["rate"].ToString();
                    string purchase = myreader["purchase_price"].ToString();
                    string tax = myreader["tax"].ToString();
                    string selling = myreader["selling_price"].ToString();

                    
                    lbItemcode.Text = code;
                     txtItemname.Text = name;
                    txtDesc.Text = desc;
                    cmbAutono.Text = autoid;
                    cmbgroup.Text = group;
                    txtReorderqty.Text = reorder;
                    txtMinimumOrderQty.Text = minimum;
                    txtRate.Text = rate;
                    lbPurchaseprice.Text = purchase;
                    cmbTax.Text = tax;
                    txtSellingprice.Text = selling;


                
                    btnEdit.Enabled= true;
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
                string query = "update  item_master_tb set item_code='" + lbItemcode.Text + "',minimum_qty='" + txtMinimumOrderQty.Text + "',reorder_qty='" + txtReorderqty.Text + "', tax ='" + cmbTax.Text + "',rate='" + txtRate.Text + "',group_name='" + cmbgroup.Text + "',item_name='" + txtItemname.Text + "',selling_price='" + txtSellingprice.Text + "',descripition='" + txtDesc.Text + "'where auto_no=" + cmbAutono.Text + "";
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
                    MessageBox.Show( ex.Message);
                }

                finally
                {
                    if (conn.State == ConnectionState.Open)
                        conn.Close();
                }
            }

         }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtItemname.Text.Length == 0)                  //group_name is null then return error message
            {
                MessageBox.Show("Please select Tax to Delete!");
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
                    //txtPercentage.Focus();

                }
                else
                {

                }

            }
        }

        void delete()
        {
            //string constring = "Data Source=SANGEETH-PC\\SQLEXPRESS;Initial Catalog=rsk_db;Integrated Security=True";
            SqlConnection conn = DBConnection.getDBConnection();

            string query = "delete from item_master_tb where auto_no=('" + cmbAutono.Text + "');";
            //SqlConnection con = new SqlConnection(constring);
            SqlCommand sc = new SqlCommand(query, conn);
            SqlDataReader myreader;
            try
            {
                conn.Open();
                if (lstItembox.Text == txtItemname.Text)
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

        private void txtReorderqty_TextChanged(object sender, EventArgs e)
        {
            string t = txtReorderqty.Text;
            if (t.Trim() == "")
                return;
            for (int i = 0; i < t.Length; i++)
            {
                if (!char.IsNumber(t[i]))
                {
                    MessageBox.Show("Please enter number");
                    txtReorderqty.Text = "";
                    return;
                }
            }/*if (txtReorderqty.Text == "")
            {
                MessageBox.Show("no values");
            }*/
        }

        private void gbDetails_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cmbgroup_click(object sender, EventArgs e)
        {
          //  MessageBox.Show("ASDF");
        }

        private void cmbAutono_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtMinimumOrderQty_TextChanged(object sender, EventArgs e)
        {
            string t = txtMinimumOrderQty.Text;
            if (t.Trim() == "")
                return;
            for (int i = 0; i < t.Length; i++)
            {
                if (!char.IsNumber(t[i]))
                {
                    MessageBox.Show("Please enter number");
                    txtMinimumOrderQty.Text = "";
                    return;
                }
            }
        }

        private void txtSellingprice_TextChanged(object sender, EventArgs e)
        {
            string t = txtSellingprice.Text;
            if (t.Trim() == "")
                return;
            for (int i = 0; i < t.Length; i++)
            {
                if (!char.IsNumber(t[i]))
                {
                    MessageBox.Show("Please enter number");
                    txtSellingprice.Text = "";
                    return;
                }
            }
        }
    }


}
