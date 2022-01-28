namespace Supermarket_Management_System
{
    partial class SalesClerkAccountSettings
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.update = new System.Windows.Forms.Button();
            this.password = new System.Windows.Forms.TextBox();
            this.ProfilePassword = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.ProfileName = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Supermarket_Management_System.Properties.Resources.settings;
            this.pictureBox1.Location = new System.Drawing.Point(170, 80);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(84, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 47;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(304, 338);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(233, 20);
            this.textBox1.TabIndex = 46;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(172, 295);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(325, 13);
            this.label3.TabIndex = 45;
            this.label3.Text = "In order to confirm your changes, please mention your EMAIL below";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(278, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 13);
            this.label2.TabIndex = 44;
            this.label2.Text = "To UPDATE your profile, enter your details below.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(278, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 43;
            this.label1.Text = "My Profile";
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.Color.Black;
            this.update.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.ForeColor = System.Drawing.SystemColors.Control;
            this.update.Location = new System.Drawing.Point(554, 326);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(153, 32);
            this.update.TabIndex = 42;
            this.update.Text = "CONFIRM UPDATE";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(304, 235);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(233, 20);
            this.password.TabIndex = 41;
            // 
            // ProfilePassword
            // 
            this.ProfilePassword.AutoSize = true;
            this.ProfilePassword.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ProfilePassword.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProfilePassword.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ProfilePassword.Location = new System.Drawing.Point(172, 233);
            this.ProfilePassword.Name = "ProfilePassword";
            this.ProfilePassword.Size = new System.Drawing.Size(114, 20);
            this.ProfilePassword.TabIndex = 40;
            this.ProfilePassword.Text = "Profile Password";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(304, 192);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(233, 20);
            this.name.TabIndex = 39;
            // 
            // ProfileName
            // 
            this.ProfileName.AutoSize = true;
            this.ProfileName.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ProfileName.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProfileName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ProfileName.Location = new System.Drawing.Point(172, 190);
            this.ProfileName.Name = "ProfileName";
            this.ProfileName.Size = new System.Drawing.Size(89, 20);
            this.ProfileName.TabIndex = 38;
            this.ProfileName.Text = "Profile Name";
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.Black;
            this.back.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.ForeColor = System.Drawing.SystemColors.Control;
            this.back.Location = new System.Drawing.Point(716, 17);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 32);
            this.back.TabIndex = 37;
            this.back.Text = "BACK";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // SalesClerkAccountSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImage = global::Supermarket_Management_System.Properties.Resources.Texture_wallpaper_HD_pictures_images1;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.update);
            this.Controls.Add(this.password);
            this.Controls.Add(this.ProfilePassword);
            this.Controls.Add(this.name);
            this.Controls.Add(this.ProfileName);
            this.Controls.Add(this.back);
            this.Name = "SalesClerkAccountSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SalesClerkAccountSettings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SalesClerkAccountSettings_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label ProfilePassword;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label ProfileName;
        private System.Windows.Forms.Button back;
    }
}