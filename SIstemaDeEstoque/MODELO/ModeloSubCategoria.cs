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
                get { return this.subcat_ID; }
                set { this.subcat_ID = value; } 
        }

        private String subcat_NOME;
        public String SUBCAT_NOME
        {
            get { return this.subcat_NOME; }
            set { this.subcat_NOME = value; }
        }

        private int catSubCat_ID;
        public int CATSUBCAT_ID
        {
            get { return this.catSubCat_ID; }
            set { this.catSubCat_ID = value; }
        }
    }
}