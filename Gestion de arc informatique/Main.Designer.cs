﻿namespace Gestion_de_arc_informatique
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panelSideBar = new System.Windows.Forms.Panel();
            this.pictureBoxCreateInterv = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxMenu = new System.Windows.Forms.PictureBox();
            this.DateTimePickerInterv = new Siticone.Desktop.UI.WinForms.SiticoneDateTimePicker();
            this.TextBoxCommentary = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.ComboBoxStaff = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.ComboBoxMaterial = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CheckBoxStatus = new Siticone.Desktop.UI.WinForms.SiticoneCheckBox();
            this.ButtonCreateInterv = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.siticoneHtmlLabel1 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.panelSideBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCreateInterv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSideBar
            // 
            this.panelSideBar.BackColor = System.Drawing.Color.PowderBlue;
            this.panelSideBar.Controls.Add(this.pictureBoxCreateInterv);
            this.panelSideBar.Controls.Add(this.pictureBox1);
            this.panelSideBar.Controls.Add(this.pictureBoxMenu);
            this.panelSideBar.Location = new System.Drawing.Point(0, 0);
            this.panelSideBar.Margin = new System.Windows.Forms.Padding(4);
            this.panelSideBar.MaximumSize = new System.Drawing.Size(429, 897);
            this.panelSideBar.MinimumSize = new System.Drawing.Size(168, 897);
            this.panelSideBar.Name = "panelSideBar";
            this.panelSideBar.Size = new System.Drawing.Size(168, 897);
            this.panelSideBar.TabIndex = 0;
            // 
            // pictureBoxCreateInterv
            // 
            this.pictureBoxCreateInterv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxCreateInterv.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCreateInterv.Image")));
            this.pictureBoxCreateInterv.Location = new System.Drawing.Point(64, 203);
            this.pictureBoxCreateInterv.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxCreateInterv.Name = "pictureBoxCreateInterv";
            this.pictureBoxCreateInterv.Size = new System.Drawing.Size(52, 46);
            this.pictureBoxCreateInterv.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCreateInterv.TabIndex = 8;
            this.pictureBoxCreateInterv.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(64, 282);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // pictureBoxMenu
            // 
            this.pictureBoxMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxMenu.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMenu.Image")));
            this.pictureBoxMenu.Location = new System.Drawing.Point(53, 31);
            this.pictureBoxMenu.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxMenu.Name = "pictureBoxMenu";
            this.pictureBoxMenu.Size = new System.Drawing.Size(63, 54);
            this.pictureBoxMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMenu.TabIndex = 3;
            this.pictureBoxMenu.TabStop = false;
            this.pictureBoxMenu.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // DateTimePickerInterv
            // 
            this.DateTimePickerInterv.BorderRadius = 10;
            this.DateTimePickerInterv.Checked = true;
            this.DateTimePickerInterv.FillColor = System.Drawing.Color.White;
            this.DateTimePickerInterv.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DateTimePickerInterv.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DateTimePickerInterv.IndicateFocus = true;
            this.DateTimePickerInterv.Location = new System.Drawing.Point(781, 236);
            this.DateTimePickerInterv.Margin = new System.Windows.Forms.Padding(4);
            this.DateTimePickerInterv.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DateTimePickerInterv.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DateTimePickerInterv.Name = "DateTimePickerInterv";
            this.DateTimePickerInterv.Size = new System.Drawing.Size(248, 94);
            this.DateTimePickerInterv.TabIndex = 1;
            this.DateTimePickerInterv.Value = new System.DateTime(2024, 5, 6, 23, 46, 4, 392);
            // 
            // TextBoxCommentary
            // 
            this.TextBoxCommentary.Animated = true;
            this.TextBoxCommentary.BorderRadius = 10;
            this.TextBoxCommentary.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxCommentary.DefaultText = "";
            this.TextBoxCommentary.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxCommentary.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxCommentary.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxCommentary.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxCommentary.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxCommentary.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.TextBoxCommentary.ForeColor = System.Drawing.Color.Black;
            this.TextBoxCommentary.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxCommentary.Location = new System.Drawing.Point(270, 447);
            this.TextBoxCommentary.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxCommentary.Name = "TextBoxCommentary";
            this.TextBoxCommentary.PasswordChar = '\0';
            this.TextBoxCommentary.PlaceholderText = "";
            this.TextBoxCommentary.SelectedText = "";
            this.TextBoxCommentary.Size = new System.Drawing.Size(466, 140);
            this.TextBoxCommentary.TabIndex = 3;
            // 
            // ComboBoxStaff
            // 
            this.ComboBoxStaff.BackColor = System.Drawing.Color.Transparent;
            this.ComboBoxStaff.BorderRadius = 10;
            this.ComboBoxStaff.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBoxStaff.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxStaff.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboBoxStaff.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboBoxStaff.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComboBoxStaff.ForeColor = System.Drawing.Color.Black;
            this.ComboBoxStaff.ItemHeight = 30;
            this.ComboBoxStaff.Location = new System.Drawing.Point(270, 213);
            this.ComboBoxStaff.Margin = new System.Windows.Forms.Padding(4);
            this.ComboBoxStaff.Name = "ComboBoxStaff";
            this.ComboBoxStaff.Size = new System.Drawing.Size(268, 36);
            this.ComboBoxStaff.TabIndex = 4;
            // 
            // ComboBoxMaterial
            // 
            this.ComboBoxMaterial.BackColor = System.Drawing.Color.Transparent;
            this.ComboBoxMaterial.BorderRadius = 10;
            this.ComboBoxMaterial.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBoxMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxMaterial.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboBoxMaterial.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboBoxMaterial.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComboBoxMaterial.ForeColor = System.Drawing.Color.Black;
            this.ComboBoxMaterial.ItemHeight = 30;
            this.ComboBoxMaterial.Location = new System.Drawing.Point(270, 307);
            this.ComboBoxMaterial.Margin = new System.Windows.Forms.Padding(4);
            this.ComboBoxMaterial.Name = "ComboBoxMaterial";
            this.ComboBoxMaterial.Size = new System.Drawing.Size(268, 36);
            this.ComboBoxMaterial.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(264, 259);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 28);
            this.label3.TabIndex = 8;
            this.label3.Text = "Material";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(264, 161);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 28);
            this.label2.TabIndex = 9;
            this.label2.Text = "Staff";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(264, 399);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 28);
            this.label4.TabIndex = 10;
            this.label4.Text = "Commentary";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(789, 201);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 28);
            this.label1.TabIndex = 11;
            this.label1.Text = "Interv Date";
            // 
            // CheckBoxStatus
            // 
            this.CheckBoxStatus.AutoSize = true;
            this.CheckBoxStatus.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CheckBoxStatus.CheckedState.BorderRadius = 0;
            this.CheckBoxStatus.CheckedState.BorderThickness = 0;
            this.CheckBoxStatus.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CheckBoxStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckBoxStatus.ForeColor = System.Drawing.Color.Black;
            this.CheckBoxStatus.Location = new System.Drawing.Point(569, 213);
            this.CheckBoxStatus.Margin = new System.Windows.Forms.Padding(4);
            this.CheckBoxStatus.Name = "CheckBoxStatus";
            this.CheckBoxStatus.Size = new System.Drawing.Size(158, 33);
            this.CheckBoxStatus.TabIndex = 12;
            this.CheckBoxStatus.Text = "Completed";
            this.CheckBoxStatus.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.CheckBoxStatus.UncheckedState.BorderRadius = 0;
            this.CheckBoxStatus.UncheckedState.BorderThickness = 0;
            this.CheckBoxStatus.UncheckedState.FillColor = System.Drawing.Color.White;
            // 
            // ButtonCreateInterv
            // 
            this.ButtonCreateInterv.Animated = true;
            this.ButtonCreateInterv.BorderRadius = 10;
            this.ButtonCreateInterv.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonCreateInterv.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonCreateInterv.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonCreateInterv.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonCreateInterv.FillColor = System.Drawing.Color.PowderBlue;
            this.ButtonCreateInterv.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F);
            this.ButtonCreateInterv.ForeColor = System.Drawing.Color.Black;
            this.ButtonCreateInterv.Location = new System.Drawing.Point(766, 468);
            this.ButtonCreateInterv.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonCreateInterv.Name = "ButtonCreateInterv";
            this.ButtonCreateInterv.Size = new System.Drawing.Size(248, 100);
            this.ButtonCreateInterv.TabIndex = 13;
            this.ButtonCreateInterv.Text = "Create";
            this.ButtonCreateInterv.Click += new System.EventHandler(this.ButtonCreateInterv_Click);
            // 
            // siticoneHtmlLabel1
            // 
            this.siticoneHtmlLabel1.AutoSize = false;
            this.siticoneHtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneHtmlLabel1.Location = new System.Drawing.Point(504, 46);
            this.siticoneHtmlLabel1.Margin = new System.Windows.Forms.Padding(4);
            this.siticoneHtmlLabel1.Name = "siticoneHtmlLabel1";
            this.siticoneHtmlLabel1.Size = new System.Drawing.Size(364, 39);
            this.siticoneHtmlLabel1.TabIndex = 14;
            this.siticoneHtmlLabel1.Text = "Create Intervention ";
            // 
            // Main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(1113, 630);
            this.Controls.Add(this.siticoneHtmlLabel1);
            this.Controls.Add(this.ButtonCreateInterv);
            this.Controls.Add(this.CheckBoxStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ComboBoxMaterial);
            this.Controls.Add(this.ComboBoxStaff);
            this.Controls.Add(this.TextBoxCommentary);
            this.Controls.Add(this.DateTimePickerInterv);
            this.Controls.Add(this.panelSideBar);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Main";
            this.Text = "Form2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Load);
            this.Shown += new System.EventHandler(this.Main_Load);
            this.panelSideBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCreateInterv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelSideBar;
        private System.Windows.Forms.PictureBox pictureBoxMenu;
        private System.Windows.Forms.PictureBox pictureBoxCreateInterv;
        private Siticone.Desktop.UI.WinForms.SiticoneDateTimePicker DateTimePickerInterv;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox TextBoxCommentary;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox ComboBoxStaff;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox ComboBoxMaterial;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private Siticone.Desktop.UI.WinForms.SiticoneCheckBox CheckBoxStatus;
        private Siticone.Desktop.UI.WinForms.SiticoneButton ButtonCreateInterv;
        private System.Windows.Forms.PictureBox pictureBox1;
        public Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel1;
    }
}