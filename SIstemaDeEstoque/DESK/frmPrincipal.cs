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
    }
}