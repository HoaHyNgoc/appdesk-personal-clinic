namespace presentation_layer.center_custom_ui.prescription_ui
{
    partial class update_prescription_ui
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
            this.btnCancelUpdatePrescription = new System.Windows.Forms.Button();
            this.tbxCoulusionPrescription = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.lbidPrescription = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnUpdateAllDelPrescription = new System.Windows.Forms.Button();
            this.nudSumPricePrescription = new System.Windows.Forms.NumericUpDown();
            this.label35 = new System.Windows.Forms.Label();
            this.dgvDelPrescription = new System.Windows.Forms.DataGridView();
            this.btnGetPricePrescription = new System.Windows.Forms.Button();
            this.tbxidPatientPrescription = new System.Windows.Forms.TextBox();
            this.btnDeleteRow = new System.Windows.Forms.Button();
            this.label30 = new System.Windows.Forms.Label();
            this.dgvBackup = new System.Windows.Forms.DataGridView();
            this.cbxBackMedicine = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.backUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backSubPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backHelp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDelPrescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCbxMedicine = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colunitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPriceMedicine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColHelpful = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddRow = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSumPricePrescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDelPrescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBackup)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnUpdateAllDelPrescription);
            this.groupBox3.Controls.Add(this.btnCancelUpdatePrescription);
            this.groupBox3.Controls.Add(this.tbxCoulusionPrescription);
            this.groupBox3.Controls.Add(this.label28);
            this.groupBox3.Controls.Add(this.label34);
            this.groupBox3.Controls.Add(this.lbidPrescription);
            this.groupBox3.Controls.Add(this.groupBox6);
            this.groupBox3.Location = new System.Drawing.Point(5, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(791, 305);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Information update";
            // 
            // btnCancelUpdatePrescription
            // 
            this.btnCancelUpdatePrescription.Location = new System.Drawing.Point(693, 276);
            this.btnCancelUpdatePrescription.Name = "btnCancelUpdatePrescription";
            this.btnCancelUpdatePrescription.Size = new System.Drawing.Size(75, 23);
            this.btnCancelUpdatePrescription.TabIndex = 12;
            this.btnCancelUpdatePrescription.Text = "Cancel";
            this.btnCancelUpdatePrescription.UseVisualStyleBackColor = true;
            this.btnCancelUpdatePrescription.Click += new System.EventHandler(this.btnCancelUpdatePrescription_Click);
            // 
            // tbxCoulusionPrescription
            // 
            this.tbxCoulusionPrescription.Location = new System.Drawing.Point(214, 21);
            this.tbxCoulusionPrescription.Name = "tbxCoulusionPrescription";
            this.tbxCoulusionPrescription.Size = new System.Drawing.Size(271, 20);
            this.tbxCoulusionPrescription.TabIndex = 9;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(146, 27);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(62, 13);
            this.label28.TabIndex = 8;
            this.label28.Text = "Conclusion:";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(14, 27);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(77, 13);
            this.label34.TabIndex = 7;
            this.label34.Text = "Id Prescription:";
            // 
            // lbidPrescription
            // 
            this.lbidPrescription.AutoSize = true;
            this.lbidPrescription.Location = new System.Drawing.Point(97, 27);
            this.lbidPrescription.Name = "lbidPrescription";
            this.lbidPrescription.Size = new System.Drawing.Size(31, 13);
            this.lbidPrescription.TabIndex = 6;
            this.lbidPrescription.Text = "5000";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnAddRow);
            this.groupBox6.Controls.Add(this.nudSumPricePrescription);
            this.groupBox6.Controls.Add(this.label35);
            this.groupBox6.Controls.Add(this.dgvDelPrescription);
            this.groupBox6.Controls.Add(this.btnGetPricePrescription);
            this.groupBox6.Controls.Add(this.tbxidPatientPrescription);
            this.groupBox6.Controls.Add(this.btnDeleteRow);
            this.groupBox6.Controls.Add(this.label30);
            this.groupBox6.Location = new System.Drawing.Point(7, 55);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(776, 164);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "List medicine reviews";
            // 
            // btnUpdateAllDelPrescription
            // 
            this.btnUpdateAllDelPrescription.Location = new System.Drawing.Point(612, 276);
            this.btnUpdateAllDelPrescription.Name = "btnUpdateAllDelPrescription";
            this.btnUpdateAllDelPrescription.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateAllDelPrescription.TabIndex = 9;
            this.btnUpdateAllDelPrescription.Text = "Update";
            this.btnUpdateAllDelPrescription.UseVisualStyleBackColor = true;
            this.btnUpdateAllDelPrescription.Click += new System.EventHandler(this.btnUpdateAllDelPrescription_Click);
            // 
            // nudSumPricePrescription
            // 
            this.nudSumPricePrescription.Enabled = false;
            this.nudSumPricePrescription.Location = new System.Drawing.Point(347, 19);
            this.nudSumPricePrescription.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nudSumPricePrescription.Name = "nudSumPricePrescription";
            this.nudSumPricePrescription.Size = new System.Drawing.Size(98, 20);
            this.nudSumPricePrescription.TabIndex = 10;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(257, 26);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(84, 13);
            this.label35.TabIndex = 7;
            this.label35.Text = "Price technique:";
            // 
            // dgvDelPrescription
            // 
            this.dgvDelPrescription.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDelPrescription.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDelPrescription,
            this.ColCbxMedicine,
            this.colunitPrice,
            this.ColNumber,
            this.ColPriceMedicine,
            this.ColHelpful});
            this.dgvDelPrescription.Location = new System.Drawing.Point(18, 54);
            this.dgvDelPrescription.Name = "dgvDelPrescription";
            this.dgvDelPrescription.Size = new System.Drawing.Size(743, 93);
            this.dgvDelPrescription.TabIndex = 8;
            this.dgvDelPrescription.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvDelPrescription_EditingControlShowing);
            // 
            // btnGetPricePrescription
            // 
            this.btnGetPricePrescription.Location = new System.Drawing.Point(511, 25);
            this.btnGetPricePrescription.Name = "btnGetPricePrescription";
            this.btnGetPricePrescription.Size = new System.Drawing.Size(75, 23);
            this.btnGetPricePrescription.TabIndex = 6;
            this.btnGetPricePrescription.Text = "Get price";
            this.btnGetPricePrescription.UseVisualStyleBackColor = true;
            this.btnGetPricePrescription.Click += new System.EventHandler(this.btnGetPricePrescription_Click);
            // 
            // tbxidPatientPrescription
            // 
            this.tbxidPatientPrescription.Enabled = false;
            this.tbxidPatientPrescription.Location = new System.Drawing.Point(64, 19);
            this.tbxidPatientPrescription.Name = "tbxidPatientPrescription";
            this.tbxidPatientPrescription.Size = new System.Drawing.Size(97, 20);
            this.tbxidPatientPrescription.TabIndex = 9;
            // 
            // btnDeleteRow
            // 
            this.btnDeleteRow.Location = new System.Drawing.Point(592, 25);
            this.btnDeleteRow.Name = "btnDeleteRow";
            this.btnDeleteRow.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteRow.TabIndex = 7;
            this.btnDeleteRow.Text = "Delete";
            this.btnDeleteRow.UseVisualStyleBackColor = true;
            this.btnDeleteRow.Click += new System.EventHandler(this.btnDeleteRow_Click);
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(6, 26);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(55, 13);
            this.label30.TabIndex = 8;
            this.label30.Text = "Id Patient:";
            // 
            // dgvBackup
            // 
            this.dgvBackup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBackup.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cbxBackMedicine,
            this.backUnitPrice,
            this.backNumber,
            this.backSubPrice,
            this.backHelp});
            this.dgvBackup.Location = new System.Drawing.Point(30, 324);
            this.dgvBackup.Name = "dgvBackup";
            this.dgvBackup.Size = new System.Drawing.Size(743, 93);
            this.dgvBackup.TabIndex = 9;
            // 
            // cbxBackMedicine
            // 
            this.cbxBackMedicine.FillWeight = 150F;
            this.cbxBackMedicine.Frozen = true;
            this.cbxBackMedicine.HeaderText = "Medicine";
            this.cbxBackMedicine.Name = "cbxBackMedicine";
            this.cbxBackMedicine.Width = 150;
            // 
            // backUnitPrice
            // 
            this.backUnitPrice.Frozen = true;
            this.backUnitPrice.HeaderText = "Unit Price";
            this.backUnitPrice.Name = "backUnitPrice";
            this.backUnitPrice.ReadOnly = true;
            // 
            // backNumber
            // 
            this.backNumber.Frozen = true;
            this.backNumber.HeaderText = "Number";
            this.backNumber.Name = "backNumber";
            // 
            // backSubPrice
            // 
            this.backSubPrice.HeaderText = "SubPrice";
            this.backSubPrice.Name = "backSubPrice";
            this.backSubPrice.ReadOnly = true;
            // 
            // backHelp
            // 
            this.backHelp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.backHelp.HeaderText = "Help";
            this.backHelp.Name = "backHelp";
            // 
            // idDelPrescription
            // 
            this.idDelPrescription.Frozen = true;
            this.idDelPrescription.HeaderText = "id";
            this.idDelPrescription.Name = "idDelPrescription";
            this.idDelPrescription.ReadOnly = true;
            this.idDelPrescription.Width = 60;
            // 
            // ColCbxMedicine
            // 
            this.ColCbxMedicine.FillWeight = 150F;
            this.ColCbxMedicine.Frozen = true;
            this.ColCbxMedicine.HeaderText = "Medicine";
            this.ColCbxMedicine.Name = "ColCbxMedicine";
            this.ColCbxMedicine.Width = 150;
            // 
            // colunitPrice
            // 
            this.colunitPrice.Frozen = true;
            this.colunitPrice.HeaderText = "Unit Price";
            this.colunitPrice.Name = "colunitPrice";
            this.colunitPrice.ReadOnly = true;
            // 
            // ColNumber
            // 
            this.ColNumber.Frozen = true;
            this.ColNumber.HeaderText = "Number";
            this.ColNumber.Name = "ColNumber";
            this.ColNumber.Width = 50;
            // 
            // ColPriceMedicine
            // 
            this.ColPriceMedicine.HeaderText = "SubPrice";
            this.ColPriceMedicine.Name = "ColPriceMedicine";
            this.ColPriceMedicine.ReadOnly = true;
            // 
            // ColHelpful
            // 
            this.ColHelpful.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColHelpful.HeaderText = "Help";
            this.ColHelpful.Name = "ColHelpful";
            // 
            // btnAddRow
            // 
            this.btnAddRow.Location = new System.Drawing.Point(673, 25);
            this.btnAddRow.Name = "btnAddRow";
            this.btnAddRow.Size = new System.Drawing.Size(75, 23);
            this.btnAddRow.TabIndex = 11;
            this.btnAddRow.Text = "Add row";
            this.btnAddRow.UseVisualStyleBackColor = true;
            this.btnAddRow.Click += new System.EventHandler(this.btnAddRow_Click);
            // 
            // update_prescription_ui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvBackup);
            this.Controls.Add(this.groupBox3);
            this.Name = "update_prescription_ui";
            this.Text = "update_prescription_ui";
            this.Load += new System.EventHandler(this.update_prescription_ui_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSumPricePrescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDelPrescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBackup)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lbidPrescription;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.TextBox tbxCoulusionPrescription;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox tbxidPatientPrescription;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.NumericUpDown nudSumPricePrescription;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Button btnUpdateAllDelPrescription;
        private System.Windows.Forms.DataGridView dgvDelPrescription;
        private System.Windows.Forms.Button btnGetPricePrescription;
        private System.Windows.Forms.Button btnDeleteRow;
        private System.Windows.Forms.DataGridView dgvBackup;
        private System.Windows.Forms.Button btnCancelUpdatePrescription;
        private System.Windows.Forms.DataGridViewComboBoxColumn cbxBackMedicine;
        private System.Windows.Forms.DataGridViewTextBoxColumn backUnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn backNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn backSubPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn backHelp;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDelPrescription;
        private System.Windows.Forms.DataGridViewComboBoxColumn ColCbxMedicine;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPriceMedicine;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColHelpful;
        private System.Windows.Forms.Button btnAddRow;
    }
}