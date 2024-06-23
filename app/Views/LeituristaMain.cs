using app.Models;
using app.Presenters;
using app.Repositories;
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

namespace app.Views
{
    public partial class LeituristaMain : Form
    {
        public LeituristaModel ltrLogado { get; set; }
        public ContaDeEnergiaModel conta { get; set; }
        public LeituristaMain()
        {
            InitializeComponent();
        }

        private void registrarKWhBtn_Click(object sender, EventArgs e)
        {
            if (valorMedidoKWh.Text.IsNullOrEmpty())
            {
                MessageBox.Show("Insira valor de KWh", "Atenção!");
                return;
            }
            if (ValidacaoContaDeEnergia.ContaDeEnergiaExiste(numInstalacaoTxBox.Text))
            {
                conta = ValidacaoContaDeEnergia.contaPresenter;
                conta.KWhMesAnterior = conta.KWhMesAtual;
                conta.KWhMesAtual = int.Parse(valorMedidoKWh.Text);
                ValidacaoContaDeEnergia.AtualizarConta(conta);
                MessageBox.Show("Valor inserido com sucesso", "Sucesso!");
            } else
            {
                MessageBox.Show("Número de instalação incorreto", "Atenção!");
            }
            numInstalacaoTxBox.Text = string.Empty;
            valorMedidoKWh.Text = string.Empty;
        }
    }
}
