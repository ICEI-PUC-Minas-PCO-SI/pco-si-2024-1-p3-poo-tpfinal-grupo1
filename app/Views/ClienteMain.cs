﻿using app.Models;
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
        }

        public ClienteMain(PessoaJuridicaModel pj)
        {
            InitializeComponent();
            nomeUsuario.Text = pj.RazaoSocial;
        }
    }
}
