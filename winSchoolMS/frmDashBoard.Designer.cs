namespace winSchoolMS
{
    partial class frmDashBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDashBoard));
            this.studentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personalInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.educationalInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentsDetailViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teacherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teacherInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newTeacherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.attendanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.teacherToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.accountsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.courseAllocationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.examinationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miscellinousToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.feesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.defaulterStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // studentToolStripMenuItem
            // 
            this.studentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personalInformationToolStripMenuItem,
            this.educationalInformationToolStripMenuItem,
            this.studentsDetailViewToolStripMenuItem});
            this.studentToolStripMenuItem.Name = "studentToolStripMenuItem";
            this.studentToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.studentToolStripMenuItem.Text = "Student";
            // 
            // personalInformationToolStripMenuItem
            // 
            this.personalInformationToolStripMenuItem.Name = "personalInformationToolStripMenuItem";
            this.personalInformationToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.personalInformationToolStripMenuItem.Text = "Personal Information";
            this.personalInformationToolStripMenuItem.Click += new System.EventHandler(this.personalInformationToolStripMenuItem_Click);
            // 
            // educationalInformationToolStripMenuItem
            // 
            this.educationalInformationToolStripMenuItem.Name = "educationalInformationToolStripMenuItem";
            this.educationalInformationToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.educationalInformationToolStripMenuItem.Text = "Educational Information";
            this.educationalInformationToolStripMenuItem.Click += new System.EventHandler(this.educationalInformationToolStripMenuItem_Click);
            // 
            // studentsDetailViewToolStripMenuItem
            // 
            this.studentsDetailViewToolStripMenuItem.Name = "studentsDetailViewToolStripMenuItem";
            this.studentsDetailViewToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.studentsDetailViewToolStripMenuItem.Text = "Students Detail View";
            this.studentsDetailViewToolStripMenuItem.Click += new System.EventHandler(this.studentsDetailViewToolStripMenuItem_Click);
            // 
            // teacherToolStripMenuItem
            // 
            this.teacherToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.teacherInfoToolStripMenuItem,
            this.newTeacherToolStripMenuItem});
            this.teacherToolStripMenuItem.Name = "teacherToolStripMenuItem";
            this.teacherToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.teacherToolStripMenuItem.Text = "Teacher";
            // 
            // teacherInfoToolStripMenuItem
            // 
            this.teacherInfoToolStripMenuItem.Name = "teacherInfoToolStripMenuItem";
            this.teacherInfoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.teacherInfoToolStripMenuItem.Text = "Teacher Detail View";
            this.teacherInfoToolStripMenuItem.Click += new System.EventHandler(this.teacherInfoToolStripMenuItem_Click);
            // 
            // newTeacherToolStripMenuItem
            // 
            this.newTeacherToolStripMenuItem.Name = "newTeacherToolStripMenuItem";
            this.newTeacherToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newTeacherToolStripMenuItem.Text = "Teacher Detail";
            this.newTeacherToolStripMenuItem.Click += new System.EventHandler(this.newTeacherToolStripMenuItem_Click);
            // 
            // attendanceToolStripMenuItem
            // 
            this.attendanceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentToolStripMenuItem1,
            this.teacherToolStripMenuItem1});
            this.attendanceToolStripMenuItem.Name = "attendanceToolStripMenuItem";
            this.attendanceToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.attendanceToolStripMenuItem.Text = "Attendance";
            // 
            // studentToolStripMenuItem1
            // 
            this.studentToolStripMenuItem1.Name = "studentToolStripMenuItem1";
            this.studentToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.studentToolStripMenuItem1.Text = "Student";
            this.studentToolStripMenuItem1.Click += new System.EventHandler(this.studentToolStripMenuItem1_Click);
            // 
            // teacherToolStripMenuItem1
            // 
            this.teacherToolStripMenuItem1.Name = "teacherToolStripMenuItem1";
            this.teacherToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.teacherToolStripMenuItem1.Text = "Teacher";
            this.teacherToolStripMenuItem1.Click += new System.EventHandler(this.teacherToolStripMenuItem1_Click);
            // 
            // accountsToolStripMenuItem
            // 
            this.accountsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.feesToolStripMenuItem,
            this.defaulterStudentToolStripMenuItem});
            this.accountsToolStripMenuItem.Name = "accountsToolStripMenuItem";
            this.accountsToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.accountsToolStripMenuItem.Text = "Accounts";
            // 
            // courseAllocationToolStripMenuItem
            // 
            this.courseAllocationToolStripMenuItem.Name = "courseAllocationToolStripMenuItem";
            this.courseAllocationToolStripMenuItem.Size = new System.Drawing.Size(113, 20);
            this.courseAllocationToolStripMenuItem.Text = "Course Allocation";
            // 
            // examinationToolStripMenuItem
            // 
            this.examinationToolStripMenuItem.Name = "examinationToolStripMenuItem";
            this.examinationToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.examinationToolStripMenuItem.Text = "Examination";
            // 
            // miscellinousToolStripMenuItem
            // 
            this.miscellinousToolStripMenuItem.Name = "miscellinousToolStripMenuItem";
            this.miscellinousToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.miscellinousToolStripMenuItem.Text = "Miscellinous";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentToolStripMenuItem,
            this.teacherToolStripMenuItem,
            this.attendanceToolStripMenuItem,
            this.accountsToolStripMenuItem,
            this.courseAllocationToolStripMenuItem,
            this.examinationToolStripMenuItem,
            this.miscellinousToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(113, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(687, 53);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(119, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(408, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Active Learning Schooling System";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::winSchoolMS.Properties.Resources.logo_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(7, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 53);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // feesToolStripMenuItem
            // 
            this.feesToolStripMenuItem.Name = "feesToolStripMenuItem";
            this.feesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.feesToolStripMenuItem.Text = "Fees";
            this.feesToolStripMenuItem.Click += new System.EventHandler(this.feesToolStripMenuItem_Click);
            // 
            // defaulterStudentToolStripMenuItem
            // 
            this.defaulterStudentToolStripMenuItem.Name = "defaulterStudentToolStripMenuItem";
            this.defaulterStudentToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.defaulterStudentToolStripMenuItem.Text = "Defaulter Student";
            this.defaulterStudentToolStripMenuItem.Click += new System.EventHandler(this.defaulterStudentToolStripMenuItem_Click);
            // 
            // frmDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDashBoard";
            this.Text = "DashBoard";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem studentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personalInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem educationalInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teacherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teacherInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newTeacherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem attendanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem teacherToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem accountsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem courseAllocationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem examinationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miscellinousToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem studentsDetailViewToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem feesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem defaulterStudentToolStripMenuItem;
    }
}

