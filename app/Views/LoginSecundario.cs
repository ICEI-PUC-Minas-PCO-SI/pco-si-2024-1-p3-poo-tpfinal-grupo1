using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app.Views
{
    public partial class LoginSecundario : Form
    {
        public LoginSecundario()
        {
            InitializeComponent();
        }

        private void btnEncerrarLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
            => this.Hide();

        private void matriculaTxBox_KeyPress(object sender, KeyPressEventArgs e)
            => e.Handled = !char.IsNumber(e.KeyChar);
    }
}
