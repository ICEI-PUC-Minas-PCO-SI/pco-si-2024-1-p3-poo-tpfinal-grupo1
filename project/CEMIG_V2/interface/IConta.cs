using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEMIG_V2
{
    interface IConta
    {
        void calcularConsumo();
        void calcularValorTotal();
        void calcularValorSemImposto();
    }
}