using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace CustomControlsLIbrary
{
    public class TextBoxNumberic:TextBox
    {
        public TextBoxNumberic()
        {
            this.Font = new Font("Times New Roman", 13);
            this.KeyPress += TextBoxNumberic_KeyPress;
            this.Validating += TextBoxNumberic_Validating;
        }

        //Phải có thông tin
        private void TextBoxNumberic_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.Text))
            {
                e.Cancel = true; // Ngăn không cho rời khỏi TextBox nếu không hợp lệ
                this.BackColor = Color.LightPink; // Đổi màu nền để thông báo lỗi
                MessageBox.Show("Vui lòng nhập giá trị số", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.BackColor = Color.White; // Khôi phục màu nền nếu nhập hợp lệ
            }
        }

        //Textbox chỉ cho nhập số
        private void TextBoxNumberic_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
