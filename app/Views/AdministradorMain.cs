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
    public partial class AdministradorMain : Form
    {
        PessoaFisicaRepository pfPersistir = new PessoaFisicaRepository();
        PessoaJuridicaRepository pjPersistir = new PessoaJuridicaRepository();
        ContaDeEnergiaRepository contaPersistir = new ContaDeEnergiaRepository();
        public AdministradorModel admLogado { get; set; }
        public AdministradorMain()
        {
            InitializeComponent();
            tabelaClientesPF.DataSource = pfPersistir.ObterTodos();
            tabelaClientesPJ.DataSource = pjPersistir.ObterTodos();
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
                var conta = new ContaDeEnergiaModel();
                pessoaFisica.CPF = documentoTxBox.Text;
                pessoaFisica.Email = emailTxBox.Text;
                pessoaFisica.Telefone = dddTelefoneTxBox.Text + telefoneTxBox.Text;
                pessoaFisica.Nome = nomeRzSocialTxBox.Text;
                conta.NumInstalacao = numInstalacaoCadastramentoTxBox.Text;

                var erros = ModelDataValidation.ObterValidacao(pessoaFisica);
                if (erros.Count() > 0)
                {
                    foreach (var erro in erros)
                    {
                        MessageBox.Show(erro.ErrorMessage);
                    }
                    return;
                }
                pfPersistir.Adicionar(pessoaFisica);
                pessoaFisica = pfPersistir.Obter(pessoaFisica.CPF).First();
                conta.IdPessoa = pessoaFisica.Id;
                contaPersistir.Adicionar(conta);
                MessageBox.Show("Adicionado com sucesso!", "Sucesso!");
            }
            else
            {
                var pessoaJuridica = new PessoaJuridicaModel();
                var conta = new ContaDeEnergiaModel();
                pessoaJuridica.CNPJ = documentoTxBox.Text;
                pessoaJuridica.Email = emailTxBox.Text;
                pessoaJuridica.Telefone = dddTelefoneTxBox.Text + telefoneTxBox.Text;
                pessoaJuridica.RazaoSocial = nomeRzSocialTxBox.Text;
                conta.NumInstalacao = numInstalacaoCadastramentoTxBox.Text;

                var erros = ModelDataValidation.ObterValidacao(pessoaJuridica);
                if (erros.Count() > 0)
                {
                    foreach (var erro in erros)
                    {
                        MessageBox.Show(erro.ErrorMessage);
                    }
                    return;
                }
                pjPersistir.Adicionar(pessoaJuridica);
                pessoaJuridica = pjPersistir.Obter(pessoaJuridica.CNPJ).First();
                conta.IdPessoa = pessoaJuridica.Id;
                contaPersistir.Adicionar(conta);
                MessageBox.Show("Adicionado com sucesso!", "Sucesso!");
            }
        }
        private void associarContaPfBtn_Click(object sender, EventArgs e)
        {
            PessoaFisicaModel cliente = new PessoaFisicaModel();
            try
            {
                cliente = tabelaClientesPF.SelectedRows[0].DataBoundItem as PessoaFisicaModel;
            }
            catch
            {
                MessageBox.Show("Selecione uma coluna!");
                return;
            }
            var numInstalacao = associarContaPfTxBox.Text;
            var conta = new ContaDeEnergiaModel();
            conta.NumInstalacao = numInstalacao;
            conta.IdPessoa = cliente.Id;
            var erros = ModelDataValidation.ObterValidacao(conta);
            if (erros.Count() > 0)
            {
                foreach (var erro in erros)
                    MessageBox.Show(erro.ErrorMessage);
                return;
            }
            contaPersistir.Adicionar(conta);
            MessageBox.Show($"Nova conta associada para o cliente: {cliente.Nome}", "Sucesso!");
            associarContaPfTxBox.Text = string.Empty;
        }

        private void associarContaPjBtn_Click(object sender, EventArgs e)
        {
            PessoaJuridicaModel cliente = new PessoaJuridicaModel();
            try
            {
                cliente = tabelaClientesPJ.SelectedRows[0].DataBoundItem as PessoaJuridicaModel;
            }
            catch
            {
                MessageBox.Show("Selecione uma coluna!");
                return;
            }
            var numInstalacao = associarContaPjTxBox.Text;
            var conta = new ContaDeEnergiaModel();
            conta.NumInstalacao = numInstalacao;
            conta.IdPessoa = cliente.Id;
            var erros = ModelDataValidation.ObterValidacao(conta);
            if (erros.Count() > 0)
            {
                foreach (var erro in erros)
                    MessageBox.Show(erro.ErrorMessage);
                return;
            }
            contaPersistir.Adicionar(conta);
            MessageBox.Show($"Nova conta associada para o cliente: {cliente.RazaoSocial}", "Sucesso!");
            associarContaPjTxBox.Text = string.Empty;
        }

        private void pesquisarPfBtn_Click(object sender, EventArgs e)
        {
            string buscar = pesquisarPfTxBox.Text;
            if (buscar.IsNullOrEmpty())
                tabelaClientesPF.DataSource = pfPersistir.ObterTodos();
            else
                tabelaClientesPF.DataSource = pfPersistir.Obter($"%{buscar}%");
        }

        private void pesquisarPjBtn_Click(object sender, EventArgs e)
        {
            string buscar = pesquisarPjTxBox.Text;
            if (buscar.IsNullOrEmpty())
                tabelaClientesPJ.DataSource = pjPersistir.ObterTodos();
            else
                tabelaClientesPJ.DataSource = pjPersistir.Obter($"%{buscar}%");
        }
    }
}
