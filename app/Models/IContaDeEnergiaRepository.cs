using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.Models
{
    internal interface IContaDeEnergiaRepository
    {
        void Adicionar(ContaDeEnergiaModel contaDeEnergia);
        void Editar (ContaDeEnergiaModel contaDeEnergia);
        void Deletar(int Id);
        List<ContaDeEnergiaModel> Obter(string value);
    }
}
