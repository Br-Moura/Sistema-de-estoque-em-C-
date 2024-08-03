namespace DESK
{
    partial class frmConsultaCategoria
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
            label1 = new Label();
            txtValor = new TextBox();
            btnLocalizar = new Button();
            dgvDados = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvDados).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 25);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 0;
            label1.Text = "Categoria";
            // 
            // txtValor
            // 
            txtValor.Location = new Point(12, 43);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(623, 23);
            txtValor.TabIndex = 1;
            // 
            // btnLocalizar
            // 
            btnLocalizar.Location = new Point(641, 42);
            btnLocalizar.Name = "btnLocalizar";
            btnLocalizar.Size = new Size(137, 23);
            btnLocalizar.TabIndex = 2;
            btnLocalizar.Text = "Localizar";
            btnLocalizar.UseVisualStyleBackColor = true;
            btnLocalizar.Click += btnLocalizar_Click;
            // 
            // dgvDados
            // 
            dgvDados.AllowUserToAddRows = false;
            dgvDados.AllowUserToDeleteRows = false;
            dgvDados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDados.Location = new Point(12, 96);
            dgvDados.Name = "dgvDados";
            dgvDados.ReadOnly = true;
            dgvDados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDados.Size = new Size(766, 453);
            dgvDados.TabIndex = 3;
            dgvDados.CellClick += dgvDados_CellClick;
            dgvDados.CellDoubleClick += dgvDados_CellDoubleClick;
            // 
            // frmConsultaCategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(dgvDados);
            Controls.Add(btnLocalizar);
            Controls.Add(txtValor);
            Controls.Add(label1);
            Name = "frmConsultaCategoria";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Consultar Categoria";
            Load += frmConsultaCategoria_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtValor;
        private Button btnLocalizar;
        private DataGridView dgvDados;
    }
}