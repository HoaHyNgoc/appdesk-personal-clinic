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

namespace presentation_layer.center_custom_ui.patient_ui
{
    public partial class update_patient_screen : Form
    {
        public PatientBUS patientBus = new PatientBUS();
        public PatientDTO patientState = new PatientDTO();

        public update_patient_screen()
        {
            InitializeComponent();
        }

        public update_patient_screen(PatientDTO _patientState)
        {
            this.patientState = _patientState;
            InitializeComponent();
        }

        #region Methods

        #region CRUD

        public void updateDataPointPatient(
            string idPassportUI,
            string fullNameUI,
            string birthdayUI,
            string statusUI,
            string originalIdPatientUI)
        {
            patientBus.updatePatient(
                idPassportUI,
                fullNameUI,
                birthdayUI,
                statusUI,
                originalIdPatientUI
                );
        }

        #endregion CRUD

        public bool loadDataPaientReceiveToView()
        {
            if (this.patientState == null)
                return false;

            lbidPatient.Text = Convert.ToString(patientState.IdPatient);
            tbxidPassportPatient.Text = Convert.ToString(patientState.IdPassport);
            tbxFullNamePatient.Text = Convert.ToString(patientState.FullName);
            tbxBirthdayPatient.Text = Convert.ToString(patientState.Birthday);
            cbxStatusPatient.Text = Convert.ToString(patientState.HealthStatus);

            return true;
        }

        #endregion Methods

        #region Events

        private void update_patient_screen_Load(object sender, EventArgs e)
        {
            if (loadDataPaientReceiveToView())
                return;
            MessageBox.Show("Receive data error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        private void btnUpdatePatient_Click(object sender, EventArgs e)
        {
            updateDataPointPatient(
                tbxidPassportPatient.Text,
                tbxFullNamePatient.Text,
                tbxBirthdayPatient.Text,
                cbxStatusPatient.SelectedIndex.ToString(),
                lbidPatient.Text
                );
            MessageBox.Show("Data updated...", "Messager", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
            return;          
        }

        #endregion Events
    }
}
