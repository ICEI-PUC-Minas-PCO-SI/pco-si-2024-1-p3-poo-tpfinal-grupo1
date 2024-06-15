using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.Models
{
    internal abstract class PessoaModel
    {
        public int Id { get; }
        public string? Email { get; set; }
        public string? Telefone { get; set; }
        public PessoaEnderecoModel? Endereco { get; set; }
    }
}
