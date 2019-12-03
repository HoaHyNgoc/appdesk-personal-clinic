namespace presentation_layer
{
    partial class screen_admin
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
            this.menuStripAdmin = new System.Windows.Forms.MenuStrip();
            this.importDatapointToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doctorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createDoctor = new System.Windows.Forms.ToolStripMenuItem();
            this.readToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.readToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medicineToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.createToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.readToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.pharmacistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doctorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pharmacistToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.patientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getDatapointToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doctorToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.pharmacistToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.unitMedicineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prescriptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.billPriceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medicineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripAdmin
            // 
            this.menuStripAdmin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importDatapointToolStripMenuItem,
            this.reportToolStripMenuItem});
            this.menuStripAdmin.Location = new System.Drawing.Point(0, 0);
            this.menuStripAdmin.Name = "menuStripAdmin";
            this.menuStripAdmin.Size = new System.Drawing.Size(800, 24);
            this.menuStripAdmin.TabIndex = 0;
            this.menuStripAdmin.Text = "menuStrip";
            // 
            // importDatapointToolStripMenuItem
            // 
            this.importDatapointToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.doctorToolStripMenuItem,
            this.pharmacistToolStripMenuItem,
            this.getDatapointToolStripMenuItem});
            this.importDatapointToolStripMenuItem.Name = "importDatapointToolStripMenuItem";
            this.importDatapointToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.importDatapointToolStripMenuItem.Text = "Rest API";
            // 
            // doctorToolStripMenuItem
            // 
            this.doctorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insertToolStripMenuItem,
            this.updateToolStripMenuItem,
            this.medicineToolStripMenuItem2});
            this.doctorToolStripMenuItem.Name = "doctorToolStripMenuItem";
            this.doctorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.doctorToolStripMenuItem.Text = "Actors";
            // 
            // insertToolStripMenuItem
            // 
            this.insertToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createDoctor,
            this.readToolStripMenuItem,
            this.updateToolStripMenuItem1,
            this.deleteToolStripMenuItem1});
            this.insertToolStripMenuItem.Name = "insertToolStripMenuItem";
            this.insertToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.insertToolStripMenuItem.Text = "Doctor";
            // 
            // createDoctor
            // 
            this.createDoctor.Name = "createDoctor";
            this.createDoctor.Size = new System.Drawing.Size(180, 22);
            this.createDoctor.Text = "Create";
            this.createDoctor.Click += new System.EventHandler(this.createDoctor_Click);
            // 
            // readToolStripMenuItem
            // 
            this.readToolStripMenuItem.Name = "readToolStripMenuItem";
            this.readToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.readToolStripMenuItem.Text = "Read";
            // 
            // updateToolStripMenuItem1
            // 
            this.updateToolStripMenuItem1.Name = "updateToolStripMenuItem1";
            this.updateToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.updateToolStripMenuItem1.Text = "Update";
            // 
            // deleteToolStripMenuItem1
            // 
            this.deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
            this.deleteToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.deleteToolStripMenuItem1.Text = "Delete";
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createToolStripMenuItem1,
            this.readToolStripMenuItem1,
            this.updateToolStripMenuItem3,
            this.deleteToolStripMenuItem});
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.updateToolStripMenuItem.Text = "Pharmacist";
            // 
            // createToolStripMenuItem1
            // 
            this.createToolStripMenuItem1.Name = "createToolStripMenuItem1";
            this.createToolStripMenuItem1.Size = new System.Drawing.Size(112, 22);
            this.createToolStripMenuItem1.Text = "Create";
            // 
            // readToolStripMenuItem1
            // 
            this.readToolStripMenuItem1.Name = "readToolStripMenuItem1";
            this.readToolStripMenuItem1.Size = new System.Drawing.Size(112, 22);
            this.readToolStripMenuItem1.Text = "Read";
            // 
            // updateToolStripMenuItem3
            // 
            this.updateToolStripMenuItem3.Name = "updateToolStripMenuItem3";
            this.updateToolStripMenuItem3.Size = new System.Drawing.Size(112, 22);
            this.updateToolStripMenuItem3.Text = "Update";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // medicineToolStripMenuItem2
            // 
            this.medicineToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createToolStripMenuItem2,
            this.readToolStripMenuItem2});
            this.medicineToolStripMenuItem2.Name = "medicineToolStripMenuItem2";
            this.medicineToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.medicineToolStripMenuItem2.Text = "Patient";
            // 
            // createToolStripMenuItem2
            // 
            this.createToolStripMenuItem2.Name = "createToolStripMenuItem2";
            this.createToolStripMenuItem2.Size = new System.Drawing.Size(108, 22);
            this.createToolStripMenuItem2.Text = "Create";
            // 
            // readToolStripMenuItem2
            // 
            this.readToolStripMenuItem2.Name = "readToolStripMenuItem2";
            this.readToolStripMenuItem2.Size = new System.Drawing.Size(108, 22);
            this.readToolStripMenuItem2.Text = "Read";
            // 
            // pharmacistToolStripMenuItem
            // 
            this.pharmacistToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.doctorToolStripMenuItem1,
            this.pharmacistToolStripMenuItem1,
            this.patientToolStripMenuItem});
            this.pharmacistToolStripMenuItem.Name = "pharmacistToolStripMenuItem";
            this.pharmacistToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pharmacistToolStripMenuItem.Text = "Specialists";
            // 
            // doctorToolStripMenuItem1
            // 
            this.doctorToolStripMenuItem1.Name = "doctorToolStripMenuItem1";
            this.doctorToolStripMenuItem1.Size = new System.Drawing.Size(130, 22);
            this.doctorToolStripMenuItem1.Text = "Specialist";
            // 
            // pharmacistToolStripMenuItem1
            // 
            this.pharmacistToolStripMenuItem1.Name = "pharmacistToolStripMenuItem1";
            this.pharmacistToolStripMenuItem1.Size = new System.Drawing.Size(130, 22);
            this.pharmacistToolStripMenuItem1.Text = "Diagnostic";
            // 
            // patientToolStripMenuItem
            // 
            this.patientToolStripMenuItem.Name = "patientToolStripMenuItem";
            this.patientToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.patientToolStripMenuItem.Text = "Technique";
            // 
            // getDatapointToolStripMenuItem
            // 
            this.getDatapointToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.doctorToolStripMenuItem2,
            this.pharmacistToolStripMenuItem2,
            this.updateToolStripMenuItem2,
            this.deleteToolStripMenuItem2,
            this.unitMedicineToolStripMenuItem});
            this.getDatapointToolStripMenuItem.Name = "getDatapointToolStripMenuItem";
            this.getDatapointToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.getDatapointToolStripMenuItem.Text = "Medicine";
            // 
            // doctorToolStripMenuItem2
            // 
            this.doctorToolStripMenuItem2.Name = "doctorToolStripMenuItem2";
            this.doctorToolStripMenuItem2.Size = new System.Drawing.Size(148, 22);
            this.doctorToolStripMenuItem2.Text = "Create";
            // 
            // pharmacistToolStripMenuItem2
            // 
            this.pharmacistToolStripMenuItem2.Name = "pharmacistToolStripMenuItem2";
            this.pharmacistToolStripMenuItem2.Size = new System.Drawing.Size(148, 22);
            this.pharmacistToolStripMenuItem2.Text = "Read";
            // 
            // updateToolStripMenuItem2
            // 
            this.updateToolStripMenuItem2.Name = "updateToolStripMenuItem2";
            this.updateToolStripMenuItem2.Size = new System.Drawing.Size(148, 22);
            this.updateToolStripMenuItem2.Text = "Update";
            // 
            // deleteToolStripMenuItem2
            // 
            this.deleteToolStripMenuItem2.Name = "deleteToolStripMenuItem2";
            this.deleteToolStripMenuItem2.Size = new System.Drawing.Size(148, 22);
            this.deleteToolStripMenuItem2.Text = "Delete";
            // 
            // unitMedicineToolStripMenuItem
            // 
            this.unitMedicineToolStripMenuItem.Name = "unitMedicineToolStripMenuItem";
            this.unitMedicineToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.unitMedicineToolStripMenuItem.Text = "Unit Medicine";
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prescriptionToolStripMenuItem,
            this.billPriceToolStripMenuItem,
            this.medicineToolStripMenuItem});
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.reportToolStripMenuItem.Text = "Report";
            // 
            // prescriptionToolStripMenuItem
            // 
            this.prescriptionToolStripMenuItem.Name = "prescriptionToolStripMenuItem";
            this.prescriptionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.prescriptionToolStripMenuItem.Text = "Prescription";
            // 
            // billPriceToolStripMenuItem
            // 
            this.billPriceToolStripMenuItem.Name = "billPriceToolStripMenuItem";
            this.billPriceToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.billPriceToolStripMenuItem.Text = "Bill price";
            // 
            // medicineToolStripMenuItem
            // 
            this.medicineToolStripMenuItem.Name = "medicineToolStripMenuItem";
            this.medicineToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.medicineToolStripMenuItem.Text = "Medicine";
            // 
            // screen_admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStripAdmin);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStripAdmin;
            this.Name = "screen_admin";
            this.Text = "admin_screen";
            this.menuStripAdmin.ResumeLayout(false);
            this.menuStripAdmin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripAdmin;
        private System.Windows.Forms.ToolStripMenuItem importDatapointToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doctorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pharmacistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prescriptionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem billPriceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doctorToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pharmacistToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem patientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getDatapointToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doctorToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem pharmacistToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem medicineToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem createDoctor;
        private System.Windows.Forms.ToolStripMenuItem readToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem unitMedicineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem readToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem readToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem medicineToolStripMenuItem;
    }
}