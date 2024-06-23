using app.Models;
using app.Presenters;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app
{
    public partial class ClienteMain : Form
    {
        public PessoaFisicaModel pfLogado { get; set; }
        public PessoaJuridicaModel pjLogado { get; set; }
        public ClienteMain(PessoaFisicaModel pf)
        {
            InitializeComponent();
            nomeUsuario.Text = pf.Nome;
            pfLogado = pf;
        }

        public ClienteMain(PessoaJuridicaModel pj)
        {
            InitializeComponent();
            nomeUsuario.Text = pj.RazaoSocial;
            pjLogado = pj;
        }

        private void calcularBtn_Click(object sender, EventArgs e)
        {
            if (numRegistroTxBox.Text.IsNullOrEmpty())
            {
                MessageBox.Show("Digite um valor");
                return;
            }

            var numInstalacao = numRegistroTxBox.Text;
            if (pjLogado == null)
            {
                if (PresenterCliente.ClientePossuiEstaConta(numInstalacao, pfLogado))
                {
                    var valores = PresenterCliente.CalcularPessoaFisica(PresenterCliente.conta);
                    consumoUltimoMesLabel.Text = $"{valores.Item1} KWh";
                    valorTotalContaLabel.Text = $"R$ {valores.Item2}";
                    valorTotalSemImpostosLabel.Text = $"R$ {valores.Item3}";
                } else
                {
                    MessageBox.Show("Numero de registro invalido");
                    numRegistroTxBox.Text = string.Empty;
                    return;
                }
            } else
            {
                if (PresenterCliente.ClientePossuiEstaConta(numInstalacao, pjLogado))
                {
                    var valores = PresenterCliente.CalcularPessoaJuridica(PresenterCliente.conta);
                    consumoUltimoMesLabel.Text = $"{valores.Item1} KWh";
                    valorTotalContaLabel.Text = $"R$ {valores.Item2}";
                    valorTotalSemImpostosLabel.Text = $"R$ {valores.Item3}";

                } else
                {
                    MessageBox.Show("Numero de registro invalido");
                    numRegistroTxBox.Text = string.Empty;
                    return;
                }
            }
        }
    }
}
