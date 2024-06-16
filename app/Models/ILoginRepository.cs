using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.Models
{
    internal interface ILoginRepository
    {
        void Adicionar(LoginModel login);
        void Editar(LoginModel login);
        void Deletar(int Id);
        List<LoginModel> Obter(string value);
    }
}
