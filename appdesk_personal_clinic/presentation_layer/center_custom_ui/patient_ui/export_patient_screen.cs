using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;

using presentation_layer.DBPersonalClinicDataSetReportTableAdapters;

namespace presentation_layer.center_custom_ui.patient_ui
{
    public partial class export_patient_screen : Form
    {
        public export_patient_screen()
        {
            InitializeComponent();
        }

        private void export_patient_screen_Load(object sender, EventArgs e)
        {
            this.rvPatient.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = Properties.Settings.Default.DBPersonalClinicConnectionStringReport;
            conn.Open();

            DBPersonalClinicDataSetReport.PATIENTDataTable tbl = new PATIENTTableAdapter().GetDataByIdPassport(tbxidPassportPatient.Text);
            rvPatient.ProcessingMode = ProcessingMode.Local;
            rvPatient.LocalReport.ReportPath = "D:\\repository\\appdesk-personal-clinic\\appdesk_personal_clinic\\presentation_layer\\reportPatient.rdlc";

            if(tbl.Rows.Count > 0)
            {
                ReportDataSource reportDataSource = new ReportDataSource();
                reportDataSource.Name = "DataSetReportPatient";
                reportDataSource.Value = tbl;

                rvPatient.LocalReport.DataSources.Clear();
                rvPatient.LocalReport.DataSources.Add(reportDataSource);
                rvPatient.RefreshReport();
            }

            conn.Close();
        }
    }
}
