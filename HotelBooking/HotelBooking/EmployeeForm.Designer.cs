namespace HotelBooking
{
    partial class EmployeeForm
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
            this.checkInBtn = new System.Windows.Forms.Button();
            this.checkOutBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkInBtn
            // 
            this.checkInBtn.Location = new System.Drawing.Point(50, 34);
            this.checkInBtn.Name = "checkInBtn";
            this.checkInBtn.Size = new System.Drawing.Size(189, 110);
            this.checkInBtn.TabIndex = 0;
            this.checkInBtn.Text = "Check In";
            this.checkInBtn.UseVisualStyleBackColor = true;
            this.checkInBtn.Click += new System.EventHandler(this.checkInBtn_Click);
            // 
            // checkOutBtn
            // 
            this.checkOutBtn.Location = new System.Drawing.Point(50, 196);
            this.checkOutBtn.Name = "checkOutBtn";
            this.checkOutBtn.Size = new System.Drawing.Size(189, 110);
            this.checkOutBtn.TabIndex = 1;
            this.checkOutBtn.Text = "Check Out";
            this.checkOutBtn.UseVisualStyleBackColor = true;
            this.checkOutBtn.Click += new System.EventHandler(this.checkOutBtn_Click);
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 347);
            this.Controls.Add(this.checkOutBtn);
            this.Controls.Add(this.checkInBtn);
            this.Name = "EmployeeForm";
            this.Text = "Employee";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button checkInBtn;
        private System.Windows.Forms.Button checkOutBtn;
    }
}