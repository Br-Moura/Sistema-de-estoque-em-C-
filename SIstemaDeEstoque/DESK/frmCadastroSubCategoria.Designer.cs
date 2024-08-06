namespace DESK
{
    partial class frmCadastroSubCategoria
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnBotoes = new Panel();
            btnCancelar = new Button();
            btnSalvar = new Button();
            btnExcluir = new Button();
            btnAlterar = new Button();
            btnLocalizar = new Button();
            btnInserir = new Button();
            pnDados = new Panel();
            cboCodigoCategoria = new ComboBox();
            txtNome = new TextBox();
            txtCodigo = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label1 = new Label();
            pnBotoes.SuspendLayout();
            pnDados.SuspendLayout();
            SuspendLayout();
            // 
            // pnBotoes
            // 
            pnBotoes.Controls.Add(btnCancelar);
            pnBotoes.Controls.Add(btnSalvar);
            pnBotoes.Controls.Add(btnExcluir);
            pnBotoes.Controls.Add(btnAlterar);
            pnBotoes.Controls.Add(btnLocalizar);
            pnBotoes.Controls.Add(btnInserir);
            pnBotoes.Location = new Point(12, 451);
            pnBotoes.Name = "pnBotoes";
            pnBotoes.Size = new Size(760, 109);
            pnBotoes.TabIndex = 2;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(664, 33);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(90, 50);
            btnCancelar.TabIndex = 0;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(402, 33);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(90, 50);
            btnSalvar.TabIndex = 0;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(306, 33);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(90, 50);
            btnExcluir.TabIndex = 0;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            btnAlterar.Location = new Point(210, 33);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(90, 50);
            btnAlterar.TabIndex = 0;
            btnAlterar.Text = "Alterar";
            btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnLocalizar
            // 
            btnLocalizar.Location = new Point(114, 33);
            btnLocalizar.Name = "btnLocalizar";
            btnLocalizar.Size = new Size(90, 50);
            btnLocalizar.TabIndex = 0;
            btnLocalizar.Text = "Localizar";
            btnLocalizar.UseVisualStyleBackColor = true;
            // 
            // btnInserir
            // 
            btnInserir.Location = new Point(18, 33);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(90, 50);
            btnInserir.TabIndex = 0;
            btnInserir.Text = "Inserir";
            btnInserir.UseVisualStyleBackColor = true;
            btnInserir.Click += btnInserir_Click;
            // 
            // pnDados
            // 
            pnDados.Controls.Add(cboCodigoCategoria);
            pnDados.Controls.Add(txtNome);
            pnDados.Controls.Add(txtCodigo);
            pnDados.Controls.Add(label2);
            pnDados.Controls.Add(label3);
            pnDados.Controls.Add(label1);
            pnDados.Location = new Point(12, 12);
            pnDados.Name = "pnDados";
            pnDados.Size = new Size(760, 414);
            pnDados.TabIndex = 3;
            // 
            // cboCodigoCategoria
            // 
            cboCodigoCategoria.FormattingEnabled = true;
            cboCodigoCategoria.Location = new Point(259, 67);
            cboCodigoCategoria.Name = "cboCodigoCategoria";
            cboCodigoCategoria.Size = new Size(173, 23);
            cboCodigoCategoria.TabIndex = 2;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(18, 139);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(736, 23);
            txtNome.TabIndex = 1;
            // 
            // txtCodigo
            // 
            txtCodigo.Enabled = false;
            txtCodigo.Location = new Point(18, 67);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(173, 23);
            txtCodigo.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 121);
            label2.Name = "label2";
            label2.Size = new Size(120, 15);
            label2.TabIndex = 0;
            label2.Text = "Nome Sub Categoria:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(259, 49);
            label3.Name = "label3";
            label3.Size = new Size(103, 15);
            label3.TabIndex = 0;
            label3.Text = "Codigo Categoria:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 49);
            label1.Name = "label1";
            label1.Size = new Size(126, 15);
            label1.TabIndex = 0;
            label1.Text = "Codigo Sub Categoria:";
            // 
            // frmCadastroSubCategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(pnDados);
            Controls.Add(pnBotoes);
            Name = "frmCadastroSubCategoria";
            Text = "Cadastro Sub Categoria";
            Load += frmCadastroSubCategoria_Load;
            pnBotoes.ResumeLayout(false);
            pnDados.ResumeLayout(false);
            pnDados.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        protected Panel pnBotoes;
        protected Button btnCancelar;
        protected Button btnSalvar;
        protected Button btnExcluir;
        protected Button btnAlterar;
        protected Button btnLocalizar;
        protected Button btnInserir;
        protected Panel pnDados;
        private TextBox txtNome;
        private TextBox txtCodigo;
        private Label label2;
        private Label label1;
        private ComboBox cboCodigoCategoria;
        private Label label3;
    }
}