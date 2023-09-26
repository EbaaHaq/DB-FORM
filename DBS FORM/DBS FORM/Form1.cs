using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBS_FORM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Form1_Load() called...");
            textBox_Count.Text = "Startup..."; try
            {
                System.Diagnostics.Debug.WriteLine("within the try");
                SqlConnection connection = new SqlConnection(@"Data 
Source=DESKTOP-VIU51SB\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True");
                connection.Open();
                textBox_Count.Text = "Connection Successful";
                connection.Close();
            }
            catch (Exception ex)
            {
                textBox_Count.Text = "Error, " + ex;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand();
         SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-VIU51SB\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True");

            connection.Open();
            textBox_Count.Text = "Inserting Record...";
            command.Connection = connection;
            command.CommandText = "insert into Customers (ID, Company) values('" +
           textBox_ID.Text + "','" + textBox_CN.Text + "')";
            command.CommandText = "INSERT INTO Customers (CustomerID, CompanyName) VALUES (@CustomerID, @CompanyName)";
            command.Parameters.AddWithValue("@CustomerID", textBox_ID.Text);
            command.Parameters.AddWithValue("@CompanyName", textBox_CN.Text);
            command.ExecuteNonQuery();

            textBox_Count.Text = "Record Inserted...";
            connection.Close();
        }

        private void button_Count_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand();
            SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-VIU51SB\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True");

            connection.Open();
            textBox_Count.Text = "Counting Records...";
            command.Connection = connection;
            command.CommandText = "select count(*) from Customers";
            int count = (int)command.ExecuteScalar();
            textBox_Count.Text = "Number of records: " + count;
            connection.Close();
        }

        private void button_View_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand();
            SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-VIU51SB\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True");

            connection.Open();
            textBox_Count.Text = "Retrieving Records...";
            command.Connection = connection;
            command.CommandText = "select * from Customers";
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;
            dataGridView1.Text = "Retrieval Successful!";
            connection.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }

}
