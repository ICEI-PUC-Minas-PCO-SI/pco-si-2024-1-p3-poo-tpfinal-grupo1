using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.Models
{
    internal class PessoaJuridicaModel : PessoaModel
    {
        public string? CNPJ { get; set; }

        public string? RazaoSocial { get; set; }
    }
}
