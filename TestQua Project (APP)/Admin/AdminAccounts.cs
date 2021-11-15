﻿using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TestQua_Project__APP_.Admin
{
   public partial class AdminAccounts : Form
   {
      public AdminAccounts()
      {
         InitializeComponent();
      }

      private void dataviewAccounts()
      {
         Connection.DB();
         Function.gen = "SELECT role.rolename as [ROLE NAME], userinformation.userid, userinformation.roleid, userinformation.profilepicture, userinformation.firstname AS [FIRST NAME], userinformation.lastname AS [LAST NAME], userinformation.username AS [USERNAME], userinformation.password AS [PASSWORD], userinformation.age As [AGE], userinformation.contactno AS [CONTACT NO.], userinformation.address AS [ADDRESS], userinformation.gender AS [GENDER], userinformation.email AS [EMAIL], userinformation.dateregistered AS [DATE REGISTERED]  FROM UserInformation INNER JOIN Role ON Role.RoleId = UserInformation.RoleId";
         Function.fill(Function.gen, viewAccounts);
         viewAccounts.Columns["roleid"].Visible = false;
         viewAccounts.Columns["ProfilePicture"].Visible = false;
         viewAccounts.Columns["Userid"].Visible = false;
      }

      private void btnAccounts_Click(object sender, EventArgs e)
      {
         tabcontrolAdminAccounts.Show();
         btnAccounts.FlatStyle = FlatStyle.Standard;
      }

      private void btnLogout_Click(object sender, EventArgs e)
      {
         var homepage = new Homepage();
         homepage.Show();
         Hide();
      }

      private void AdminAccounts_Load(object sender, EventArgs e)
      {
         updateButtons(false);
         btnSave.Enabled = true;
         btnAccounts.FlatStyle = FlatStyle.Standard;
         dataviewAccounts();
      }

      private void btnProducts_Click(object sender, EventArgs e)
      {
         var adminproduct = new AdminProduct();
         adminproduct.Show();
         Hide();
      }

      private void viewAccounts_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
      {
         try
         {
            txtUserid.Text = viewAccounts.Rows[e.RowIndex].Cells["userid"].Value.ToString();
            txtRoleId.Text = viewAccounts.Rows[e.RowIndex].Cells["roleid"].Value.ToString();
            txtFirstname.Text = viewAccounts.Rows[e.RowIndex].Cells["FIRST NAME"].Value.ToString();
            txtLastname.Text = viewAccounts.Rows[e.RowIndex].Cells["LAST NAME"].Value.ToString();
            txtAge.Text = viewAccounts.Rows[e.RowIndex].Cells["AGE"].Value.ToString();
            txtAddress.Text = viewAccounts.Rows[e.RowIndex].Cells["ADDRESS"].Value.ToString();
            cmbGender.Text = viewAccounts.Rows[e.RowIndex].Cells["GENDER"].Value.ToString();
            txtEmail.Text = viewAccounts.Rows[e.RowIndex].Cells["EMAIL"].Value.ToString();
            txtUsername.Text = viewAccounts.Rows[e.RowIndex].Cells["USERNAME"].Value.ToString();
            txtPassword.Text = viewAccounts.Rows[e.RowIndex].Cells["PASSWORD"].Value.ToString();
            txtContacno.Text = viewAccounts.Rows[e.RowIndex].Cells["CONTACT NO."].Value.ToString();

            if (txtRoleId.Text.Equals("1"))
            {
               cmbRole.Text = "Admin";
            }
            else if (txtRoleId.Text.Equals("2"))
            {
               cmbRole.Text = "Customer";
            }
            else
            {
               cmbRole.Text = "Supplier";
            }

            updateButtons(true);
            btnSave.Enabled = false;
            tabcontrolAdminAccounts.SelectedIndex = 0;
         }

         catch (Exception ex)
         {
            MessageBox.Show(ex.Message);
         }
      }

      private void updateButtons(bool status)
      {
         btnUpdate.Enabled = status;
         btnDelete.Enabled = status;

         if (status == false)
            btnSave.Enabled = true;
         else
            btnSave.Enabled = false;
      }

      private void btnSave_Click(object sender, EventArgs e)
      {
         int roleid = 0;

         if (cmbGender.Text.Equals("Admin"))
         {
            roleid = 1;
         }
         else if (cmbGender.Text.Equals("Customer"))
         {
            roleid = 2;
         }
         else
         {
            roleid = 3;
         }

         try
         {
            Connection.DB();
            Function.gen = "INSERT INTO UserInformation(RoleId, Firstname, Lastname, Age, Address, Gender, Email, DateRegistered, Username, Password, ContactNo) VALUES('" + roleid + "', '" + txtFirstname.Text + "', '" + txtLastname.Text + "', '" + txtAge.Text + "', '" + txtAddress.Text + "', '" + cmbGender.Text + "', '" + txtEmail.Text + "', '" + DateTime.Now.ToString() + "', '" + txtUsername.Text + "', '" + txtPassword.Text + "', '" + txtContacno.Text + "')";
            Function.command = new SqlCommand(Function.gen, Connection.con);
            Function.command.ExecuteNonQuery();
            MessageBox.Show("Registration success.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Connection.con.Close();

            dataviewAccounts();
            resetFields();
            updateButtons(false);
         }

         catch (Exception ex)
         {
            MessageBox.Show(ex.Message);
         }
      }

      private void btnUpdate_Click(object sender, EventArgs e)
      {
         try
         {
            Connection.DB();
            Function.gen = "UPDATE Userinformation SET Firstname = '" + txtFirstname.Text + "', Lastname = '" + txtLastname.Text + "', Age = '" + txtAge.Text + "', Address = '" + txtAddress.Text + "', Gender = '" + cmbGender.Text + "', email = '" + txtEmail.Text + "', password = '" + txtPassword.Text + "', contactno = '" + txtContacno.Text + "' WHERE Userid = '" + txtUserid.Text + "' ";
            Function.command = new SqlCommand(Function.gen, Connection.con);
            Function.command.ExecuteNonQuery();
            MessageBox.Show("Update success.", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Connection.con.Close();
            updateButtons(false);
            resetFields();
            dataviewAccounts();
         }

         catch (Exception ex)
         {
            MessageBox.Show(ex.Message);
         }
      }

      private void btnDelete_Click(object sender, EventArgs e)
      {
         try
         {
            Connection.DB();
            var gen = MessageBox.Show("Are you sure you want to delete this record?", "Delete record", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (gen == DialogResult.Yes)
            {
               Function.gen = "DELETE FROM UserInformation WHERE UserId = '" + txtUserid.Text + "' ";
               Function.command = new SqlCommand(Function.gen, Connection.con);
               Function.command.ExecuteNonQuery();
               Connection.con.Close();
               updateButtons(false);
               resetFields();
               dataviewAccounts();
            }
         }

         catch (Exception ex)
         {
            MessageBox.Show(ex.Message);
         }
      }

      private void resetFields()
      {
         txtRoleId.Clear();
         txtUserid.Clear();
         txtFirstname.Clear();
         txtLastname.Clear();
         txtAddress.Clear();
         txtAge.Clear();
         txtContacno.Clear();
         txtEmail.Clear();
         txtUsername.Clear();
         txtPassword.Clear();

      }

      private void txtSearch_TextChanged(object sender, EventArgs e)
      {
         try
         {
            Function.gen = "SELECT * FROM UserInformation WHERE UserId LIKE '" + txtSearch.Text + "%' OR FirstName LIKE '" + txtSearch.Text + "%' OR LastName LIKE '" + txtSearch.Text + "%' OR Username LIKE '" + txtSearch.Text + "%' OR Email LIKE '" + txtSearch.Text + "%' OR RoleId LIKE '" + txtSearch.Text + "%' ";
            Function.fill(Function.gen, viewAccounts);
            //dataGridView1.Columns["userid"].Visible = false;
            viewAccounts.Columns["UserId"].Visible = false;
            viewAccounts.Columns["UserId"].Visible = false;
         }

         catch (Exception ex)
         {
            MessageBox.Show(ex.Message);
         }
      }

      private void btnHome_Click(object sender, EventArgs e)
      {
         var adminhome = new AdminHome();
         adminhome.Show();
         Close();
      }

      private void btnReports_Click(object sender, EventArgs e)
      {
         var adminreport = new AdminReport();
         adminreport.Show();
         Close();
      }
   }
}
/*
 DATAGRID 
  -Hide userid
  -Display Role name instead of ID
  -Hide Profile picture
 */