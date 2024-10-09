using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace CustomControlsLibrary
{
    public class TextBoxLogin:TextBox
    {
        public TextBoxLogin()
        {
            this.Font = new Font("Times New Roman", 13);
            this.KeyPress += UserTextBox_KeyPress;
            this.Validating += TextBoxLogin_Validating;
        }

        private void TextBoxLogin_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            
        }

        private void UserTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //chỉ cho nhập số và nhập chữ
            if (!char.IsDigit(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
