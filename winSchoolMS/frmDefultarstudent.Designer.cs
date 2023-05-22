namespace winSchoolMS
{
    partial class frmDefultarstudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDefultarstudent));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDSLSearch = new System.Windows.Forms.TextBox();
            this.btnSDLSearch = new System.Windows.Forms.Button();
            this.gvDefaulterrStudent = new System.Windows.Forms.DataGridView();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvDefaulterrStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(251, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Defaulter Student List";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(88, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Search";
            // 
            // txtDSLSearch
            // 
            this.txtDSLSearch.Location = new System.Drawing.Point(135, 95);
            this.txtDSLSearch.Name = "txtDSLSearch";
            this.txtDSLSearch.Size = new System.Drawing.Size(287, 20);
            this.txtDSLSearch.TabIndex = 2;
            // 
            // btnSDLSearch
            // 
            this.btnSDLSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnSDLSearch.Location = new System.Drawing.Point(625, 93);
            this.btnSDLSearch.Name = "btnSDLSearch";
            this.btnSDLSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSDLSearch.TabIndex = 3;
            this.btnSDLSearch.Text = "Search";
            this.btnSDLSearch.UseVisualStyleBackColor = false;
            // 
            // gvDefaulterrStudent
            // 
            this.gvDefaulterrStudent.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.gvDefaulterrStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvDefaulterrStudent.Location = new System.Drawing.Point(91, 147);
            this.gvDefaulterrStudent.Name = "gvDefaulterrStudent";
            this.gvDefaulterrStudent.Size = new System.Drawing.Size(609, 277);
            this.gvDefaulterrStudent.TabIndex = 4;
            // 
            // cmbMonth
            // 
            this.cmbMonth.FormattingEnabled = true;
            this.cmbMonth.Items.AddRange(new object[] {
            "One Month",
            "Two Month\'s",
            "Three Month\'s",
            "Four Month\'s",
            "Five Month\'s",
            "Six Month\'s",
            "Seven Month\'s",
            "Eight Month\'s",
            "Nine Month\'s",
            "Ten Month\'s",
            "Eleven Month\'s",
            "One Year"});
            this.cmbMonth.Location = new System.Drawing.Point(479, 95);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(140, 21);
            this.cmbMonth.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(428, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Month";
            // 
            // frmDefultarstudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbMonth);
            this.Controls.Add(this.gvDefaulterrStudent);
            this.Controls.Add(this.btnSDLSearch);
            this.Controls.Add(this.txtDSLSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDefultarstudent";
            this.Text = "Defultarstudent";
            ((System.ComponentModel.ISupportInitialize)(this.gvDefaulterrStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDSLSearch;
        private System.Windows.Forms.Button btnSDLSearch;
        private System.Windows.Forms.DataGridView gvDefaulterrStudent;
        private System.Windows.Forms.ComboBox cmbMonth;
        private System.Windows.Forms.Label label3;
    }
}