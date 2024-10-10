using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace CustomControlsLIbrary
{
    public class ButtonLogin:Button
    {
        public ButtonLogin()
        {
            this.Font = new Font("Times New Roman", 13);
            this.Text = "OK";
            this.Size = new Size(128, 64);
        }
    }
}
