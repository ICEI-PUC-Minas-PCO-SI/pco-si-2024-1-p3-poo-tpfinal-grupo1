using app.Models;
using app.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.Presenters
{
    public class PresenterCliente
    {
        public static ContaDeEnergiaModel conta = new ContaDeEnergiaModel();
        public static ContaDeEnergiaRepository persistenciaConta = new ContaDeEnergiaRepository();  
        public static bool ClientePossuiEstaConta(string numInstalacao, PessoaFisicaModel pf)
        {
            try
            {
                conta = persistenciaConta.Obter(numInstalacao).First();
                if (pf.Id.ToString() != conta.IdPessoa.ToString()) return false;
            } catch
            {
                return false;
            }
            return true;
        }

        public static bool ClientePossuiEstaConta(string numInstalacao, PessoaJuridicaModel pj)
        {
            try
            {
                conta = persistenciaConta.Obter(numInstalacao).First();
                if (pj.Id.ToString() != conta.IdPessoa.ToString())
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
            return true;
        }
        public static (int, double, double) CalcularPessoaFisica(ContaDeEnergiaModel conta)
        {
            var consumo = conta.KWhMesAtual - conta.KWhMesAnterior;
            var valorTotalSemImposto = consumo * 0.40 + 9.25;
            var valorTotalComImposto = valorTotalSemImposto * 1.30;

            return (consumo, valorTotalSemImposto, valorTotalComImposto);
        }

        public static (int, double, double) CalcularPessoaJuridica(ContaDeEnergiaModel conta)
        {
            var consumo = conta.KWhMesAtual - conta.KWhMesAnterior;
            var valorTotalSemImposto = consumo * 0.35 + 9.25;
            var valorTotalComImposto = valorTotalSemImposto * 1.18;

            return (consumo, valorTotalSemImposto, valorTotalComImposto);
        }
    }
}
