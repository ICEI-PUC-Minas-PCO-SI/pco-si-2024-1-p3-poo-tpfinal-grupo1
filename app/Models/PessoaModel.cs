using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.Models
{
    internal abstract class PessoaModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Email é necessário", AllowEmptyStrings = false)]
        [StringLength(50, MinimumLength =5, ErrorMessage = 
            "O email deve ter no mínimo 5 caracteres")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Informe um email válido...")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Nome é necessário", AllowEmptyStrings = false)]
        [StringLength(11, MinimumLength = 10, ErrorMessage =
            "Telefone não está correto")]
        public string? Telefone { get; set; }
        public PessoaEnderecoModel? Endereco { get; set; }
    }
}
