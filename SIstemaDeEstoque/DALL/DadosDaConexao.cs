using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALL
{
    public class DadosDaConexao
    {
        public static String StringdeConexao
        {
            get
            {
               // return "Data Source=DESKTOP-MPBBNFK\\MYSQLSERVER;Catalog=CRUDNOVO; Security=True;Connect Timeout=30;Encrypt=False;";
                return "server=DESKTOP-MPBBNFK\\MYSQLSERVER;Database=CRUDNOVO;User Id=SUPER;Password=123456;";
            }

        }
    }
}
