using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;

namespace Cantina3._0
{
    internal class listaProdutos
    {
        private List<Produto> estoque = new List<Produto>();
        //private string fileName = ".json";
      

        public void addListaProdutos(Produto produto)
        {
           estoque.Add(produto);
          
        }
        public List<Produto> getEstoque()
        {
            return estoque;
        }
        public void addListaJSON(string fileName)
        {
             string jsonString = JsonSerializer.Serialize(estoque);
             File.WriteAllText(fileName, jsonString);
             //Console.WriteLine(File.ReadAllText(fileName));
        }

        public List<Produto> getListaJSON(string fileName)
        {
            string jsonString = File.ReadAllText(fileName);
            List<Produto> lista = JsonSerializer.Deserialize<List<Produto>>(jsonString);
            foreach (Produto produto3 in lista)
                Console.WriteLine($"{produto3.Descrição} - R${produto3.Valor} ");
            return lista;
        }
    }
}
