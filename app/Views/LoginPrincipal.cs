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
    public partial class LoginPrincipal : Form
    {
        public LoginPrincipal()
        {
            InitializeComponent();
            documentoTxBox.Enabled = false;
        }
        private void optionsLogin_SelectedIndexChanged(object sender, EventArgs e)
        {
            documentoTxBox.Enabled = true;
            documentoTxBox.Text = string.Empty;
            if (optionsLogin.SelectedIndex == 0)
            {
                documentoLabel.Text = "CPF";
                documentoTxBox.MaxLength = 11;
            }
            else
            {
                documentoLabel.Text = "CNPJ";
                documentoTxBox.MaxLength = 14;
            }
        }
        private void btnAbirLoginSecundario_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var loginSecundario = new LoginSecundario();
            loginSecundario.Show();
        }

        private void documentoTxBox_KeyPress(object sender, KeyPressEventArgs e)
            => e.Handled = !char.IsNumber(e.KeyChar);
    }
}
