using app.Models;
using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.Repositories
{
    internal class LoginRepository : BaseRepository, ILoginRepository
    {
        public void Adicionar(LoginModel login)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                var insertSQL = @"INSERT INTO
                                     Login
                                  Values(@Id, @Senha);";
                connection.Execute(insertSQL, new
                {
                    login.Id,
                    login.Senha
                });
            }
        }

        public void Deletar(int Id)
        {
            throw new NotImplementedException();
        }

        public void Editar(LoginModel login)
        {
            throw new NotImplementedException();
        }

        public List<LoginModel> Obter(string value)
        {
            throw new NotImplementedException();
        }
    }
}
