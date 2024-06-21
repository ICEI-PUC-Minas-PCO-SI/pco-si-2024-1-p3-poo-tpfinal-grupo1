using app.Models;
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
    public partial class AdministradorMain : Form
    {
        PessoaFisicaRepository clientePF = new PessoaFisicaRepository();
        public AdministradorModel admLogado { get; set; }
        public AdministradorMain()
        {
            InitializeComponent();
            dataGridView1.DataSource = clientePF.ObterTodos();
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

        }
    }
}
