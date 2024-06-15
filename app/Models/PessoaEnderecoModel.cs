using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.Models
{
    internal class PessoaEnderecoModel
    {
        public int Id { get; }
        public string? Logradouro { get; set; }
        public int Numero { get; set; }
        public string? Complemento { get; set;}
        public string? Bairro { get; set;}
        public string? Cidade { get; set;}
    }
}
