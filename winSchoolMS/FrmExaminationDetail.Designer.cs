namespace winSchoolMS
{
    partial class FrmExaminationDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmExaminationDetail));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearchED = new System.Windows.Forms.TextBox();
            this.btnSearchED = new System.Windows.Forms.Button();
            this.gvExamDetail = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gvExamDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(242, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(257, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Examination Detail";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(108, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search";
            // 
            // txtSearchED
            // 
            this.txtSearchED.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtSearchED.Location = new System.Drawing.Point(155, 94);
            this.txtSearchED.Name = "txtSearchED";
            this.txtSearchED.Size = new System.Drawing.Size(442, 20);
            this.txtSearchED.TabIndex = 4;
            // 
            // btnSearchED
            // 
            this.btnSearchED.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnSearchED.Location = new System.Drawing.Point(615, 92);
            this.btnSearchED.Name = "btnSearchED";
            this.btnSearchED.Size = new System.Drawing.Size(75, 23);
            this.btnSearchED.TabIndex = 5;
            this.btnSearchED.Text = "Search";
            this.btnSearchED.UseVisualStyleBackColor = false;
            // 
            // gvExamDetail
            // 
            this.gvExamDetail.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.gvExamDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvExamDetail.Location = new System.Drawing.Point(77, 131);
            this.gvExamDetail.Name = "gvExamDetail";
            this.gvExamDetail.Size = new System.Drawing.Size(647, 310);
            this.gvExamDetail.TabIndex = 6;
            // 
            // FrmExaminationDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gvExamDetail);
            this.Controls.Add(this.btnSearchED);
            this.Controls.Add(this.txtSearchED);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmExaminationDetail";
            this.Text = "ExaminationDetail";
            ((System.ComponentModel.ISupportInitialize)(this.gvExamDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearchED;
        private System.Windows.Forms.Button btnSearchED;
        private System.Windows.Forms.DataGridView gvExamDetail;
    }
}