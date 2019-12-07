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
    public partial class screen_debug_data : Form
    {
        public MedicalRecordBUS objectBus = new MedicalRecordBUS();

        public screen_debug_data()
        {
            InitializeComponent();
        }

        public void loadDataDebugGrid()
        {
            PersonalClinicDataSet.MEDICAL_RECORDDataTable tableData = objectBus.getData();
            dataGridView1.DataSource = tableData;
        }

        private void screen_debug_data_Load(object sender, EventArgs e)
        {
            loadDataDebugGrid();
        }
    }
}
