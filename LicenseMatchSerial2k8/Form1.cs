using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LicenseMatchSerial2k8
{
    partial class Form1 : Form
    {
        List<VersionDates.Version> IB_versions = new List<VersionDates.Version>();
        List<VersionDates.Version> ITE_versions = new List<VersionDates.Version>();

        List<VersionDates.Version> IB_versionsValid = new List<VersionDates.Version>();
        List<VersionDates.Version> ITE_versionsValid = new List<VersionDates.Version>();

        DateTime currentDeviceLicenseDateGraced = new DateTime();
        DateTime currentDeviceLicenseDate = new DateTime();
        VersionDates.Version IB_latest = null;
        VersionDates.Version ITE_latest = null;

        void LoadVersions()
        {
            if (!System.IO.File.Exists("VersionDates.xml"))
                MessageBox.Show("Missing \"VersionDates.xml\"");
            VersionDates.app_versions myAppVersions = new VersionDates.app_versions("VersionDates.xml");

            IB_versions = myAppVersions.IB_versions;
            ITE_versions = myAppVersions.ITE_versions;

            listBox1.Items.Clear();
            foreach (VersionDates.Version ite in ITE_versions)
            {
                listBox1.Items.Add(ite);
            }
            foreach (VersionDates.Version ib in IB_versions)
            {
                listBox1.Items.Add(ib);
            }
        }
        
        void LoadVersionsValid()
        {
            getLatest(currentDeviceLicenseDateGraced);
            listBox1.Items.Clear();
            foreach (VersionDates.Version ite in ITE_versionsValid)
            {
                listBox1.Items.Add(ite);
            }
            foreach (VersionDates.Version ib in IB_versionsValid)
            {
                listBox1.Items.Add(ib);
            }
        }

        public Form1()
        {
            this.InitializeComponent();
            LoadVersions();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (this.textBox1.Text.Length == 11)
                this.btnSearch.Enabled = true;
            else
                this.btnSearch.Enabled = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //reset
            IB_latest = null;
            ITE_latest = null;
            currentDeviceLicenseDateGraced = new DateTime();
            currentDeviceLicenseDate = new DateTime();

            int serialJulianDay=0;
            int serialYear=2000;
            try
            {
                serialJulianDay = (int)Convert.ToInt16(this.textBox1.Text.Substring(0, 3));
                serialYear = (int)Convert.ToInt16(this.textBox1.Text.Substring(4, 2));
            }
            catch (Exception ex)
            {
                int num = (int)MessageBox.Show("Serial number has invalid format. "+ex.Message);
                return;
            }
            /*
            Below is an example of a serial number of a legacy unit and a break down of what the different digits of the serial number represent.
            SN: 146110580XX

            Julian Date     location     year   sequential unit number
                 146          1           10    580XX                       manufactured May 26, 2010
            */
            int serialLicenseJulianDayGraced = serialJulianDay + 120;
            int serialLicenseYear = serialYear + 2000;

            DateTime dtLicense = new DateTime(serialLicenseYear, 1, 1).AddDays(serialJulianDay - 1);
            txtManufDate.Text = dtLicense.ToString("yyyy-MM-dd");
            currentDeviceLicenseDate = dtLicense;

            if (serialLicenseJulianDayGraced > 365)
            {
                serialLicenseJulianDayGraced -= 365;
                ++serialLicenseYear;
            }
            DateTime dtLicenseGraced = new DateTime(serialLicenseYear, 1, 1).AddDays(serialLicenseJulianDayGraced - 1);
            txtGracedLicenseDay.Text= dtLicenseGraced.ToString("yyyy-MM-dd");
            currentDeviceLicenseDateGraced = dtLicenseGraced;

            getLatest(currentDeviceLicenseDateGraced);
            listBox1.Refresh();
        }

        void getLatest(DateTime dtGraced)
        {
            IB_versionsValid.Clear();
            ITE_versionsValid.Clear();

            foreach(VersionDates.Version ib in IB_versions)
            {
                if (ib.DateReleased <= dtGraced)
                {
                    IB_versionsValid.Add(ib);
                    if (IB_latest == null)
                        IB_latest = ib;
                    else if (IB_latest.DateReleased < ib.DateReleased)
                        IB_latest = ib;
                }
            }
            foreach (VersionDates.Version ite in ITE_versions)
            {
                if (ite.DateReleased <= dtGraced) {
                    System.Diagnostics.Debug.WriteLine(ite.DateReleased.ToString("dd-MM-yyyy") + " <= " + dtGraced.ToString("dd-MM-yyyy") + ":\n\t Add valid: " + ite.ToString());
                    ITE_versionsValid.Add(ite);
                    if (ITE_latest == null)
                        ITE_latest = ite;
                    else if (ITE_latest.DateReleased < ite.DateReleased)
                        ITE_latest = ite;
                }
            }

            if (IB_latest != null)
            {
                lbl_IBDate.Text = IB_latest.DateString;
                lbl_IBVersion.Text = IB_latest.Number;
                lbl_IBNotes.Text = IB_latest.Notes;
                lbl_IBDate.Visible = true;
                lbl_IBVersion.Visible = true;
                lbl_IBNotes.Visible = true;
            }
            if (ITE_latest != null)
            {
                lbl_ITEDate.Text = ITE_latest.DateString;
                lbl_ITEVersion.Text = ITE_latest.Number;
                lbl_ITENotes.Text = ITE_latest.Notes;
                lbl_ITEDate.Visible = true;
                lbl_ITEVersion.Visible = true;
                lbl_ITENotes.Visible = true;
                
            }
        }

        private void listBox1_DrawItem(object sender,
          DrawItemEventArgs e)
        {
            //
            // Draw the background of the ListBox control for each item.
            // Create a new Brush and initialize to a Black colored brush
            // by default.
            //
            e.DrawBackground();
            Brush myBrush = Brushes.Black;

            Brush brushBlack = Brushes.Black;
            Brush brushGreen = Brushes.Green;
            Brush brushGray = Brushes.Gray;

            VersionDates.Version currentItem = (VersionDates.Version)listBox1.Items[e.Index];
            //is the device date before the software release date?
            if (currentItem.DateReleased <= currentDeviceLicenseDateGraced)
            {
                myBrush = brushGreen;
                if (currentItem.Notes.StartsWith("IB") || currentItem.Notes.StartsWith("EB"))
                {
                    if(IB_latest==null)
                        IB_latest = currentItem;
                    else if(IB_latest.DateReleased < currentItem.DateReleased)//current is newer entry?
                        IB_latest = currentItem;
                }
                if (currentItem.Notes.StartsWith("TE") || currentItem.Notes.StartsWith("ITE"))
                {
                    if (ITE_latest == null)
                        ITE_latest = currentItem;
                    else if (ITE_latest.DateReleased < currentItem.DateReleased)//current is newer entry?
                        ITE_latest = currentItem;
                }
            }
            else
                myBrush = brushGray;

                //
                // Draw the current item text based on the current 
                // Font and the custom brush settings.
                //
                e.Graphics.DrawString(((ListBox)sender).Items[e.Index].ToString(),
                e.Font, myBrush, e.Bounds, StringFormat.GenericDefault);
            //
            // If the ListBox has focus, draw a focus rectangle 
            // around the selected item.
            //
            e.DrawFocusRectangle();
        }

        private void btn_Copy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox1.Text + ", graced license date: " + txtManufDate.Text + ", \r\nIB/EB: " +
                IB_latest.ToString() + "; \r\nTE/ITE: " + ITE_latest.ToString(),TextDataFormat.UnicodeText);
            System.Diagnostics.Debug.WriteLine("Clipboard=\r\n" + textBox1.Text + ", graced license date: " + txtManufDate.Text + ", \r\nIB/EB: " +
                IB_latest.ToString() + "; \r\nTE/ITE: " + ITE_latest.ToString());
        }

        private void checkBox1_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                LoadVersionsValid();
            else
                LoadVersions();
        }
    }
}

