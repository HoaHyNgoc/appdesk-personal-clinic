using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

#region Import Screen

using presentation_layer.center_custom_ui.patient_ui;
using presentation_layer.center_custom_ui.medical_ui;

#endregion Import Screen

using business_logic_layer;
using database_access_layer;
using data_transfer_object;

namespace presentation_layer
{
    public partial class center_screen : Form
    {
        #region Global Variables

        List<Control> listMedicalProcess = new List<Control>();
        
        #endregion Global Variables

        #region Import global object business

        DoctorBUS doctorBUS = new DoctorBUS();
        MedicalRecordBUS medicalRecordBUS = new MedicalRecordBUS();
        PatientBUS patientBUS = new PatientBUS();

        #endregion Import global object business

        #region Import state data object transfer

        MedicalRecordDTO medicalRecordDTO = new MedicalRecordDTO();
        PatientDTO patientDTO = new PatientDTO();

        #endregion Import state data object transfer

        public center_screen()
        {
            InitializeComponent();
            initSwitchMenuOption();
        }

        #region Methods

        #region Global methods

        public void loadSingletonDataObject()
        {
            getDataDoctorGird();
            getDataPatientGrid();
        }

        public void initSwitchMenuOption()
        {         
            listMedicalProcess.Add(lbStateMedicalProcess01);
            listMedicalProcess.Add(lbStateMedicalProcess02);
            listMedicalProcess.Add(lbStateMedicalProcess03);
            listMedicalProcess.Add(lbStateMedicalProcess04);
        }

        #endregion Global methods

        #region Read data - objects

        public void getDataPatientGrid()
        {
            PersonalClinicDataSet.PATIENTDataTable tablePatient = patientBUS.getData();
            dgvPatient.DataSource = tablePatient;

            // Fill data patient - combobox medical record
            cbxMedicalRecordPatient.DataSource = tablePatient;
            cbxMedicalRecordPatient.ValueMember = "idPatient";
            cbxMedicalRecordPatient.DisplayMember = "fullName";
        }

        public void getDataDoctorGird()
        {
            PersonalClinicDataSet.DOCTORDataTable tableDoctor = doctorBUS.getData();

            // Fill data doctor - combobox medical record
            cbxMedicalRecordDoctor.DataSource = tableDoctor;
            cbxMedicalRecordDoctor.ValueMember = "idDoctor";
            cbxMedicalRecordDoctor.DisplayMember = "fullName";
        }

        public void getDataMedicalGrid()
        {
            PersonalClinicDataSet.MEDICAL_RECORDDataTable tableMedicalRecord = medicalRecordBUS.getDataTarget("");
            dgvMedicalRecord.DataSource = tableMedicalRecord;
        }

        #endregion Read data - objects

        #region Patient

        public bool fillCurrentRowDataPatientToControl()
        {
            lbidPatient.Text = Convert.ToString(dgvPatient.CurrentRow.Cells["idPatient"].Value);
            lbidPassportPatient.Text = Convert.ToString(dgvPatient.CurrentRow.Cells["idPassport"].Value);
            lbFullNamePatient.Text = Convert.ToString(dgvPatient.CurrentRow.Cells["fullName"].Value);
            lbBrithdayPatient.Text = Convert.ToString(dgvPatient.CurrentRow.Cells["birthday"].Value);
            lbStatusPatient.Text = (Convert.ToInt32(dgvPatient.CurrentRow.Cells["healthStatus"].Value) == 1) ? "Good" : "Bad";
            return true;
        }

        public PatientDTO selectCurrentRowDataPatientToControl()
        {
            patientDTO.IdPatient = Convert.ToInt32(dgvPatient.CurrentRow.Cells["idPatient"].Value);
            patientDTO.IdPassport = Convert.ToString(dgvPatient.CurrentRow.Cells["idPassport"].Value);
            patientDTO.FullName = Convert.ToString(dgvPatient.CurrentRow.Cells["fullName"].Value);
            patientDTO.Birthday = Convert.ToString(dgvPatient.CurrentRow.Cells["birthday"].Value);
            patientDTO.HealthStatus = Convert.ToInt32(dgvPatient.CurrentRow.Cells["healthStatus"].Value);
            return patientDTO;
        }

        public void clearDataFieldPatient()
        {
            tbxidPassportPatient.Text = "";
            tbxFullNamePatient.Text = "";
            tbxBirthdayPatient.Text = "";
        }

        public bool isCheckNullFieldPatient(string passport, string fullname, string birthday)
        {
            if (passport.Length != 0 && fullname.Length != 0 && birthday.Length != 0)
                return true;
            return false;
        }

        public bool showInforPatientWillInsert(string passport, string fullname, string birthday)
        {
            if (!isCheckNullFieldPatient(passport, fullname, birthday))
            {
                MessageBox.Show("Data is null...", "Messager", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        #endregion Patient

        #region Medical record

        public MedicalRecordDTO selectCurrentRowDataMedicalToControl()
        {
            medicalRecordDTO.IdPatient = Convert.ToInt32(dgvMedicalRecord.CurrentRow.Cells["idPatient"].Value);
            medicalRecordDTO.IdDoctor = Convert.ToInt32(dgvMedicalRecord.CurrentRow.Cells["idDoctor"].Value);
            medicalRecordDTO.History = Convert.ToString(dgvMedicalRecord.CurrentRow.Cells["history"].Value);
            medicalRecordDTO.DateInitMedical = Convert.ToString(dgvMedicalRecord.CurrentRow.Cells["dateInitMedical"].Value);
            medicalRecordDTO.Request = Convert.ToString(dgvMedicalRecord.CurrentRow.Cells["request"].Value);
            medicalRecordDTO.IdMedicalRecord = Convert.ToInt32(dgvMedicalRecord.CurrentRow.Cells["idMedicalRecord"].Value);
            return medicalRecordDTO;
        }

        public void clearDataFieldMedicalRecord()
        {
            tbxHistoryMedicalRecord.Text = "";
        }

        #endregion Medical record

        #endregion Methods


        #region Events

        private void center_screen_Load(object sender, EventArgs e)
        {
            loadSingletonDataObject();
        }

        #region Patient

        private void dgvPatient_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            fillCurrentRowDataPatientToControl();
        }

        private void dgvPatient_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            selectCurrentRowDataPatientToControl();
            Form frmUpdatePatient = new update_patient_screen(patientDTO);
            frmUpdatePatient.Show();
        }

        private void btnRefeshGridPatient_Click(object sender, EventArgs e)
        {
            getDataPatientGrid();
            tbxSearchPatient.Text = "";
        }

        private void btnClearPatient_Click(object sender, EventArgs e)
        {
            clearDataFieldPatient();
        }

        private void btnInsertPatient_Click(object sender, EventArgs e)
        {
            if (!showInforPatientWillInsert(tbxidPassportPatient.Text, tbxFullNamePatient.Text, tbxBirthdayPatient.Text))
                return;

            patientBUS.insertPatient(
                tbxidPassportPatient.Text,
                tbxFullNamePatient.Text,
                tbxBirthdayPatient.Text,
                cbxStatusPatient.SelectedIndex.ToString()
                );

            MessageBox.Show("Data inserted...", "Messager", MessageBoxButtons.OK, MessageBoxIcon.Information);
            clearDataFieldPatient();
            return;
        }

        private void tbxSearchPatient_TextChanged(object sender, EventArgs e)
        {
            PersonalClinicDataSet.PATIENTDataTable tablePatientSearch = patientBUS.getDataTarget(tbxSearchPatient.Text);
            dgvPatient.DataSource = tablePatientSearch;
        }

        #endregion Patient

        #region Medical record

        private void btnClearMedicalRecord_Click(object sender, EventArgs e)
        {
            clearDataFieldMedicalRecord();
        }

        private void btnInsertMedicalRecord_Click(object sender, EventArgs e)
        {
            medicalRecordBUS.insertMedicalRecord(
                cbxMedicalRecordPatient.SelectedValue.ToString(),
                cbxMedicalRecordDoctor.SelectedValue.ToString(),
                tbxHistoryMedicalRecord.Text,
                dtpMedicalRecord.Value.ToString(),
                cbxMedicalRecordRequest.Text
                );
            MessageBox.Show("Data medical record inserted...", "Messager", MessageBoxButtons.OK, MessageBoxIcon.Information);
            clearDataFieldMedicalRecord();
            return;
        }

        private void tbxSearchMedicalRecord_TextChanged(object sender, EventArgs e)
        {
            PersonalClinicDataSet.MEDICAL_RECORDDataTable tableMedicalRecordSearch = medicalRecordBUS.getDataTarget(tbxSearchMedicalRecord.Text);
            if(tbxSearchMedicalRecord == null)
            {
                MessageBox.Show("Search information is null ...", "Messager", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            dgvMedicalRecord.DataSource = tableMedicalRecordSearch;
            return;
        }

        private void dgvMedicalRecord_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            selectCurrentRowDataMedicalToControl();
            Form frmUpdateMedicalRecord = new update_medical_screen(medicalRecordDTO);
            frmUpdateMedicalRecord.Show();
        }

        private void btnRefeshMedicalGrid_Click(object sender, EventArgs e)
        {
            tbxSearchMedicalRecord.Text = "";
            getDataMedicalGrid();
        }

        #endregion Medical record

        #region Medical process

        public void setStateMedicalProcess(string labelStateMedicalProcess)
        {
            foreach (Control item in listMedicalProcess)
            {
                if (item.Name == labelStateMedicalProcess)
                    item.ForeColor = Color.BlueViolet;
                else
                    item.ForeColor = Color.Black;
            }
        }

        private void ptPatient_Click(object sender, EventArgs e)
        {
            tabControlMain.SelectedTab = tpPatient;
            setStateMedicalProcess(lbStateMedicalProcess01.Name);
        }

        private void ptMedicalRecord_Click(object sender, EventArgs e)
        {
            tabControlMain.SelectedTab = tpMedicalRecord;
            setStateMedicalProcess(lbStateMedicalProcess02.Name);
        }

        private void ptTechnique_Click(object sender, EventArgs e)
        {
            tabControlMain.SelectedTab = tpTechnical;
            setStateMedicalProcess(lbStateMedicalProcess03.Name);
        }

        private void ptPrescription_Click(object sender, EventArgs e)
        {
            tabControlMain.SelectedTab = tpPrescription;
            setStateMedicalProcess(lbStateMedicalProcess04.Name);
        }

        #endregion Medical process

        #endregion Events
    }
}
