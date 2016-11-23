namespace project_Product.presentation_layer
{
    partial class Catogory
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.print_cat = new System.Windows.Forms.GroupBox();
            this.save_cat_prod = new System.Windows.Forms.Button();
            this.saveAs_pdf = new System.Windows.Forms.Button();
            this.print_all = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.edite = new System.Windows.Forms.Button();
            this.delete_cat = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.new_cat = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.frist_cat = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.toword = new System.Windows.Forms.Button();
            this.lastcat = new System.Windows.Forms.Button();
            this.desc = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.print_cat.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.print_cat);
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(0, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(780, 397);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "الاصناف ";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // print_cat
            // 
            this.print_cat.Controls.Add(this.save_cat_prod);
            this.print_cat.Controls.Add(this.saveAs_pdf);
            this.print_cat.Controls.Add(this.print_all);
            this.print_cat.Controls.Add(this.button9);
            this.print_cat.Controls.Add(this.edite);
            this.print_cat.Controls.Add(this.delete_cat);
            this.print_cat.Controls.Add(this.add);
            this.print_cat.Controls.Add(this.new_cat);
            this.print_cat.Location = new System.Drawing.Point(6, 282);
            this.print_cat.Name = "print_cat";
            this.print_cat.Size = new System.Drawing.Size(749, 100);
            this.print_cat.TabIndex = 6;
            this.print_cat.TabStop = false;
            this.print_cat.Text = "العمليات ";
            // 
            // save_cat_prod
            // 
            this.save_cat_prod.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.save_cat_prod.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.save_cat_prod.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_cat_prod.Image = global::project_Product.Properties.Resources.Printer_icon;
            this.save_cat_prod.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.save_cat_prod.Location = new System.Drawing.Point(12, 64);
            this.save_cat_prod.Name = "save_cat_prod";
            this.save_cat_prod.Size = new System.Drawing.Size(253, 30);
            this.save_cat_prod.TabIndex = 7;
            this.save_cat_prod.Text = "حفظ الصنف بمنتجاته PDF";
            this.save_cat_prod.UseVisualStyleBackColor = true;
            this.save_cat_prod.Click += new System.EventHandler(this.save_cat_prod_Click);
            // 
            // saveAs_pdf
            // 
            this.saveAs_pdf.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.saveAs_pdf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.saveAs_pdf.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveAs_pdf.Image = global::project_Product.Properties.Resources._1435975908_icon_70_document_file_pdf;
            this.saveAs_pdf.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.saveAs_pdf.Location = new System.Drawing.Point(285, 64);
            this.saveAs_pdf.Name = "saveAs_pdf";
            this.saveAs_pdf.Size = new System.Drawing.Size(225, 30);
            this.saveAs_pdf.TabIndex = 6;
            this.saveAs_pdf.Text = "حفظ الاصناف PDF";
            this.saveAs_pdf.UseVisualStyleBackColor = true;
            this.saveAs_pdf.Click += new System.EventHandler(this.saveAs_pdf_Click);
            // 
            // print_all
            // 
            this.print_all.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.print_all.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.print_all.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.print_all.Image = global::project_Product.Properties.Resources.printer_icon__1_;
            this.print_all.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.print_all.Location = new System.Drawing.Point(12, 19);
            this.print_all.Name = "print_all";
            this.print_all.Size = new System.Drawing.Size(211, 30);
            this.print_all.TabIndex = 5;
            this.print_all.Text = "طباعه كل الاصناف";
            this.print_all.UseVisualStyleBackColor = true;
            this.print_all.Click += new System.EventHandler(this.print_all_Click);
            // 
            // button9
            // 
            this.button9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button9.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Image = global::project_Product.Properties.Resources.Printer_icon;
            this.button9.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button9.Location = new System.Drawing.Point(528, 64);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(211, 30);
            this.button9.TabIndex = 4;
            this.button9.Text = "طباعه الصنف المحدد";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // edite
            // 
            this.edite.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.edite.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.edite.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edite.Image = global::project_Product.Properties.Resources._1435975321_icon_136_document_edit;
            this.edite.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.edite.Location = new System.Drawing.Point(251, 19);
            this.edite.Name = "edite";
            this.edite.Size = new System.Drawing.Size(121, 30);
            this.edite.TabIndex = 3;
            this.edite.Text = "تعديل ";
            this.edite.UseVisualStyleBackColor = true;
            this.edite.Click += new System.EventHandler(this.edite_Click);
            // 
            // delete_cat
            // 
            this.delete_cat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.delete_cat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.delete_cat.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_cat.Image = global::project_Product.Properties.Resources.Close_2_icon__1_1;
            this.delete_cat.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.delete_cat.Location = new System.Drawing.Point(391, 19);
            this.delete_cat.Name = "delete_cat";
            this.delete_cat.Size = new System.Drawing.Size(96, 30);
            this.delete_cat.TabIndex = 2;
            this.delete_cat.Text = "حذف";
            this.delete_cat.UseVisualStyleBackColor = true;
            this.delete_cat.Click += new System.EventHandler(this.delete_cat_Click);
            // 
            // add
            // 
            this.add.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.add.Enabled = false;
            this.add.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.Image = global::project_Product.Properties.Resources._1435975123_icon_81_document_add;
            this.add.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.add.Location = new System.Drawing.Point(504, 19);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(96, 30);
            this.add.TabIndex = 1;
            this.add.Text = "اضافه";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.button6_Click);
            // 
            // new_cat
            // 
            this.new_cat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.new_cat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.new_cat.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.new_cat.Image = global::project_Product.Properties.Resources.math_add_icon1;
            this.new_cat.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.new_cat.Location = new System.Drawing.Point(619, 19);
            this.new_cat.Name = "new_cat";
            this.new_cat.Size = new System.Drawing.Size(120, 30);
            this.new_cat.TabIndex = 0;
            this.new_cat.Text = "جديد";
            this.new_cat.UseVisualStyleBackColor = true;
            this.new_cat.Click += new System.EventHandler(this.button5_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(6, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(320, 229);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "جميع الاصناف ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-6, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(314, 200);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.frist_cat);
            this.groupBox1.Controls.Add(this.Back);
            this.groupBox1.Controls.Add(this.toword);
            this.groupBox1.Controls.Add(this.lastcat);
            this.groupBox1.Controls.Add(this.desc);
            this.groupBox1.Controls.Add(this.id);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(354, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(401, 229);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "لائحه الاصناف";
            // 
            // frist_cat
            // 
            this.frist_cat.BackgroundImage = global::project_Product.Properties.Resources.Actions_go_first_view_icon;
            this.frist_cat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.frist_cat.Location = new System.Drawing.Point(55, 165);
            this.frist_cat.Name = "frist_cat";
            this.frist_cat.Size = new System.Drawing.Size(75, 48);
            this.frist_cat.TabIndex = 7;
            this.frist_cat.UseVisualStyleBackColor = true;
            this.frist_cat.Click += new System.EventHandler(this.frist_cat_Click);
            // 
            // Back
            // 
            this.Back.BackgroundImage = global::project_Product.Properties.Resources.Actions_go_next_icon;
            this.Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Back.Location = new System.Drawing.Point(230, 165);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(75, 48);
            this.Back.TabIndex = 6;
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // toword
            // 
            this.toword.BackgroundImage = global::project_Product.Properties.Resources.Actions_go_previous_icon;
            this.toword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.toword.Location = new System.Drawing.Point(136, 165);
            this.toword.Name = "toword";
            this.toword.Size = new System.Drawing.Size(75, 48);
            this.toword.TabIndex = 5;
            this.toword.UseVisualStyleBackColor = true;
            this.toword.Click += new System.EventHandler(this.toword_Click);
            // 
            // lastcat
            // 
            this.lastcat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lastcat.BackgroundImage = global::project_Product.Properties.Resources.Actions_go_last_view_icon;
            this.lastcat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.lastcat.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lastcat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lastcat.Location = new System.Drawing.Point(316, 165);
            this.lastcat.Name = "lastcat";
            this.lastcat.Size = new System.Drawing.Size(75, 48);
            this.lastcat.TabIndex = 4;
            this.lastcat.UseVisualStyleBackColor = true;
            this.lastcat.Click += new System.EventHandler(this.lastcat_Click);
            // 
            // desc
            // 
            this.desc.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desc.Location = new System.Drawing.Point(55, 96);
            this.desc.Name = "desc";
            this.desc.Size = new System.Drawing.Size(211, 30);
            this.desc.TabIndex = 3;
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(55, 46);
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Size = new System.Drawing.Size(211, 27);
            this.id.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(289, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "وصف الصنف ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(299, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID_الصنف ";
            // 
            // Catogory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 406);
            this.Controls.Add(this.groupBox3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Catogory";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Catogory";
            this.Load += new System.EventHandler(this.Catogory_Load);
            this.groupBox3.ResumeLayout(false);
            this.print_cat.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox print_cat;
        private System.Windows.Forms.Button new_cat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button frist_cat;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button toword;
        private System.Windows.Forms.Button lastcat;
        private System.Windows.Forms.TextBox desc;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button delete_cat;
        private System.Windows.Forms.Button edite;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button save_cat_prod;
        private System.Windows.Forms.Button saveAs_pdf;
        private System.Windows.Forms.Button print_all;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;

    }
}