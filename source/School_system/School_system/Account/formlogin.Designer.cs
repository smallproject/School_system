namespace Exam_80437_C_Side_Solution
{
    partial class formlogin
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
            this.lblwelcome = new System.Windows.Forms.Label();
            this.lbluser = new System.Windows.Forms.Label();
            this.lblpassword = new System.Windows.Forms.Label();
            this.txtbuser = new System.Windows.Forms.TextBox();
            this.txtbpass = new System.Windows.Forms.TextBox();
            this.btnlogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblwelcome
            // 
            this.lblwelcome.AutoSize = true;
            this.lblwelcome.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblwelcome.Location = new System.Drawing.Point(12, 9);
            this.lblwelcome.Name = "lblwelcome";
            this.lblwelcome.Size = new System.Drawing.Size(88, 17);
            this.lblwelcome.TabIndex = 0;
            this.lblwelcome.Text = "lblwelcome";
            // 
            // lbluser
            // 
            this.lbluser.AutoSize = true;
            this.lbluser.Location = new System.Drawing.Point(40, 107);
            this.lbluser.Name = "lbluser";
            this.lbluser.Size = new System.Drawing.Size(64, 17);
            this.lbluser.TabIndex = 1;
            this.lbluser.Text = "lbluser";
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.Location = new System.Drawing.Point(40, 139);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(96, 17);
            this.lblpassword.TabIndex = 2;
            this.lblpassword.Text = "lblpassword";
            // 
            // txtbuser
            // 
            this.txtbuser.Location = new System.Drawing.Point(142, 104);
            this.txtbuser.Name = "txtbuser";
            this.txtbuser.Size = new System.Drawing.Size(137, 23);
            this.txtbuser.TabIndex = 3;
            this.txtbuser.Text = "txtbuser";
            // 
            // txtbpass
            // 
            this.txtbpass.Location = new System.Drawing.Point(142, 136);
            this.txtbpass.Name = "txtbpass";
            this.txtbpass.Size = new System.Drawing.Size(137, 23);
            this.txtbpass.TabIndex = 4;
            this.txtbpass.Text = "txtbpass";
            // 
            // btnlogin
            // 
            this.btnlogin.Location = new System.Drawing.Point(190, 165);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(89, 30);
            this.btnlogin.TabIndex = 5;
            this.btnlogin.Text = "btnlogin";
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // formlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 209);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.txtbpass);
            this.Controls.Add(this.txtbuser);
            this.Controls.Add(this.lblpassword);
            this.Controls.Add(this.lbluser);
            this.Controls.Add(this.lblwelcome);
            this.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "formlogin";
            this.Text = "Log in";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblwelcome;
        private System.Windows.Forms.Label lbluser;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.TextBox txtbuser;
        private System.Windows.Forms.TextBox txtbpass;
        private System.Windows.Forms.Button btnlogin;
    }
}

