using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste.DAL
{
    public class TesteDAL
    {
        public static string Eae()
        {
            using (var connection = ConnectionFactory.TESTE())
            {
                var query = @"
                            SELECT 
                                Nome 
                            FROM 
                                Teste
                            WHERE
                                Id = 1";

                return connection.QueryFirstOrDefault<string>(query);
            }
        }
    }
}
