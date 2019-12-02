namespace presentation_layer
{
    partial class search_screen
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
            this.dgvDoctor = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnInsertDoctor = new System.Windows.Forms.Button();
            this.btnUpdateDoctor = new System.Windows.Forms.Button();
            this.lbidDoctor = new System.Windows.Forms.Label();
            this.tbxFullnameDoctor = new System.Windows.Forms.TextBox();
            this.lbidSpecialist = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbisGeneral = new System.Windows.Forms.Label();
            this.lbFullname = new System.Windows.Forms.Label();
            this.tbxPassportDoctor = new System.Windows.Forms.TextBox();
            this.cbxSpecialist = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoctor)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDoctor
            // 
            this.dgvDoctor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoctor.Location = new System.Drawing.Point(12, 12);
            this.dgvDoctor.Name = "dgvDoctor";
            this.dgvDoctor.Size = new System.Drawing.Size(558, 150);
            this.dgvDoctor.TabIndex = 1;
            this.dgvDoctor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDoctor_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxSpecialist);
            this.groupBox1.Controls.Add(this.btnInsertDoctor);
            this.groupBox1.Controls.Add(this.btnUpdateDoctor);
            this.groupBox1.Controls.Add(this.lbidDoctor);
            this.groupBox1.Controls.Add(this.tbxFullnameDoctor);
            this.groupBox1.Controls.Add(this.lbidSpecialist);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lbisGeneral);
            this.groupBox1.Controls.Add(this.lbFullname);
            this.groupBox1.Controls.Add(this.tbxPassportDoctor);
            this.groupBox1.Location = new System.Drawing.Point(12, 181);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(416, 176);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btnInsertDoctor
            // 
            this.btnInsertDoctor.Location = new System.Drawing.Point(332, 139);
            this.btnInsertDoctor.Name = "btnInsertDoctor";
            this.btnInsertDoctor.Size = new System.Drawing.Size(75, 23);
            this.btnInsertDoctor.TabIndex = 6;
            this.btnInsertDoctor.Text = "Insert";
            this.btnInsertDoctor.UseVisualStyleBackColor = true;
            this.btnInsertDoctor.Click += new System.EventHandler(this.btnInsertDoctor_Click);
            // 
            // btnUpdateDoctor
            // 
            this.btnUpdateDoctor.Location = new System.Drawing.Point(251, 139);
            this.btnUpdateDoctor.Name = "btnUpdateDoctor";
            this.btnUpdateDoctor.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateDoctor.TabIndex = 3;
            this.btnUpdateDoctor.Text = "Update";
            this.btnUpdateDoctor.UseVisualStyleBackColor = true;
            this.btnUpdateDoctor.Click += new System.EventHandler(this.btnUpdateDoctor_Click);
            // 
            // lbidDoctor
            // 
            this.lbidDoctor.AutoSize = true;
            this.lbidDoctor.Location = new System.Drawing.Point(94, 116);
            this.lbidDoctor.Name = "lbidDoctor";
            this.lbidDoctor.Size = new System.Drawing.Size(75, 13);
            this.lbidDoctor.TabIndex = 3;
            this.lbidDoctor.Text = "label_idDoctor";
            // 
            // tbxFullnameDoctor
            // 
            this.tbxFullnameDoctor.Location = new System.Drawing.Point(97, 54);
            this.tbxFullnameDoctor.Name = "tbxFullnameDoctor";
            this.tbxFullnameDoctor.Size = new System.Drawing.Size(180, 20);
            this.tbxFullnameDoctor.TabIndex = 3;
            // 
            // lbidSpecialist
            // 
            this.lbidSpecialist.AutoSize = true;
            this.lbidSpecialist.Location = new System.Drawing.Point(29, 85);
            this.lbidSpecialist.Name = "lbidSpecialist";
            this.lbidSpecialist.Size = new System.Drawing.Size(55, 13);
            this.lbidSpecialist.TabIndex = 3;
            this.lbidSpecialist.Text = "Specialist:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Id Passport:";
            // 
            // lbisGeneral
            // 
            this.lbisGeneral.AutoSize = true;
            this.lbisGeneral.Location = new System.Drawing.Point(94, 139);
            this.lbisGeneral.Name = "lbisGeneral";
            this.lbisGeneral.Size = new System.Drawing.Size(79, 13);
            this.lbisGeneral.TabIndex = 3;
            this.lbisGeneral.Text = "label_isGeneral";
            // 
            // lbFullname
            // 
            this.lbFullname.AutoSize = true;
            this.lbFullname.Location = new System.Drawing.Point(29, 61);
            this.lbFullname.Name = "lbFullname";
            this.lbFullname.Size = new System.Drawing.Size(57, 13);
            this.lbFullname.TabIndex = 3;
            this.lbFullname.Text = "Full Name:";
            // 
            // tbxPassportDoctor
            // 
            this.tbxPassportDoctor.Location = new System.Drawing.Point(97, 30);
            this.tbxPassportDoctor.Name = "tbxPassportDoctor";
            this.tbxPassportDoctor.Size = new System.Drawing.Size(180, 20);
            this.tbxPassportDoctor.TabIndex = 0;
            // 
            // cbxSpecialist
            // 
            this.cbxSpecialist.FormattingEnabled = true;
            this.cbxSpecialist.Location = new System.Drawing.Point(97, 78);
            this.cbxSpecialist.Name = "cbxSpecialist";
            this.cbxSpecialist.Size = new System.Drawing.Size(121, 21);
            this.cbxSpecialist.TabIndex = 7;
            // 
            // search_screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvDoctor);
            this.Name = "search_screen";
            this.Text = "search_screen";
            this.Load += new System.EventHandler(this.search_screen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoctor)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvDoctor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbxPassportDoctor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbisGeneral;
        private System.Windows.Forms.Label lbFullname;
        private System.Windows.Forms.Label lbidSpecialist;
        private System.Windows.Forms.TextBox tbxFullnameDoctor;
        private System.Windows.Forms.Label lbidDoctor;
        private System.Windows.Forms.Button btnInsertDoctor;
        private System.Windows.Forms.Button btnUpdateDoctor;
        private System.Windows.Forms.ComboBox cbxSpecialist;
    }
}