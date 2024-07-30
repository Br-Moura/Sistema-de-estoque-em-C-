using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class ModeloCategoria
    {
        private int cat_ID;
        public int CatID
        {
            get { return this.cat_ID; }
            set { this.cat_ID = value; }
        }

        private String cat_nome;

        public String CatNome
        {
            get { return this.cat_nome; }
            set { this.cat_nome = value; }
        }
    }
}
