using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MODELO
{
    public class ModeloSubCategoria
    {
        private int subcat_ID;
        public int SUBCAT_ID
        {
                get { return this.SUBCAT_NOME;}
                set { this.SUBCAT_NOME= value; } 
        }

        private String subcat_NOME;
        public String SUBCAT_NOME
        {
            get { return this.SUBCAT_NOME;}
            set { this.SUBCAT_NOME= value; }
        }

        private int catSubCat_ID;
        public int CATSUBCAT_ID
        {
            get { return this.CATSUBCAT_ID; }
            set { this.CATSUBCAT_ID = value; }
        }
    }
}