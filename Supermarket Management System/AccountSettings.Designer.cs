﻿namespace Supermarket_Management_System
{
    partial class AccountSettings
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
            this.label1 = new System.Windows.Forms.Label();
            this.ProfileName = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.ProfilePassword = new System.Windows.Forms.Label();
            this.update = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(270, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "My Profile";
            // 
            // ProfileName
            // 
            this.ProfileName.AutoSize = true;
            this.ProfileName.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ProfileName.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProfileName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ProfileName.Location = new System.Drawing.Point(180, 157);
            this.ProfileName.Name = "ProfileName";
            this.ProfileName.Size = new System.Drawing.Size(89, 20);
            this.ProfileName.TabIndex = 2;
            this.ProfileName.Text = "Profile Name";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(312, 159);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(233, 20);
            this.name.TabIndex = 3;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(312, 202);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(233, 20);
            this.password.TabIndex = 5;
            // 
            // ProfilePassword
            // 
            this.ProfilePassword.AutoSize = true;
            this.ProfilePassword.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ProfilePassword.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProfilePassword.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ProfilePassword.Location = new System.Drawing.Point(180, 200);
            this.ProfilePassword.Name = "ProfilePassword";
            this.ProfilePassword.Size = new System.Drawing.Size(114, 20);
            this.ProfilePassword.TabIndex = 4;
            this.ProfilePassword.Text = "Profile Password";
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.Color.Black;
            this.update.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.ForeColor = System.Drawing.SystemColors.Control;
            this.update.Location = new System.Drawing.Point(312, 262);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(153, 32);
            this.update.TabIndex = 9;
            this.update.Text = "CONFIRM UPDATE";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.Black;
            this.back.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.ForeColor = System.Drawing.SystemColors.Control;
            this.back.Location = new System.Drawing.Point(713, 12);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 32);
            this.back.TabIndex = 10;
            this.back.Text = "BACK";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(270, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "To UPDATE your profile, enter your details below.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Supermarket_Management_System.Properties.Resources.settings;
            this.pictureBox1.Location = new System.Drawing.Point(180, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(84, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // AccountSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = global::Supermarket_Management_System.Properties.Resources.Texture_wallpaper_HD_pictures_images1;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.back);
            this.Controls.Add(this.update);
            this.Controls.Add(this.password);
            this.Controls.Add(this.ProfilePassword);
            this.Controls.Add(this.name);
            this.Controls.Add(this.ProfileName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "AccountSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AccountSettings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AccountSettings_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ProfileName;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label ProfilePassword;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}