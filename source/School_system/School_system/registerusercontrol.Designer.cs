namespace Exam_80437_C_Side_Solution
{
    partial class registerusercontrol
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.first = new System.Windows.Forms.Label();
            this.lblfirstname = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // first
            // 
            this.first.AutoSize = true;
            this.first.Location = new System.Drawing.Point(3, 0);
            this.first.Name = "first";
            this.first.Size = new System.Drawing.Size(112, 17);
            this.first.TabIndex = 0;
            this.first.Text = "lbl_firstname";
            // 
            // lblfirstname
            // 
            this.lblfirstname.AutoSize = true;
            this.lblfirstname.Location = new System.Drawing.Point(3, 17);
            this.lblfirstname.Name = "lblfirstname";
            this.lblfirstname.Size = new System.Drawing.Size(112, 17);
            this.lblfirstname.TabIndex = 1;
            this.lblfirstname.Text = "lbl_firstname";
            // 
            // registerusercontrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblfirstname);
            this.Controls.Add(this.first);
            this.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "registerusercontrol";
            this.Size = new System.Drawing.Size(388, 399);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label first;
        private System.Windows.Forms.Label lblfirstname;
    }
}
