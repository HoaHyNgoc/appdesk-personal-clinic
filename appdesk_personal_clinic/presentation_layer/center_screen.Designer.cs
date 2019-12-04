namespace presentation_layer
{
    partial class center_screen
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
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tpPatient = new System.Windows.Forms.TabPage();
            this.tbMedicalRecord = new System.Windows.Forms.TabPage();
            this.tpTechnical = new System.Windows.Forms.TabPage();
            this.tpPrescription = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvPatient = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tabControlMain.SuspendLayout();
            this.tpPatient.SuspendLayout();
            this.tbMedicalRecord.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatient)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tpPatient);
            this.tabControlMain.Controls.Add(this.tbMedicalRecord);
            this.tabControlMain.Controls.Add(this.tpTechnical);
            this.tabControlMain.Controls.Add(this.tpPrescription);
            this.tabControlMain.Location = new System.Drawing.Point(12, 12);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(776, 426);
            this.tabControlMain.TabIndex = 0;
            // 
            // tpPatient
            // 
            this.tpPatient.Controls.Add(this.groupBox2);
            this.tpPatient.Location = new System.Drawing.Point(4, 22);
            this.tpPatient.Name = "tpPatient";
            this.tpPatient.Padding = new System.Windows.Forms.Padding(3);
            this.tpPatient.Size = new System.Drawing.Size(768, 400);
            this.tpPatient.TabIndex = 0;
            this.tpPatient.Text = "Patient";
            this.tpPatient.UseVisualStyleBackColor = true;
            // 
            // tbMedicalRecord
            // 
            this.tbMedicalRecord.Controls.Add(this.groupBox3);
            this.tbMedicalRecord.Controls.Add(this.groupBox1);
            this.tbMedicalRecord.Location = new System.Drawing.Point(4, 22);
            this.tbMedicalRecord.Name = "tbMedicalRecord";
            this.tbMedicalRecord.Padding = new System.Windows.Forms.Padding(3);
            this.tbMedicalRecord.Size = new System.Drawing.Size(768, 400);
            this.tbMedicalRecord.TabIndex = 1;
            this.tbMedicalRecord.Text = "Medical record";
            this.tbMedicalRecord.UseVisualStyleBackColor = true;
            // 
            // tpTechnical
            // 
            this.tpTechnical.Location = new System.Drawing.Point(4, 22);
            this.tpTechnical.Name = "tpTechnical";
            this.tpTechnical.Padding = new System.Windows.Forms.Padding(3);
            this.tpTechnical.Size = new System.Drawing.Size(768, 400);
            this.tpTechnical.TabIndex = 2;
            this.tpTechnical.Text = "Technique";
            this.tpTechnical.UseVisualStyleBackColor = true;
            // 
            // tpPrescription
            // 
            this.tpPrescription.Location = new System.Drawing.Point(4, 22);
            this.tpPrescription.Name = "tpPrescription";
            this.tpPrescription.Padding = new System.Windows.Forms.Padding(3);
            this.tpPrescription.Size = new System.Drawing.Size(768, 400);
            this.tpPrescription.TabIndex = 3;
            this.tpPrescription.Text = "Prescription";
            this.tpPrescription.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(6, 250);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(756, 144);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Create new patien";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(6, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(318, 46);
            this.panel1.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 14);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(229, 20);
            this.textBox1.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(238, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // dgvPatient
            // 
            this.dgvPatient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPatient.Location = new System.Drawing.Point(6, 71);
            this.dgvPatient.Name = "dgvPatient";
            this.dgvPatient.Size = new System.Drawing.Size(744, 96);
            this.dgvPatient.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvPatient);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(756, 173);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data view";
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(6, 185);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(756, 209);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Detail medical record";
            // 
            // center_screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControlMain);
            this.Name = "center_screen";
            this.Text = "center_screen";
            this.tabControlMain.ResumeLayout(false);
            this.tpPatient.ResumeLayout(false);
            this.tbMedicalRecord.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatient)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tpPatient;
        private System.Windows.Forms.TabPage tbMedicalRecord;
        private System.Windows.Forms.TabPage tpTechnical;
        private System.Windows.Forms.TabPage tpPrescription;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvPatient;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}