using System.Text.Json;
using Microsoft.VisualBasic;
namespace Cantina3._0
{
    public partial class Form : System.Windows.Forms.Form
    {
        string fileName = "listaProdutos.json";
        listaProdutos ListaProdutos = new listaProdutos();
        List<Produto> produtos = new List<Produto>();

        public Form()
        {

            InitializeComponent();
            produtos = ListaProdutos.getListaJSON(fileName);
            foreach (Produto produto in produtos)
                listProdutos.Items.Add((Produto)produto);
        }
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            txtProduto.Focus();
            double pre�o = 0;
            if (!String.IsNullOrEmpty(txtProduto.Text) && !String.IsNullOrEmpty(txtValor.Text))
            {
                foreach (Produto produto1 in listProdutos.Items)
                {
                    if (produto1.Descri��o == txtProduto.Text.ToUpper())
                    {
                        MessageBox.Show("Esse produto j� existe! Remova ou altere.");
                        return;
                    }
                }
                if (!double.TryParse(txtValor.Text, out pre�o))
                {
                    MessageBox.Show("Valor Inv�lido");
                    txtValor.Focus(); 
                    
                }
                else
                {
                    Produto produto = new Produto(txtProduto.Text.ToUpper(), pre�o);
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
            txtProduto.Focus();
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
            double novoPre�o = 0;
            if (listProdutos.SelectedItem != null)
            {

                var itemEditar = (Produto)listProdutos.SelectedItem;
                string novaDescri��o = Interaction.InputBox($"Descri��o do Produto: ", "Editar");
                if (!String.IsNullOrEmpty(novaDescri��o))
                {
                    string strnovoPre�o = Interaction.InputBox($"Valor do Produto: ", "Editar");
                    while (!Double.TryParse(strnovoPre�o, out novoPre�o))
                    {
                        Interaction.MsgBox("Valor Inv�lido!");
                        strnovoPre�o = Interaction.InputBox($"Valor do Produto: ", "Editar");
                    }

                    listProdutos.Items.Remove(listProdutos.SelectedItem);
                    itemEditar.Descri��o = novaDescri��o.ToUpper();
                    itemEditar.Valor = novoPre�o;
                    listProdutos.Items.Add(itemEditar);
                }
            }
        }
        private void txtProduto_KeyDown(object sender, KeyEventArgs e)
        {
            if (!String.IsNullOrEmpty(txtProduto.Text))
                {
                if (e.KeyCode == Keys.Enter)
                {
                    txtValor.Select();
                }
            }
        }
        private void txtValor_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                btnAdicionar_Click(sender, e);
                
            }
        }


        private void btnFormComprar_Click(object sender, EventArgs e)
        {
            foreach (Produto item in listProdutos.Items)
                ListaProdutos.addListaProdutos(item);
            ListaProdutos.addListaJSON(fileName);
            Close();
        }
    }
}
