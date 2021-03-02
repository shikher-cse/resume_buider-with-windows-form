/*
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registration_form
{

    public partial class Form1 : Form
    {
        /*List<Student> myName = new List<Student>();
        List<Student> myRollno = new List<Student>();
        List<Student> myGender = new List<Student>();
        List<Student> myPhoneNumber = new List<Student>();
        List<Student> myEmail = new List<Student>();
        List<Student> myDepartment = new List<Student>();
        List<Student> myAddress = new List<Student>();*/
        //DataTable table = new DataTable("table");

        //int index;

        //public Form1()
        //{
        //    InitializeComponent();
             /*myDepartment.Add(new Student { Department = "CSE" });
             myDepartment.Add(new Student { Department = "IT" });
             myDepartment.Add(new Student { Department = "ECE" });
             myDepartment.Add(new Student { Department = "EE" });*/


        
/*
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            table.Columns.Add("Name", Type.GetType("System.String"));
            table.Columns.Add("Rollno", Type.GetType("System.String"));
            table.Columns.Add("Gender", Type.GetType("System.String"));
            table.Columns.Add("Phone", Type.GetType("System.Int32"));
            table.Columns.Add("Email", Type.GetType("System.String"));
            table.Columns.Add("Department", Type.GetType("System.String"));
            table.Columns.Add("Address", Type.GetType("System.String"));

            dataGridView1.DataSource = table;

        }

        private void lb3Gender_Click(object sender, EventArgs e)
        {

        }

        //Submit Button
        private void btn1Submit_Click(object sender, EventArgs e)
        {





            //Adding FirstName
            if (!string.IsNullOrEmpty(tb1EnterName.Text) || !string.IsNullOrEmpty(tb2EnterRollno.Text)
                || !string.IsNullOrEmpty(rb1Male.Text)
                || !string.IsNullOrEmpty(tb3Phone.Text) || !string.IsNullOrEmpty(tb4Email.Text)
                || !string.IsNullOrEmpty(cb1Department.Text) || !string.IsNullOrEmpty(tb5Address.Text))
            {
                table.Rows.Add(tb1EnterName.Text, tb2EnterRollno.Text, rb1Male.Text, tb3Phone.Text, tb4Email.Text,
                    cb1Department.Text, tb5Address.Text);
            }






            //Adding LastName
            /* if (!string.IsNullOrEmpty(tb2EnterRollno.Text))                        
             {
                 table.Rows.Add(tb2EnterRollno.Text);
                 //Student myobjstu = new Student();
                 //myobjstu.Rollno = tb2EnterRollno.Text;
                // myRollno.Add(myobjstu);
             }*/

            //Validation and Addition of Gender Field
            /* if (!string.IsNullOrEmpty(rb1Male.Text) || !string.IsNullOrEmpty(rb2Female.Text))
             {
                // Student myobjstu = new Student();
                 bool isChecked = rb1Male.Checked;

                 if (isChecked)
                 {
                     table.Rows.Add(rb1Male.Text);
                 }
                 else
                 {
                     table.Rows.Add(rb2Female.Text);
                 }
             }*/


            //Validation and Addition of Phone Field
            /*if (!string.IsNullOrEmpty(tb3Phone.Text))
            {
                 table.Rows.Add(tb3Phone.Text);
            }*/


            //Validation and Addition of E-mail Field
            /* if (!string.IsNullOrEmpty(tb4Email.Text))
             {
                  table.Rows.Add(tb4Email.Text);
             }*/


            //Validation and Addition of Department Field
            /*if (!string.IsNullOrEmpty(cb1Department.Text))
            {
                 table.Rows.Add(cb1Department.Text);
            }*/

            //Validation and Addition of Address Field
            /*if (!string.IsNullOrEmpty(tb5Address.Text))
            {
                 table.Rows.Add(tb5Address.Text);
            }*/

        //    MessageBox.Show("You are Registered Successfully");
        //}


     /*   //Cancel Button
        private void btn2Cancel_Click(object sender, EventArgs e)
        //{
        //    DialogResult dr = MessageBox.Show("Are you sure you want cancel the registration ?", "Confirm",
        //        MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
                this.Close();
        }

        private void cb1Department_SelectedIndexChanged(object sender, EventArgs e)
        {


            /* Student myobjstu = new Student();
             myobjstu.Department = cb1Department.Text;
             myDepartment.AcNCdd(myobjstu);*/
        
/*

        //Validation of FirstName Field
        private void tb1FirstName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tb1EnterName.Text))
            {
                e.Cancel = true;
                tb1EnterName.Focus();
                errorProvider1.SetError(tb1EnterName, "FirstName should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tb1EnterName, "");
            }
        }


        //Validation of PhoneNumber Field
        private void tb3Phone_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tb3Phone.Text))
            {
                e.Cancel = true;
                tb3Phone.Focus();
                errorProvider1.SetError(tb3Phone, "FirstName should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tb3Phone, "");
            }
        }


        //Validation of Email Field
        private void tb4Email_Validating(object sender, CancelEventArgs e)
        {
            /*if (string.IsNullOrWhiteSpace(tb4Email.Text))
            {
                e.Cancel = true;
                tb4Email.Focus();
                errorProvider1.SetError(tb4Email, "FirstName should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tb4Email, "");
            }*/
     



/*
        private void rb1Male_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)          //New button
        {
            tb1EnterName.Text = string.Empty;
            tb2EnterRollno.Text = string.Empty;

            tb3Phone.Text = string.Empty;
            tb4Email.Text = string.Empty;
            cb1Department.Text = string.Empty;
            tb5Address.Text = string.Empty;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[index];

            tb1EnterName.Text = row.Cells[0].Value.ToString();
            tb2EnterRollno.Text = row.Cells[1].Value.ToString();
            rb1Male.Text = row.Cells[2].Value.ToString();
            tb3Phone.Text = row.Cells[3].Value.ToString();
            tb4Email.Text = row.Cells[4].Value.ToString();
            cb1Department.Text = row.Cells[5].Value.ToString();
            tb5Address.Text = row.Cells[6].Value.ToString();
        }
        private void btn4Update_Click(object sender, EventArgs e)
        {
            DataGridViewRow newdata = dataGridView1.Rows[index];

            newdata.Cells[0].Value = tb1EnterName.Text;
            newdata.Cells[1].Value = tb2EnterRollno.Text;
            newdata.Cells[2].Value = rb1Male.Text;
            newdata.Cells[3].Value = tb3Phone.Text;
            newdata.Cells[4].Value = tb4Email.Text;
            newdata.Cells[5].Value = cb1Department.Text;
            newdata.Cells[6].Value = tb5Address.Text;

        }

        private void btn5Delete_Click(object sender, EventArgs e)
        {
            index = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(index);
        }
    }
}
*/