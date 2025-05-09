namespace Cantina3._0
{
    partial class Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAdicionar = new Button();
            listProdutos = new ListBox();
            btnRemover = new Button();
            btnFormComprar = new Button();
            lblProduto = new Label();
            txtProduto = new TextBox();
            txtValor = new TextBox();
            lblValor = new Label();
            btnEditar = new Button();
            SuspendLayout();
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(447, 186);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(93, 38);
            btnAdicionar.TabIndex = 0;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // listProdutos
            // 
            listProdutos.FormattingEnabled = true;
            listProdutos.ItemHeight = 15;
            listProdutos.Location = new Point(167, 204);
            listProdutos.Name = "listProdutos";
            listProdutos.Size = new Size(233, 154);
            listProdutos.TabIndex = 1;
            listProdutos.SizeChanged += listProdutos_SizeChanged;
            // 
            // btnRemover
            // 
            btnRemover.Location = new Point(447, 251);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(93, 38);
            btnRemover.TabIndex = 2;
            btnRemover.Text = "Remover";
            btnRemover.UseVisualStyleBackColor = true;
            btnRemover.Click += btnRemover_Click;
            // 
            // btnFormComprar
            // 
            btnFormComprar.Location = new Point(666, 387);
            btnFormComprar.Name = "btnFormComprar";
            btnFormComprar.Size = new Size(93, 38);
            btnFormComprar.TabIndex = 3;
            btnFormComprar.Text = "Comprar";
            btnFormComprar.UseVisualStyleBackColor = true;
            btnFormComprar.Click += btnFormComprar_Click;
            // 
            // lblProduto
            // 
            lblProduto.AutoSize = true;
            lblProduto.Location = new Point(113, 130);
            lblProduto.Name = "lblProduto";
            lblProduto.Size = new Size(56, 15);
            lblProduto.TabIndex = 4;
            lblProduto.Text = "Produto :";
            // 
            // txtProduto
            // 
            txtProduto.Location = new Point(190, 127);
            txtProduto.Name = "txtProduto";
            txtProduto.Size = new Size(157, 23);
            txtProduto.TabIndex = 5;
            txtProduto.KeyDown += txtProduto_KeyDown;
            // 
            // txtValor
            // 
            txtValor.Location = new Point(190, 157);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(157, 23);
            txtValor.TabIndex = 7;
            txtValor.KeyDown += txtValor_KeyDown;
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.Location = new Point(127, 157);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(42, 15);
            lblValor.TabIndex = 6;
            lblValor.Text = "Valor  :";
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(561, 251);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(93, 38);
            btnEditar.TabIndex = 8;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEditar);
            Controls.Add(txtValor);
            Controls.Add(lblValor);
            Controls.Add(txtProduto);
            Controls.Add(lblProduto);
            Controls.Add(btnFormComprar);
            Controls.Add(btnRemover);
            Controls.Add(listProdutos);
            Controls.Add(btnAdicionar);
            Name = "Form";
            Text = "Gerenciar";
            Load += Form_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdicionar;
        private ListBox listProdutos;
        private Button btnRemover;
        private Button btnFormComprar;
        private Label lblProduto;
        private TextBox txtProduto;
        private TextBox txtValor;
        private Label lblValor;
        private Button btnEditar;
    }
}
