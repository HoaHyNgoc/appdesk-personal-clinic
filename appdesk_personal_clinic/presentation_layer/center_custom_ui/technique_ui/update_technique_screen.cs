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

namespace presentation_layer.center_custom_ui.technique_ui
{
    public partial class update_technique_screen : Form
    {

        #region Import BUS

        TechniqueBUS techniqueBUS = new TechniqueBUS();
        DetailTechniqueBUS detailTechniqueBUS = new DetailTechniqueBUS();
        DiagnosticBUS diagnosticBUS = new DiagnosticBUS();

        #endregion Import BUS

        #region Import DTO

        TechniqueDTO techniqueState = new TechniqueDTO();

        #endregion Import DTO

        #region Methods

        public update_technique_screen()
        {
            InitializeComponent();
        }

        public update_technique_screen(TechniqueDTO _techniqueState)
        {
            this.techniqueState = _techniqueState;
            InitializeComponent();
        }

        public void getDiagnosticGrid()
        {
            PersonalClinicDataSet.DIAGNOSTICDataTable tableDiagnostic = diagnosticBUS.getData();

            // Fill data diagnostic - combobox technique
            cbxDiagnostic.DataSource = tableDiagnostic;
            cbxDiagnostic.ValueMember = "idDiagnostic";
            cbxDiagnostic.DisplayMember = "fullName";

        }

        public void getDataDetailTechniqueGrid(string _idTechnique)
        {
            PersonalClinicDataSet.DETAIL_TECHNIQUEDataTable tableDetailTechnique;
            tableDetailTechnique = detailTechniqueBUS.getDataTarget(_idTechnique);
            dgvDetailTechnique.DataSource = tableDetailTechnique;
        }

        public decimal sumColumnPriceDataGridView()
        {
            decimal totalPrice = 0;

            for (int i = 0; i < dgvDetailTechnique.Rows.Count; i++)
            {
                totalPrice += Convert.ToDecimal(dgvDetailTechnique.Rows[i].Cells["price"].Value);
            }
            return totalPrice;
        }

        public void backupDataDetailTechnique()
        {
            for (int i = 0; i < dgvbackupDetailTechnique.Rows.Count; i++)
            {
                if(Convert.ToString(dgvbackupDetailTechnique.Rows[i].Cells["price"].Value) != "")
                {
                    detailTechniqueBUS.updateDelTechnique(
                        Convert.ToString(dgvbackupDetailTechnique.Rows[i].Cells["idTechnique"].Value),
                        Convert.ToString(dgvbackupDetailTechnique.Rows[i].Cells["idDiagnostic"].Value),
                        Convert.ToString(dgvbackupDetailTechnique.Rows[i].Cells["result"].Value),
                        Convert.ToString(dgvbackupDetailTechnique.Rows[i].Cells["price"].Value),
                        Convert.ToString(dgvbackupDetailTechnique.Rows[i].Cells["idDetailTechnique"].Value)
                        );
                }

            }
        }

        #endregion Methods

        #region Events

        private void update_technique_screen_Load(object sender, EventArgs e)
        {
            lbidTechnique.Text = techniqueState.IdTechnique.ToString();
            lbidDoctor.Text = techniqueState.IdDoctor.ToString();
            tbxidPatientTechnique.Text = techniqueState.IdPatient.ToString();
            nudSumPriceTechnique.Value = techniqueState.Price;

            // backup data
            PersonalClinicDataSet.DETAIL_TECHNIQUEDataTable tableDetailTechnique;
            tableDetailTechnique = detailTechniqueBUS.getDataTarget(techniqueState.IdTechnique.ToString());
            dgvbackupDetailTechnique.DataSource = tableDetailTechnique;
            nudBackupSumPriceTechnique.Value = techniqueState.Price;

            getDataDetailTechniqueGrid(techniqueState.IdTechnique.ToString());
            getDiagnosticGrid();
        }

        private void dgvDetailTechnique_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lbidDelTechnique.Text = Convert.ToString(dgvDetailTechnique.CurrentRow.Cells["idDetailTechnique"].Value);
            nudPriceDetailTechnique.Value = Convert.ToDecimal(dgvDetailTechnique.CurrentRow.Cells["price"].Value);
            tbxResultDetailTechnique.Text = Convert.ToString(dgvDetailTechnique.CurrentRow.Cells["result"].Value);
            cbxDiagnostic.SelectedValue = Convert.ToString(dgvDetailTechnique.CurrentRow.Cells["idDiagnostic"].Value);
        }

        private void btnUpdateDelTechnique_Click(object sender, EventArgs e)
        {
            detailTechniqueBUS.updateDelTechnique(
                lbidTechnique.Text,
                cbxDiagnostic.SelectedValue.ToString(),
                tbxResultDetailTechnique.Text,
                nudPriceDetailTechnique.Value.ToString(),
                lbidDelTechnique.Text
                );

            getDataDetailTechniqueGrid(techniqueState.IdTechnique.ToString());
            nudSumPriceTechnique.Value = sumColumnPriceDataGridView();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nudSumPriceTechnique.Value = sumColumnPriceDataGridView();
        }

        private void cbxDiagnostic_TextChanged(object sender, EventArgs e)
        {
            if (cbxDiagnostic.SelectedValue.ToString() == "System.Data.DataRowView")
                return;
            int priceDiagnostic = diagnosticBUS.getDataTargetIdDiagnostic(cbxDiagnostic.SelectedValue.ToString());
            nudPriceDetailTechnique.Value = Convert.ToDecimal(priceDiagnostic);
        }

        private void btnUpdateTechnique_Click(object sender, EventArgs e)
        {
            techniqueBUS.updateTechnique(
                lbidDoctor.Text,
                nudSumPriceTechnique.Value.ToString(),
                tbxidPatientTechnique.Text,
                lbidTechnique.Text
                );

            MessageBox.Show("Data technique updated...", "Messager", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnCancelUpdateTechnique_Click(object sender, EventArgs e)
        {
            DialogResult resultCancelUpdate = MessageBox.Show(
            "You want to stop updating this data",
            "Warning",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning);
            if (resultCancelUpdate == DialogResult.Yes)
            {
                backupDataDetailTechnique();
                this.Close();
            }
            return;
        }

        #endregion Events
    }
}
