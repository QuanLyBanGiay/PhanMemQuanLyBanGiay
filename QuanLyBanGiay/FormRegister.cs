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
    public partial class FormRegister : Form
    {
        string conn = "Data Source=LAPTOP\\LEYEN1;Initial Catalog=QUANLYBANGIAY;Integrated Security=True;Encrypt=False";
        public FormRegister()
        {
            InitializeComponent();
            registerControl1.Conn = conn;
            registerControl1.Close += Close;
            registerControl1.RegisterSuccessful += RegisterSuccessful;
        }

        private void RegisterSuccessful(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Close(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
