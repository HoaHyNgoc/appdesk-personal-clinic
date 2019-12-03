using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace presentation_layer
{
    public partial class screen_admin : Form
    {
        public screen_admin()
        {
            InitializeComponent();
        }

        private void createDoctor_Click(object sender, EventArgs e)
        {
            Form form = new screen_create();
            form.Show();
        }
    }
}
