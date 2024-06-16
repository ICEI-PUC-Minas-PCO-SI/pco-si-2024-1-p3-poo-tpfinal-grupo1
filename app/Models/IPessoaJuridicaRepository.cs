using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.Models
{
    internal interface IPessoaJuridicaRepository
    {
        void Adicionar(PessoaJuridicaModel pessoaJuridica);
        void Editar(PessoaJuridicaModel pessoaJuridica);
        void Deletar(int Id);
        List<PessoaJuridicaModel> ObterTodos();
        List<PessoaJuridicaModel> Obter();
    }
}
