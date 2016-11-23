namespace project_Product.presentation_layer
{
    partial class BackUp_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BackUp_form));
            this.savebtn = new System.Windows.Forms.Button();
            this.showtxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.browsbtn = new System.Windows.Forms.Button();
            this.closebtn = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // savebtn
            // 
            resources.ApplyResources(this.savebtn, "savebtn");
            this.savebtn.Image = global::project_Product.Properties.Resources._1435975123_icon_81_document_add;
            this.savebtn.Name = "savebtn";
            this.savebtn.UseVisualStyleBackColor = true;
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // showtxt
            // 
            resources.ApplyResources(this.showtxt, "showtxt");
            this.showtxt.Name = "showtxt";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.browsbtn);
            this.groupBox1.Controls.Add(this.closebtn);
            this.groupBox1.Controls.Add(this.showtxt);
            this.groupBox1.Controls.Add(this.savebtn);
            this.groupBox1.Controls.Add(this.label1);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // browsbtn
            // 
            resources.ApplyResources(this.browsbtn, "browsbtn");
            this.browsbtn.Name = "browsbtn";
            this.browsbtn.UseVisualStyleBackColor = true;
            this.browsbtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // closebtn
            // 
            resources.ApplyResources(this.closebtn, "closebtn");
            this.closebtn.Image = global::project_Product.Properties.Resources.Close_2_icon__1_;
            this.closebtn.Name = "closebtn";
            this.closebtn.UseVisualStyleBackColor = true;
            // 
            // BackUp_form
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "BackUp_form";
            this.Load += new System.EventHandler(this.BackUp_form_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button savebtn;
        private System.Windows.Forms.TextBox showtxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button browsbtn;
        private System.Windows.Forms.Button closebtn;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}