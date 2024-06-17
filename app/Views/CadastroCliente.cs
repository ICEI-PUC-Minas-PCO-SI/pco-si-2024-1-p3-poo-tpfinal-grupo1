using app.Models;
using app.Presenters;
using app.Repositories;
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
    public partial class CadastroCliente : Form
    {
        public CadastroCliente()
        {
            InitializeComponent();
            documentoTxBox.Enabled = false;
            nomeRzSocialTxBox.Enabled = false;
        }

        private void tipoPessoaOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            documentoTxBox.Enabled = true;
            nomeRzSocialTxBox.Enabled = true;
            documentoTxBox.Text = string.Empty;
            nomeRzSocialTxBox.Text = string.Empty;

            if (tipoPessoaOptions.SelectedIndex == 0)
            {
                documentoGB.Text = "CPF";
                nomeRzSocialGB.Text = "Nome";
                documentoTxBox.MaxLength = 11;
            }
            else
            {
                documentoGB.Text = "CNPJ";
                nomeRzSocialGB.Text = "Razão Social";
                documentoTxBox.MaxLength = 14;
            }
        }

        private void cadastrarPessoaBtn_Click(object sender, EventArgs e)
        {
            if (tipoPessoaOptions.SelectedIndex == 0)
            {
                var pessoaFisica = new PessoaFisicaModel();
                pessoaFisica.CPF = documentoTxBox.Text;
                pessoaFisica.Email = emailTxBox.Text;
                pessoaFisica.Telefone = dddTelefoneTxBox.Text + telefoneTxBox.Text;
                pessoaFisica.Nome = nomeRzSocialTxBox.Text;

                var erros = ModelDataValidation.ObterValidacao(pessoaFisica);
                foreach(var erro in erros)
                {
                    MessageBox.Show(erro.ErrorMessage);
                }

                var persistirPessoa = new PessoaFisicaRepository();
                //persistirPessoa.Adicionar(pessoaFisica);

                var login = new LoginModel();
                login.Senha = senhaTxBox.Text;
                login.Id = pessoaFisica.Id;

                var persistirLogin = new LoginRepository();
                //persistirLogin.Adicionar(login);
            }
            else
            {
                var pessoaJuridica = new PessoaJuridicaModel();
            }
        }
    }
}
