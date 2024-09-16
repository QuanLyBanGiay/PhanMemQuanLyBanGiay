using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanGiay
{
    public partial class FormLogin : Form
    {
        string conn = "Data Source=LAPTOP\\LEYEN1;Initial Catalog=QUANLYBANGIAY;Integrated Security=True;Encrypt=False";
        public FormLogin()
        {
            InitializeComponent();
            loginContol1.Conn = conn;
            loginContol1.LoginSuccessful += LoginSuccessful;
            loginContol1.Register += Register;
        }

        private void Register(object sender, EventArgs e)
        {
            Form f = new FormRegister();
            f.ShowDialog();
        }


        private void LoginSuccessful(object sender, EventArgs e)
        {
            Form f = new Form1();
            f.Show();
            this.Hide();
        }
    }
}
