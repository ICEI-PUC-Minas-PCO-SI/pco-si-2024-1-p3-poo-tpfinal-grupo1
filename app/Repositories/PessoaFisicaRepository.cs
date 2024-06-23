using app.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Dapper;

namespace app.Repositories
{
    internal class PessoaFisicaRepository : BaseRepository, IPessoaFisicaRepository
    {
        public void Adicionar(PessoaFisicaModel pessoaFisica)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                var insertSql = @"INSERT INTO
                                    Pessoa
                                 OUTPUT INSERTED.Id
                                 VALUES(@Email, @Telefone);";

                var id = connection.ExecuteScalar<int> (insertSql, new
                {
                    pessoaFisica.Email,
                    pessoaFisica.Telefone
                });

                pessoaFisica.Id = id;

                insertSql = @"INSERT INTO
                                PessoaFisica
                            VALUES(@CPF, @Id, @Nome)";

                connection.Execute(insertSql, new
                {
                    pessoaFisica.CPF,
                    pessoaFisica.Id,
                    pessoaFisica.Nome
                });
            }
        }

        public void Deletar(int Id)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                var deleteSql = @"DELETE FROM
                                    PessoaFisica
                                 WHERE IdPessoa = @Id;

                                 DELETE FROM
                                    Pessoa
                                 WHERE Id = @Id;";

                connection.Execute(deleteSql, new { Id });
            }
        }
        public void Editar(PessoaFisicaModel pessoaFisica)
        {
            throw new NotImplementedException();
        }

        public List<PessoaFisicaModel> Obter(string value)
        {
            using (var connection = new SqlConnection (connectionString))
            {
                var selectQuery = @"SELECT 
                                        PessoaFisica.Nome as Nome,
                                        Pessoa.Email as Email,
                                        PessoaFisica.CPF as CPF,
                                        Pessoa.Telefone as Telefone,
                                        Pessoa.Id as Id
                                    FROM 
                                        Pessoa
                                    INNER JOIN PessoaFisica ON Pessoa.Id = PessoaFisica.IdPessoa
                                    where CPF = @value or Nome LIKE @value;";
                var pessoaFisica = connection.Query<PessoaFisicaModel>(selectQuery, new { value });
                return pessoaFisica.ToList();
            }
        }

        public List<PessoaFisicaModel> ObterTodos()
        {
            using (var connection = new SqlConnection(connectionString))
            {
                var pessoasFisicas = connection.Query<PessoaFisicaModel>(
                            @"SELECT 
                                PessoaFisica.Nome as Nome,
                                Pessoa.Email as Email,
                                PessoaFisica.CPF as CPF,
                                Pessoa.Telefone as Telefone,
                                Pessoa.Id as Id
                            FROM 
                                Pessoa
                            INNER JOIN PessoaFisica ON Pessoa.Id = PessoaFisica.IdPessoa"
                 );
                return pessoasFisicas.ToList();
            }
        }
    }
}
