namespace HotelBooking
{
    partial class AdminForm
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
            this.adminEnterBtn = new System.Windows.Forms.Button();
            this.suiteYesRadioBtn = new System.Windows.Forms.RadioButton();
            this.suiteNoRadioBtn = new System.Windows.Forms.RadioButton();
            this.suiteGrpBx = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.amtRoomsTxtBx = new System.Windows.Forms.TextBox();
            this.twoBedRoomsTxtBx = new System.Windows.Forms.TextBox();
            this.smokingRoomsTxtBx = new System.Windows.Forms.TextBox();
            this.balconyRoomsTxtBx = new System.Windows.Forms.TextBox();
            this.startingRoomNumTxtBx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.adminFormExit = new System.Windows.Forms.Button();
            this.reportBtn = new System.Windows.Forms.Button();
            this.repairbtn = new System.Windows.Forms.Button();
            this.suiteGrpBx.SuspendLayout();
            this.SuspendLayout();
            // 
            // adminEnterBtn
            // 
            this.adminEnterBtn.Location = new System.Drawing.Point(154, 399);
            this.adminEnterBtn.Name = "adminEnterBtn";
            this.adminEnterBtn.Size = new System.Drawing.Size(91, 28);
            this.adminEnterBtn.TabIndex = 0;
            this.adminEnterBtn.Text = "Submit";
            this.adminEnterBtn.UseVisualStyleBackColor = true;
            this.adminEnterBtn.Click += new System.EventHandler(this.adminEnterBtn_Click);
            // 
            // suiteYesRadioBtn
            // 
            this.suiteYesRadioBtn.AutoSize = true;
            this.suiteYesRadioBtn.Location = new System.Drawing.Point(210, 19);
            this.suiteYesRadioBtn.Name = "suiteYesRadioBtn";
            this.suiteYesRadioBtn.Size = new System.Drawing.Size(43, 17);
            this.suiteYesRadioBtn.TabIndex = 8;
            this.suiteYesRadioBtn.TabStop = true;
            this.suiteYesRadioBtn.Text = "Yes";
            this.suiteYesRadioBtn.UseVisualStyleBackColor = true;
            this.suiteYesRadioBtn.CheckedChanged += new System.EventHandler(this.suiteYesRadioBtn_CheckedChanged);
            // 
            // suiteNoRadioBtn
            // 
            this.suiteNoRadioBtn.AutoSize = true;
            this.suiteNoRadioBtn.Location = new System.Drawing.Point(271, 19);
            this.suiteNoRadioBtn.Name = "suiteNoRadioBtn";
            this.suiteNoRadioBtn.Size = new System.Drawing.Size(39, 17);
            this.suiteNoRadioBtn.TabIndex = 9;
            this.suiteNoRadioBtn.TabStop = true;
            this.suiteNoRadioBtn.Text = "No";
            this.suiteNoRadioBtn.UseVisualStyleBackColor = true;
            this.suiteNoRadioBtn.CheckedChanged += new System.EventHandler(this.suiteNoRadioBtn_CheckedChanged);
            // 
            // suiteGrpBx
            // 
            this.suiteGrpBx.Controls.Add(this.label7);
            this.suiteGrpBx.Controls.Add(this.suiteNoRadioBtn);
            this.suiteGrpBx.Controls.Add(this.suiteYesRadioBtn);
            this.suiteGrpBx.Location = new System.Drawing.Point(49, 318);
            this.suiteGrpBx.Name = "suiteGrpBx";
            this.suiteGrpBx.Size = new System.Drawing.Size(310, 46);
            this.suiteGrpBx.TabIndex = 10;
            this.suiteGrpBx.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Does you hotel have a suite?";
            // 
            // amtRoomsTxtBx
            // 
            this.amtRoomsTxtBx.Location = new System.Drawing.Point(259, 50);
            this.amtRoomsTxtBx.Name = "amtRoomsTxtBx";
            this.amtRoomsTxtBx.Size = new System.Drawing.Size(100, 20);
            this.amtRoomsTxtBx.TabIndex = 11;
            // 
            // twoBedRoomsTxtBx
            // 
            this.twoBedRoomsTxtBx.Location = new System.Drawing.Point(259, 95);
            this.twoBedRoomsTxtBx.Name = "twoBedRoomsTxtBx";
            this.twoBedRoomsTxtBx.Size = new System.Drawing.Size(100, 20);
            this.twoBedRoomsTxtBx.TabIndex = 12;
            // 
            // smokingRoomsTxtBx
            // 
            this.smokingRoomsTxtBx.Location = new System.Drawing.Point(259, 139);
            this.smokingRoomsTxtBx.Name = "smokingRoomsTxtBx";
            this.smokingRoomsTxtBx.Size = new System.Drawing.Size(100, 20);
            this.smokingRoomsTxtBx.TabIndex = 13;
            // 
            // balconyRoomsTxtBx
            // 
            this.balconyRoomsTxtBx.Location = new System.Drawing.Point(259, 182);
            this.balconyRoomsTxtBx.Name = "balconyRoomsTxtBx";
            this.balconyRoomsTxtBx.Size = new System.Drawing.Size(100, 20);
            this.balconyRoomsTxtBx.TabIndex = 14;
            // 
            // startingRoomNumTxtBx
            // 
            this.startingRoomNumTxtBx.Location = new System.Drawing.Point(259, 229);
            this.startingRoomNumTxtBx.Name = "startingRoomNumTxtBx";
            this.startingRoomNumTxtBx.Size = new System.Drawing.Size(100, 20);
            this.startingRoomNumTxtBx.TabIndex = 15;
            this.startingRoomNumTxtBx.TextChanged += new System.EventHandler(this.startingRoomNumberTxtBx_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "How many rooms does your hotel have?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "How many rooms have 2 beds?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "How many rooms do you allow smoking in?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "How many rooms have a balcony?";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "What is the starting room Number?";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 283);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(217, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Do you have rooms that are down for repair?";
            // 
            // adminFormExit
            // 
            this.adminFormExit.Location = new System.Drawing.Point(52, 399);
            this.adminFormExit.Name = "adminFormExit";
            this.adminFormExit.Size = new System.Drawing.Size(91, 28);
            this.adminFormExit.TabIndex = 23;
            this.adminFormExit.Text = "Exit";
            this.adminFormExit.UseVisualStyleBackColor = true;
            this.adminFormExit.Click += new System.EventHandler(this.adminFormExit_Click);
            // 
            // reportBtn
            // 
            this.reportBtn.Location = new System.Drawing.Point(262, 399);
            this.reportBtn.Name = "reportBtn";
            this.reportBtn.Size = new System.Drawing.Size(91, 28);
            this.reportBtn.TabIndex = 24;
            this.reportBtn.Text = "Report";
            this.reportBtn.UseVisualStyleBackColor = true;
            // 
            // repairbtn
            // 
            this.repairbtn.Location = new System.Drawing.Point(284, 269);
            this.repairbtn.Name = "repairbtn";
            this.repairbtn.Size = new System.Drawing.Size(75, 43);
            this.repairbtn.TabIndex = 25;
            this.repairbtn.Text = "Enter Rooms";
            this.repairbtn.UseVisualStyleBackColor = true;
            this.repairbtn.Click += new System.EventHandler(this.repairbtn_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 450);
            this.Controls.Add(this.repairbtn);
            this.Controls.Add(this.reportBtn);
            this.Controls.Add(this.adminFormExit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.startingRoomNumTxtBx);
            this.Controls.Add(this.balconyRoomsTxtBx);
            this.Controls.Add(this.smokingRoomsTxtBx);
            this.Controls.Add(this.twoBedRoomsTxtBx);
            this.Controls.Add(this.amtRoomsTxtBx);
            this.Controls.Add(this.suiteGrpBx);
            this.Controls.Add(this.adminEnterBtn);
            this.Name = "AdminForm";
            this.Text = "Administrator";
            this.suiteGrpBx.ResumeLayout(false);
            this.suiteGrpBx.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button adminEnterBtn;
        private System.Windows.Forms.RadioButton suiteYesRadioBtn;
        private System.Windows.Forms.RadioButton suiteNoRadioBtn;
        private System.Windows.Forms.GroupBox suiteGrpBx;
        private System.Windows.Forms.TextBox amtRoomsTxtBx;
        private System.Windows.Forms.TextBox twoBedRoomsTxtBx;
        private System.Windows.Forms.TextBox smokingRoomsTxtBx;
        private System.Windows.Forms.TextBox balconyRoomsTxtBx;
        private System.Windows.Forms.TextBox startingRoomNumTxtBx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button adminFormExit;
        private System.Windows.Forms.Button reportBtn;
        private System.Windows.Forms.Button repairbtn;
    }
}