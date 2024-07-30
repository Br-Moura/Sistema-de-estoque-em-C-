using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALL
{
    class DadosDaConexao
    {
        public static String StringdeConexao
        {
            get
            {
                return "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CRUDNOVO;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
            }

        }
    }
}
