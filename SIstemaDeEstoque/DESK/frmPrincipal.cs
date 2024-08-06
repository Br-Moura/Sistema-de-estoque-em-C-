namespace DESK
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }



        private void categoriaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmModeloDeCadastro frm = new frmModeloDeCadastro();
            frm.ShowDialog();
            frm.Dispose();
        }

        private void categoriaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaCategoria frm = new frmConsultaCategoria();
            frm.ShowDialog();
            frm.Dispose();
        }

        private void subCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroSubCategoria frm = new frmCadastroSubCategoria();
            frm.ShowDialog();
            frm.Dispose();
        }
    }
}
