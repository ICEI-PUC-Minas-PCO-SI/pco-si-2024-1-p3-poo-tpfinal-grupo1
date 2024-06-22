using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.Models
{
    public class PessoaFisicaModel : PessoaModel
    {
        [Required(ErrorMessage = "CPF é necessário", AllowEmptyStrings = false)]
        [StringLength(11, MinimumLength = 11, ErrorMessage =
            "CPF deve conter 11 caracteres")]
        public string? CPF { get; set; }

        [Required(ErrorMessage = "Nome é necessário", AllowEmptyStrings = false)]
        [StringLength(80, MinimumLength = 3, ErrorMessage =
            "Nome deve conter pelo menos 3 caracteres")]
        public string? Nome { get; set;}
    }
}
