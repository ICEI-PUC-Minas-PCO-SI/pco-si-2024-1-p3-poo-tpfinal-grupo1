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
    internal class ContaDeEnergiaRepository : BaseRepository, IContaDeEnergiaRepository
    {
        public void Adicionar(ContaDeEnergiaModel contaDeEnergia)
        {
            using(var connection = new SqlConnection(connectionString))
            {
                var insertSql = @"INSERT INTO
                                     ContaDeEnergia
                                 Values(@NumInstalacao, @IdPessoa, @KWhMesAtual, @KWhMesAnterior);";
                connection.Execute(insertSql, new
                {
                    contaDeEnergia.NumInstalacao,
                    contaDeEnergia.IdPessoa,
                    contaDeEnergia.KWhMesAtual,
                    contaDeEnergia.KWhMesAnterior
                });
            }
        }

        public void Deletar(int numInstalacao)
        {
            using(var connection = new SqlConnection(connectionString))
            {
                connection.Execute(@"DELETE FROM
                                        ContaDeEnergia
                                    WHERE NumInstalacao = @NumInstalacao", new { numInstalacao });
            }
        }

        public void Editar(ContaDeEnergiaModel contaDeEnergia)
        {
            throw new NotImplementedException();
        }

        public List<ContaDeEnergiaModel> Obter(string idPessoa)
        {
            using(var connection = new SqlConnection(connectionString))
            {
                var contasDeEnergia = connection.Query<ContaDeEnergiaModel>(@"
                                    SELECT 
                                        *
                                    FROM ContaDeEnergia
                                    WHERE IdPessoa = @idPessoa;", new { idPessoa});
                
                return contasDeEnergia.ToList();
            }
        }
    }
}
