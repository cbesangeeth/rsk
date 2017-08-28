using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace rsk
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            fillcombo1();
            fillcombo2();
            comboBox2.Text = null;
            comboBox1.Text = null;
        }

        void fillcombo1()
        {
            SqlConnection con = new SqlConnection("Data Source=RSK-PC\\SQLEXPRESS;Initial Catalog=rsk_db;Integrated Security=True");

            SqlDataAdapter da = new SqlDataAdapter("select * from group_master_tb", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBox1.DisplayMember = "group_name";
            comboBox1.DataSource = dt;
        }
        void fillcombo2()
        {
            SqlConnection con = new SqlConnection("Data Source=RSK-PC\\SQLEXPRESS;Initial Catalog=rsk_db;Integrated Security=True");

            SqlDataAdapter da = new SqlDataAdapter("select * from group_master_tb", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBox2.DisplayMember = "auto_no";
            comboBox2.DataSource = dt;
        }


        public class ReadData                                  //this class used to execute stored procedure in sqlserever
        {
            public bool FindString(string myString)
            {
                SqlConnection connection = new SqlConnection("Data Source=RSK-PC\\SQLEXPRESS;Initial Catalog=rsk_db;Integrated Security=True");
                SqlCommand command = new SqlCommand();

                command.Connection = connection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "FindString";
                command.Parameters.AddWithValue("@MyString", myString);
                try
                {
                    connection.Open();
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
                    if (connection.State == ConnectionState.Open)
                        connection.Close();
                }
                return false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {


            ReadData r = new ReadData();

            if (r.FindString(textBox1.Text))    //checking database if groupname already exits or not
            {
                MessageBox.Show("Name already exists ");
                //textBox1.Text = null;
                // textBox2.Text = null;

            }
           
               else if (textBox1.Text.Length == 0)                  //group_name is null then return error message
                {
                    MessageBox.Show("Please enter group name!");
                }

                else                                           //used to save group_name and des in db
                {
                   
                    save();

                }
            

        }


        
          

        //  save function
        void save()
        {

            string constring = "Data Source=RSK-PC\\SQLEXPRESS;Initial Catalog=rsk_db;Integrated Security=True";
                    string query = "insert into group_master_tb values('" + textBox1.Text + "','" + textBox2.Text + "');";
                    SqlConnection con = new SqlConnection(constring);
                    SqlCommand sc = new SqlCommand(query, con);
                    SqlDataReader myreader;
                    try
                    {
                        con.Open();
                        myreader = sc.ExecuteReader();
                        MessageBox.Show("Saved Sucessfully");
                        fillcombo1();
                        fillcombo2();
                        textBox1.Text = null;
                        textBox2.Text = null;
                        comboBox1.Text = null;
                        comboBox2.Text = null;
                        while (myreader.Read())
                        {

                        }

                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    finally
                    {
                        if (con.State == ConnectionState.Open)
                            con.Close();
                    }
        }
        //end of save


        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            textBox2.Text = null;
            comboBox1.Text = null;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string constring = "Data Source=RSK-PC\\SQLEXPRESS;Initial Catalog=rsk_db;Integrated Security=True";
            string query = "select * from group_master_tb where group_name='" + comboBox1.Text + "'";
            SqlConnection con = new SqlConnection(constring);
            SqlCommand sc = new SqlCommand(query, con);
            SqlDataReader myreader;
            try
            {
                con.Open();
                myreader = sc.ExecuteReader();
                //  comboBox2.Text = myreader


                while (myreader.Read())
                {
                    // string name = myreader.GetString("group_name").ToString();


                }

            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }




        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //tofind();

            if (textBox1.Text.Length == 0)                  //group_name is null then return error message
            {
                MessageBox.Show("Please enter group name to Delete!");
            }

            else                                           //used to save group_name and des in db
            {
                delete();
            }

        }


        void delete()
        {
            string constring = "Data Source=RSK-PC\\SQLEXPRESS;Initial Catalog=rsk_db;Integrated Security=True";
            string query = "delete from group_master_tb where group_name=('" + textBox1.Text + "');";
            SqlConnection con = new SqlConnection(constring);
            SqlCommand sc = new SqlCommand(query, con);
            SqlDataReader myreader;
            try
            {
                con.Open();
                myreader = sc.ExecuteReader();
                
                //if(MessageBox.Show("Do you Really want to delete"),me
                MessageBox.Show("Deleted Sucessfully");
                fillcombo1();
                fillcombo2();
                textBox1.Text = null;
                textBox2.Text = null;
                comboBox1.Text = null;
                comboBox2.Text = null;
                while (myreader.Read())
                {

                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }

        }
    }
}