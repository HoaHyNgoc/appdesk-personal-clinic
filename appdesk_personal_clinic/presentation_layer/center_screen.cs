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
        List<DetailTechniqueDTO> stateListDetailTechnique = new List<DetailTechniqueDTO>();
        decimal sumPriceTechnique = 0;
        
        #endregion Global Variables

        #region Import global object business

        DoctorBUS doctorBUS = new DoctorBUS();
        DiagnosticBUS diagnosticBUS = new DiagnosticBUS();
        DetailTechniqueBUS detailTechniqueBUS = new DetailTechniqueBUS();
        MedicalRecordBUS medicalRecordBUS = new MedicalRecordBUS();
        PatientBUS patientBUS = new PatientBUS();
        TechniqueBUS techniqueBUS = new TechniqueBUS();
        

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
            getDiagnosticGrid();
            getDateTechniqueGrid();
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

            // Fill data doctor - combobox technique
            cbxTechniqueDoctor.DataSource = tableDoctor;
            cbxTechniqueDoctor.ValueMember = "idDoctor";
            cbxTechniqueDoctor.DisplayMember = "fullName";
        }

        public void getDataMedicalGrid()
        {
            PersonalClinicDataSet.MEDICAL_RECORDDataTable tableMedicalRecord = medicalRecordBUS.getDataTarget("");
            dgvMedicalRecord.DataSource = tableMedicalRecord;
        }

        public void getDiagnosticGrid()
        {
            PersonalClinicDataSet.DIAGNOSTICDataTable tableDiagnostic = diagnosticBUS.getData();

            // Fill data diagnostic - combobox technique
            cbxTechniqueDiagnostic.DataSource = tableDiagnostic;
            cbxTechniqueDiagnostic.ValueMember = "idDiagnostic";
            cbxTechniqueDiagnostic.DisplayMember = "fullName";

        }

        public void getDateTechniqueGrid()
        {
            PersonalClinicDataSet.TECHNIQUEDataTable tableTechnique = techniqueBUS.getData();
            dgvTechnique.DataSource = tableTechnique;
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

        #region Technique

        public decimal sumPriceDetailTechnique(decimal price)
        {
            sumPriceTechnique += Convert.ToDecimal(price);
            return sumPriceTechnique;
        }

        public void resetControlDetailTechnique()
        {
            sumPriceTechnique = 0;
            nudSumPriceTechnique.Value = 0;
            stateListDetailTechnique.Clear();
            lvDetailTechnique.Items.Clear();
        }

        public bool isCheckDuplicateDetailTechnique(int _idCurrentDiagnostic)
        {
            if (stateListDetailTechnique.Count != 0)
            {
                foreach (DetailTechniqueDTO item in stateListDetailTechnique)
                {
                    if (item.IdDiagnostic == _idCurrentDiagnostic)
                    {
                        MessageBox.Show("Diagnostic already exist...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
            return true;
        }

        #endregion Technique

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

        #region Technique

        private void cbxTechniqueDiagnostic_TextChanged(object sender, EventArgs e)
        {
            if (cbxTechniqueDiagnostic.SelectedValue.ToString() == "System.Data.DataRowView")
                return;
            int priceDiagnostic = diagnosticBUS.getDataTargetIdDiagnostic(cbxTechniqueDiagnostic.SelectedValue.ToString());
            nudTechniquePriceDiagnostic.Value = Convert.ToDecimal(priceDiagnostic);
        }

        private void btnTechniqueAddDelTechnique_Click(object sender, EventArgs e)
        {
            if (isCheckDuplicateDetailTechnique(Convert.ToInt32(cbxTechniqueDiagnostic.SelectedValue)))
            {
                DetailTechniqueDTO temp = new DetailTechniqueDTO();
                temp.IdTechnique = Convert.ToInt32(lbidTechnique.Text);
                temp.IdDiagnostic = Convert.ToInt32(cbxTechniqueDiagnostic.SelectedValue);
                temp.Result = "process";
                temp.Price = nudTechniquePriceDiagnostic.Value;

                ListViewItem dataItemDetailTechnique = new ListViewItem(temp.IdDiagnostic.ToString());
                ListViewItem.ListViewSubItem subPriceDiagnostic = new ListViewItem.ListViewSubItem(dataItemDetailTechnique, temp.Price.ToString());
                dataItemDetailTechnique.SubItems.Add(subPriceDiagnostic);
                lvDetailTechnique.Items.Add(dataItemDetailTechnique);

                nudSumPriceTechnique.Value = sumPriceDetailTechnique(nudTechniquePriceDiagnostic.Value);

                stateListDetailTechnique.Add(temp);
                MessageBox.Show("Size list: " + stateListDetailTechnique.Count().ToString());
            }
        }

        private void dgvTechnique_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lbidTechnique.Text = Convert.ToString(dgvTechnique.CurrentRow.Cells["idTechnique"].Value);
            string priceTechniqueSelected = dgvTechnique.CurrentRow.Cells["price"].Value.ToString();
            if (priceTechniqueSelected == "")
            {
                nudSumPriceTechnique.Value = 0;
                return;
            }
            nudSumPriceTechnique.Value = Convert.ToDecimal(priceTechniqueSelected);
        }

        private void btnResetTechniqueSumprice_Click(object sender, EventArgs e)
        {
            resetControlDetailTechnique();
        }

        private void btnInsertAllDetailTechnique_Click(object sender, EventArgs e)
        {
            DialogResult resultCancelUpdate = MessageBox.Show(
            "The list of techniques has been tested (id Technique, list technique, price...) ",
            "Confirm information",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning);
            if (resultCancelUpdate == DialogResult.Yes)
            {              
                if(stateListDetailTechnique.Count != 0)
                {
                    foreach (DetailTechniqueDTO item in stateListDetailTechnique)
                    {
                        detailTechniqueBUS.insertDelTechnique(
                            item.IdTechnique.ToString(),
                            item.IdDiagnostic.ToString(),
                            item.Result.ToString(),
                            item.Price.ToString()
                            );
                    }

                    MessageBox.Show("Data list technique inserted...");
                    resetControlDetailTechnique();
                }
            }   
            return;
        }

        private void tbxSearchTechnique_TextChanged(object sender, EventArgs e)
        {
            PersonalClinicDataSet.TECHNIQUEDataTable tableTechniqueSearch = techniqueBUS.getDataTarget(tbxSearchTechnique.Text);
            if (tbxSearchTechnique == null)
            {
                MessageBox.Show("Search information is null ...", "Messager", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            dgvTechnique.DataSource = tableTechniqueSearch;
            return;
        }

        private void btnRefeshTechnique_Click(object sender, EventArgs e)
        {
            tbxSearchTechnique.Text = "";
            getDateTechniqueGrid();
        }

        #endregion Technique

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
