using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using business_logic_layer;
using database_access_layer;
using data_transfer_object;

namespace presentation_layer.center_custom_ui.medical_ui
{
    public partial class update_medical_screen : Form
    {
        DoctorBUS doctorBUS = new DoctorBUS();
        MedicalRecordBUS medicalRecordBUS = new MedicalRecordBUS();
        PatientBUS patientBUS = new PatientBUS();

        MedicalRecordDTO medicalRecordState = new MedicalRecordDTO();

        public update_medical_screen()
        {
            InitializeComponent();
        }

        public update_medical_screen(MedicalRecordDTO _medicalRecordState)
        {
            this.medicalRecordState = _medicalRecordState;
            InitializeComponent();
        }

        #region Methods

        #region CRUD

        //public void updateDataPointPatient(
        //    string idPassportUI,
        //    string fullNameUI,
        //    string birthdayUI,
        //    string statusUI,
        //    string originalIdPatientUI)
        //{
        //    patientBus.updatePatient(
        //        idPassportUI,
        //        fullNameUI,
        //        birthdayUI,
        //        statusUI,
        //        originalIdPatientUI
        //        );
        //}

        #endregion CRUD

        public bool loadDataMedicalReceiveToView()
        {
            // Fill data patient - combobox medical record
            PersonalClinicDataSet.PATIENTDataTable tablePatient = patientBUS.getData();
            cbxMedicalRecordPatient.DataSource = tablePatient;
            cbxMedicalRecordPatient.ValueMember = "idPatient";
            cbxMedicalRecordPatient.DisplayMember = "fullName";

            // Fill data doctor - combobox medical record
            PersonalClinicDataSet.DOCTORDataTable tableDoctor = doctorBUS.getData();
            cbxMedicalRecordDoctor.DataSource = tableDoctor;
            cbxMedicalRecordDoctor.ValueMember = "idDoctor";
            cbxMedicalRecordDoctor.DisplayMember = "fullName";

            if (this.medicalRecordState == null)
                return false;

            lbidMedicalRecord.Text = Convert.ToString(medicalRecordState.IdMedicalRecord);
            cbxMedicalRecordPatient.Text = Convert.ToString(medicalRecordState.IdPatient);
            cbxMedicalRecordDoctor.Text = Convert.ToString(medicalRecordState.IdDoctor);
            cbxMedicalRecordRequest.Text = Convert.ToString(medicalRecordState.Request);
            tbxHistoryMedicalRecord.Text = Convert.ToString(medicalRecordState.History);

            return true;
        }

        #endregion Methods

        #region Events

        private void update_medical_screen_Load(object sender, EventArgs e)
        {
            if (loadDataMedicalReceiveToView())
                return;
            MessageBox.Show("Receive data error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        private void btnUpdateMedical_Click(object sender, EventArgs e)
        {
            medicalRecordBUS.updateMedicalRecord(
            cbxMedicalRecordPatient.SelectedValue.ToString(),
            cbxMedicalRecordDoctor.SelectedValue.ToString(),
            tbxHistoryMedicalRecord.Text,
            dtpMedicalRecord.Value.ToString(),
            cbxMedicalRecordRequest.Text,
            lbidMedicalRecord.Text
            );

            MessageBox.Show("Data updated...", "Messager", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
            return;
        }

        private void btnCancelMedical_Click(object sender, EventArgs e)
        {
            DialogResult resultCancelUpdate = MessageBox.Show(
                "You want to stop updating this data",
                "Warning",
                MessageBoxButtons.YesNo, 
                MessageBoxIcon.Warning);
            if (resultCancelUpdate == DialogResult.Yes)
                this.Close();
            return;
        }

        #endregion Events
    }
}
