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

namespace presentation_layer.center_custom_ui.prescription_ui
{
    public partial class update_prescription_ui : Form
    {

        #region Import BUS

        PrescriptionBUS prescriptionBUS = new PrescriptionBUS();
        DetailPrescriptionBUS delprescriptionBUS = new DetailPrescriptionBUS();
        MedicineBUS medicineBUS = new MedicineBUS();

        #endregion Import BUS

        #region Import DTO

        PrescriptionDTO prescriptionState = new PrescriptionDTO();

        #endregion Import DTO

        public update_prescription_ui()
        {
            InitializeComponent();
        }

        public update_prescription_ui(PrescriptionDTO _prescriptionState)
        {
            this.prescriptionState = _prescriptionState;
            InitializeComponent();
            dgvDelPrescription.AutoGenerateColumns = false;
            dgvDelPrescription.AllowUserToAddRows = false;
        }

        public void getDataMedicine()
        {
            PersonalClinicDataSet.MEDICINEDataTable tableMedicine = medicineBUS.getData();

            ColCbxMedicine.DataSource = tableMedicine;
            ColCbxMedicine.ValueMember = "idMedicine";
            ColCbxMedicine.DisplayMember = "fullName";

            cbxBackMedicine.DataSource = tableMedicine;
            cbxBackMedicine.ValueMember = "idMedicine";
            cbxBackMedicine.DisplayMember = "fullName";
        }

        public void getDataDetailPrescriptionGrid(string _idPrescription)
        {
            PersonalClinicDataSet.DETAIL_PRESCRIPTIONDataTable tableDetailPrescription;
            tableDetailPrescription = delprescriptionBUS.getDataTarget(_idPrescription);
            dgvDelPrescription.DataSource = tableDetailPrescription;

            ColCbxMedicine.DataPropertyName = "idMedicine";
            ColNumber.DataPropertyName = "number";
            ColHelpful.DataPropertyName = "useHelp";
            ColPriceMedicine.DataPropertyName = "price";
        }

        private void update_prescription_ui_Load(object sender, EventArgs e)
        {
            lbidPrescription.Text = prescriptionState.IdPrescription.ToString();
            tbxCoulusionPrescription.Text = prescriptionState.ConclusionMedical.ToString();
            tbxidPatientPrescription.Text = prescriptionState.IdPatient.ToString();
            nudSumPricePrescription.Value = prescriptionState.Price;

            getDataDetailPrescriptionGrid(prescriptionState.IdPrescription.ToString());
            getDataMedicine();
        }
    }
}
