using app.Models;
using app.Presenters;
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
        PessoaFisicaModel pessoaFisica = new PessoaFisicaModel();
        PessoaJuridicaModel pessoaJuridica = new PessoaJuridicaModel();
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

        private void btnEntrarLogin_Click(object sender, EventArgs e)
        {
            if (optionsLogin.SelectedIndex == 0)
            {
                pessoaFisica.CPF = documentoTxBox.Text;
                if (ValidacaoLoginCliente.PessoaFisicaExiste(pessoaFisica.CPF))
                {
                    pessoaFisica = ValidacaoLoginCliente.pf;
                    var clienteForm = new ClienteMain(pessoaFisica);
                    clienteForm.Show();
                } else
                {
                    documentoTxBox.Text = string.Empty;
                    MessageBox.Show("CPF não cadastrado", "Atenção!");
                }
            } else if (optionsLogin.SelectedIndex == 1)
            {
                pessoaJuridica.CNPJ = documentoTxBox.Text;
                if (ValidacaoLoginCliente.PessoaJuridicaExiste(pessoaJuridica.CNPJ))
                {
                    pessoaJuridica = ValidacaoLoginCliente.pj;
                    var clienteForm = new ClienteMain(pessoaJuridica);
                    clienteForm.Show();
                } else
                {
                    documentoTxBox.Text = string.Empty;
                    MessageBox.Show("CNPJ não cadastrado", "Atenção!");
                }
            }
        }
    }
}
