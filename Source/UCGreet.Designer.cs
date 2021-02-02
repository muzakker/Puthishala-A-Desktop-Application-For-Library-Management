
namespace Project.LMS.AppLayer
{
    partial class UCGreet
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
            this.pnlWelcome = new System.Windows.Forms.Panel();
            this.pnlWelcome2 = new System.Windows.Forms.Panel();
            this.txtBoxWelcome = new System.Windows.Forms.TextBox();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.pnlWelcome.SuspendLayout();
            this.pnlWelcome2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlWelcome
            // 
            this.pnlWelcome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.pnlWelcome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlWelcome.Controls.Add(this.pnlWelcome2);
            this.pnlWelcome.Location = new System.Drawing.Point(27, 82);
            this.pnlWelcome.Name = "pnlWelcome";
            this.pnlWelcome.Size = new System.Drawing.Size(599, 423);
            this.pnlWelcome.TabIndex = 2;
            // 
            // pnlWelcome2
            // 
            this.pnlWelcome2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(129)))), ((int)(((byte)(180)))));
            this.pnlWelcome2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlWelcome2.Controls.Add(this.txtBoxWelcome);
            this.pnlWelcome2.Controls.Add(this.lblWelcome);
            this.pnlWelcome2.Location = new System.Drawing.Point(15, 12);
            this.pnlWelcome2.Name = "pnlWelcome2";
            this.pnlWelcome2.Size = new System.Drawing.Size(566, 397);
            this.pnlWelcome2.TabIndex = 0;
            // 
            // txtBoxWelcome
            // 
            this.txtBoxWelcome.BackColor = System.Drawing.Color.Green;
            this.txtBoxWelcome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxWelcome.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxWelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.txtBoxWelcome.Location = new System.Drawing.Point(78, 192);
            this.txtBoxWelcome.Multiline = true;
            this.txtBoxWelcome.Name = "txtBoxWelcome";
            this.txtBoxWelcome.Size = new System.Drawing.Size(436, 82);
            this.txtBoxWelcome.TabIndex = 5;
            this.txtBoxWelcome.Text = "A Library Management System Developed as the Final Project of Object Oriented Pro" +
    "gramming - 2. ";
            this.txtBoxWelcome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.BackColor = System.Drawing.Color.Green;
            this.lblWelcome.Font = new System.Drawing.Font("Modern No. 20", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.lblWelcome.Location = new System.Drawing.Point(93, 94);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(397, 41);
            this.lblWelcome.TabIndex = 4;
            this.lblWelcome.Text = "Welcome to Puthishala";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // UCGreet
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(129)))), ((int)(((byte)(180)))));
            this.Controls.Add(this.pnlWelcome);
            this.Name = "UCGreet";
            this.Size = new System.Drawing.Size(658, 563);
            this.pnlWelcome.ResumeLayout(false);
            this.pnlWelcome2.ResumeLayout(false);
            this.pnlWelcome2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlWelcome;
        private System.Windows.Forms.Panel pnlWelcome2;
        private System.Windows.Forms.TextBox txtBoxWelcome;
        private System.Windows.Forms.Label lblWelcome;
    }
}
