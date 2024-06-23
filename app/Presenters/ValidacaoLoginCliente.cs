using app.Models;
using app.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.Presenters
{
    public static class ValidacaoLoginCliente
    {
        public static PessoaFisicaModel pf = new PessoaFisicaModel();
        static PessoaFisicaRepository pfRepository = new PessoaFisicaRepository();
        public static PessoaJuridicaModel pj = new PessoaJuridicaModel();
        static PessoaJuridicaRepository pjRepository = new PessoaJuridicaRepository();
    
        public static bool PessoaFisicaExiste (string cpf)
        {
            try
            {
                pf = pfRepository.Obter(cpf).First();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
        public static bool PessoaJuridicaExiste(string CNPJ)
        {
            try
            {
                pj = pjRepository.Obter(CNPJ).First();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
    }
}
