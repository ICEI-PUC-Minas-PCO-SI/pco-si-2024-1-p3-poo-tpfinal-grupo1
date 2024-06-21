using app.Models;
using app.Repositories;
using System;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.Presenters
{
    public static class ValidacaoLoginFuncionario
    {
        static AdministradorModel administrador = new AdministradorModel();
        static AdministradorRepository AdmRepository = new AdministradorRepository();
        static LeituristaModel leiturista = new LeituristaModel();
        static LeituristaRepository leituristaRepository = new LeituristaRepository();
        static LoginRepository loginRepository = new LoginRepository();
        public static bool AdministradorExiste(string matricula)
        {
            try
            {
                administrador = AdmRepository.Obter(matricula).First();
            } catch (Exception)
            {
                return false;
            }
            return true;
        }
        public static bool SenhaAdministradorEstaCorreta(string senha)
            => (loginRepository.Obter(administrador.Id.ToString()) == senha);

        public static bool LeituristaExiste(string matricula)
        {
            try
            {
                leiturista = leituristaRepository.Obter(matricula).First();
            } catch (Exception)
            {
                return false;
            }
            return true;
        }
        public static bool SenhaLeituristaEstaCorreta(string senha)
            => (loginRepository.Obter(leiturista.Id.ToString()) == senha);

    }
}
