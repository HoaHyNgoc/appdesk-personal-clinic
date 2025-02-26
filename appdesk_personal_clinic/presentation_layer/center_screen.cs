﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

#region Import Screen

using presentation_layer.center_custom_ui.patient_ui;
using presentation_layer.center_custom_ui.medical_ui;
using presentation_layer.center_custom_ui.technique_ui;
using presentation_layer.center_custom_ui.prescription_ui;

#endregion Import Screen

using business_logic_layer;
using database_access_layer;
using data_transfer_object;
using presentation_layer.DBPersonalClinicDataSetReportTableAdapters;

namespace presentation_layer
{
    public partial class center_screen : Form
    {
        #region Global Variables

        List<Control> listMedicalProcess = new List<Control>();
        List<DetailTechniqueDTO> stateListDetailTechnique = new List<DetailTechniqueDTO>();
        Dictionary<string, string> dicUser = new Dictionary<string, string>();
        decimal sumPriceTechnique = 0;
        decimal sumPricePrescription = 0;
        
        #endregion Global Variables

        #region Import global object business

        DoctorBUS doctorBUS = new DoctorBUS();
        DiagnosticBUS diagnosticBUS = new DiagnosticBUS();
        DetailTechniqueBUS detailTechniqueBUS = new DetailTechniqueBUS();
        MedicalRecordBUS medicalRecordBUS = new MedicalRecordBUS();
        PatientBUS patientBUS = new PatientBUS();
        TechniqueBUS techniqueBUS = new TechniqueBUS();
        PrescriptionBUS prescriptionBUS = new PrescriptionBUS();
        DetailPrescriptionBUS delPrescriptionBUS = new DetailPrescriptionBUS();
        MedicineBUS medicineBUS = new MedicineBUS();
        

        #endregion Import global object business

        #region Import state data object transfer

        MedicalRecordDTO medicalRecordDTO = new MedicalRecordDTO();
        PatientDTO patientDTO = new PatientDTO();
        TechniqueDTO techniqueDTO = new TechniqueDTO();
        PrescriptionDTO prescriptionDTO = new PrescriptionDTO();

        #endregion Import state data object transfer

        public center_screen()
        {
            InitializeComponent();
            initSwitchMenuOption();
        }

        public center_screen(Dictionary<string, string> _dicUser)
        {
            this.dicUser = _dicUser;
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
            getDatePrescriptionGrid();
            getDateMedicine();
        }

        public void initSwitchMenuOption()
        {
            foreach (var pair in dicUser)
            {
                if (pair.Key == "actor")
                {
                    if(pair.Value == "doctor")
                    {
                        tabControlCenter.TabPages.Remove(tabPageReport);
                        tabControlCenter.TabPages.Remove(tabPagePay);
                    }

                    if (pair.Value == "employee")
                    {
                        tabControlCenter.TabPages.Remove(tabPageMedical);
                    }
                }
            }
            listMedicalProcess.Add(lbStateMedicalProcess01);
            listMedicalProcess.Add(lbStateMedicalProcess02);
            listMedicalProcess.Add(lbStateMedicalProcess03);
            listMedicalProcess.Add(lbStateMedicalProcess04);
            listMedicalProcess.Add(lbReportDocument1);
            listMedicalProcess.Add(lbReportDocument2);
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

        public void getDatePrescriptionGrid()
        {
            PersonalClinicDataSet.PRESCRIPTIONDataTable tablePrescription = prescriptionBUS.getData();
            dgvPrescription.DataSource = tablePrescription;
        }

        public void getDateMedicine()
        {
            PersonalClinicDataSet.MEDICINEDataTable tableMedicine = medicineBUS.getData();
            ColCbxMedicine.DataSource = tableMedicine;

            ColCbxMedicine.ValueMember = "idMedicine";
            ColCbxMedicine.DisplayMember = "fullName";
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

        public TechniqueDTO selectCurrentRowDataTechniqueToControl()
        {
            techniqueDTO.IdPatient = Convert.ToInt32(dgvTechnique.CurrentRow.Cells["idPatient"].Value);
            techniqueDTO.IdDoctor = Convert.ToInt32(dgvTechnique.CurrentRow.Cells["idDoctor"].Value);
            techniqueDTO.Price = Convert.ToDecimal(dgvTechnique.CurrentRow.Cells["price"].Value);
            techniqueDTO.IdTechnique = Convert.ToInt32(dgvTechnique.CurrentRow.Cells["idTechnique"].Value);
            return techniqueDTO;
        }

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

        public void clearDataFieldTechnique()
        {
            tbxidPatientTechnique.Text = "";
        }

        #endregion Technique

        #region Prescription

        public void clearDataFieldPrescription()
        {
            tbxidPatientPrescription.Text = "";
            tbxCoulusionPrescription.Text = "";
        }

        public PrescriptionDTO selectCurrentRowDataPrescriptionToControl()
        {
            prescriptionDTO.IdPrescription = Convert.ToInt32(dgvPrescription.CurrentRow.Cells["idPrescription"].Value);
            prescriptionDTO.IdPatient = Convert.ToInt32(dgvPrescription.CurrentRow.Cells["idPatient"].Value);
            prescriptionDTO.Price = Convert.ToDecimal(dgvPrescription.CurrentRow.Cells["price"].Value);
            prescriptionDTO.ConclusionMedical = Convert.ToString(dgvPrescription.CurrentRow.Cells["conclusionMedical"].Value);
            return prescriptionDTO;
        }

        public decimal sumPriceDetailPrescription(decimal price)
        {
            sumPricePrescription += Convert.ToDecimal(price);
            return sumPricePrescription;
        }

        public void resetControlDetailPrescription()
        {
            sumPricePrescription = 0;
            nudSumPricePrescription.Value = 0;
            lbidPrescription.Text = "";
            dgvDelPrescription.Rows.Clear();
        }

        public bool isCheckNullFieldDelPrescription(string _idPrescription, object _numberMedicine, object _helpMedicine)
        {
            if (_idPrescription == null || _idPrescription == "")
                return false;
            else if (_numberMedicine == null)
                return false;
            else if (_helpMedicine == null)
                return false;
            return true;
        }

        #endregion Prescription

        #endregion Methods


        #region Events

        private void center_screen_Load(object sender, EventArgs e)
        {
            loadSingletonDataObject();
            this.rvPrescription.RefreshReport();
            this.rvTechnique.RefreshReport();
            this.rvPayPrescription.RefreshReport();
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

        private void btnExportPatient_Click(object sender, EventArgs e)
        {
            Form frmExportPatient = new export_patient_screen();
            frmExportPatient.ShowDialog();
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
            selectCurrentRowDataTechniqueToControl();

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

                    techniqueBUS.updateTechnique(
                        techniqueDTO.IdDoctor.ToString(),
                        nudSumPriceTechnique.Value.ToString(),
                        techniqueDTO.IdPatient.ToString(),
                        DateTime.Now.ToString("yyyy-MM-dd"),
                        techniqueDTO.IdTechnique.ToString());

                    resetControlDetailTechnique();
                    getDateTechniqueGrid();
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

        private void dgvTechnique_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            selectCurrentRowDataTechniqueToControl();
            Form frmUpdateTechnique = new update_technique_screen(techniqueDTO);
            frmUpdateTechnique.Show();
        }

        private void btnInsertTechnique_Click(object sender, EventArgs e)
        {
            techniqueBUS.insertTechnique(
                cbxTechniqueDoctor.SelectedValue.ToString(),
                "0",
                tbxidPatientTechnique.Text,
                DateTime.Now.ToString("yyyy-MM-dd")
                );

            MessageBox.Show("Data technique inserted...", "Messager", MessageBoxButtons.OK, MessageBoxIcon.Information);
            clearDataFieldTechnique();
        }

        #endregion Technique

        #region Prescription

        private void btnInsertPrescription_Click(object sender, EventArgs e)
        {
            prescriptionBUS.insertPrescription(
                tbxidPatientPrescription.Text,
                tbxCoulusionPrescription.Text,
                "0",
                DateTime.Now.ToString("yyyy-MM-dd")
                );
            MessageBox.Show("Data prescription inserted...", "Messager", MessageBoxButtons.OK, MessageBoxIcon.Information);
            clearDataFieldPrescription();
            getDatePrescriptionGrid();
        }

        private void btnRefeshPrescription_Click(object sender, EventArgs e)
        {
            clearDataFieldTechnique();
            getDatePrescriptionGrid();
        }

        private void tbxSearchPrescription_TextChanged(object sender, EventArgs e)
        {
            PersonalClinicDataSet.PRESCRIPTIONDataTable tablePrescriptionSearch = prescriptionBUS.getDataTarget(tbxSearchPrescription.Text);
            if (tbxSearchTechnique == null)
            {
                MessageBox.Show("Search information is null ...", "Messager", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            dgvPrescription.DataSource = tablePrescriptionSearch;
            return;
        }

        private void dgvPrescription_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectCurrentRowDataPrescriptionToControl();

            lbidPrescription.Text = Convert.ToString(dgvPrescription.CurrentRow.Cells["idPrescription"].Value);
            string pricePrescriptionSelected = dgvPrescription.CurrentRow.Cells["price"].Value.ToString();
            if (pricePrescriptionSelected == "")
            {
                nudSumPricePrescription.Value = 0;
                return;
            }
            nudSumPricePrescription.Value = Convert.ToDecimal(pricePrescriptionSelected);
        }

        private void btnGetPricePrescription_Click(object sender, EventArgs e)
        {
            sumPricePrescription = 0;
            for (int i = 0; i < dgvDelPrescription.RowCount - 1; i++)
            {
                decimal unitPrice = Convert.ToDecimal(dgvDelPrescription.Rows[i].Cells[1].Value);
                int currentNumber = Convert.ToInt32(dgvDelPrescription.Rows[i].Cells[2].Value);
                //MessageBox.Show(dgvDelPrescription.Rows[i].Cells[0].Value.ToString());
                dgvDelPrescription.Rows[i].Cells[3].Value = Convert.ToString(unitPrice * currentNumber);

                sumPriceDetailPrescription(Convert.ToDecimal(unitPrice * currentNumber));
            }

            nudSumPricePrescription.Value = sumPricePrescription;
        }

        private void dgvDelPrescription_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            //GET OUR COMBO OBJECT
            ComboBox comboCell = e.Control as ComboBox;
            if (comboCell != null)
            {
                comboCell.SelectedIndexChanged += new EventHandler(comboCell_SelectedIndexChanged);
            }
        }

        public void comboCell_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((sender as ComboBox).SelectedValue == null)
                return;
            string cellText = (sender as ComboBox).SelectedValue.ToString();

            //retrieve data from database using this cellText
            if (cellText == "System.Data.DataRowView")
                return;
            int priceMedicine = medicineBUS.getDataTargetIdMedicine(cellText);
            dgvDelPrescription.CurrentRow.Cells[1].Value = Convert.ToString(priceMedicine);
        }

        private void btnInsertAllDelPrescription_Click(object sender, EventArgs e)
        {
            DialogResult resultCancelUpdate = MessageBox.Show(
                "The list of techniques has been tested (id Prescription, list medicine, price...) ",
                "Confirm information",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
            if (resultCancelUpdate == DialogResult.Yes)
            {
                if (dgvDelPrescription.RowCount != 0)
                {
                    for (int i = 0; i < dgvDelPrescription.RowCount - 1; i++)
                    {
                        if (isCheckNullFieldDelPrescription(
                            lbidPrescription.Text,
                            dgvDelPrescription.Rows[i].Cells[2].Value,
                            dgvDelPrescription.Rows[i].Cells[4].Value))
                        {
                            delPrescriptionBUS.insertDelPrescription(
                                    lbidPrescription.Text,
                                    dgvDelPrescription.Rows[i].Cells[0].Value.ToString(),
                                    dgvDelPrescription.Rows[i].Cells[2].Value.ToString(),
                                    dgvDelPrescription.Rows[i].Cells[4].Value.ToString(),
                                    dgvDelPrescription.Rows[i].Cells[3].Value.ToString()
                                    );
                        }
                        else
                        {
                            MessageBox.Show("List medicine have field is null...", "Messager", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                    }

                    MessageBox.Show("Data list prescription inserted...");

                    prescriptionBUS.updatePrescription(
                        prescriptionDTO.IdPatient.ToString(),
                        prescriptionDTO.ConclusionMedical,
                        nudSumPricePrescription.Value.ToString(),
                        DateTime.Now.ToString("yyyy-MM-dd"),
                        prescriptionDTO.IdPrescription.ToString()
                        );

                    resetControlDetailPrescription();
                    getDatePrescriptionGrid();
                }
            }
            return;
        }

        private void dgvPrescription_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            selectCurrentRowDataPrescriptionToControl();
            Form frmUpdatePrescription = new update_prescription_ui(prescriptionDTO);
            frmUpdatePrescription.ShowDialog();
        }

        #endregion Prescription

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

        #region Reports

        private void btnCreateReportPrescription_Click(object sender, EventArgs e)
        {
            DBPersonalClinicDataSetReport.PRESCRIPTIONDataTable tblPre = new PRESCRIPTIONTableAdapter().GetDataByTime(dtpTimePrescription.Value.Month);
            rvPrescription.ProcessingMode = ProcessingMode.Local;
            rvPrescription.LocalReport.ReportPath = "D:\\repository\\appdesk-personal-clinic\\appdesk_personal_clinic\\presentation_layer\\reportPrescription.rdlc";

            if (tblPre.Rows.Count > 0)
            {
                ReportDataSource reportDataSource1 = new ReportDataSource();
                reportDataSource1.Name = "DataSetPrescriptionRP";
                reportDataSource1.Value = tblPre;

                rvPrescription.LocalReport.DataSources.Clear();
                rvPrescription.LocalReport.DataSources.Add(reportDataSource1);
                rvPrescription.RefreshReport();
            }
        }

        private void btnCreateReportTechnique_Click(object sender, EventArgs e)
        {
            DBPersonalClinicDataSetReport.TECHNIQUEDataTable tblTec = new TECHNIQUETableAdapter().GetDataByTime(dtpReportTechnique.Value.Month);
            rvTechnique.ProcessingMode = ProcessingMode.Local;
            rvTechnique.LocalReport.ReportPath = "D:\\repository\\appdesk-personal-clinic\\appdesk_personal_clinic\\presentation_layer\\reportTechnique.rdlc";

            if(tblTec.Rows.Count > 0)
            {
                ReportDataSource reportDataSource2 = new ReportDataSource();
                reportDataSource2.Name = "DataSetTechniqueRP";
                reportDataSource2.Value = tblTec;

                rvTechnique.LocalReport.DataSources.Clear();
                rvTechnique.LocalReport.DataSources.Add(reportDataSource2);
                rvTechnique.RefreshReport();
            }
        }

        private void ptReportTechnique_Click(object sender, EventArgs e)
        {
            tabControlMain.SelectedTab = tbReportTechnique;
            setStateMedicalProcess(lbReportDocument2.Name);
        }

        private void ptReportPrescription_Click(object sender, EventArgs e)
        {
            tabControlMain.SelectedTab = tbReportSale;
            setStateMedicalProcess(lbReportDocument1.Name);
        }

        private void ptPayPrescription_Click(object sender, EventArgs e)
        {
            tabControlMain.SelectedTab = tpPayPrescription;
        }

        #endregion Reports

        #region Pay


        private void btnGetPayPrescription_Click(object sender, EventArgs e)
        {
            DBPersonalClinicDataSetReport.PRESCRIPTIONDataTable tbl1 = new PRESCRIPTIONTableAdapter().GetDataByIdPatient(Convert.ToInt32(tbxidPayPrescription.Text));
            string idPre = tbl1.Rows[0]["idPrescription"].ToString();

            DBPersonalClinicDataSetReport.DETAIL_PRESCRIPTIONDataTable tbl2 = new DETAIL_PRESCRIPTIONTableAdapter().GetDataByIdPrescription(Convert.ToInt32(idPre));
            rvPayPrescription.ProcessingMode = ProcessingMode.Local;
            rvPayPrescription.LocalReport.ReportPath = "D:\\repository\\appdesk-personal-clinic\\appdesk_personal_clinic\\presentation_layer\\payPrescription.rdlc";

            if (tbl1.Rows.Count > 0 && tbl1.Rows.Count > 0)
            {
                ReportDataSource reportDataSource1 = new ReportDataSource();
                reportDataSource1.Name = "DataSetPayPrescription";
                reportDataSource1.Value = tbl1;

                ReportDataSource reportDataSource2 = new ReportDataSource();
                reportDataSource2.Name = "DataSetPayDetailPre";
                reportDataSource2.Value = tbl2;

                rvPayPrescription.LocalReport.DataSources.Clear();
                rvPayPrescription.LocalReport.DataSources.Add(reportDataSource1);
                rvPayPrescription.LocalReport.DataSources.Add(reportDataSource2);
                rvPayPrescription.RefreshReport();
            }
            return;
        }

        #endregion Pay

        #endregion Events
    }
}
