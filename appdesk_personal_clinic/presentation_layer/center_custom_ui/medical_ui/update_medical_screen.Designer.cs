namespace presentation_layer.center_custom_ui.medical_ui
{
    partial class update_medical_screen
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.tbxHistoryMedicalRecord = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cbxMedicalRecordRequest = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.cbxMedicalRecordPatient = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dtpMedicalRecord = new System.Windows.Forms.DateTimePicker();
            this.cbxMedicalRecordDoctor = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnCancelMedical = new System.Windows.Forms.Button();
            this.btnUpdateMedical = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbidMedicalRecord = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.panel7);
            this.groupBox3.Controls.Add(this.panel10);
            this.groupBox3.Controls.Add(this.panel6);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(756, 177);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Information update";
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.tbxHistoryMedicalRecord);
            this.panel7.Controls.Add(this.label15);
            this.panel7.Controls.Add(this.cbxMedicalRecordRequest);
            this.panel7.Controls.Add(this.label16);
            this.panel7.Location = new System.Drawing.Point(385, 53);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(340, 110);
            this.panel7.TabIndex = 3;
            // 
            // tbxHistoryMedicalRecord
            // 
            this.tbxHistoryMedicalRecord.Location = new System.Drawing.Point(84, 32);
            this.tbxHistoryMedicalRecord.Name = "tbxHistoryMedicalRecord";
            this.tbxHistoryMedicalRecord.Size = new System.Drawing.Size(244, 20);
            this.tbxHistoryMedicalRecord.TabIndex = 10;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(9, 16);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(50, 13);
            this.label15.TabIndex = 5;
            this.label15.Text = "Request:";
            // 
            // cbxMedicalRecordRequest
            // 
            this.cbxMedicalRecordRequest.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMedicalRecordRequest.FormattingEnabled = true;
            this.cbxMedicalRecordRequest.Items.AddRange(new object[] {
            "Service",
            "Insurrance"});
            this.cbxMedicalRecordRequest.Location = new System.Drawing.Point(84, 8);
            this.cbxMedicalRecordRequest.Name = "cbxMedicalRecordRequest";
            this.cbxMedicalRecordRequest.Size = new System.Drawing.Size(157, 21);
            this.cbxMedicalRecordRequest.TabIndex = 9;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(9, 40);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(42, 13);
            this.label16.TabIndex = 6;
            this.label16.Text = "History:";
            // 
            // panel10
            // 
            this.panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel10.Controls.Add(this.lbidMedicalRecord);
            this.panel10.Controls.Add(this.label1);
            this.panel10.Controls.Add(this.cbxMedicalRecordPatient);
            this.panel10.Controls.Add(this.label12);
            this.panel10.Location = new System.Drawing.Point(211, 13);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(514, 34);
            this.panel10.TabIndex = 2;
            // 
            // cbxMedicalRecordPatient
            // 
            this.cbxMedicalRecordPatient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMedicalRecordPatient.FormattingEnabled = true;
            this.cbxMedicalRecordPatient.Location = new System.Drawing.Point(94, 5);
            this.cbxMedicalRecordPatient.Name = "cbxMedicalRecordPatient";
            this.cbxMedicalRecordPatient.Size = new System.Drawing.Size(184, 21);
            this.cbxMedicalRecordPatient.TabIndex = 4;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(34, 13);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "Id patient:";
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.dtpMedicalRecord);
            this.panel6.Controls.Add(this.cbxMedicalRecordDoctor);
            this.panel6.Controls.Add(this.label14);
            this.panel6.Controls.Add(this.label13);
            this.panel6.Location = new System.Drawing.Point(39, 53);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(340, 110);
            this.panel6.TabIndex = 0;
            // 
            // dtpMedicalRecord
            // 
            this.dtpMedicalRecord.Location = new System.Drawing.Point(78, 32);
            this.dtpMedicalRecord.Name = "dtpMedicalRecord";
            this.dtpMedicalRecord.Size = new System.Drawing.Size(200, 20);
            this.dtpMedicalRecord.TabIndex = 8;
            // 
            // cbxMedicalRecordDoctor
            // 
            this.cbxMedicalRecordDoctor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMedicalRecordDoctor.FormattingEnabled = true;
            this.cbxMedicalRecordDoctor.Location = new System.Drawing.Point(78, 7);
            this.cbxMedicalRecordDoctor.Name = "cbxMedicalRecordDoctor";
            this.cbxMedicalRecordDoctor.Size = new System.Drawing.Size(157, 21);
            this.cbxMedicalRecordDoctor.TabIndex = 7;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 39);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(48, 13);
            this.label14.TabIndex = 4;
            this.label14.Text = "Init date:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 15);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 13);
            this.label13.TabIndex = 3;
            this.label13.Text = "Id doctor:";
            // 
            // btnCancelMedical
            // 
            this.btnCancelMedical.Location = new System.Drawing.Point(677, 195);
            this.btnCancelMedical.Name = "btnCancelMedical";
            this.btnCancelMedical.Size = new System.Drawing.Size(75, 23);
            this.btnCancelMedical.TabIndex = 4;
            this.btnCancelMedical.Text = "Cancel";
            this.btnCancelMedical.UseVisualStyleBackColor = true;
            this.btnCancelMedical.Click += new System.EventHandler(this.btnCancelMedical_Click);
            // 
            // btnUpdateMedical
            // 
            this.btnUpdateMedical.Location = new System.Drawing.Point(596, 195);
            this.btnUpdateMedical.Name = "btnUpdateMedical";
            this.btnUpdateMedical.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateMedical.TabIndex = 3;
            this.btnUpdateMedical.Text = "Update";
            this.btnUpdateMedical.UseVisualStyleBackColor = true;
            this.btnUpdateMedical.Click += new System.EventHandler(this.btnUpdateMedical_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(299, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Id Medical record:";
            // 
            // lbidMedicalRecord
            // 
            this.lbidMedicalRecord.AutoSize = true;
            this.lbidMedicalRecord.Location = new System.Drawing.Point(397, 12);
            this.lbidMedicalRecord.Name = "lbidMedicalRecord";
            this.lbidMedicalRecord.Size = new System.Drawing.Size(35, 13);
            this.lbidMedicalRecord.TabIndex = 6;
            this.lbidMedicalRecord.Text = "label2";
            // 
            // update_medical_screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancelMedical);
            this.Controls.Add(this.btnUpdateMedical);
            this.Controls.Add(this.groupBox3);
            this.Name = "update_medical_screen";
            this.Text = "update_medical_screen";
            this.Load += new System.EventHandler(this.update_medical_screen_Load);
            this.groupBox3.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox tbxHistoryMedicalRecord;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cbxMedicalRecordRequest;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.ComboBox cbxMedicalRecordPatient;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DateTimePicker dtpMedicalRecord;
        private System.Windows.Forms.ComboBox cbxMedicalRecordDoctor;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnCancelMedical;
        private System.Windows.Forms.Button btnUpdateMedical;
        private System.Windows.Forms.Label lbidMedicalRecord;
        private System.Windows.Forms.Label label1;
    }
}