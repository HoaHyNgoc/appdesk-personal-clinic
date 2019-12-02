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

namespace presentation_layer
{
    public partial class search_screen : Form
    {
        public DoctorBUS doctorBus = new DoctorBUS();
        public DoctorDTO doctorState = new DoctorDTO();

        public search_screen()
        {
            InitializeComponent();
        }

        #region Methods

        #region CRUD

        public void getDataGrid()
        {
            PersonalClinicDataSet.DOCTORDataTable tableDoctor = doctorBus.getData();
            dgvDoctor.DataSource = tableDoctor;
        }

        public void updateDataPointDoctor(
            string idSpecialistUI,
            string idPassportUI,
            string fullNameUI,
            string isGeneralUI,
            string originalIdDoctorUI)
        {
            doctorBus.updateDoctor(
                idSpecialistUI, 
                idPassportUI, 
                fullNameUI, 
                isGeneralUI, 
                originalIdDoctorUI
                );
        }

        public bool fillCurrentRowDataDoctorToControl()
        {
            tbxPassportDoctor.Text = dgvDoctor.CurrentRow.Cells["idPassport"].Value.ToString();
            tbxFullnameDoctor.Text = dgvDoctor.CurrentRow.Cells["fullName"].Value.ToString();
            cbxSpecialist.Text = dgvDoctor.CurrentRow.Cells["idSpecialist"].Value.ToString();
            lbidDoctor.Text = dgvDoctor.CurrentRow.Cells["idDoctor"].Value.ToString();
            lbisGeneral.Text = dgvDoctor.CurrentRow.Cells["isGeneral"].Value.ToString();

            return true;
        }

        #endregion CRUD

        #endregion Methods

        #region Events

        private void search_screen_Load(object sender, EventArgs e)
        {
            getDataGrid();
        }

        private void dgvDoctor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvDoctor.RowCount > 0)
                fillCurrentRowDataDoctorToControl();
            return;
        }

        private void btnUpdateDoctor_Click(object sender, EventArgs e)
        {
            updateDataPointDoctor(
                cbxSpecialist.Text,
                tbxPassportDoctor.Text,
                tbxFullnameDoctor.Text,
                lbisGeneral.Text,
                lbidDoctor.Text
                );

            getDataGrid();
        }

        #endregion Events
    }
}
