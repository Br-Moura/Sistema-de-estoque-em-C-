using BLL;
using DALL;
using MODELO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DESK
{
    public partial class frmConsultaCategoria : Form
    {
        public int codigo = 0;

        public frmConsultaCategoria()
        {
            InitializeComponent();
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringdeConexao);
            BLLCategoria bll = new BLLCategoria(cx);
            dgvDados.DataSource = bll.Pesquisar(txtValor.Text);
        }

        private void frmConsultaCategoria_Load(object sender, EventArgs e)
        {
            btnLocalizar_Click(sender, e);
            dgvDados.Columns[0].HeaderText = "Codigo";
            dgvDados.Columns[0].Width = 67;
            dgvDados.Columns[1].HeaderText = "Categoria";
            dgvDados.Columns[1].Width = 655;
        }

        private void dgvDados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == 0)
            {
                this.codigo = Convert.ToInt32(dgvDados.Rows[e.RowIndex].Cells[0].Value);
                this.Close();
            }
        }

        private void dgvDados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == 0)
            {
                this.codigo = Convert.ToInt32(dgvDados.Rows[e.RowIndex].Cells[0].Value);
                this.Close();
            }
        }
    }
}
