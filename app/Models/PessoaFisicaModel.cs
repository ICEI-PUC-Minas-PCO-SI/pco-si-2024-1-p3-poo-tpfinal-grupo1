﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.Models
{
    internal class PessoaFisicaModel : PessoaModel
    {
        public string? CPF { get; set; }
        public string? Nome { get; set;}
    }
}