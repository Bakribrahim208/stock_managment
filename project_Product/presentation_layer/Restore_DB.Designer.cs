namespace project_Product.presentation_layer
{
    partial class Restore_DB
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
            this.showtxt = new System.Windows.Forms.TextBox();
            this.restore = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.browsbtn = new System.Windows.Forms.Button();
            this.closebtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // showtxt
            // 
            this.showtxt.Font = new System.Drawing.Font("Traditional Arabic", 14.25F, System.Drawing.FontStyle.Bold);
            this.showtxt.Location = new System.Drawing.Point(100, 58);
            this.showtxt.Name = "showtxt";
            this.showtxt.Size = new System.Drawing.Size(393, 37);
            this.showtxt.TabIndex = 1;
            // 
            // restore
            // 
            this.restore.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.restore.Image = global::project_Product.Properties.Resources._1435975123_icon_81_document_add;
            this.restore.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.restore.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.restore.Location = new System.Drawing.Point(274, 119);
            this.restore.Name = "restore";
            this.restore.Size = new System.Drawing.Size(153, 30);
            this.restore.TabIndex = 0;
            this.restore.Text = "استعاده النسخه";
            this.restore.UseVisualStyleBackColor = true;
            this.restore.Click += new System.EventHandler(this.restore_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.browsbtn);
            this.groupBox1.Controls.Add(this.closebtn);
            this.groupBox1.Controls.Add(this.showtxt);
            this.groupBox1.Controls.Add(this.restore);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(571, 191);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // browsbtn
            // 
            this.browsbtn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.browsbtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.browsbtn.Location = new System.Drawing.Point(6, 58);
            this.browsbtn.Name = "browsbtn";
            this.browsbtn.Size = new System.Drawing.Size(79, 37);
            this.browsbtn.TabIndex = 4;
            this.browsbtn.Text = "....";
            this.browsbtn.UseVisualStyleBackColor = true;
            this.browsbtn.Click += new System.EventHandler(this.browsbtn_Click);
            // 
            // closebtn
            // 
            this.closebtn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.closebtn.Image = global::project_Product.Properties.Resources.Close_2_icon__1_;
            this.closebtn.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.closebtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.closebtn.Location = new System.Drawing.Point(100, 119);
            this.closebtn.Name = "closebtn";
            this.closebtn.Size = new System.Drawing.Size(133, 30);
            this.closebtn.TabIndex = 3;
            this.closebtn.Text = "خروج";
            this.closebtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(213, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "ضع مسار النسخه الاحتياطيه";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Restore_DB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 215);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Restore_DB";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "استعاده النسخه الاحتياطيه ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox showtxt;
        private System.Windows.Forms.Button restore;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button browsbtn;
        private System.Windows.Forms.Button closebtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}