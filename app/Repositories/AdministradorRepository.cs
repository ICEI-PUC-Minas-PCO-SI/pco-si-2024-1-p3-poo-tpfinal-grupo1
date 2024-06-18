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
    internal class AdministradorRepository : BaseRepository, IAdministradorRepository
    {
        public void Adicionar(AdministradorModel administradorModel)
        {
            using(var connection = new SqlConnection(connectionString))
            {
                var insertSql = @"INSERT INTO
                                    Pessoa
                                 OUTPUT INSERTED.Id
                                 VALUES(@Email, @Telefone);";
                var id = connection.ExecuteScalar<int>(insertSql, new
                {
                    administradorModel.Email,
                    administradorModel.Telefone
                });

                administradorModel.Id = id;

                insertSql = @"INSERT INTO
                                  Administrador
                              Values(@Id, @Nome);";

                connection.Execute(insertSql, new
                {
                    administradorModel.Id,
                    administradorModel.Nome
                });
            }
        }

        public void Deletar(int Id)
        {
            throw new NotImplementedException();
        }

        public void Editar(AdministradorModel administradorModel)
        {
            throw new NotImplementedException();
        }

        public List<AdministradorModel> Obter(string value)
        {
            throw new NotImplementedException();
        }
    }
}
