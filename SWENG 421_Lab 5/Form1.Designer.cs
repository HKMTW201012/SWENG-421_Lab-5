namespace SWENG_421_Lab_5
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
            this.lstModules = new System.Windows.Forms.ListBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.lblCurrent = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstModules
            // 
            this.lstModules.FormattingEnabled = true;
            this.lstModules.Location = new System.Drawing.Point(234, 110);
            this.lstModules.Name = "lstModules";
            this.lstModules.Size = new System.Drawing.Size(223, 108);
            this.lstModules.TabIndex = 0;
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(556, 156);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(75, 23);
            this.btnRun.TabIndex = 1;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // lblCurrent
            // 
            this.lblCurrent.AutoSize = true;
            this.lblCurrent.Location = new System.Drawing.Point(374, 278);
            this.lblCurrent.Name = "lblCurrent";
            this.lblCurrent.Size = new System.Drawing.Size(83, 13);
            this.lblCurrent.TabIndex = 2;
            this.lblCurrent.Text = "Current Value: 0";
            this.lblCurrent.Click += new System.EventHandler(this.lblCurrent_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCurrent);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.lstModules);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstModules;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Label lblCurrent;
    }
}

