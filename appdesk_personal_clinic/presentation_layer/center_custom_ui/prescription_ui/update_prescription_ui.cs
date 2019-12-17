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

        DataTable currentTable = new DataTable();

        public update_prescription_ui()
        {
            InitializeComponent();
        }

        public update_prescription_ui(PrescriptionDTO _prescriptionState)
        {
            this.prescriptionState = _prescriptionState;
            InitializeComponent();

            // ignore auto generate columns 
            dgvDelPrescription.AutoGenerateColumns = false;
            dgvDelPrescription.AllowUserToAddRows = false;
            dgvBackup.AutoGenerateColumns = false;
            dgvBackup.AllowUserToAddRows = false;
        }

        public void getDataMedicine()
        {
            PersonalClinicDataSet.MEDICINEDataTable tableMedicine = medicineBUS.getData();

            ColCbxMedicine.DataSource = tableMedicine;
            ColCbxMedicine.ValueMember = "idMedicine";
            ColCbxMedicine.DisplayMember = "fullName";

            //backup
            cbxBackMedicine.DataSource = tableMedicine;
            cbxBackMedicine.ValueMember = "idMedicine";
            cbxBackMedicine.DisplayMember = "fullName";
        }

        public void getDataDetailPrescriptionGrid(string _idPrescription)
        {
            PersonalClinicDataSet.DETAIL_PRESCRIPTIONDataTable tableDetailPrescription;
            tableDetailPrescription = delprescriptionBUS.getDataTarget(_idPrescription);

            dgvDelPrescription.DataSource = tableDetailPrescription;
            idDelPrescription.DataPropertyName = "idDetailPrescription";
            ColCbxMedicine.DataPropertyName = "idMedicine";
            ColNumber.DataPropertyName = "number";
            ColHelpful.DataPropertyName = "useHelp";
            ColPriceMedicine.DataPropertyName = "price";

            //backup
            //dgvBackup.DataSource = tableDetailPrescription;
            //cbxBackMedicine.DataPropertyName = "idMedicine";
            //backNumber.DataPropertyName = "number";
            //backHelp.DataPropertyName = "useHelp";
            //backSubPrice.DataPropertyName = "price";
        }

        public decimal sumColumnPriceDataGridView()
        {
            decimal totalPrice = 0;

            for (int i = 0; i < dgvDelPrescription.Rows.Count; i++)
            {
                totalPrice += Convert.ToDecimal(dgvDelPrescription.Rows[i].Cells[4].Value);
            }
            return totalPrice;
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

        private void AddARow(DataTable table)
        {
            // Use the NewRow method to create a DataRow with 
            // the table's schema.
            DataRow newRow = table.NewRow();

            // Add the row to the rows collection.
            table.Rows.Add(newRow);
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
            dgvDelPrescription.CurrentRow.Cells[2].Value = Convert.ToString(priceMedicine);
        }

        private void btnGetPricePrescription_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < dgvDelPrescription.RowCount; i++)
            {
                decimal unitPrice = Convert.ToDecimal(dgvDelPrescription.Rows[i].Cells[2].Value);
                int currentNumber = Convert.ToInt32(dgvDelPrescription.Rows[i].Cells[3].Value);
                dgvDelPrescription.Rows[i].Cells[4].Value = Convert.ToString(unitPrice * currentNumber);
            }
          
            nudSumPricePrescription.Value = sumColumnPriceDataGridView();
        }

        private void btnUpdateAllDelPrescription_Click(object sender, EventArgs e)
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
                            dgvDelPrescription.Rows[i].Cells[3].Value,
                            dgvDelPrescription.Rows[i].Cells[5].Value))
                        {
                            delprescriptionBUS.updateDelPrescription(
                                    lbidPrescription.Text,
                                    dgvDelPrescription.Rows[i].Cells[1].Value.ToString(),
                                    dgvDelPrescription.Rows[i].Cells[3].Value.ToString(),
                                    dgvDelPrescription.Rows[i].Cells[5].Value.ToString(),
                                    dgvDelPrescription.Rows[i].Cells[4].Value.ToString(),
                                    dgvDelPrescription.Rows[i].Cells[0].Value.ToString()
                                    );
                        }
                        else
                        {
                            MessageBox.Show("List medicine have field is null...", "Messager", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                    }

                    MessageBox.Show("Data list prescription updated...");

                    prescriptionBUS.updatePrescription(
                        prescriptionState.IdPatient.ToString(),
                        tbxCoulusionPrescription.Text,
                        nudSumPricePrescription.Value.ToString(),
                        prescriptionState.IdPrescription.ToString()
                        );

                    this.Close();
                }
            }
            return;
        }

        private void btnCancelUpdatePrescription_Click(object sender, EventArgs e)
        {
            DialogResult resultCancelUpdate = MessageBox.Show(
            "You want to stop updating this data",
            "Warning",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning);
            if (resultCancelUpdate == DialogResult.Yes)
            {
                this.Close();
            }
            return;
        }

        private void btnAddRow_Click(object sender, EventArgs e)
        {
            delprescriptionBUS.insertDelPrescription(
                    lbidPrescription.Text,
                    dgvDelPrescription.Rows[0].Cells[1].Value.ToString(),
                    dgvDelPrescription.Rows[0].Cells[3].Value.ToString(),
                    dgvDelPrescription.Rows[0].Cells[5].Value.ToString(),
                    dgvDelPrescription.Rows[0].Cells[4].Value.ToString()
                );
            getDataDetailPrescriptionGrid(prescriptionState.IdPrescription.ToString());
        }

        private void btnDeleteRow_Click(object sender, EventArgs e)
        {
            if (dgvDelPrescription.SelectedRows.Count > 0)
            {
                DataGridViewSelectedRowCollection row = dgvDelPrescription.SelectedRows;
                // taking the index of the selected rows and removing
                dgvDelPrescription.Rows.RemoveAt(dgvDelPrescription.SelectedRows[0].Index);
                delprescriptionBUS.deleteDelPrescription(dgvDelPrescription.CurrentRow.Cells[0].Value.ToString());
                MessageBox.Show("Row is deleted...");
            }
            else
            {  //optional    
                MessageBox.Show("Please select a row");
            }
        }
    }
}
