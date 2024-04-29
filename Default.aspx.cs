using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CRUDApplication
{
    public partial class _Default : Page
    {
        // Database connection
        SqlConnection con = new SqlConnection("Data Source=SQL8001.site4now.net,1433;Initial Catalog=db_aa4083_patientdb;User Id=db_aa4083_patientdb_admin;Password=pa1ti2en3t");

        protected void Page_Load(object sender, EventArgs e)
        {
            // Load records only on initial page load, not on postbacks
            if (!IsPostBack)
            {
                LoadRecord();
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Load records when the DropDownList selection changes
            LoadRecord();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            // Insert button click event
            // Open database connection, insert data, close connection, show success alert, and reload records
            con.Open();
            SqlCommand comm = new SqlCommand("Insert into Patient_Information_Tab values('" + int.Parse(TextBox1.Text) + "', '" + TextBox2.Text + "', '" + double.Parse(TextBox3.Text) + "','" + DropDownList1.SelectedValue + "', '" + TextBox4.Text + "')", con);
            comm.ExecuteNonQuery();
            con.Close();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Inserted Successfully');", true);
            LoadRecord();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            // Update button click event
            // Open database connection, update data, close connection, show success alert, and reload records
            con.Open();
            SqlCommand comm = new SqlCommand("update Patient_Information_Tab set [Patient Name] = '" + TextBox2.Text + "', Age = '" + double.Parse(TextBox3.Text) + "', Address = '" + DropDownList1.SelectedValue + "', Contact = '" + TextBox4.Text + "' where [Patient ID] = '" + int.Parse(TextBox1.Text) + "'", con);
            comm.ExecuteNonQuery();
            con.Close();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Updated Successfully');", true);
            LoadRecord();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            // Delete button click event
            // Open database connection, delete data, close connection, show success alert, and reload records
            con.Open();
            SqlCommand comm = new SqlCommand("Delete Patient_Information_Tab where [Patient ID] = '" + int.Parse(TextBox1.Text) + "'", con);
            comm.ExecuteNonQuery();
            con.Close();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Deleted Successfully');", true);
            LoadRecord();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            // Search button click event
            // Fetch data based on Patient ID, display in GridView
            SqlCommand comm = new SqlCommand("select * from Patient_Information_Tab where [Patient ID] = '" + int.Parse(TextBox1.Text) + "'", con);
            SqlDataAdapter adapter = new SqlDataAdapter(comm);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            GridView1.DataSource = dataTable;
            GridView1.DataBind();
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            // Get button click event (Read operation)
            // Fetch data based on Patient ID and populate TextBoxes and DropDownList
            con.Open();
            SqlCommand comm = new SqlCommand("select * from Patient_Information_Tab where [Patient ID] = '" + int.Parse(TextBox1.Text) + "'", con);
            SqlDataReader reader = comm.ExecuteReader();
            while (reader.Read())
            {
                TextBox2.Text = reader.GetValue(1).ToString();
                TextBox3.Text = reader.GetValue(2).ToString();
                DropDownList1.SelectedValue = reader.GetValue(3).ToString();
                TextBox4.Text = reader.GetValue(4).ToString();
            }
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            // Sort button click event
            // Sort records based on Patient ID and display in GridView
            con.Open();
            SqlCommand comm = new SqlCommand("select * from Patient_Information_Tab order by [Patient ID]", con);
            SqlDataAdapter adapter = new SqlDataAdapter(comm);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            GridView1.DataSource = dataTable;
            GridView1.DataBind();
        }

        protected void OnPageIndexchanging(object sender, GridViewPageEventArgs e)
        {
            // Paging event
            GridView1.PageIndex = e.NewPageIndex;
            this.LoadRecord();
        }

        void LoadRecord()
        {
            // Load all records from the database and bind to GridView
            SqlCommand comm = new SqlCommand("select * from Patient_Information_Tab", con);
            SqlDataAdapter adapter = new SqlDataAdapter(comm);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            GridView1.DataSource = dataTable;
            GridView1.DataBind();
        }
    }
}
