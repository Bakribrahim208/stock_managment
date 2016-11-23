namespace project_Product.presentation_layer
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.usernamrtxt = new System.Windows.Forms.TextBox();
            this.passtxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.closebut = new System.Windows.Forms.Button();
            this.logbut = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // usernamrtxt
            // 
            this.usernamrtxt.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernamrtxt.Location = new System.Drawing.Point(40, 72);
            this.usernamrtxt.Name = "usernamrtxt";
            this.usernamrtxt.Size = new System.Drawing.Size(256, 33);
            this.usernamrtxt.TabIndex = 1;
            // 
            // passtxt
            // 
            this.passtxt.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passtxt.Location = new System.Drawing.Point(40, 119);
            this.passtxt.Name = "passtxt";
            this.passtxt.PasswordChar = '*';
            this.passtxt.Size = new System.Drawing.Size(256, 33);
            this.passtxt.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(328, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "username ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(335, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "password";
            // 
            // closebut
            // 
            this.closebut.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closebut.Location = new System.Drawing.Point(62, 228);
            this.closebut.Name = "closebut";
            this.closebut.Size = new System.Drawing.Size(124, 37);
            this.closebut.TabIndex = 6;
            this.closebut.Text = "close";
            this.closebut.UseVisualStyleBackColor = true;
            this.closebut.Click += new System.EventHandler(this.closebut_Click);
            // 
            // logbut
            // 
            this.logbut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logbut.CausesValidation = false;
            this.logbut.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.logbut.FlatAppearance.BorderSize = 3;
            this.logbut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.logbut.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logbut.ImageKey = "(none)";
            this.logbut.Location = new System.Drawing.Point(242, 228);
            this.logbut.Name = "logbut";
            this.logbut.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.logbut.Size = new System.Drawing.Size(124, 37);
            this.logbut.TabIndex = 5;
            this.logbut.Text = "login";
            this.logbut.UseVisualStyleBackColor = true;
            this.logbut.Click += new System.EventHandler(this.logbut_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::project_Product.Properties.Resources.Apps_preferences_desktop_user_password_icon;
            this.pictureBox1.Location = new System.Drawing.Point(525, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(328, 265);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // login
            // 
            this.AcceptButton = this.logbut;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(895, 335);
            this.Controls.Add(this.closebut);
            this.Controls.Add(this.logbut);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passtxt);
            this.Controls.Add(this.usernamrtxt);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "login";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "تسجيل الخدول ";
            this.Load += new System.EventHandler(this.login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox usernamrtxt;
        private System.Windows.Forms.TextBox passtxt;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button logbut;
        private System.Windows.Forms.Button closebut;
    }
}