using System.Text.Json;
using Microsoft.VisualBasic;
namespace Cantina3._0
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {

            InitializeComponent();

        }
        string fileName = "listaProdutos.json";
        listaProdutos ListaProdutos = new listaProdutos();
        List<Produto> produtos = new List<Produto>();
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            double preço = 0;
            if (!String.IsNullOrEmpty(txtProduto.Text) && !String.IsNullOrEmpty(txtValor.Text))
            {
                foreach (Produto produto1 in listProdutos.Items)
                {
                    if (produto1.Descrição == txtProduto.Text.ToUpper())
                    {
                        MessageBox.Show("Esse produto já existe! Remova ou altere.");
                        return;
                    }
                }
                if (!double.TryParse(txtValor.Text, out preço))
                {
                    MessageBox.Show("Valor Inválido");
                }
                else
                {
                    Produto produto = new Produto(txtProduto.Text.ToUpper(), preço);
                    listProdutos.Items.Add(produto);
                    txtProduto.Clear();
                    txtValor.Clear();
                    listProdutos.ClearSelected();
                }
            }
            else
            {
                MessageBox.Show("Preencha todos os campos!");
            }

        }
        private void Form_Load(object sender, EventArgs e)
        {
            produtos = ListaProdutos.getListaJSON(fileName);
            foreach (Produto produto in produtos)
                listProdutos.Items.Add((Produto)produto);
            listProdutos.DisplayMember = "produto.ToString()";
        }
        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (listProdutos.SelectedItem != null)
            {
                listProdutos.Items.Remove(listProdutos.SelectedItem);
                listProdutos.ClearSelected();
            }
            else
            {
                MessageBox.Show("Selecione um item!");
            }
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            double novoPreço = 0;
            if (listProdutos.SelectedItem != null)
            {

                var itemEditar = (Produto)listProdutos.SelectedItem;
                string novaDescrição = Interaction.InputBox($"Descrição do Produto: ", "Editar");
                if (!String.IsNullOrEmpty(novaDescrição))
                {
                    string strnovoPreço = Interaction.InputBox($"Valor do Produto: ", "Editar");
                    while (!Double.TryParse(strnovoPreço, out novoPreço))
                    {
                        Interaction.MsgBox("Valor Inválido!");
                        strnovoPreço = Interaction.InputBox($"Valor do Produto: ", "Editar");
                    }

                    listProdutos.Items.Remove(listProdutos.SelectedItem);
                    itemEditar.Descrição = novaDescrição.ToUpper();
                    itemEditar.Valor = novoPreço;
                    listProdutos.Items.Add(itemEditar);
                }
            }
        }
        private void txtProduto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtValor.Select();
            }
        }
        private void txtValor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAdicionar_Click(sender, e);
                txtProduto.Focus();
            }
        }

        private void listProdutos_SizeChanged(object sender, EventArgs e)
        {
            foreach (Produto item in listProdutos.Items)
                ListaProdutos.addListaProdutos(item);
            ListaProdutos.addListaJSON(fileName);

        }

        private void btnFormComprar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
