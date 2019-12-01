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

namespace presentation_layer
{
    public partial class search_screen : Form
    {
        public DoctorBUS _doctorBus = new DoctorBUS();

        public search_screen()
        {
            InitializeComponent();
        }

        #region Methods

        public void loadList()
        {
            PersonalClinicDataSet.DOCTORDataTable _tableDoctor = _doctorBus.getData();

            listBox1.DisplayMember = "fullName";
            listBox1.ValueMember = "idDoctor";
            listBox1.DataSource = _tableDoctor;
        }

        #endregion Methods

        private void search_screen_Load(object sender, EventArgs e)
        {
            loadList();
        }
    }
}
