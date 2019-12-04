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
    public partial class update_medicine_screen : Form
    {
        public MedicineBUS medicineBus = new MedicineBUS();
        public UnitMedicineBUS unitMedicineBUS = new UnitMedicineBUS();
        public MedicineDTO medicineState = new MedicineDTO();

        public update_medicine_screen()
        {
            InitializeComponent();
        }

        public update_medicine_screen(MedicineDTO _medicineState)
        {
            this.medicineState = _medicineState;
            InitializeComponent();
        }

        #region Methods

        public bool loadDataMedicineReceiveToView()
        {
            if (this.medicineState == null)
                return false;

            lbidMedicine.Text = Convert.ToString(medicineState.IdMedicine);
            cbxUnit.Text = Convert.ToString(medicineState.IdUnitMedicine);
            tbxFullName.Text = Convert.ToString(medicineState.FullName);
            tbxSymbol.Text = Convert.ToString(medicineState.Symbol);
            tbxIngredient.Text = Convert.ToString(medicineState.Ingredient);
            nudPrice.Value = Convert.ToInt32(medicineState.PriceUnit);

            return true;
        }

        public bool loadDataUnitMedicineToView()
        {
            PersonalClinicDataSet.UNIT_MEDICINEDataTable tableUnitMedicine = unitMedicineBUS.getData();
            cbxUnit.DataSource = tableUnitMedicine;
            cbxUnit.DisplayMember = "fullNameUnit";
            cbxUnit.ValueMember = "idUnitMedicine";
            return true;
        }

        public void updateDataPointMedicine(
            string idUnitMedicineUI,
            string fullNameUI,
            string symbolUI,
            string ingredientUI,
            string priceUnitUI,
            string originalIdMedicineUI)
        {
            medicineBus.updateMedicine(
                idUnitMedicineUI,
                fullNameUI,
                symbolUI,
                ingredientUI,
                priceUnitUI,
                originalIdMedicineUI
                );
        }

        #endregion Methods

        #region Events

        private void update_medicine_screen_Load(object sender, EventArgs e)
        {
            if (loadDataMedicineReceiveToView() && loadDataUnitMedicineToView())
                return;
            MessageBox.Show("Receive data medicine error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            updateDataPointMedicine(
                cbxUnit.SelectedValue.ToString(),
                tbxFullName.Text,
                tbxSymbol.Text,
                tbxIngredient.Text,
                nudPrice.Value.ToString(),
                lbidMedicine.Text
                );

            MessageBox.Show("Data updated...", "Messager", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        #endregion Envents
    }
}
