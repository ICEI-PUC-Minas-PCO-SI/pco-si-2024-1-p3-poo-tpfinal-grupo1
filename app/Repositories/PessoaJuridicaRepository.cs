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
    internal class PessoaJuridicaRepository : BaseRepository, IPessoaJuridicaRepository
    {
        public void Adicionar(PessoaJuridicaModel pessoaJuridica)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                var insertSql = @"INSERT INTO
                                    Pessoa
                                 OUTPUT INSERTED.Id
                                 VALUES(@Email, @Telefone);";

                var id = connection.ExecuteScalar<int>(insertSql, new
                {
                    pessoaJuridica.Email,
                    pessoaJuridica.Telefone
                });

                pessoaJuridica.Id = id;

                insertSql = @"INSERT INTO
                                PessoaJuridica
                            VALUES(@CNPJ, @Id, @RazaoSocial)";

                connection.Execute(insertSql, new
                {
                    pessoaJuridica.CNPJ,
                    pessoaJuridica.Id,
                    pessoaJuridica.RazaoSocial
                });
            }
        }

        public void Deletar(int Id)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                var deleteSql = @"DELETE FROM
                                    PessoaJuridica
                                 WHERE IdPessoa = @Id;

                                 DELETE FROM
                                    Pessoa
                                 WHERE Id = @Id;";

                connection.Execute(deleteSql, new { Id });
            }
        }

        public void Editar(PessoaJuridicaModel pessoaJuridica)
        {
            throw new NotImplementedException();
        }

        public List<PessoaJuridicaModel> Obter(string value)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                var selectQuery = @"SELECT 
                                        PessoaJuridica.RazaoSocial as RazaoSocial,
                                        Pessoa.Email as Email,
                                        PessoaJuridica.CNPJ as CNPJ,
                                        Pessoa.Telefone as Telefone,
                                        Pessoa.Id as Id
                                    FROM 
                                        Pessoa
                                    INNER JOIN PessoaJuridica ON Pessoa.Id = PessoaJuridica.IdPessoa
                                    where CPF = @value or Nome = @value;";
                var pessoaJuridica = connection.Query<PessoaJuridicaModel>(selectQuery, new { value });
                return pessoaJuridica.ToList();
            }
        }

        public List<PessoaJuridicaModel> ObterTodos()
        {
            using (var connection = new SqlConnection(connectionString))
            {
                var pessoasJuridicas = connection.Query<PessoaJuridicaModel>(
                            @"SELECT 
                                PessoaJuridica.RazaoSocial as RazaoSocial,
                                Pessoa.Email as Email,
                                PessoaJuridica.CNPJ as CNPJ,
                                Pessoa.Telefone as Telefone,
                                Pessoa.Id as Id
                            FROM 
                                Pessoa
                            INNER JOIN PessoaJuridica ON Pessoa.Id = PessoaJuridica.IdPessoa"
                 );
                return pessoasJuridicas.ToList();
            }
        }
    }
}
