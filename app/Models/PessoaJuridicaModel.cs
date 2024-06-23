using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.Models
{
    public class PessoaJuridicaModel : PessoaModel
    {
        [Required(ErrorMessage = "CNPJ é necessário", AllowEmptyStrings = false)]
        [StringLength(14, MinimumLength = 14, ErrorMessage =
            "CNPJ deve conter 11 caracteres")]
        public string? CNPJ { get; set; }
        [Required(ErrorMessage = "Razão social é necessário", AllowEmptyStrings = false)]
        [StringLength(80, MinimumLength = 3, ErrorMessage =
            "Razão social deve ter no mínimo 3 caracteres e no máximo 80")]
        public string? RazaoSocial { get; set; }
    }
}
