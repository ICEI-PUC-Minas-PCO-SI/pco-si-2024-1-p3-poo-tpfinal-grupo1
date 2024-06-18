using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.Models
{
    internal interface IAdministradorRepository
    {
        void Adicionar(AdministradorModel administradorModel);
        void Editar(AdministradorModel administradorModel);
        void Deletar(int Id);
        List<AdministradorModel> Obter(string value);
    }
}
