using System.Windows.Forms;

namespace LicenseMatchSerial2k8
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private Button btnSearch;
        private TextBox textBox1;
        private Label label1;
        private Label lblVersion;
        private Label lbl_ITEVersion;
        private Label lblDate;
        private Label lbl_ITEDate;
        private Label lblNotes;
        private Label lbl_ITENotes;
        private ListBox listBox1;
        private TextBox txtManufDate;
        private Label label2;
        private Label lbl_IBVersion;
        private Label lbl_IBDate;
        private Label lbl_IBNotes;
        private Label label3;
        private Label label4;
        private TextBox txtGracedLicenseDay;
        private Button btn_Copy;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSearch = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lbl_ITEVersion = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lbl_ITEDate = new System.Windows.Forms.Label();
            this.lblNotes = new System.Windows.Forms.Label();
            this.lbl_ITENotes = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtManufDate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_IBVersion = new System.Windows.Forms.Label();
            this.lbl_IBDate = new System.Windows.Forms.Label();
            this.lbl_IBNotes = new System.Windows.Forms.Label();
            this.txtGracedLicenseDay = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Copy = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Enabled = false;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnSearch.Location = new System.Drawing.Point(184, 35);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(80, 42);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Get Latest";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 45);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(166, 23);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "146110580XX";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Location = new System.Drawing.Point(9, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter Serial Number";
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersion.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblVersion.Location = new System.Drawing.Point(10, 85);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(60, 17);
            this.lblVersion.TabIndex = 8;
            this.lblVersion.Text = "Version:";
            // 
            // lbl_ITEVersion
            // 
            this.lbl_ITEVersion.AutoSize = true;
            this.lbl_ITEVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ITEVersion.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbl_ITEVersion.Location = new System.Drawing.Point(10, 103);
            this.lbl_ITEVersion.Name = "lbl_ITEVersion";
            this.lbl_ITEVersion.Size = new System.Drawing.Size(54, 17);
            this.lbl_ITEVersion.TabIndex = 9;
            this.lbl_ITEVersion.Text = "version";
            this.lbl_ITEVersion.Visible = false;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblDate.Location = new System.Drawing.Point(118, 85);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(42, 17);
            this.lblDate.TabIndex = 10;
            this.lblDate.Text = "Date:";
            // 
            // lbl_ITEDate
            // 
            this.lbl_ITEDate.AutoSize = true;
            this.lbl_ITEDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ITEDate.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbl_ITEDate.Location = new System.Drawing.Point(118, 103);
            this.lbl_ITEDate.Name = "lbl_ITEDate";
            this.lbl_ITEDate.Size = new System.Drawing.Size(36, 17);
            this.lbl_ITEDate.TabIndex = 11;
            this.lbl_ITEDate.Text = "date";
            this.lbl_ITEDate.Visible = false;
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotes.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblNotes.Location = new System.Drawing.Point(236, 85);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(49, 17);
            this.lblNotes.TabIndex = 12;
            this.lblNotes.Text = "Notes:";
            // 
            // lbl_ITENotes
            // 
            this.lbl_ITENotes.AutoSize = true;
            this.lbl_ITENotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ITENotes.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbl_ITENotes.Location = new System.Drawing.Point(236, 103);
            this.lbl_ITENotes.Name = "lbl_ITENotes";
            this.lbl_ITENotes.Size = new System.Drawing.Size(43, 17);
            this.lbl_ITENotes.TabIndex = 13;
            this.lbl_ITENotes.Text = "notes";
            this.lbl_ITENotes.Visible = false;
            // 
            // listBox1
            // 
            this.listBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 175);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBox1.Size = new System.Drawing.Size(770, 324);
            this.listBox1.TabIndex = 14;
            this.listBox1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listBox1_DrawItem);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Window;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label3.Location = new System.Drawing.Point(270, 516);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(512, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "*This application does not take into account the extra day in a leap year.";
            // 
            // txtManufDate
            // 
            this.txtManufDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtManufDate.Location = new System.Drawing.Point(282, 45);
            this.txtManufDate.Name = "txtManufDate";
            this.txtManufDate.ReadOnly = true;
            this.txtManufDate.Size = new System.Drawing.Size(166, 23);
            this.txtManufDate.TabIndex = 1;
            this.txtManufDate.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label2.Location = new System.Drawing.Point(279, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Manufactoring date:";
            // 
            // lbl_IBVersion
            // 
            this.lbl_IBVersion.AutoSize = true;
            this.lbl_IBVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_IBVersion.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbl_IBVersion.Location = new System.Drawing.Point(9, 120);
            this.lbl_IBVersion.Name = "lbl_IBVersion";
            this.lbl_IBVersion.Size = new System.Drawing.Size(54, 17);
            this.lbl_IBVersion.TabIndex = 9;
            this.lbl_IBVersion.Text = "version";
            this.lbl_IBVersion.Visible = false;
            // 
            // lbl_IBDate
            // 
            this.lbl_IBDate.AutoSize = true;
            this.lbl_IBDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_IBDate.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbl_IBDate.Location = new System.Drawing.Point(117, 120);
            this.lbl_IBDate.Name = "lbl_IBDate";
            this.lbl_IBDate.Size = new System.Drawing.Size(36, 17);
            this.lbl_IBDate.TabIndex = 11;
            this.lbl_IBDate.Text = "date";
            this.lbl_IBDate.Visible = false;
            // 
            // lbl_IBNotes
            // 
            this.lbl_IBNotes.AutoSize = true;
            this.lbl_IBNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_IBNotes.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbl_IBNotes.Location = new System.Drawing.Point(235, 120);
            this.lbl_IBNotes.Name = "lbl_IBNotes";
            this.lbl_IBNotes.Size = new System.Drawing.Size(43, 17);
            this.lbl_IBNotes.TabIndex = 13;
            this.lbl_IBNotes.Text = "notes";
            this.lbl_IBNotes.Visible = false;
            // 
            // txtGracedLicenseDay
            // 
            this.txtGracedLicenseDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGracedLicenseDay.Location = new System.Drawing.Point(454, 45);
            this.txtGracedLicenseDay.Name = "txtGracedLicenseDay";
            this.txtGracedLicenseDay.ReadOnly = true;
            this.txtGracedLicenseDay.Size = new System.Drawing.Size(166, 23);
            this.txtGracedLicenseDay.TabIndex = 1;
            this.txtGracedLicenseDay.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label4.Location = new System.Drawing.Point(451, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Graced License date:";
            // 
            // btn_Copy
            // 
            this.btn_Copy.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Copy.Location = new System.Drawing.Point(702, 146);
            this.btn_Copy.Name = "btn_Copy";
            this.btn_Copy.Size = new System.Drawing.Size(80, 23);
            this.btn_Copy.TabIndex = 16;
            this.btn_Copy.Text = "copy";
            this.btn_Copy.UseVisualStyleBackColor = true;
            this.btn_Copy.Click += new System.EventHandler(this.btn_Copy_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBox1.Location = new System.Drawing.Point(531, 148);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(98, 17);
            this.checkBox1.TabIndex = 17;
            this.checkBox1.Text = "show valid only";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckStateChanged += new System.EventHandler(this.checkBox1_CheckStateChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(794, 545);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btn_Copy);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lbl_IBNotes);
            this.Controls.Add(this.lbl_ITENotes);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.lbl_IBDate);
            this.Controls.Add(this.lbl_ITEDate);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lbl_IBVersion);
            this.Controls.Add(this.lbl_ITEVersion);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtGracedLicenseDay);
            this.Controls.Add(this.txtManufDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnSearch);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CheckBox checkBox1;
    }
}

