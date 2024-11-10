using SchoolBusiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Project
{
    public partial class frmAddUpdateUser : Form
    {

        private int? SelectedPersonID = null;
        private enum enMode { AddNew = 0, UpdateNew = 1 };
        private enMode _Mode = enMode.AddNew;

        private int? _UserID = null;

        private clsUsers _User;

        public clsPerson PersonInfo;

        public Action<int?> UserIDBack;



        public frmAddUpdateUser(int UserID,bool AllowtoEdit=true)
        {
            InitializeComponent();

            _UserID = UserID;

            txtPassword.Enabled = AllowtoEdit;
            txtConfirmPassword.Enabled = AllowtoEdit;

            _Mode = enMode.UpdateNew;
        }
        public frmAddUpdateUser()
        {
            InitializeComponent();

            _Mode = enMode.AddNew;
        }

        private void ResetDefaultValues()
        {

            if (_Mode == enMode.AddNew)
            {

                lblTitle.Text = "Add New Users";

                _User = new clsUsers();

                return;


            }
            else
            {
                lblTitle.Text = "Update Users ";
            }



        }
        private int CountPermissions()
        {


            int Permissions = 0;

            if (chkAdmin.Checked)
                return -1;

            if (chkAddUser.Checked)
                Permissions += (int)clsUsers.enPermissions.AddUser;

            if (chkUpdateUser.Checked)
                Permissions += (int)clsUsers.enPermissions.UpdateUser;

            if (chkDeleteUser.Checked)
                Permissions += (int)clsUsers.enPermissions.DeleteUser;

            if (chkListUsers.Checked)
                Permissions += (int)clsUsers.enPermissions.ListUsers;


            return Permissions;
        }
        private void FillCheckBoxPermissions()
        {

            if (_User.Permissions == -1)
            {

                chkAdmin.Checked = true;
                return;

            }

            foreach (var item in gbPermissions.Controls)
            {

                if (item is CheckBox chk)
                {

                    if (chk.Tag.ToString() != "-1")
                    {

                        if (((Convert.ToInt32(chk.Tag)) & _User.Permissions) == (Convert.ToInt32(chk.Tag)))
                        {
                            chk.Checked = true;
                        }

                    }

                }

            }
        }
        //this Method Check if there is no Permissions Selected ,otherwise false 
        private bool DoesNotSelectedAnyPermissions()
        {

            foreach (var item in gbPermissions.Controls)
            {

                if (item is CheckBox chk)
                {

                    if (chk.Checked)
                    {
                        return false;
                    }

                }

            }
            return true;
        }

        public void LoadUsersInfo()
        {

            ResetDefaultValues();

            _User = clsUsers.FindByUserID(_UserID);

            if (_User == null)
            {

                MessageBox.Show("No Users With UserID " + _UserID.ToString(), "Error"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }


            lblUserID.Text = _User.UserID.ToString();
            txtUsername.Text = _User.Username;
            txtPassword.Text = _User.Password;
            txtConfirmPassword.Text = _User.Password;
            chkActiveUser.Checked = _User.IsActive;
            ctrlPersonCardWithFilter1.LoadPersonInfo(_User.PersonID);
            FillCheckBoxPermissions();



          panelPassword.Visible = false;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (DoesNotSelectedAnyPermissions())
            {

                MessageBox.Show("You have to Select Permissions for the user ", "Permissions Error"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

         

            _User.PersonID = ctrlPersonCardWithFilter1.PersonID;
            _User.Username = txtUsername.Text;
            _User.Password = txtPassword.Text;
            _User.IsActive = chkActiveUser.Checked;
            _User.Permissions = CountPermissions();


            if (_Mode == enMode.AddNew)
            {
                _User.Password = clsGlobal.ComputeHash(txtPassword.Text);
            }

            if (_User.Save())
            {


                lblUserID.Text = _User.UserID.ToString();

                _Mode = enMode.UpdateNew;

                UserIDBack?.Invoke(_User.UserID);

                MessageBox.Show("Data Saved Sucessfully :-)", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                MessageBox.Show("Data not Saved  :-)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }



        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void frmAddUpdateUser_Load(object sender, EventArgs e)
        {
            ResetDefaultValues();


            if (_Mode == enMode.UpdateNew)
                LoadUsersInfo();



        }

        private void ctrlPersonCardWithFilter1_OnePersonSelected(object sender, ctrlPersonCardWithFilter.clsPersonSelectedEventArgs e)
        {



            //    if (!e.PersonID.HasValue)
            //    {


            //        tpUserData.Enabled = false;
            //        btnSave.Enabled = false;

            //        return;

            //    }


            //    if (_Mode == enMode.AddNew && ctrlPersonCardWithFilter1.SelectedPersonInfo.IsUser)
            //    {



            //        MessageBox.Show("Seelcted Persom Already has a User , Choose Onther One", "Selected Onther Person", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //        tpUserData.Enabled = false;
            //        btnSave.Enabled = false;

            //        return;

            //    }


            
        
    



            //SelectedPersonID = e.PersonID;

            //tpUserData.Enabled = true;
            //btnSave.Enabled = true;





        }

        private void txtUsername_Validating(object sender, CancelEventArgs e)
        {


            if(string.IsNullOrWhiteSpace(txtUsername.Text.Trim()))
            {

                e.Cancel = true;
                errorProvider1.SetError(txtUsername, "UserName can not be Blank");

                return;
            }
            else
            {
                errorProvider1.SetError(txtUsername, null);
            }


            if(txtUsername.Text.Trim()!=_User.Username && clsUsers.IsUserExist(txtUsername.Text.Trim()))
                {
                e.Cancel = true;
                errorProvider1.SetError(txtUsername, "UserName is Used By Onther User");
            }
            else
            {
                errorProvider1.SetError(txtUsername, null);
            }
        }

        private void txtConfirmPassword_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrEmpty(txtConfirmPassword.Text.Trim()))
            {

                e.Cancel = true;
                errorProvider1.SetError(txtConfirmPassword, "Confirm Password  can not be Blank");

                return;
            }
            else
            {
                errorProvider1.SetError(txtConfirmPassword, null);
            }



            if(txtPassword.Text.Trim()!=txtConfirmPassword.Text.Trim())
            {

                e.Cancel = true;
                errorProvider1.SetError(txtConfirmPassword, "Password Confiramation does not match Password ");

            }
            else
            {
                errorProvider1.SetError(txtConfirmPassword, null);
            }







        }
    }
}
