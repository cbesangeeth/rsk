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
    public partial class frmgroup : Form
    {

        public frmgroup()
        {
            InitializeComponent();
            refresh();
           
        }


        void fillcombo1()
        {
            
          //  SqlConnection con = new SqlConnection("Data Source=SANGEETH-PC\\SQLEXPRESS;Initial Catalog=rsk_db;Integrated Security=True");
            SqlConnection conn = DBConnection.getDBConnection();
            
            SqlDataAdapter da = new SqlDataAdapter("select * from group_master_tb", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBox11.DisplayMember = "group_name";
            comboBox11.DataSource = dt;
        }
        
        
        
        void fillcombo2()
        {
            //SqlConnection con = new SqlConnection("Data Source=SANGEETH-PC\\SQLEXPRESS;Initial Catalog=rsk_db;Integrated Security=True");
           // SqlConnection conn = DBConnection.getDBConnection();
            SqlConnection conn = DBConnection.getDBConnection();
            
            SqlDataAdapter da = new SqlDataAdapter("select * from group_master_tb", conn);
            DataTable dt = new DataTable();
           
            da.Fill(dt);
            comboBox2.DisplayMember = "auto_no";
            comboBox2.DataSource = dt;
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
                command.CommandText = "FindString";
                command.Parameters.AddWithValue("@MyString", myString);
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
        
        
        
      


        
        private void  refresh()
        {
            fillcombo1();
            fillcombo2();
            comboBox2.Visible = false;
        
            textBox1.Text = "";
            textBox2.Text = "";
            button1.Text = "&Save";
            button2.Text = "&Clear";
            comboBox11.Text = null;
            comboBox2.Text = null;
            //fillcombo1();
            //fillcombo2();

        }
        
        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();

        }

      
       

       
       
    
        private void Form1_Load(object sender, EventArgs e)
        {
           
            

          }

       
        void delete()
        {
            //string constring = "Data Source=SANGEETH-PC\\SQLEXPRESS;Initial Catalog=rsk_db;Integrated Security=True";
            SqlConnection conn = DBConnection.getDBConnection();
            
            string query = "delete from group_master_tb where group_name=('" + textBox1.Text + "');";
            //SqlConnection con = new SqlConnection(constring);
            SqlCommand sc = new SqlCommand(query, conn);
            SqlDataReader myreader;
            try
            {
                conn.Open();
                if (comboBox11.Text == textBox1.Text)
                {
                    myreader = sc.ExecuteReader();
                    //string m = "dfafd";

                    //MessageBox.Show(m, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //if(MessageBox.Show("Do you Really want to delete"),me
                    MessageBox.Show("Deleted Sucessfully");
                    
                    
                }
                else
                {
                    string error = "Name you entered not in Database";
                    MessageBox.Show(error,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    refresh();
                    textBox1.Focus();
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

       
       
        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
           

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ReadData r = new ReadData();

            if (r.FindString(textBox1.Text))    //checking database if groupname already exits or not
            {
                MessageBox.Show("Name already exists ");
                textBox1.Focus();
                //textBox1.Text = null;
                // textBox2.Text = null;

            }
            else if (textBox1.Text.Length == 0)                  //group_name is null then return error message
            {
                MessageBox.Show("Please enter group name!");
                textBox1.Focus();
            }

            else if (button1.Text == "&Save")                                          //used to save group_name and des in db
            {
                string Error = "";
                DBProductMaster saveobj = new DBProductMaster();
                saveobj.savegroup(textBox1.Text, textBox2.Text, ref Error);
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
            else if (button1.Text == "&Update")
            {
                string Error = "";
                DBProductMaster updateobj = new DBProductMaster();
                updateobj.updategroup(textBox1.Text, textBox2.Text, comboBox2.Text, ref Error);
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

        private void button2_Click_1(object sender, EventArgs e)
        {
            refresh();
            
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0)                  //group_name is null then return error message
            {
                MessageBox.Show("Please select group name to Delete!");
                comboBox11.Focus();
            }

            else                                           //used to save group_name and des in db
            {
                if (MessageBox.Show("Are You sure Want To Delete? ", "Conform Delete", MessageBoxButtons.YesNo) == (DialogResult.Yes))
                {

                    delete();
                    refresh();
                    textBox1.Focus();

                }
                else
                {

                }

            }

        }

        private void comboBox11_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection conn = DBConnection.getDBConnection();

            string query = "select * from group_master_tb where group_name='" + comboBox11.Text + "'";
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
                    string name = myreader["group_name"].ToString();
                    string desc = myreader["description"].ToString();
                    string autoid = myreader["auto_no"].ToString();
                    textBox1.Text = name;
                    textBox2.Text = desc;
                    comboBox2.Text = autoid;
                   button1.Text = "&Update";
                   button2.Text = "&Add New";
                    button1.Enabled = true;

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

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            refresh();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}