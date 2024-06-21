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
    public class AdministradorRepository : BaseRepository, IAdministradorRepository
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
            using (var connection = new SqlConnection(connectionString))
            {
                var selectQuery = @"SELECT 
                                        Administrador.Nome as Nome,
                                        Pessoa.Email as Email,
                                        Administrador.Matricula as Matricula,
                                        Pessoa.Telefone as Telefone,
                                        Pessoa.Id as Id
                                    FROM 
                                        Pessoa
                                    INNER JOIN Administrador ON Pessoa.Id = Administrador.IdPessoa
                                    where Matricula = @value or Nome = @value;";
                return connection.Query<AdministradorModel>(selectQuery, new { value }).ToList();
            }
        }
    }
}
