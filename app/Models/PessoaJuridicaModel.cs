using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.Models
{
    public class PessoaJuridicaModel : PessoaModel
    {
        public string? CNPJ { get; set; }

        public string? RazaoSocial { get; set; }
    }
}
