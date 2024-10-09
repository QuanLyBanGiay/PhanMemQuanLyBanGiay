using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Text.RegularExpressions;

namespace CustomControlsLIbrary
{
    public class TextBoxPassword : TextBox
    {
        public TextBoxPassword()
        {
            this.Font = new Font("Times New Roman", 13);
            this.UseSystemPasswordChar = true;
            this.Validating += TextBoxPassword_Validating;
        }

        //Mật khẩu: tối thiểu 8 ký tự, có chữ thường, chữ hoa, số, ký tự đặc biệt 
        private void TextBoxPassword_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string passwordPattern = @"^(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$";

            if (!Regex.IsMatch(this.Text, passwordPattern))
            {
                MessageBox.Show("Mật khẩu phải chứa ít nhất 1 chữ in hoa, 1 số, 1 ký tự đặc biệt và tối thiểu 8 ký tự");
                e.Cancel = true;
            }
        }
    }
}
