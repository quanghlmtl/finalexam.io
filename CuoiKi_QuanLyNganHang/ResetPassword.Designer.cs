﻿namespace CuoiKi_QuanLyNganHang
{
    partial class ResetPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResetPassword));
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblNumberPhone = new System.Windows.Forms.Label();
            this.lblCCCD = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.rjButton1 = new CuoiKi_QuanLyNganHang.RJControls.RJButton();
            this.txtNumberPhone = new CuoiKi_QuanLyNganHang.RJControls.RJTextBox();
            this.txtUser = new CuoiKi_QuanLyNganHang.RJControls.RJTextBox();
            this.txtCCCD = new CuoiKi_QuanLyNganHang.RJControls.RJTextBox();
            this.txtFullName = new CuoiKi_QuanLyNganHang.RJControls.RJTextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.BackColor = System.Drawing.Color.Transparent;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(249, 725);
            this.lblMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(93, 33);
            this.lblMessage.TabIndex = 33;
            this.lblMessage.Text = "label1";
            this.lblMessage.Visible = false;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.Location = new System.Drawing.Point(1036, 17);
            this.btnHome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(60, 62);
            this.btnHome.TabIndex = 32;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // lblUser
            // 
            this.lblUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.DimGray;
            this.lblUser.Location = new System.Drawing.Point(242, 609);
            this.lblUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(131, 25);
            this.lblUser.TabIndex = 31;
            this.lblUser.Text = "Tên tài khoản";
            this.lblUser.Visible = false;
            // 
            // lblNumberPhone
            // 
            this.lblNumberPhone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNumberPhone.AutoSize = true;
            this.lblNumberPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberPhone.ForeColor = System.Drawing.Color.DimGray;
            this.lblNumberPhone.Location = new System.Drawing.Point(242, 457);
            this.lblNumberPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumberPhone.Name = "lblNumberPhone";
            this.lblNumberPhone.Size = new System.Drawing.Size(126, 25);
            this.lblNumberPhone.TabIndex = 30;
            this.lblNumberPhone.Text = "Số điện thoại";
            // 
            // lblCCCD
            // 
            this.lblCCCD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCCCD.AutoSize = true;
            this.lblCCCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCCCD.ForeColor = System.Drawing.Color.DimGray;
            this.lblCCCD.Location = new System.Drawing.Point(242, 297);
            this.lblCCCD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCCCD.Name = "lblCCCD";
            this.lblCCCD.Size = new System.Drawing.Size(101, 25);
            this.lblCCCD.TabIndex = 29;
            this.lblCCCD.Text = "Số CCCD";
            this.lblCCCD.Visible = false;
            // 
            // lblFullName
            // 
            this.lblFullName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullName.ForeColor = System.Drawing.Color.DimGray;
            this.lblFullName.Location = new System.Drawing.Point(242, 152);
            this.lblFullName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(97, 25);
            this.lblFullName.TabIndex = 28;
            this.lblFullName.Text = "họ và tên ";
            this.lblFullName.Visible = false;
            // 
            // rjButton1
            // 
            this.rjButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rjButton1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton1.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton1.BorderRadius = 20;
            this.rjButton1.BorderSize = 0;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.ForeColor = System.Drawing.Color.White;
            this.rjButton1.Location = new System.Drawing.Point(434, 780);
            this.rjButton1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(225, 62);
            this.rjButton1.TabIndex = 27;
            this.rjButton1.Text = "rjButton1";
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            this.rjButton1.Click += new System.EventHandler(this.rjButton1_Click);
            // 
            // txtNumberPhone
            // 
            this.txtNumberPhone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNumberPhone.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.txtNumberPhone.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtNumberPhone.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtNumberPhone.BorderSize = 2;
            this.txtNumberPhone.ControlPadding = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.txtNumberPhone.CTextAlign = CuoiKi_QuanLyNganHang.RJControls.RJTextBox.Choose2.Left;
            this.txtNumberPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumberPhone.ForeColor = System.Drawing.Color.DimGray;
            this.txtNumberPhone.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtNumberPhone.Location = new System.Drawing.Point(240, 457);
            this.txtNumberPhone.Margin = new System.Windows.Forms.Padding(6);
            this.txtNumberPhone.Multiline = true;
            this.txtNumberPhone.Name = "txtNumberPhone";
            this.txtNumberPhone.Padding = new System.Windows.Forms.Padding(12, 23, 8, 8);
            this.txtNumberPhone.PasswordChar = true;
            this.txtNumberPhone.Size = new System.Drawing.Size(600, 91);
            this.txtNumberPhone.StateValue = CuoiKi_QuanLyNganHang.RJControls.RJTextBox.Choose.Number;
            this.txtNumberPhone.TabIndex = 26;
            this.txtNumberPhone.TabStop = false;
            this.txtNumberPhone.Texts = "Số điện thoại";
            this.txtNumberPhone.UnderLinedStyle = true;
            this.txtNumberPhone.Leave += new System.EventHandler(this.ResetPassword_Leave);
            // 
            // txtUser
            // 
            this.txtUser.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.txtUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUser.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.txtUser.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtUser.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtUser.BorderSize = 2;
            this.txtUser.ControlPadding = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.txtUser.CTextAlign = CuoiKi_QuanLyNganHang.RJControls.RJTextBox.Choose2.Left;
            this.txtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.ForeColor = System.Drawing.Color.DimGray;
            this.txtUser.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtUser.Location = new System.Drawing.Point(240, 609);
            this.txtUser.Margin = new System.Windows.Forms.Padding(6);
            this.txtUser.Multiline = true;
            this.txtUser.Name = "txtUser";
            this.txtUser.Padding = new System.Windows.Forms.Padding(12, 23, 8, 8);
            this.txtUser.PasswordChar = false;
            this.txtUser.Size = new System.Drawing.Size(600, 91);
            this.txtUser.StateValue = CuoiKi_QuanLyNganHang.RJControls.RJTextBox.Choose.All;
            this.txtUser.TabIndex = 25;
            this.txtUser.TabStop = false;
            this.txtUser.Texts = "Tên tài khoản";
            this.txtUser.UnderLinedStyle = true;
            this.txtUser.Leave += new System.EventHandler(this.ResetPassword_Leave);
            // 
            // txtCCCD
            // 
            this.txtCCCD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCCCD.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.txtCCCD.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtCCCD.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtCCCD.BorderSize = 2;
            this.txtCCCD.ControlPadding = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.txtCCCD.CTextAlign = CuoiKi_QuanLyNganHang.RJControls.RJTextBox.Choose2.Left;
            this.txtCCCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCCCD.ForeColor = System.Drawing.Color.DimGray;
            this.txtCCCD.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtCCCD.Location = new System.Drawing.Point(240, 297);
            this.txtCCCD.Margin = new System.Windows.Forms.Padding(6);
            this.txtCCCD.Multiline = true;
            this.txtCCCD.Name = "txtCCCD";
            this.txtCCCD.Padding = new System.Windows.Forms.Padding(12, 23, 8, 8);
            this.txtCCCD.PasswordChar = false;
            this.txtCCCD.Size = new System.Drawing.Size(600, 91);
            this.txtCCCD.StateValue = CuoiKi_QuanLyNganHang.RJControls.RJTextBox.Choose.Number;
            this.txtCCCD.TabIndex = 24;
            this.txtCCCD.TabStop = false;
            this.txtCCCD.Texts = "Số CCCD";
            this.txtCCCD.UnderLinedStyle = true;
            this.txtCCCD.Leave += new System.EventHandler(this.ResetPassword_Leave);
            // 
            // txtFullName
            // 
            this.txtFullName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFullName.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.txtFullName.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtFullName.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtFullName.BorderSize = 2;
            this.txtFullName.ControlPadding = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.txtFullName.CTextAlign = CuoiKi_QuanLyNganHang.RJControls.RJTextBox.Choose2.Left;
            this.txtFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFullName.ForeColor = System.Drawing.Color.DimGray;
            this.txtFullName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtFullName.Location = new System.Drawing.Point(240, 152);
            this.txtFullName.Margin = new System.Windows.Forms.Padding(6);
            this.txtFullName.Multiline = true;
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Padding = new System.Windows.Forms.Padding(12, 23, 8, 8);
            this.txtFullName.PasswordChar = false;
            this.txtFullName.Size = new System.Drawing.Size(600, 91);
            this.txtFullName.StateValue = CuoiKi_QuanLyNganHang.RJControls.RJTextBox.Choose.All;
            this.txtFullName.TabIndex = 23;
            this.txtFullName.TabStop = false;
            this.txtFullName.Texts = "Họ và tên";
            this.txtFullName.UnderLinedStyle = true;
            this.txtFullName.Leave += new System.EventHandler(this.ResetPassword_Leave);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTitle.Location = new System.Drawing.Point(324, 34);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(443, 40);
            this.lblTitle.TabIndex = 22;
            this.lblTitle.Text = "Yêu cầu lấy lại mật khẩu ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.MinimumSize = new System.Drawing.Size(1114, 969);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1114, 969);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ResetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 969);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblNumberPhone);
            this.Controls.Add(this.lblCCCD);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.rjButton1);
            this.Controls.Add(this.txtNumberPhone);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.txtCCCD);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.MinimumSize = new System.Drawing.Size(1116, 987);
            this.Name = "ResetPassword";
            this.Text = "ResetPassword";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ResetPassword_FormClosing);
            this.Load += new System.EventHandler(this.ResetPassword_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTitle;
        private RJControls.RJTextBox txtFullName;
        private RJControls.RJTextBox txtCCCD;
        private RJControls.RJTextBox txtUser;
        private RJControls.RJTextBox txtNumberPhone;
        private RJControls.RJButton rjButton1;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblCCCD;
        private System.Windows.Forms.Label lblNumberPhone;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label lblMessage;
    }
}