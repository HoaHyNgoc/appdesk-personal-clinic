using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

#region UI namespace

using presentation_layer.admin_root_ui.rest_ui.medicine_ui;

#endregion UI namespace

namespace presentation_layer
{
    public partial class screen_admin : Form
    {
        public screen_admin()
        {
            InitializeComponent();
        }

        #region Events MenuItem

        #region CRUD Medicine

        private void meiMedicine_Click(object sender, EventArgs e)
        {
            Form frmCreatMedicine = new create_medicin_screen();
            frmCreatMedicine.Show();
        }

        #endregion CRUD Medicine

        #endregion Events MenuItem
    }
}
