using app.Models;
using app.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.Presenters
{
    public static class ValidacaoContaDeEnergia
    {
        public static ContaDeEnergiaModel contaPresenter = new ContaDeEnergiaModel();
        static ContaDeEnergiaRepository contaRepository = new ContaDeEnergiaRepository();

        public static bool ContaDeEnergiaExiste (string numInstalacao) 
        {
            try
            {
                contaPresenter = contaRepository.Obter(numInstalacao).First();

            } catch (Exception)
            {
                return false;
            }
            return true;
        }
        public static void AtualizarConta(ContaDeEnergiaModel conta)
            => contaRepository.Editar(conta);
    }
}
