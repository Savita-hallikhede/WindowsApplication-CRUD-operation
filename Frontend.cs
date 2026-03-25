using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.LinkLabel;

namespace WindowsFormsApp1
{
    public partial class Econtact : Form
    {
        public Econtact()
        {
            InitializeComponent();
        }






        private void ADD_Click(object sender, EventArgs e)
        {
            btn_add.Visible = false;
            btn_edit.Visible = true;
            btn_save.Visible = true;
            btn_update.Visible = false;
            btn_edit.Enabled = false;
            btn_add.Enabled = true;
            btn_delete.Enabled = false;
            btn_Clear.Enabled = true;

            txt_Fname.ReadOnly = false; txt_Lname.ReadOnly = false;
            txt_Contactno.ReadOnly = false;
            txt_address.ReadOnly = false;



            txt_Fname.Enabled = true; txt_Lname.Enabled = true;
            txt_Contactno.Enabled = true;
            txt_address.Enabled = true;
            combo_gender.Enabled = true;
            clear();
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            Defaulttdata();
        }

        public void clear()
        {
            txt_Fname.Text = "";
            txt_Lname.Text = "";
            txt_Contactno.Text = "";
            txt_address.Text = "";
            combo_gender.SelectedIndex = 0;

        }

        private void Econtact_Load(object sender, EventArgs e)

        {
           btn_save.Visible = false;
            btn_add.Visible = true;
            btn_update.Visible = false;
            combo_gender.SelectedIndex = 0;

            Display();

            Defaulttdata();

        }


        public void Display()
        {
            btn_update.Visible = false;
            btn_save.Visible = false;
            btn_add.Visible = true;


            var SQlCon = Connection();

            SQlCon.Open();
            //string query = "Select*from Table_Contact";
            string query = "Sp_GetInfo";



            SqlCommand sqlCommand = new SqlCommand(query, SQlCon);

            sqlCommand.CommandType = CommandType.StoredProcedure;
           //
           //sqlCommand.Parameters.AddWithValue("", txt__search.Text)

          


            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

            DataSet dbset = new DataSet();

            sqlDataAdapter.Fill(dbset);

            gv_display.DataSource = dbset.Tables[0];

           


        }

        public SqlConnection Connection()
        {

            string Con = ConfigurationManager.ConnectionStrings["MY_REG_CON"].ConnectionString;
            SqlConnection SQlCon = new SqlConnection(Con);



            return SQlCon;
        }
             


        public void Defaulttdata()
        {
            btn_update.Visible = false;
            lbl_id.Text = "";
            txt_Fname.Text = "";
            txt_Lname.Text = "";
            txt_Contactno.Text = "";
            txt_address.Text = "";
            combo_gender.SelectedIndex = 0;

            lbl_id.Visible = false;

            txt_Fname.Enabled = true; txt_Lname.Enabled = true;
            txt_Contactno.Enabled = true;
            txt_address.Enabled = true;
            combo_gender.Enabled = true;

            txt_Fname.ReadOnly = false;
            txt_Lname.ReadOnly = false;
            txt_address.ReadOnly = false;
            txt_Contactno.ReadOnly = false;
            btn_add.Visible = true;
            btn_save.Visible = false;
            btn_edit.Enabled = false;
            btn_delete.Enabled = false;

            btn_edit.Visible = true;

        }


        private void gv_display_SelectionChanged(object sender, EventArgs e)
        {
            Reg_properties datapropert = new Reg_properties();

            if (gv_display.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in gv_display.SelectedRows)
                {

                    datapropert.contact_Id = Convert.ToInt32(row.Cells[0].Value);
                    datapropert.First_name = row.Cells["First_name"].Value.ToString();
                    datapropert.Last_name = row.Cells["Last_name"].Value.ToString();
                    datapropert.Contact_No = Convert.ToInt64(row.Cells["Contact_no"].Value.ToString());
                    datapropert.Address = row.Cells["Address"].Value.ToString();
                    datapropert.Gender = row.Cells[5].Value.ToString();
                  
                }

                lbl_id.Text = datapropert.contact_Id.ToString();
                
                txt_Fname.Text = datapropert.First_name;
                txt_Fname.ReadOnly = true;
                txt_Fname.Enabled = false;
                combo_gender.Enabled = false;


                txt_Lname.Text = datapropert.Last_name;
                txt_Lname.ReadOnly = true;
                txt_Lname.Enabled = false;

                txt_Fname.Enabled = false;
                txt_Contactno.Text = Convert.ToString(datapropert.Contact_No);
                txt_Contactno.ReadOnly = true;
                txt_Contactno.Enabled = false;
                txt_address.Text = datapropert.Address;
                txt_address.ReadOnly = true;
                txt_address.Enabled = false;

                var Gendervalue = datapropert.Gender.ToUpper().TrimEnd();

                if (datapropert.Gender.ToUpper().TrimEnd() == "MALE")
                {
                    combo_gender.SelectedIndex = 1;
                }
                else if (datapropert.Gender.ToUpper().TrimEnd() == "FEMALE")
                {
                    combo_gender.SelectedIndex = 2;
                }
                else
                {
                    combo_gender.SelectedIndex = 3;
                }
                btn_update.Visible = false;
                btn_edit.Visible = true;
                btn_add.Visible = true;
                btn_save.Visible = false;
                        

                btn_delete.Enabled = true;
                btn_update.Enabled = false;
                btn_edit.Enabled = true;
                btn_add.Enabled = true;
                
            }









        }
        //1.we should interact the database
        //     A: need connection string data
        //      create obj of sql connection using connection string data


        //string Con = "Data Source=.;Initial Catalog=Econtact; User Id=sa ;Password=Soumya@123;Integrated Security=False";
        //SqlConnection SQlCon = new SqlConnection(Con);

        //SQlCon.Open();




        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (lbl_id.Text != "" || lbl_id.Text != string.Empty)
            {

                SqlConnection SqlCon_obj = Connection();
                SqlCon_obj.Open();

                string query = "delete from Table_Contact where contact_Id = '" + lbl_id.Text + "' ";

                SqlCommand SQlcmd = new SqlCommand(query, SqlCon_obj);

                SQlcmd.CommandType = CommandType.Text;

                int Count_affectedRows = SQlcmd.ExecuteNonQuery();

                if (Count_affectedRows > 0)
                {
                    MessageBox.Show("your information deleted succesfully in database", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                Display();

                Defaulttdata();
            }
            else
            {
                MessageBox.Show("Please select the record for deleting oparation", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }







        private void btn_update_Click(object sender, EventArgs e)
        {
           
           Reg_properties obj = new Reg_properties();

            obj.First_name = txt_Fname.Text;
            obj.Last_name = txt_Lname.Text;
            obj.Contact_No = Convert.ToInt64(txt_Contactno.Text);
            obj.Address = txt_address.Text;
            obj.Gender = combo_gender.Text;
            obj.contact_Id= Convert.ToInt32(lbl_id.Text);

            var SQlCon = Connection();
            SQlCon.Open();

            string query = "Sp_Update";
            SqlCommand sqlCommand = new SqlCommand(query, SQlCon);

            sqlCommand.Parameters.AddWithValue("@First_name", obj.First_name);
            sqlCommand.Parameters.AddWithValue("@Last_name", obj.Last_name);
            sqlCommand.Parameters.AddWithValue("@Contact_No", obj.Contact_No);
            sqlCommand.Parameters.AddWithValue("@Address", obj.Address);
            sqlCommand.Parameters.AddWithValue("@Gender", obj.Gender);
            sqlCommand.Parameters.AddWithValue("@contact_Id", obj.contact_Id);

            sqlCommand.CommandType = CommandType.StoredProcedure;

            int a = sqlCommand.ExecuteNonQuery();

            if (a > 0)
            {
                MessageBox.Show("your updated information saved succesfully in database", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            Display();
            Defaulttdata();
        }












        private void btn_edit_Click(object sender, EventArgs e)
        {
            btn_edit.Visible=false;
            btn_update.Visible=true;   

            btn_add.Enabled=false;
            btn_delete.Enabled = false;
            btn_Clear.Enabled = false;
            btn_update.Enabled = true;
            txt_Fname.ReadOnly = false; txt_Lname.ReadOnly = false;
            txt_Contactno.ReadOnly = false;
            txt_address.ReadOnly = false;
           


            txt_Fname.Enabled = true; txt_Lname.Enabled = true;
            txt_Contactno.Enabled = true;
            txt_address.Enabled = true;
            combo_gender.Enabled = true;

        }

        private void txt_Fname_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            Reg_properties obj = new Reg_properties();

            obj.First_name = txt_Fname.Text;
            obj.Last_name = txt_Lname.Text;
            obj.Contact_No = Convert.ToInt64(txt_Contactno.Text);
            obj.Address = txt_address.Text;
            obj.Gender = combo_gender.Text;

            var SQlCon = Connection();
            SQlCon.Open();

            //Third Approach Used: Stored Procedure with Parameters

            string query = "sending_user_data";

            SqlCommand sqlCommand = new SqlCommand(query, SQlCon);

            sqlCommand.Parameters.AddWithValue("@Fname", obj.First_name);
            sqlCommand.Parameters.AddWithValue("@lastName", obj.Last_name);
            sqlCommand.Parameters.AddWithValue("@Contactno", obj.Contact_No);
            sqlCommand.Parameters.AddWithValue("@address", obj.Address);
            sqlCommand.Parameters.AddWithValue("@Gender", obj.Gender);

            sqlCommand.CommandType = CommandType.StoredProcedure;

            int a = sqlCommand.ExecuteNonQuery();

            if (a > 0)
            {
                MessageBox.Show("your information saved succesfully in database", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


            clear();
            Display();
         }
















       

        private void btn_search_Click(object sender, EventArgs e)
        {
            var SQlCon = Connection();
            SQlCon.Open();
            string query = "Soumya_Table_Firstname_filter";
            SqlCommand sqlCommand= new SqlCommand(query, SQlCon);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@FValue", txt__search.Text);

            
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);   
            DataSet dbset = new DataSet();  
            sqlDataAdapter.Fill(dbset);
            gv_display.DataSource = dbset.Tables[0];

        }
      }
    }
