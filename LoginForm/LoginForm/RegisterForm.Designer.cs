﻿namespace LoginForm
{
	partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.usernameRegister = new System.Windows.Forms.TextBox();
            this.userBarRegister = new System.Windows.Forms.FlowLayoutPanel();
            this.passBarRegister = new System.Windows.Forms.FlowLayoutPanel();
            this.passwordRegister = new System.Windows.Forms.TextBox();
            this.mailBarRegister = new System.Windows.Forms.FlowLayoutPanel();
            this.register = new System.Windows.Forms.Button();
            this.mainMenu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.emailRegister = new System.Windows.Forms.TextBox();
            this.instagram = new System.Windows.Forms.PictureBox();
            this.facebook = new System.Windows.Forms.PictureBox();
            this.emailImg = new System.Windows.Forms.PictureBox();
            this.passImg = new System.Windows.Forms.PictureBox();
            this.userImg = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.confirmPasswordRegister = new System.Windows.Forms.TextBox();
            this.confirmPassImg = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.instagram)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facebook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.confirmPassImg)).BeginInit();
            this.SuspendLayout();
            // 
            // usernameRegister
            // 
            this.usernameRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.usernameRegister.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usernameRegister.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameRegister.ForeColor = System.Drawing.Color.LightGray;
            this.usernameRegister.Location = new System.Drawing.Point(74, 106);
            this.usernameRegister.Margin = new System.Windows.Forms.Padding(2);
            this.usernameRegister.Name = "usernameRegister";
            this.usernameRegister.Size = new System.Drawing.Size(156, 17);
            this.usernameRegister.TabIndex = 2;
            this.usernameRegister.Click += new System.EventHandler(this.username_Click);
            // 
            // userBarRegister
            // 
            this.userBarRegister.BackColor = System.Drawing.Color.White;
            this.userBarRegister.Location = new System.Drawing.Point(45, 131);
            this.userBarRegister.Margin = new System.Windows.Forms.Padding(2);
            this.userBarRegister.Name = "userBarRegister";
            this.userBarRegister.Size = new System.Drawing.Size(188, 1);
            this.userBarRegister.TabIndex = 3;
            // 
            // passBarRegister
            // 
            this.passBarRegister.BackColor = System.Drawing.Color.White;
            this.passBarRegister.Location = new System.Drawing.Point(45, 178);
            this.passBarRegister.Margin = new System.Windows.Forms.Padding(2);
            this.passBarRegister.Name = "passBarRegister";
            this.passBarRegister.Size = new System.Drawing.Size(188, 1);
            this.passBarRegister.TabIndex = 6;
            // 
            // passwordRegister
            // 
            this.passwordRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.passwordRegister.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordRegister.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordRegister.ForeColor = System.Drawing.Color.LightGray;
            this.passwordRegister.Location = new System.Drawing.Point(73, 154);
            this.passwordRegister.Margin = new System.Windows.Forms.Padding(2);
            this.passwordRegister.Name = "passwordRegister";
            this.passwordRegister.Size = new System.Drawing.Size(156, 17);
            this.passwordRegister.TabIndex = 5;
            this.passwordRegister.UseSystemPasswordChar = true;
            this.passwordRegister.Click += new System.EventHandler(this.password_Click);
            // 
            // mailBarRegister
            // 
            this.mailBarRegister.BackColor = System.Drawing.Color.White;
            this.mailBarRegister.Location = new System.Drawing.Point(45, 278);
            this.mailBarRegister.Margin = new System.Windows.Forms.Padding(2);
            this.mailBarRegister.Name = "mailBarRegister";
            this.mailBarRegister.Size = new System.Drawing.Size(188, 1);
            this.mailBarRegister.TabIndex = 9;
            // 
            // register
            // 
            this.register.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.register.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.register.Location = new System.Drawing.Point(44, 306);
            this.register.Margin = new System.Windows.Forms.Padding(2);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(188, 32);
            this.register.TabIndex = 10;
            this.register.Text = "Register";
            this.register.UseVisualStyleBackColor = false;
            this.register.Click += new System.EventHandler(this.register_Click);
            // 
            // mainMenu
            // 
            this.mainMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.mainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainMenu.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainMenu.ForeColor = System.Drawing.Color.LightGray;
            this.mainMenu.Location = new System.Drawing.Point(44, 356);
            this.mainMenu.Margin = new System.Windows.Forms.Padding(2);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(188, 32);
            this.mainMenu.TabIndex = 12;
            this.mainMenu.Text = "Main Menu";
            this.mainMenu.UseVisualStyleBackColor = false;
            this.mainMenu.Click += new System.EventHandler(this.mainMenu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(106, 419);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "register with";
            // 
            // emailRegister
            // 
            this.emailRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.emailRegister.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.emailRegister.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailRegister.ForeColor = System.Drawing.Color.LightGray;
            this.emailRegister.Location = new System.Drawing.Point(76, 253);
            this.emailRegister.Margin = new System.Windows.Forms.Padding(2);
            this.emailRegister.Name = "emailRegister";
            this.emailRegister.Size = new System.Drawing.Size(156, 17);
            this.emailRegister.TabIndex = 15;
            this.emailRegister.Click += new System.EventHandler(this.email_Click);
            // 
            // instagram
            // 
            this.instagram.Image = ((System.Drawing.Image)(resources.GetObject("instagram.Image")));
            this.instagram.Location = new System.Drawing.Point(186, 454);
            this.instagram.Margin = new System.Windows.Forms.Padding(2);
            this.instagram.Name = "instagram";
            this.instagram.Size = new System.Drawing.Size(43, 46);
            this.instagram.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.instagram.TabIndex = 13;
            this.instagram.TabStop = false;
            // 
            // facebook
            // 
            this.facebook.Image = ((System.Drawing.Image)(resources.GetObject("facebook.Image")));
            this.facebook.Location = new System.Drawing.Point(44, 454);
            this.facebook.Margin = new System.Windows.Forms.Padding(2);
            this.facebook.Name = "facebook";
            this.facebook.Size = new System.Drawing.Size(43, 46);
            this.facebook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.facebook.TabIndex = 11;
            this.facebook.TabStop = false;
            // 
            // emailImg
            // 
            this.emailImg.Image = ((System.Drawing.Image)(resources.GetObject("emailImg.Image")));
            this.emailImg.Location = new System.Drawing.Point(45, 245);
            this.emailImg.Margin = new System.Windows.Forms.Padding(2);
            this.emailImg.Name = "emailImg";
            this.emailImg.Size = new System.Drawing.Size(23, 25);
            this.emailImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.emailImg.TabIndex = 7;
            this.emailImg.TabStop = false;
            // 
            // passImg
            // 
            this.passImg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passImg.Image = ((System.Drawing.Image)(resources.GetObject("passImg.Image")));
            this.passImg.Location = new System.Drawing.Point(44, 146);
            this.passImg.Margin = new System.Windows.Forms.Padding(2);
            this.passImg.Name = "passImg";
            this.passImg.Size = new System.Drawing.Size(23, 25);
            this.passImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.passImg.TabIndex = 4;
            this.passImg.TabStop = false;
            // 
            // userImg
            // 
            this.userImg.Image = global::LoginForm.Properties.Resources.user1;
            this.userImg.Location = new System.Drawing.Point(45, 97);
            this.userImg.Margin = new System.Windows.Forms.Padding(2);
            this.userImg.Name = "userImg";
            this.userImg.Size = new System.Drawing.Size(23, 26);
            this.userImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userImg.TabIndex = 1;
            this.userImg.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(110, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(45, 227);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(188, 1);
            this.flowLayoutPanel1.TabIndex = 18;
            // 
            // confirmPasswordRegister
            // 
            this.confirmPasswordRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.confirmPasswordRegister.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.confirmPasswordRegister.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmPasswordRegister.ForeColor = System.Drawing.Color.LightGray;
            this.confirmPasswordRegister.Location = new System.Drawing.Point(73, 203);
            this.confirmPasswordRegister.Margin = new System.Windows.Forms.Padding(2);
            this.confirmPasswordRegister.Name = "confirmPasswordRegister";
            this.confirmPasswordRegister.Size = new System.Drawing.Size(156, 17);
            this.confirmPasswordRegister.TabIndex = 17;
            this.confirmPasswordRegister.UseSystemPasswordChar = true;
            // 
            // confirmPassImg
            // 
            this.confirmPassImg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.confirmPassImg.Image = ((System.Drawing.Image)(resources.GetObject("confirmPassImg.Image")));
            this.confirmPassImg.Location = new System.Drawing.Point(44, 195);
            this.confirmPassImg.Margin = new System.Windows.Forms.Padding(2);
            this.confirmPassImg.Name = "confirmPassImg";
            this.confirmPassImg.Size = new System.Drawing.Size(23, 25);
            this.confirmPassImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.confirmPassImg.TabIndex = 16;
            this.confirmPassImg.TabStop = false;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(289, 521);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.confirmPasswordRegister);
            this.Controls.Add(this.confirmPassImg);
            this.Controls.Add(this.emailRegister);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.instagram);
            this.Controls.Add(this.mainMenu);
            this.Controls.Add(this.facebook);
            this.Controls.Add(this.register);
            this.Controls.Add(this.mailBarRegister);
            this.Controls.Add(this.emailImg);
            this.Controls.Add(this.passBarRegister);
            this.Controls.Add(this.passwordRegister);
            this.Controls.Add(this.passImg);
            this.Controls.Add(this.userBarRegister);
            this.Controls.Add(this.usernameRegister);
            this.Controls.Add(this.userImg);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.instagram)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facebook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.confirmPassImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox userImg;
		private System.Windows.Forms.TextBox usernameRegister;
		private System.Windows.Forms.FlowLayoutPanel userBarRegister;
		private System.Windows.Forms.FlowLayoutPanel passBarRegister;
		private System.Windows.Forms.TextBox passwordRegister;
		private System.Windows.Forms.PictureBox passImg;
		private System.Windows.Forms.FlowLayoutPanel mailBarRegister;
		private System.Windows.Forms.PictureBox emailImg;
		private System.Windows.Forms.Button register;
		private System.Windows.Forms.PictureBox facebook;
		private System.Windows.Forms.Button mainMenu;
		private System.Windows.Forms.PictureBox instagram;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox emailRegister;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox confirmPasswordRegister;
        private System.Windows.Forms.PictureBox confirmPassImg;
    }
}

