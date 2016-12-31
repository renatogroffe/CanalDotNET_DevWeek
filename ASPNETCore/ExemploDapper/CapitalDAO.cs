using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Dapper;

namespace ExemploDapper
{
    public class CapitalDAO
    {
        private IConfiguration _configuracoes;
        public CapitalDAO(IConfiguration config)
        {
            _configuracoes = config;
        }

        public IEnumerable<Capital> ListarTodos()
        {
            using (SqlConnection conexao = new SqlConnection(
                _configuracoes.GetConnectionString("BaseDevWeek")))
            {
                return conexao.Query<Capital>(
                    "SELECT SiglaEstado, Estado, NomeCidade, Regiao " +
                    "FROM dbo.Capitais " +
                    "ORDER BY Estado"
                );
            }
        }
    }
}