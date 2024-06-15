using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.Models
{
    internal class ContaDeEnergiaModel
    {
        public string? NumInstalacao { get; set; }
        public int IdPessoa { get; set; }
        public int KWhMesAtual { get; set; }
        public int KWhMesAnterior { get; set; }
    }
}
