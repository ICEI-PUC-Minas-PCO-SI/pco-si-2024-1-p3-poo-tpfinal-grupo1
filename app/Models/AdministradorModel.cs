using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.Models
{
    internal class AdministradorModel : PessoaModel
    {
        public string? Matricula { get; set; }

        [Required(ErrorMessage = "Nome é necessário", AllowEmptyStrings = false)]
        [StringLength(80, MinimumLength = 3, ErrorMessage =
            "Nome deve conter pelo menos 3 caracteres")]
        public string? Nome { get; set; }
    }
}
