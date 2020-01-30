namespace Status
{
    partial class StudentStatus
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
            this.lblNameCredits = new System.Windows.Forms.Label();
            this.txtCredits = new System.Windows.Forms.TextBox();
            this.btnWhatStatus = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNameCredits
            // 
            this.lblNameCredits.AutoSize = true;
            this.lblNameCredits.Location = new System.Drawing.Point(130, 110);
            this.lblNameCredits.Name = "lblNameCredits";
            this.lblNameCredits.Size = new System.Drawing.Size(90, 13);
            this.lblNameCredits.TabIndex = 0;
            this.lblNameCredits.Text = "Number of credits";
            // 
            // txtCredits
            // 
            this.txtCredits.Location = new System.Drawing.Point(359, 107);
            this.txtCredits.Name = "txtCredits";
            this.txtCredits.Size = new System.Drawing.Size(100, 20);
            this.txtCredits.TabIndex = 1;
            // 
            // btnWhatStatus
            // 
            this.btnWhatStatus.Location = new System.Drawing.Point(247, 227);
            this.btnWhatStatus.Name = "btnWhatStatus";
            this.btnWhatStatus.Size = new System.Drawing.Size(135, 23);
            this.btnWhatStatus.TabIndex = 2;
            this.btnWhatStatus.Text = "What\'s my status?";
            this.btnWhatStatus.UseVisualStyleBackColor = true;
            this.btnWhatStatus.Click += new System.EventHandler(this.btnWhatStatus_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(244, 315);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(100, 23);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "Status shown here";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblStatus.Click += new System.EventHandler(this.label2_Click);
            // 
            // StudentStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnWhatStatus);
            this.Controls.Add(this.txtCredits);
            this.Controls.Add(this.lblNameCredits);
            this.Name = "StudentStatus";
            this.Text = "Student Status";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNameCredits;
        private System.Windows.Forms.TextBox txtCredits;
        private System.Windows.Forms.Button btnWhatStatus;
        private System.Windows.Forms.Label lblStatus;
    }
}

