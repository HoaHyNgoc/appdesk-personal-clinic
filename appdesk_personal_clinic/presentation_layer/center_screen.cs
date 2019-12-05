using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using presentation_layer.center_custom_ui.patient_ui;

using business_logic_layer;
using database_access_layer;
using data_transfer_object;

namespace presentation_layer
{
    public partial class center_screen : Form
    {
        #region Import global object business

        PatientBUS patientBUS = new PatientBUS();

        #endregion Import global object business

        #region Import state data object transfer

        PatientDTO patientDTO = new PatientDTO();

        #endregion Import state data object transfer

        public center_screen()
        {
            InitializeComponent();
        }

        #region Methods

        #region CRUD

        #region Patient
        public void getDataPatientGrid()
        {
            PersonalClinicDataSet.PATIENTDataTable tablePatient = patientBUS.getData();
            dgvPatient.DataSource = tablePatient;
        }
        #endregion Patient

        #endregion CRUD

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

        #endregion Methods


        #region Events

        #region Patient
        private void center_screen_Load(object sender, EventArgs e)
        {
            getDataPatientGrid();
        }

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

        #endregion Patient

        #endregion Events

        private void tbxSearchPatient_TextChanged(object sender, EventArgs e)
        {
            PersonalClinicDataSet.PATIENTDataTable tablePatientSearch = patientBUS.getDataTarget(tbxSearchPatient.Text);
            dgvPatient.DataSource = tablePatientSearch;
        }
    }
}
