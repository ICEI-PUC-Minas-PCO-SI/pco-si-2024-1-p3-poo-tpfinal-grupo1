using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.Models
{
    internal interface IPessoaEnderecoRepository
    {
        void Adicionar(PessoaEnderecoModel pessoaEndereco);
        void Editar(PessoaEnderecoModel pessoaEndereco);
        void Deletar(int Id);
        List<PessoaEnderecoModel> ObterTodos();
        List<PessoaEnderecoModel> Obter(string value);
    }
}
