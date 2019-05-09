namespace HotelBooking
{
    partial class CheckOutForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkOutNameTxtBX = new System.Windows.Forms.TextBox();
            this.checkOutRoomNumberTxtBx = new System.Windows.Forms.TextBox();
            this.finalCheckOutBtn = new System.Windows.Forms.Button();
            this.customerInfoListBx = new System.Windows.Forms.ListBox();
            this.prizeListBx = new System.Windows.Forms.ListBox();
            this.backBtn = new System.Windows.Forms.Button();
            this.exitBtnCheckOut = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.checkOutNameTxtBX);
            this.groupBox1.Controls.Add(this.checkOutRoomNumberTxtBx);
            this.groupBox1.Controls.Add(this.finalCheckOutBtn);
            this.groupBox1.Location = new System.Drawing.Point(22, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(247, 198);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "OR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Room Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name (Frist Last)";
            // 
            // checkOutNameTxtBX
            // 
            this.checkOutNameTxtBX.Location = new System.Drawing.Point(98, 13);
            this.checkOutNameTxtBX.Name = "checkOutNameTxtBX";
            this.checkOutNameTxtBX.Size = new System.Drawing.Size(129, 20);
            this.checkOutNameTxtBX.TabIndex = 2;
            // 
            // checkOutRoomNumberTxtBx
            // 
            this.checkOutRoomNumberTxtBx.Location = new System.Drawing.Point(98, 87);
            this.checkOutRoomNumberTxtBx.Name = "checkOutRoomNumberTxtBx";
            this.checkOutRoomNumberTxtBx.Size = new System.Drawing.Size(129, 20);
            this.checkOutRoomNumberTxtBx.TabIndex = 1;
            // 
            // finalCheckOutBtn
            // 
            this.finalCheckOutBtn.Location = new System.Drawing.Point(49, 130);
            this.finalCheckOutBtn.Name = "finalCheckOutBtn";
            this.finalCheckOutBtn.Size = new System.Drawing.Size(117, 41);
            this.finalCheckOutBtn.TabIndex = 0;
            this.finalCheckOutBtn.Text = "Check Out";
            this.finalCheckOutBtn.UseVisualStyleBackColor = true;
            this.finalCheckOutBtn.Click += new System.EventHandler(this.finalCheckOutBtn_Click);
            // 
            // customerInfoListBx
            // 
            this.customerInfoListBx.FormattingEnabled = true;
            this.customerInfoListBx.Location = new System.Drawing.Point(314, 25);
            this.customerInfoListBx.Name = "customerInfoListBx";
            this.customerInfoListBx.Size = new System.Drawing.Size(228, 329);
            this.customerInfoListBx.TabIndex = 1;
            // 
            // prizeListBx
            // 
            this.prizeListBx.FormattingEnabled = true;
            this.prizeListBx.Location = new System.Drawing.Point(22, 243);
            this.prizeListBx.Name = "prizeListBx";
            this.prizeListBx.Size = new System.Drawing.Size(247, 108);
            this.prizeListBx.TabIndex = 2;
            this.prizeListBx.SelectedIndexChanged += new System.EventHandler(this.prizeListBx_SelectedIndexChanged);
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(31, 357);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(75, 23);
            this.backBtn.TabIndex = 3;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // exitBtnCheckOut
            // 
            this.exitBtnCheckOut.Location = new System.Drawing.Point(174, 357);
            this.exitBtnCheckOut.Name = "exitBtnCheckOut";
            this.exitBtnCheckOut.Size = new System.Drawing.Size(75, 23);
            this.exitBtnCheckOut.TabIndex = 4;
            this.exitBtnCheckOut.Text = "Exit";
            this.exitBtnCheckOut.UseVisualStyleBackColor = true;
            this.exitBtnCheckOut.Click += new System.EventHandler(this.exitBtnCheckOut_Click);
            // 
            // CheckOutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 408);
            this.Controls.Add(this.exitBtnCheckOut);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.prizeListBx);
            this.Controls.Add(this.customerInfoListBx);
            this.Controls.Add(this.groupBox1);
            this.Name = "CheckOutForm";
            this.Text = "Check Out";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox checkOutNameTxtBX;
        private System.Windows.Forms.TextBox checkOutRoomNumberTxtBx;
        private System.Windows.Forms.Button finalCheckOutBtn;
        private System.Windows.Forms.ListBox customerInfoListBx;
        private System.Windows.Forms.ListBox prizeListBx;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button exitBtnCheckOut;
    }
}