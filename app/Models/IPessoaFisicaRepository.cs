using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.Models
{
    internal interface IPessoaFisicaRepository
    {
        void Adicionar(PessoaFisicaModel pessoaFisica);
        void Editar(PessoaFisicaModel pessoaFisica);
        void Deletar(int Id);
        List<PessoaFisicaModel> ObterTodos();
        List<PessoaFisicaModel> Obter(string value);
    }
}
