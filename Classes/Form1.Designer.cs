
namespace Task1
{
    partial class Form1
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
            this.Add_prof = new System.Windows.Forms.Button();
            this.Course_grid = new System.Windows.Forms.DataGridView();
            this.Add_Course = new System.Windows.Forms.Button();
            this.Delete_Dep = new System.Windows.Forms.Button();
            this.Prof_Grid = new System.Windows.Forms.DataGridView();
            this.Dep_grid = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.Prof_name = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Prof_ID = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Prof_age = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.Prof_phone = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.Prof_exp = new System.Windows.Forms.TextBox();
            this.Dep_ID = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.Dep_name = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.depID = new System.Windows.Forms.TextBox();
            this.Description = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.Add_Dep = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.Course_name = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.Course_ID = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.Course_lvl = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.course_profid = new System.Windows.Forms.TextBox();
            this.Delete_prof = new System.Windows.Forms.Button();
            this.Delete_course = new System.Windows.Forms.Button();
            this.Update_dep = new System.Windows.Forms.Button();
            this.Update_prof = new System.Windows.Forms.Button();
            this.Update_Course = new System.Windows.Forms.Button();
            this.Retrieve_prof = new System.Windows.Forms.Button();
            this.Retrieve_Dep = new System.Windows.Forms.Button();
            this.Retrieve_Course = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Course_grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Prof_Grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dep_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // Add_prof
            // 
            this.Add_prof.Location = new System.Drawing.Point(683, 478);
            this.Add_prof.Name = "Add_prof";
            this.Add_prof.Size = new System.Drawing.Size(91, 25);
            this.Add_prof.TabIndex = 2;
            this.Add_prof.Text = "Add_prof";
            this.Add_prof.UseVisualStyleBackColor = true;
            this.Add_prof.Click += new System.EventHandler(this.Add_prof1);
            // 
            // Course_grid
            // 
            this.Course_grid.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.Course_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Course_grid.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.Course_grid.Location = new System.Drawing.Point(1042, 3);
            this.Course_grid.Name = "Course_grid";
            this.Course_grid.Size = new System.Drawing.Size(478, 288);
            this.Course_grid.TabIndex = 3;
            // 
            // Add_Course
            // 
            this.Add_Course.Location = new System.Drawing.Point(1233, 452);
            this.Add_Course.Name = "Add_Course";
            this.Add_Course.Size = new System.Drawing.Size(101, 30);
            this.Add_Course.TabIndex = 2;
            this.Add_Course.Text = "Add_Course";
            this.Add_Course.UseVisualStyleBackColor = true;
            this.Add_Course.Click += new System.EventHandler(this.Add_course);
            // 
            // Delete_Dep
            // 
            this.Delete_Dep.Location = new System.Drawing.Point(206, 478);
            this.Delete_Dep.Name = "Delete_Dep";
            this.Delete_Dep.Size = new System.Drawing.Size(97, 25);
            this.Delete_Dep.TabIndex = 2;
            this.Delete_Dep.Text = "Delete_Dep";
            this.Delete_Dep.UseVisualStyleBackColor = true;
            this.Delete_Dep.Click += new System.EventHandler(this.Delete_Dep1);
            // 
            // Prof_Grid
            // 
            this.Prof_Grid.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.Prof_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Prof_Grid.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.Prof_Grid.Location = new System.Drawing.Point(528, 3);
            this.Prof_Grid.Name = "Prof_Grid";
            this.Prof_Grid.Size = new System.Drawing.Size(493, 288);
            this.Prof_Grid.TabIndex = 3;
            this.Prof_Grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Prof_Grid_CellContentClick);
            // 
            // Dep_grid
            // 
            this.Dep_grid.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.Dep_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dep_grid.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.Dep_grid.Location = new System.Drawing.Point(2, 3);
            this.Dep_grid.Name = "Dep_grid";
            this.Dep_grid.Size = new System.Drawing.Size(507, 288);
            this.Dep_grid.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(669, 307);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Prof Name";
            this.label9.Click += new System.EventHandler(this.label1_Click);
            // 
            // Prof_name
            // 
            this.Prof_name.Location = new System.Drawing.Point(746, 304);
            this.Prof_name.Name = "Prof_name";
            this.Prof_name.Size = new System.Drawing.Size(100, 20);
            this.Prof_name.TabIndex = 1;
            this.Prof_name.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(669, 365);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Age";
            // 
            // Prof_ID
            // 
            this.Prof_ID.Location = new System.Drawing.Point(746, 332);
            this.Prof_ID.Name = "Prof_ID";
            this.Prof_ID.Size = new System.Drawing.Size(100, 20);
            this.Prof_ID.TabIndex = 1;
            this.Prof_ID.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(669, 392);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Phone";
            this.label11.Click += new System.EventHandler(this.label3_Click);
            // 
            // Prof_age
            // 
            this.Prof_age.Location = new System.Drawing.Point(746, 362);
            this.Prof_age.Name = "Prof_age";
            this.Prof_age.Size = new System.Drawing.Size(100, 20);
            this.Prof_age.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(669, 418);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Experience";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(669, 332);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Prof ID";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(669, 452);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(73, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "DepartmentID";
            // 
            // Prof_phone
            // 
            this.Prof_phone.Location = new System.Drawing.Point(746, 392);
            this.Prof_phone.Name = "Prof_phone";
            this.Prof_phone.Size = new System.Drawing.Size(100, 20);
            this.Prof_phone.TabIndex = 1;
            this.Prof_phone.TextChanged += new System.EventHandler(this.textBox10_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(692, 395);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(0, 13);
            this.label15.TabIndex = 0;
            this.label15.Click += new System.EventHandler(this.label5_Click);
            // 
            // Prof_exp
            // 
            this.Prof_exp.Location = new System.Drawing.Point(746, 418);
            this.Prof_exp.Name = "Prof_exp";
            this.Prof_exp.Size = new System.Drawing.Size(100, 20);
            this.Prof_exp.TabIndex = 1;
            this.Prof_exp.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // Dep_ID
            // 
            this.Dep_ID.Location = new System.Drawing.Point(746, 452);
            this.Dep_ID.Name = "Dep_ID";
            this.Dep_ID.Size = new System.Drawing.Size(100, 20);
            this.Dep_ID.TabIndex = 1;
            this.Dep_ID.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(87, 316);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(58, 13);
            this.label16.TabIndex = 0;
            this.label16.Text = "Dep Name";
            this.label16.Click += new System.EventHandler(this.label1_Click);
            // 
            // Dep_name
            // 
            this.Dep_name.Location = new System.Drawing.Point(151, 314);
            this.Dep_name.Name = "Dep_name";
            this.Dep_name.Size = new System.Drawing.Size(100, 20);
            this.Dep_name.TabIndex = 1;
            this.Dep_name.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(85, 392);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(60, 13);
            this.label17.TabIndex = 0;
            this.label17.Text = "Description";
            // 
            // depID
            // 
            this.depID.Location = new System.Drawing.Point(151, 347);
            this.depID.Name = "depID";
            this.depID.Size = new System.Drawing.Size(100, 20);
            this.depID.TabIndex = 1;
            this.depID.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Description
            // 
            this.Description.Location = new System.Drawing.Point(151, 389);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(100, 20);
            this.Description.TabIndex = 1;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(87, 350);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(41, 13);
            this.label20.TabIndex = 0;
            this.label20.Text = "Dep ID";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(354, 398);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(0, 13);
            this.label22.TabIndex = 0;
            this.label22.Click += new System.EventHandler(this.label5_Click);
            // 
            // Add_Dep
            // 
            this.Add_Dep.Location = new System.Drawing.Point(90, 440);
            this.Add_Dep.Name = "Add_Dep";
            this.Add_Dep.Size = new System.Drawing.Size(91, 25);
            this.Add_Dep.TabIndex = 2;
            this.Add_Dep.Text = "Add_Dep";
            this.Add_Dep.UseVisualStyleBackColor = true;
            this.Add_Dep.Click += new System.EventHandler(this.Add_Dep1);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(1195, 332);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(71, 13);
            this.label18.TabIndex = 0;
            this.label18.Text = "Course Name";
            this.label18.Click += new System.EventHandler(this.label1_Click);
            // 
            // Course_name
            // 
            this.Course_name.Location = new System.Drawing.Point(1277, 329);
            this.Course_name.Name = "Course_name";
            this.Course_name.Size = new System.Drawing.Size(100, 20);
            this.Course_name.TabIndex = 1;
            this.Course_name.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(1195, 388);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(69, 13);
            this.label19.TabIndex = 0;
            this.label19.Text = "Course Level";
            // 
            // Course_ID
            // 
            this.Course_ID.Location = new System.Drawing.Point(1277, 358);
            this.Course_ID.Name = "Course_ID";
            this.Course_ID.Size = new System.Drawing.Size(100, 20);
            this.Course_ID.TabIndex = 1;
            this.Course_ID.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(1195, 414);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(65, 13);
            this.label21.TabIndex = 0;
            this.label21.Text = "Professor ID";
            this.label21.Click += new System.EventHandler(this.label3_Click);
            // 
            // Course_lvl
            // 
            this.Course_lvl.Location = new System.Drawing.Point(1277, 385);
            this.Course_lvl.Name = "Course_lvl";
            this.Course_lvl.Size = new System.Drawing.Size(100, 20);
            this.Course_lvl.TabIndex = 1;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(1195, 358);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(54, 13);
            this.label23.TabIndex = 0;
            this.label23.Text = "Course ID";
            // 
            // course_profid
            // 
            this.course_profid.Location = new System.Drawing.Point(1277, 411);
            this.course_profid.Name = "course_profid";
            this.course_profid.Size = new System.Drawing.Size(100, 20);
            this.course_profid.TabIndex = 1;
            this.course_profid.TextChanged += new System.EventHandler(this.textBox10_TextChanged);
            // 
            // Delete_prof
            // 
            this.Delete_prof.Location = new System.Drawing.Point(793, 509);
            this.Delete_prof.Name = "Delete_prof";
            this.Delete_prof.Size = new System.Drawing.Size(93, 25);
            this.Delete_prof.TabIndex = 2;
            this.Delete_prof.Text = "Delete_Prof";
            this.Delete_prof.UseVisualStyleBackColor = true;
            this.Delete_prof.Click += new System.EventHandler(this.Delete_prof1);
            // 
            // Delete_course
            // 
            this.Delete_course.Location = new System.Drawing.Point(1351, 488);
            this.Delete_course.Name = "Delete_course";
            this.Delete_course.Size = new System.Drawing.Size(100, 30);
            this.Delete_course.TabIndex = 2;
            this.Delete_course.Text = "Delete_course";
            this.Delete_course.UseVisualStyleBackColor = true;
            this.Delete_course.Click += new System.EventHandler(this.Delete_course1);
            // 
            // Update_dep
            // 
            this.Update_dep.Location = new System.Drawing.Point(88, 478);
            this.Update_dep.Name = "Update_dep";
            this.Update_dep.Size = new System.Drawing.Size(91, 25);
            this.Update_dep.TabIndex = 2;
            this.Update_dep.Text = "Update_Dep";
            this.Update_dep.UseVisualStyleBackColor = true;
            this.Update_dep.Click += new System.EventHandler(this.Update_dep1);
            // 
            // Update_prof
            // 
            this.Update_prof.Location = new System.Drawing.Point(683, 509);
            this.Update_prof.Name = "Update_prof";
            this.Update_prof.Size = new System.Drawing.Size(91, 25);
            this.Update_prof.TabIndex = 2;
            this.Update_prof.Text = "Update_prof";
            this.Update_prof.UseVisualStyleBackColor = true;
            this.Update_prof.Click += new System.EventHandler(this.Update_prof1);
            // 
            // Update_Course
            // 
            this.Update_Course.Location = new System.Drawing.Point(1233, 488);
            this.Update_Course.Name = "Update_Course";
            this.Update_Course.Size = new System.Drawing.Size(101, 30);
            this.Update_Course.TabIndex = 2;
            this.Update_Course.Text = "Update_Course";
            this.Update_Course.UseVisualStyleBackColor = true;
            this.Update_Course.Click += new System.EventHandler(this.Update_Course1);
            // 
            // Retrieve_prof
            // 
            this.Retrieve_prof.Location = new System.Drawing.Point(793, 478);
            this.Retrieve_prof.Name = "Retrieve_prof";
            this.Retrieve_prof.Size = new System.Drawing.Size(91, 25);
            this.Retrieve_prof.TabIndex = 2;
            this.Retrieve_prof.Text = "Retrieve_prof";
            this.Retrieve_prof.UseVisualStyleBackColor = true;
            this.Retrieve_prof.Click += new System.EventHandler(this.Retrieve_prof1);
            // 
            // Retrieve_Dep
            // 
            this.Retrieve_Dep.Location = new System.Drawing.Point(206, 440);
            this.Retrieve_Dep.Name = "Retrieve_Dep";
            this.Retrieve_Dep.Size = new System.Drawing.Size(91, 25);
            this.Retrieve_Dep.TabIndex = 2;
            this.Retrieve_Dep.Text = "Retrieve_Dep";
            this.Retrieve_Dep.UseVisualStyleBackColor = true;
            this.Retrieve_Dep.Click += new System.EventHandler(this.Retrieve_Dep1);
            // 
            // Retrieve_Course
            // 
            this.Retrieve_Course.Location = new System.Drawing.Point(1350, 452);
            this.Retrieve_Course.Name = "Retrieve_Course";
            this.Retrieve_Course.Size = new System.Drawing.Size(101, 30);
            this.Retrieve_Course.TabIndex = 2;
            this.Retrieve_Course.Text = "Retrieve_Course";
            this.Retrieve_Course.UseVisualStyleBackColor = true;
            this.Retrieve_Course.Click += new System.EventHandler(this.Retrieve_course1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1532, 602);
            this.Controls.Add(this.Dep_grid);
            this.Controls.Add(this.Prof_Grid);
            this.Controls.Add(this.Course_grid);
            this.Controls.Add(this.Delete_course);
            this.Controls.Add(this.Delete_prof);
            this.Controls.Add(this.Delete_Dep);
            this.Controls.Add(this.Update_Course);
            this.Controls.Add(this.Retrieve_Course);
            this.Controls.Add(this.Add_Course);
            this.Controls.Add(this.Update_dep);
            this.Controls.Add(this.Retrieve_Dep);
            this.Controls.Add(this.Add_Dep);
            this.Controls.Add(this.Update_prof);
            this.Controls.Add(this.Retrieve_prof);
            this.Controls.Add(this.Add_prof);
            this.Controls.Add(this.Dep_ID);
            this.Controls.Add(this.Prof_exp);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.course_profid);
            this.Controls.Add(this.Prof_phone);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.Course_lvl);
            this.Controls.Add(this.Prof_age);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.depID);
            this.Controls.Add(this.Course_ID);
            this.Controls.Add(this.Prof_ID);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Dep_name);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.Course_name);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.Prof_name);
            this.Controls.Add(this.label9);
            this.Name = "Form1";
            this.Text = "CRUD";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Course_grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Prof_Grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dep_grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Add_prof;
        private System.Windows.Forms.DataGridView Course_grid;
        private System.Windows.Forms.Button Add_Course;
        private System.Windows.Forms.Button Delete_Dep;
        private System.Windows.Forms.DataGridView Prof_Grid;
        private System.Windows.Forms.DataGridView Dep_grid;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Prof_name;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Prof_ID;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox Prof_age;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox Prof_phone;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox Prof_exp;
        private System.Windows.Forms.TextBox Dep_ID;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox Dep_name;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox depID;
        private System.Windows.Forms.TextBox Description;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button Add_Dep;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox Course_name;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox Course_ID;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox Course_lvl;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox course_profid;
        private System.Windows.Forms.Button Delete_prof;
        private System.Windows.Forms.Button Delete_course;
        private System.Windows.Forms.Button Update_dep;
        private System.Windows.Forms.Button Update_prof;
        private System.Windows.Forms.Button Update_Course;
        private System.Windows.Forms.Button Retrieve_prof;
        private System.Windows.Forms.Button Retrieve_Dep;
        private System.Windows.Forms.Button Retrieve_Course;
    }
}

