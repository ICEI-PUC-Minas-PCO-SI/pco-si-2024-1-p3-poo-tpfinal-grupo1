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
    public partial class LoginSecundario : Form
    {
        AdministradorModel administrador;
        LeituristaModel leiturista;
        public LoginSecundario()
        {
            InitializeComponent();
            administrador = new AdministradorModel();
            leiturista = new LeituristaModel();
        }

        private void btnEncerrarLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
            => this.Hide();

        private void matriculaTxBox_KeyPress(object sender, KeyPressEventArgs e)
            => e.Handled = !char.IsNumber(e.KeyChar);

        private void btnEntrarLogin_Click(object sender, EventArgs e)
        {
            administrador.Matricula = matriculaTxBox.Text;
            leiturista.Matricula = matriculaTxBox.Text;
            string senha;

            if (optionsLogin.SelectedIndex == 0)
            {
                if (ValidacaoLoginFuncionario.AdministradorExiste(administrador.Matricula))
                {
                    senha = textBox1.Text;
                    if (ValidacaoLoginFuncionario.SenhaAdministradorEstaCorreta(senha))
                    {
                        var admForm = new AdministradorMain();
                        admForm.admLogado = administrador;
                        admForm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Senha incorreta!", "Atenção!");
                    }
                }
                else
                {
                    MessageBox.Show("Matrícula incorreta para administrador!", "Atenção!");
                    matriculaTxBox.Text = string.Empty;
                }
            }
            else if(optionsLogin.SelectedIndex == 1)
            {
                if (ValidacaoLoginFuncionario.LeituristaExiste(leiturista.Matricula))
                {
                    senha = textBox1.Text;
                    if (ValidacaoLoginFuncionario.SenhaLeituristaEstaCorreta(senha))
                    {
                        var ltrForm = new LeituristaMain();
                        ltrForm.ltrLogado = leiturista;
                        ltrForm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Senha incorreta!", "Atenção!");
                    }
                }
                else
                {
                    MessageBox.Show("Matrícula incorreta para leiturista!", "Atenção!");
                    matriculaTxBox.Text = string.Empty;
                }
            } else
            {
                MessageBox.Show("Selecione um tipo de funcionário", "Atenção!");
            }

        }
    }
}
