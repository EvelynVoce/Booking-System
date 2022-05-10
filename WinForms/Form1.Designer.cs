namespace WinForms
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
            this.btn_hello = new System.Windows.Forms.Button();
            this.lbl_title = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.surgeryDrop = new System.Windows.Forms.ComboBox();
            this.doctorDrop = new System.Windows.Forms.ComboBox();
            this.lblSurgery = new System.Windows.Forms.Label();
            this.lblDoctor = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_hello
            // 
            this.btn_hello.Location = new System.Drawing.Point(292, 389);
            this.btn_hello.Name = "btn_hello";
            this.btn_hello.Size = new System.Drawing.Size(189, 40);
            this.btn_hello.TabIndex = 0;
            this.btn_hello.Text = " Book";
            this.btn_hello.UseVisualStyleBackColor = true;
            this.btn_hello.Click += new System.EventHandler(this.btn_hello_Click);
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lbl_title.Location = new System.Drawing.Point(273, 23);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(236, 26);
            this.lbl_title.TabIndex = 1;
            this.lbl_title.Text = "Book your appointment";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(442, 234);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(148, 20);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // surgeryDrop
            // 
            this.surgeryDrop.FormattingEnabled = true;
            this.surgeryDrop.Location = new System.Drawing.Point(442, 119);
            this.surgeryDrop.Name = "surgeryDrop";
            this.surgeryDrop.Size = new System.Drawing.Size(148, 21);
            this.surgeryDrop.TabIndex = 3;
            // 
            // doctorDrop
            // 
            this.doctorDrop.FormattingEnabled = true;
            this.doctorDrop.Location = new System.Drawing.Point(442, 177);
            this.doctorDrop.Name = "doctorDrop";
            this.doctorDrop.Size = new System.Drawing.Size(148, 21);
            this.doctorDrop.TabIndex = 4;
            // 
            // lblSurgery
            // 
            this.lblSurgery.AutoSize = true;
            this.lblSurgery.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblSurgery.Location = new System.Drawing.Point(292, 119);
            this.lblSurgery.Name = "lblSurgery";
            this.lblSurgery.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblSurgery.Size = new System.Drawing.Size(94, 26);
            this.lblSurgery.TabIndex = 5;
            this.lblSurgery.Text = "Surgery:";
            // 
            // lblDoctor
            // 
            this.lblDoctor.AutoSize = true;
            this.lblDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblDoctor.Location = new System.Drawing.Point(292, 172);
            this.lblDoctor.Name = "lblDoctor";
            this.lblDoctor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDoctor.Size = new System.Drawing.Size(82, 26);
            this.lblDoctor.TabIndex = 6;
            this.lblDoctor.Text = "Doctor:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblDate.Location = new System.Drawing.Point(292, 228);
            this.lblDate.Name = "lblDate";
            this.lblDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDate.Size = new System.Drawing.Size(64, 26);
            this.lblDate.TabIndex = 7;
            this.lblDate.Text = "Date:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblDoctor);
            this.Controls.Add(this.lblSurgery);
            this.Controls.Add(this.doctorDrop);
            this.Controls.Add(this.surgeryDrop);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.btn_hello);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_hello;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox surgeryDrop;
        private System.Windows.Forms.ComboBox doctorDrop;
        private System.Windows.Forms.Label lblSurgery;
        private System.Windows.Forms.Label lblDoctor;
        private System.Windows.Forms.Label lblDate;
    }
}

