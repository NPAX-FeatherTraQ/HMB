using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace System.Windows.Forms.Wizard
{
    public partial class HMBLicense : Form
    {
        public HMBLicense(string srclicenseStatus)
        {
            InitializeComponent();
            lblLicenseStatus.Text = srclicenseStatus; //txtLicenseStatus

            RegistryKey src1 = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows Start");
            //RegistryKey src2 = Registry.CurrentUser.OpenSubKey(@"CONTROL PANEL\Microsoft");

            //lblValidityPeriod.Text = "New";

            // if (src1 != null /*&& src2 != null*/)
            // {
                 lblValidityPeriod.Text = (src1 == null ? srclicenseStatus == "New" ? string.Empty : "Activation date: " + (string)(src1.GetValue("WindowsStart")).ToString() + "\r\n" + "Expiration date: " + (string)(src1.GetValue("WindowsEnd")).ToString() : string.Empty);//lblValidityPeriod

                 //if (src1 != null)
                 //    src1.Close();
             //    //src2.Close();
             //}

            btnRenew.Visible = false;
            btnSetupLicenseRegistration.Visible = false;

            if (srclicenseStatus == "New")
            {
                lblLicenseStatus.ForeColor = Color.Green;
                btnSetupLicenseRegistration.Text = "Setup License Registration";
                lblPlsContact.Text = "Please contact the system provider for the License Registration.";
            }
            else
            {
                lblValidityPeriod.Text = " Activation date: " + (string)(src1.GetValue("WindowsStart")).ToString() + "\r\n Expiration date: " + (string)(src1.GetValue("WindowsEnd")).ToString();
                lblLicenseStatus.ForeColor = Color.Red;
                lblValidityPeriod.ForeColor = Color.Red;
                btnSetupLicenseRegistration.Text = "Setup License Renewal";
                lblPlsContact.Text = "License has expired." + "\r\n" + "HMB will now stop backing up your data/files."+ "\r\n" + "Please contact the system provider for the License Renewal.";
            }

            if (src1 != null)
            {
                txtLastRunningDate.Text = (string)(src1.GetValue("running")).ToString();
                src1.Close();
            }  

            //lblLicenseStatus.Refresh();
            txtAdminPassword.Visible = false;
            btnActivate.Text = srclicenseStatus == "New" ? "Activate" : "Renew";
            grpLicenseRegistration.Text = srclicenseStatus == "New" ? "License Registration" : "License Renewal";
            grpLicenseRegistration.Visible = false;

            //Hardware Information
            lblHardwareInfo.Text = "Processor ID      : " + HardwareInfo.GetCPUManufacturer() + " " + HardwareInfo.GetCpuSpeedInGHz() + "\r\n" + "HDD Serial No   : " + HardwareInfo.GetHDDSerialNo() + "\r\n" + "Board Maker      : " + HardwareInfo.GetBoardMaker() + "\r\n" + "Physical Memory: " + HardwareInfo.GetPhysicalMemory() + "\r\n" + "MAC Address     : " + HardwareInfo.GetMACAddress();

            try
            {
                //accessing the CurrentUser root element  
                RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows Start");

                //storing the values  
                if (key != null)
                {
                    if (Convert.ToDateTime(key.GetValue("running")) /*<=*/ > DateTime.Now)
                    {
                        //    txtLastRunningDate.Text = DateTime.Now.ToString();
                        //    key.SetValue("running", DateTime.Now);
                        //}
                        //else
                        //{
                        MessageBox.Show("HMB License is invalid! Please contact the system provider.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        txtLastRunningDate.Text = (string)(key.GetValue("running")).ToString();
                        return;
                    }
                    key.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }  


        }

        private void HMBLicense_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Environment.Exit(0);
            Application.Exit();
        }

        private void btnSetupLicenseRegistration_Click(object sender, EventArgs e)
        {
            btnSetupLicenseRegistration.Visible = false;
            txtAdminPassword.Visible = true;
            txtAdminPassword.Focus();
        }

        //private void lblNote_DoubleClick(object sender, EventArgs e)
        //{
        //    btnSetupLicenseRegistration.Visible = true;
        //}

        private void txtAdminPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtAdminPassword.Text.Trim() == (lblLicenseStatus.Text == "New" ? "$ys@d.HMb_*New" : "$ys@d.HMb_*Renew"))
                {
                    if (lblLicenseStatus.Text == "Invalid")
                    {
                        //accessing the CurrentUser root element  
                        RegistryKey key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\Microsoft\Windows Start");

                        //storing the values  
                        key.SetValue("running", DateTime.Now);
                        key.Close();

                        MessageBox.Show("Invalid HMB License has successfully corrected.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Dispose();
                    }
                    else
                    {
                        txtAdminPassword.Visible = false;
                        grpLicenseRegistration.Visible = true;
                        lblNote.Visible = false;
                        lblPlsContact.Visible = false;
                    }
                }
                else
                {
                    MessageBox.Show("Invalid License Key.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtAdminPassword.SelectionStart = 0;
                    txtAdminPassword.SelectionLength = txtAdminPassword.Text.Length;
                    return;
                }
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to cancel the HMB licensing?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                //this.Dispose();
                //Environment.Exit(0);
                Application.Exit();
            }
            else
            {
                return;
            }

            
        }

        private void cbNoOfMonths_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtValidUntil.Enabled = cbNoOfMonths.Text.Substring(0, 2) == "00" ? true : false;
            dtValidUntil.Value = DateTime.Now.AddMonths(Int32.Parse(cbNoOfMonths.Text.Substring(0,2)));
            lblValidityPeriod.Text = "Activation date: " + DateTime.Now + "\r\n"+ "Expiration date: " + dtValidUntil.Value; //lblValidityPeriod
            lblValidityPeriod.ForeColor = Color.Green;
            if (lblLicenseStatus.Text != "New")
            {
                lblLicenseStatus.Text = "Renewal";
                lblLicenseStatus.ForeColor = Color.Green;
            }
        }

        private void btnActivate_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cbNoOfMonths.Text))
            {
                DialogResult result = MessageBox.Show("Are you sure you want to " + btnActivate.Text + " the HMB License?" + "\r\n" + "\r\n" + "No. of Month(s): " + cbNoOfMonths.Text + "\r\n" + lblValidityPeriod.Text, this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2); //lblValidityPeriod

                if (result == DialogResult.Yes)
                {
                    //accessing the CurrentUser root element  
                    RegistryKey src1key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\Microsoft\Windows Start");
                    RegistryKey src2key = Registry.CurrentUser.CreateSubKey(@"CONTROL PANEL\Microsoft");

                    //storing the values  
                    DateTime DateNow = DateTime.Now;
                    DateTime ValidUntil = cbNoOfMonths.Text.Substring(0, 2) == "00" ? dtValidUntil.Value : DateTime.Now.AddMonths(Int32.Parse(cbNoOfMonths.Text.Substring(0,2)));

                    src1key.SetValue("WindowsStart", DateNow);
                    src1key.SetValue("WindowsEnd", ValidUntil);
                    src1key.SetValue("_ReadMe", "Modifying any value will cause a Windows problem");
                    src1key.SetValue("running", DateNow);

                    src2key.SetValue("WindowsStart", DateNow);
                    src2key.SetValue("WindowsEnd", ValidUntil);
                    src2key.SetValue("_ReadMe", "Modifying any value will cause a Windows problem");
                    //src2key.SetValue("Activated", DateNow);

                    src1key.Close();
                    src2key.Close();

                    string msginfo = lblLicenseStatus.Text == "New" ? "activated" : "renewed";
                    MessageBox.Show("HMB License successfully " + msginfo + ".", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //DialogResult = DialogResult.OK;

                    this.Hide();

                    //Application.Restart();
                    //Environment.Exit(0);

                    //this.Dispose();

                }
                //else return;
            }
            else
            {
                MessageBox.Show("No. of Month(s) is required.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
        }

        private void dtValidUntil_ValueChanged(object sender, EventArgs e)
        {
            if (dtValidUntil.Value > DateTime.Now.AddDays(5) && cbNoOfMonths.Text.Substring(0, 2) == "00")
            {
                MessageBox.Show("Expiration date must not be greater than 5 days from date today.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                dtValidUntil.Value = DateTime.Now;
                return;
            }
            else
            {
                lblValidityPeriod.Text = "Activation date: " + DateTime.Now + "\r\n" + "Expiration date: " + dtValidUntil.Value;
            }
        }

        private void HMBLicense_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.Shift && e.KeyCode == Keys.N)
            {
                btnSetupLicenseRegistration.Visible = true;
            }
        }

        private void lblNote_DoubleClick(object sender, EventArgs e)
        {
            btnSetupLicenseRegistration.Visible = true;
        }

    }
}
