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
    public partial class center_login : Form
    {
        Dictionary<string, string> dicUser = new Dictionary<string, string>();
        public center_login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            dicUser.Clear();
            dicUser.Add("username", tbxUsername.Text);
            dicUser.Add("password", tbxPassword.Text);

            bool isCheck = false; 

            if(tbxUsername.Text.IndexOf("DC") == 0)
            {
                dicUser.Add("actor", "doctor");
                isCheck = true;
            }
                
            if (tbxUsername.Text.IndexOf("EM") == 0)
            {
                dicUser.Add("actor", "employee");
                isCheck = true;
            }
                
            if (tbxUsername.Text.IndexOf("AD") == 0)
            {
                dicUser.Add("actor", "admin");
                isCheck = true;
            }
                
            if(isCheck)
            {
                Form frmMain = new center_screen(dicUser);
                frmMain.ShowDialog();
                return;
            }

            MessageBox.Show("The username or password does not exist, please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
