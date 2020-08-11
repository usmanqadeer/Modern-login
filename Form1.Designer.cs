namespace ModernLogIn
{
    partial class frmLogIn
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogIn));
            this.bunifuElipseLogInForm = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.picBacground = new System.Windows.Forms.PictureBox();
            this.txtUserEmail = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.txtUserPassword = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.btnLogInUser = new System.Windows.Forms.Button();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.lblCompnyName = new Bunifu.Framework.UI.BunifuCustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.picBacground)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipseLogInForm
            // 
            this.bunifuElipseLogInForm.ElipseRadius = 15;
            this.bunifuElipseLogInForm.TargetControl = this;
            // 
            // picBacground
            // 
            this.picBacground.Image = ((System.Drawing.Image)(resources.GetObject("picBacground.Image")));
            this.picBacground.Location = new System.Drawing.Point(0, -3);
            this.picBacground.Margin = new System.Windows.Forms.Padding(5);
            this.picBacground.Name = "picBacground";
            this.picBacground.Size = new System.Drawing.Size(677, 419);
            this.picBacground.TabIndex = 0;
            this.picBacground.TabStop = false;
            this.picBacground.Click += new System.EventHandler(this.picBacground_Click);
            // 
            // txtUserEmail
            // 
            this.txtUserEmail.BackColor = System.Drawing.Color.White;
            this.txtUserEmail.BorderColor = System.Drawing.Color.White;
            this.txtUserEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUserEmail.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserEmail.ForeColor = System.Drawing.Color.DarkGray;
            this.txtUserEmail.Location = new System.Drawing.Point(78, 137);
            this.txtUserEmail.Margin = new System.Windows.Forms.Padding(5);
            this.txtUserEmail.Name = "txtUserEmail";
            this.txtUserEmail.Size = new System.Drawing.Size(224, 24);
            this.txtUserEmail.TabIndex = 0;
            this.txtUserEmail.MouseLeave += new System.EventHandler(this.txtUserEmail_MouseLeave);
            this.txtUserEmail.MouseHover += new System.EventHandler(this.txtUserEmail_MouseHover);
            // 
            // txtUserPassword
            // 
            this.txtUserPassword.BackColor = System.Drawing.Color.White;
            this.txtUserPassword.BorderColor = System.Drawing.Color.White;
            this.txtUserPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUserPassword.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserPassword.ForeColor = System.Drawing.Color.DarkGray;
            this.txtUserPassword.Location = new System.Drawing.Point(85, 171);
            this.txtUserPassword.Margin = new System.Windows.Forms.Padding(5);
            this.txtUserPassword.Name = "txtUserPassword";
            this.txtUserPassword.Size = new System.Drawing.Size(224, 24);
            this.txtUserPassword.TabIndex = 1;
            this.txtUserPassword.Text = "Password";
            // 
            // btnLogInUser
            // 
            this.btnLogInUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(0)))), ((int)(((byte)(244)))));
            this.btnLogInUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(43)))), ((int)(((byte)(228)))));
            this.btnLogInUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogInUser.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogInUser.ForeColor = System.Drawing.Color.White;
            this.btnLogInUser.Location = new System.Drawing.Point(78, 234);
            this.btnLogInUser.Name = "btnLogInUser";
            this.btnLogInUser.Size = new System.Drawing.Size(224, 38);
            this.btnLogInUser.TabIndex = 2;
            this.btnLogInUser.Text = "Sign In";
            this.btnLogInUser.UseVisualStyleBackColor = false;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.picBacground;
            this.bunifuDragControl1.Vertical = true;
            // 
            // lblCompnyName
            // 
            this.lblCompnyName.AutoSize = true;
            this.lblCompnyName.BackColor = System.Drawing.Color.White;
            this.lblCompnyName.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompnyName.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblCompnyName.Location = new System.Drawing.Point(80, 135);
            this.lblCompnyName.Name = "lblCompnyName";
            this.lblCompnyName.Size = new System.Drawing.Size(39, 17);
            this.lblCompnyName.TabIndex = 0;
            this.lblCompnyName.Text = "Email\r\n";
            // 
            // frmLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 415);
            this.Controls.Add(this.lblCompnyName);
            this.Controls.Add(this.btnLogInUser);
            this.Controls.Add(this.txtUserPassword);
            this.Controls.Add(this.txtUserEmail);
            this.Controls.Add(this.picBacground);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmLogIn";
            this.Opacity = 0.98D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLogInScreen";
            ((System.ComponentModel.ISupportInitialize)(this.picBacground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipseLogInForm;
        private Bunifu.Framework.UI.BunifuCustomLabel lblCompnyName;
        private System.Windows.Forms.Button btnLogInUser;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtUserPassword;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtUserEmail;
        private System.Windows.Forms.PictureBox picBacground;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    }
}

