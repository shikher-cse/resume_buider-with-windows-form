using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Diagnostics;
namespace monday_resumebuilder
{
    public partial class Form1 : Form
    {

        List<resume_get_info> data_entered_by_user_list = new List<resume_get_info>();

        public Form1()
        {
            InitializeComponent();
        } 
        public void Form1_Load(object sender, EventArgs e)
        {
            //DataGridViewImageColumn new_col_datagrid2_get_image = new DataGridViewImageColumn();
            //new_col_datagrid2_get_image.HeaderText = " User  Image";
            //new_col_datagrid2_get_image.ImageLayout = DataGridViewImageCellLayout.Stretch;
            //dataGridView2.Columns.Add(new_col_datagrid2_get_image);
            //dataGridView2.RowTemplate.Height = 250;
            //dataGridView2.AllowUserToAddRows = false;
        }     



        // combo box for the gender data of the student 
        private void mybox_drop_gender(object sender, EventArgs e)
        {
            mybox_gender.MaxLength = 3;
            mybox_gender.DropDownStyle = ComboBoxStyle.DropDown;         
            mybox_gender.Items.Add("Male");
            mybox_gender.Items.Add("Female");
            mybox_gender.Items.Add("Other");           
        }


        //combobox for the martial status of the student 
        private void mybox_drop_martial_status(object sender, EventArgs e)
        {
            mybox_martial.MaxLength = 4;
            mybox_martial.DropDownStyle = ComboBoxStyle.DropDown;
            mybox_martial.Items.Add("Single");
            mybox_martial.Items.Add("Married");
            mybox_martial.Items.Add("Divorced");
            mybox_martial.Items.Add("Separated");           
        }


        //combobox for status of the university, either passed or persuing 
        private void mybox_statusof_collg_uni (object sender, EventArgs e)
        {
            mybox_status_college_uni.MaxLength = 2;
            mybox_status_college_uni.DropDownStyle = ComboBoxStyle.DropDown;
            mybox_status_college_uni.Items.Add("Passed");
            mybox_status_college_uni.Items.Add("Persuing");
        }





        //functionality for saving the information inside the data grid using the save button and adding new information withthe same button
        //two procedure with the same button ,  make no new button for (new)  record into the data grid;



        private void btnsave_click(object sender, EventArgs e)
        {


            resume_get_info get_info = new resume_get_info();

            if (!string.IsNullOrEmpty(objfirstname.Text))
            { get_info.firstname = objfirstname.Text; }

            if (!string.IsNullOrEmpty(objsurname.Text))
            { get_info.surname = objsurname.Text; }

            if (!string.IsNullOrEmpty(objaddress.Text))
            { get_info.permanent_address = objaddress.Text; }

            if (!string.IsNullOrEmpty(objphonenumber.Text))
            { get_info.phone_number = Convert.ToInt32(objphonenumber.Text); }

            if (!string.IsNullOrEmpty(objhighschool.Text))
            { get_info.high_school = objhighschool.Text; }

            // get_info.dob = dob.Value;
            // get_info.uni_from = from_date.Value;
            //get_info.uni_to = to_date.Value;

            if (!string.IsNullOrEmpty(objsecondaryschool.Text))
            { get_info.sec_school = objsecondaryschool.Text; }

            if (!string.IsNullOrEmpty(objuniversity.Text))
            { get_info.uni = objuniversity.Text; }

            if (!string.IsNullOrEmpty(objhome_pincode.Text))
            { get_info.pincode_permanent = objhome_pincode.Text; }

            if (!string.IsNullOrEmpty(objhighschool_pincode.Text))
            { get_info.pincode_highschool = objhighschool_pincode.Text; }

             if (!string.IsNullOrEmpty(mybox_gender.Text))
             { get_info.gender = mybox_gender.Text; }

            if (!string.IsNullOrEmpty(mybox_martial.Text))
            { get_info.martial_status = mybox_martial.Text; }

            if (!string.IsNullOrEmpty(mybox_status_college_uni.Text))
            { get_info.status_of_uni = mybox_status_college_uni.Text; }

             if (!string.IsNullOrEmpty(objsecondarychool_pincode.Text))
            { get_info.pincode_secschool = objsecondarychool_pincode.Text; }

            if (!string.IsNullOrEmpty(objuniversity_pincode.Text))
            {get_info.pincode_university = objuniversity_pincode.Text; }

            if (!string.IsNullOrEmpty(objindustrial_training.Text))
            { get_info.industrial_training = objindustrial_training.Text; }

            if (!string.IsNullOrEmpty(objcertificates.Text))
            { get_info.certifications = objcertificates.Text; }

            if (!string.IsNullOrEmpty(obj_ogpa.Text))
            { get_info.current_ogpa = obj_ogpa.Text; }

            if (!string.IsNullOrEmpty(txtextra_info.Text))
            { get_info.extra_information = txtextra_info.Text; }


            MessageBox.Show(" THe information of user  is saved successfully ! ");           
            DialogResult run_again = MessageBox.Show("Do you want to add new resume in the form " +
                "  ? ", "Confirm",MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (run_again == DialogResult.Yes)
            {               
                MessageBox.Show(" Please fill the form again for the new  record ! ");
                // implement the list again  ;
               
                objfirstname.Text = string.Empty;
                objsurname.Text = string.Empty;
                objaddress.Text = string.Empty;
                objuniversity.Text = string.Empty;
                objuniversity_pincode.Text = string.Empty;               
                objcertificates.Text = string.Empty;
                objhighschool.Text = string.Empty;
                mybox_gender.Text = string.Empty;
                mybox_martial.Text = string.Empty;
                mybox_status_college_uni.Text = string.Empty;
                objhighschool_pincode.Text = string.Empty;
                objsecondarychool_pincode.Text = string.Empty;
                objsecondaryschool.Text = string.Empty;
                objlinkedin.Text = string.Empty;
                txtextra_info.Text = string.Empty;
                obj_ogpa.Text = string.Empty;
                objhome_pincode.Text = string.Empty;
                objphonenumber.Text = string.Empty;
                objindustrial_training.Text = string.Empty;
                objsignature.Text = string.Empty;
                //dob.Text = string.Empty;
                //from_date.Text = string.Empty;
                //to_date.Text = string.Empty;
                //dob = default;
                //from_date = default;  
                //to_date = default;
            }
            else if (run_again == DialogResult.Cancel)
            {
                MessageBox.Show("no changes made ");
                objfirstname.Text = string.Empty;
                objsurname.Text = string.Empty;
                objaddress.Text = string.Empty;
                objuniversity.Text = string.Empty;
                objuniversity_pincode.Text = string.Empty;
                objcertificates.Text = string.Empty;
                objhighschool.Text = string.Empty;
                mybox_gender.Text = string.Empty;
                mybox_martial.Text = string.Empty;
                mybox_status_college_uni.Text = string.Empty;
                objhighschool_pincode.Text = string.Empty;
                objsecondarychool_pincode.Text = string.Empty;
                objsecondaryschool.Text = string.Empty;
                objlinkedin.Text = string.Empty;
                txtextra_info.Text = string.Empty;
                obj_ogpa.Text = string.Empty;
                objhome_pincode.Text = string.Empty;
                objphonenumber.Text = string.Empty;
                objindustrial_training.Text = string.Empty;
                objsignature.Text = string.Empty;
                //dob.Text = string.Empty;
                //from_date.Text = string.Empty;
                //to_date.Text = string.Empty;
                dob = default;
                from_date = default;
                to_date = default;

            }
            else 
            {
                MessageBox.Show("DONE !");
                objfirstname.Text = string.Empty;
                objsurname.Text = string.Empty;
                objaddress.Text = string.Empty;
                objuniversity.Text = string.Empty;
                objuniversity_pincode.Text = string.Empty;
                objcertificates.Text = string.Empty;
                objhighschool.Text = string.Empty;
                mybox_gender.Text = string.Empty;
                mybox_martial.Text = string.Empty;
                mybox_status_college_uni.Text = string.Empty;
                objhighschool_pincode.Text = string.Empty;
                objsecondarychool_pincode.Text = string.Empty;
                objsecondaryschool.Text = string.Empty;
                objlinkedin.Text = string.Empty;
                txtextra_info.Text = string.Empty;
                obj_ogpa.Text = string.Empty;
                objhome_pincode.Text = string.Empty;
                objphonenumber.Text = string.Empty;
                objindustrial_training.Text = string.Empty;
                objsignature.Text = string.Empty;
                //dob.Text = string.Empty;
                //from_date.Text = string.Empty;
                //to_date.Text = string.Empty;
                dob = default;
                from_date = default;
                to_date = default;
            }           
            data_entered_by_user_list.Add(get_info);
            dataGridView1.RowTemplate.Height = 25;
            
            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
            dataGridView1.DataSource = data_entered_by_user_list;
           


            ////only show the relavant information onto the datagrid  view  but store every information in list
            //dataGridView1.DataSource = data_entered_by_user_list.Select(o => new
            //{ Firstname= o.firstname, Surname= o.surname, Phonenumber= o.phone_number, University = o.uni,  ContactID = o.linkedin }).ToList();
        }
        
        private void btnreset_click(object sender, EventArgs e)
        {
            //resume_get_info get_info = new resume_get_info();
            //data_entered_by_user_list.Remove(get_info);
            objfirstname.Text = string.Empty;
            objsurname.Text = string.Empty;
            objaddress.Text = string.Empty;
            objuniversity.Text = string.Empty;
            objuniversity_pincode.Text = string.Empty;
            objcertificates.Text = string.Empty;
            objhighschool.Text = string.Empty;
            mybox_gender.Text = string.Empty;
            mybox_martial.Text = string.Empty;
            mybox_status_college_uni.Text = string.Empty;
            objhighschool_pincode.Text = string.Empty;
            objsecondarychool_pincode.Text = string.Empty;
            objsecondaryschool.Text = string.Empty;
            objlinkedin.Text = string.Empty;
            txtextra_info.Text = string.Empty;
            obj_ogpa.Text = string.Empty;
            objhome_pincode.Text = string.Empty;
            objphonenumber.Text = string.Empty;
            objindustrial_training.Text = string.Empty;
            objsignature.Text = string.Empty;
            //dob.Text = string.Empty;
            //from_date.Text = string.Empty;
            //to_date.Text = string.Empty;
            Console.Beep();
            MessageBox.Show(" The information is   reset successfully !! ");
        }
        private void btncancel_click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want cancel the registration ?", "Confirm",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)             
                MessageBox.Show(" All operations  are cancelled  successfully !! ");          
            this.Close();                  
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int col_index = e.ColumnIndex;
            string col_header = dataGridView1.Columns[col_index].HeaderText;

            if(col_header =="edit")
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                int roll = Convert.ToInt32(row.Cells[3].Value);

                resume_get_info get_info = data_entered_by_user_list.Where(x => x.phone_number == roll).FirstOrDefault();

                objfirstname.Text =       get_info.firstname;
                objsurname.Text =         get_info.surname;
                objuniversity.Text =      get_info.uni;
                objaddress.Text =         get_info.permanent_address;
                objcertificates.Text =    get_info.certifications;
                objhighschool.Text =      get_info.high_school;
                objsecondaryschool.Text = get_info.sec_school;

                MessageBox.Show("You clicked on edit ! ");
            }

            //else if(col_header == " DELETE INFORMATION ")
            //{
            //     DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            //     // row.Cells.Clear();
                
            //    MessageBox.Show("You clicked  on delete ! ");

            //}
            //else
            //{
            //    MessageBox.Show("No information available ");
            //}





            //int col_index = e.ColumnIndex;
            //string col_header = dataGridView1.Columns[col_index].HeaderText;

            //if (col_header == "act_edit")
            //{
            //    dataGridView1.Columns.Clear();


                //DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
               
                //resume_get_info myobjstu = data_entered_by_user_list.Where(x => x.phone_number == "1234").FirstOrDefault();
                //data_entered_by_user_list.Remove(myobjstu);
                //MessageBox.Show(" record deleted successfully");
                //dataGridView1.Refresh();

            //}

            //put object's data in the control
            //if(dataGridView1.SelectedRows.Count!= 0)
            // {
            //     DataGridViewRow rowq = this.dataGridView1.SelectedRows[0];
            //     rowq.Cells["Firstname "].Value.ToString();
            // }
            // DataGridViewColumn column = dataGridView1.Columns[e.ColumnIndex];
            //txtID.Text = row.Cells[0].Value.ToString();
            //txtName.Text = row.Cells[1].Value.ToString();
            //txtCountry.Text = row.Cells[2].Value.ToString();
            //}

            //if(col_header == "act_delete")
            //{
            //    DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
            //    DataGridViewColumn column = dataGridView1.Columns[e.ColumnIndex];
            //    //object ka data control


        }









        private void btn_update_click(object sender, EventArgs e)
        {        
            






            //    resume_get_info get_info = new resume_get_info();
            //    DialogResult ar = MessageBox.Show("Are you sure you want to update ?", "Confirm",
            //    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //if (ar == DialogResult.Yes)
            //{
            //    MessageBox.Show(" click on any row in the datagrid and edit it ! ");
            //    this.dataGridView1.AllowUserToAddRows = true;
            //    this.dataGridView1.AllowUserToOrderColumns = true;
            //    this.dataGridView1.AllowUserToResizeRows = true;
            //   //index = dataGridView1.CurrentCell.RowIndex;
            //   // dataGridView1.Rows.RemoveAt(index);
            //}           
        }









        private void add_photo_click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                get_image.Image = new Bitmap(opnfd.FileName);
                //put the path of the image here in var from global
                string file_path = opnfd.FileName;
            }

        }     
        private void save_btn_click(object sender, EventArgs e)
        {
           MemoryStream mmst = new MemoryStream();
           get_image.Image.Save(mmst, get_image.Image.RawFormat);
           byte[] img = mmst.ToArray();
           dataGridView2.Rows.Add(img);
          // student objstudent = mystudent.Where(x => x.rollnumber == rolldel).FirstOrDefault(); 
        }
    }
}
