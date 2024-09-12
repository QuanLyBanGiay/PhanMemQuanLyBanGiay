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
    public class TextBoxEmail:TextBox
    {
        public TextBoxEmail()
        {
            this.Font = new Font("Times New Roman", 13);
            this.Validating += TextBoxEmail_Validating;
        }

        private void TextBoxEmail_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if (!Regex.IsMatch(this.Text, emailPattern))
            {
                MessageBox.Show("Email không hợp lệ");
                e.Cancel = true;
            }
        }
    }
}
