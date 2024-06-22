using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.Models
{
    internal interface ILeituristaRepository
    {
        void Adicionar(LeituristaModel leituristaModel);
        void Editar(LeituristaModel leituristaModel);
        void Deletar(int Id);
        List<LeituristaModel> Obter(string value);
    }
}
