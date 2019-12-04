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

namespace presentation_layer.admin_root_ui.rest_ui.medicine_ui
{
    public partial class create_medicin_screen : Form
    {
        public MedicineBUS medicineBus = new MedicineBUS();
        public MedicineDTO medicineState = new MedicineDTO();

        public create_medicin_screen()
        {
            InitializeComponent();
        }

        #region Methods

        #region CRUD

        // getDataGrid
        public void getDataGrid()
        {
            PersonalClinicDataSet.MEDICINEDataTable tableMedicine = medicineBus.getData();
            dgvMedicine.DataSource = tableMedicine;
        }
        // updateDataPoint
        //insertDataPoint
        #endregion CRUD

        // selectCurrentRowDataToControl
        public MedicineDTO selectCurrentRowDataMedicineToControl()
        {
            medicineState.IdMedicine = Convert.ToInt32(dgvMedicine.CurrentRow.Cells["idMedicine"].Value);
            medicineState.IdUnitMedicine = Convert.ToInt32(dgvMedicine.CurrentRow.Cells["idUnitMedicine"].Value);
            medicineState.FullName= Convert.ToString(dgvMedicine.CurrentRow.Cells["fullName"].Value);
            medicineState.Symbol = Convert.ToString(dgvMedicine.CurrentRow.Cells["symbol"].Value);
            medicineState.Ingredient = Convert.ToString(dgvMedicine.CurrentRow.Cells["ingredient"].Value);
            medicineState.PriceUnit = Convert.ToDecimal(dgvMedicine.CurrentRow.Cells["priceUnit"].Value);

            return medicineState;
        }

        // fillCurrentRowDataToControl
        public bool fillCurrentRowDataMedicineToControl()
        {
            return true;
        }

        #endregion Methods

        #region Events

        private void create_medicin_screen_Load(object sender, EventArgs e)
        {
            getDataGrid();
        }

        private void dgvMedicine_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int currenRowGrid = dgvMedicine.FirstDisplayedScrollingRowIndex;
            selectCurrentRowDataMedicineToControl();
            Form frmCurrentMedicineUpdate = new update_medicine_screen(medicineState);
            frmCurrentMedicineUpdate.Show();
        }

        private void btnRefesh_Click(object sender, EventArgs e)
        {
            getDataGrid();
        }

        #endregion Events
    }
}
