using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.Models
{
    public class ContaDeEnergiaModel
    {
        [Required(ErrorMessage = "Número de Instalação é necessário", AllowEmptyStrings = false)]
        public string? NumInstalacao { get; set; }
        public int IdPessoa { get; set; }
        public int KWhMesAtual { get; set; }
        public int KWhMesAnterior { get; set; }
    }
}
