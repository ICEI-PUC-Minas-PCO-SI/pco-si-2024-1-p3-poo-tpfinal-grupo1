using app.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace app.Repositories
{
    internal class LeituristaRepository : BaseRepository, ILeituristaRepository
    {
        public void Adicionar(LeituristaModel leituristaModel)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                var insertSql = @"INSERT INTO
                                    Pessoa
                                 OUTPUT INSERTED.Id
                                 VALUES(@Email, @Telefone);";
                var id = connection.ExecuteScalar<int>(insertSql, new
                {
                    leituristaModel.Email,
                    leituristaModel.Telefone
                });

                leituristaModel.Id = id;

                insertSql = @"INSERT INTO
                                  Leiturista
                              Values(@Id, @Nome);";

                connection.Execute(insertSql, new
                {
                    leituristaModel.Id,
                    leituristaModel.Nome
                });
            }
        }

        public void Deletar(int Id)
        {
            throw new NotImplementedException();
        }

        public void Editar(LeituristaModel leituristaModel)
        {
            throw new NotImplementedException();
        }

        public List<LeituristaModel> Obter(string value)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                var selectQuery = @"SELECT 
                                        Leiturista.Nome as Nome,
                                        Pessoa.Email as Email,
                                        Leiturista.Matricula as Matricula,
                                        Pessoa.Telefone as Telefone,
                                        Pessoa.Id as Id
                                    FROM 
                                        Pessoa
                                    INNER JOIN Leiturista ON Pessoa.Id = Leiturista.IdPessoa
                                    where Matricula = @value or Nome = @value;";
                return connection.Query<LeituristaModel>(selectQuery, new { value }).ToList();
            }
        }
    }
}
