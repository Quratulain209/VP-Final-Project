namespace winSchoolMS
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.label2 = new System.Windows.Forms.Label();
            this.lblCreateanAccount = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPassward = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label2.Location = new System.Drawing.Point(504, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 37);
            this.label2.TabIndex = 4;
            this.label2.Text = "Login ";
            // 
            // lblCreateanAccount
            // 
            this.lblCreateanAccount.AutoSize = true;
            this.lblCreateanAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateanAccount.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblCreateanAccount.Location = new System.Drawing.Point(561, 345);
            this.lblCreateanAccount.Name = "lblCreateanAccount";
            this.lblCreateanAccount.Size = new System.Drawing.Size(115, 16);
            this.lblCreateanAccount.TabIndex = 16;
            this.lblCreateanAccount.Text = "Create an account";
            this.lblCreateanAccount.Click += new System.EventHandler(this.lblCreateanAccount_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label6.Location = new System.Drawing.Point(450, 345);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "Not Registered yet?";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnLogin.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLogin.Location = new System.Drawing.Point(517, 257);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(92, 41);
            this.btnLogin.TabIndex = 14;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label7.Location = new System.Drawing.Point(342, 212);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Password";
            // 
            // txtPassward
            // 
            this.txtPassward.Location = new System.Drawing.Point(427, 206);
            this.txtPassward.Multiline = true;
            this.txtPassward.Name = "txtPassward";
            this.txtPassward.Size = new System.Drawing.Size(273, 31);
            this.txtPassward.TabIndex = 11;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(427, 157);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(273, 31);
            this.txtName.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label8.Location = new System.Drawing.Point(339, 165);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 16);
            this.label8.TabIndex = 13;
            this.label8.Text = "UserName";
            // 
            // pbxLogo
            // 
            this.pbxLogo.Image = global::winSchoolMS.Properties.Resources.logo_removebg_preview;
            this.pbxLogo.Location = new System.Drawing.Point(37, 91);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(231, 225);
            this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxLogo.TabIndex = 17;
            this.pbxLogo.TabStop = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(749, 414);
            this.Controls.Add(this.pbxLogo);
            this.Controls.Add(this.lblCreateanAccount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPassward);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLogin";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCreateanAccount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPassward;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pbxLogo;
    }
}