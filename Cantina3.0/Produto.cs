using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cantina3._0
{
    internal class Produto
    {
        private string descrição;
        private double valor;

        public override string ToString()
        {
            return $"{descrição} - R${valor} ";
            
        }
        public Produto()
        {
            this.descrição = string.Empty;
            this.valor = 0;

        }
        public Produto(string descrição, double valor)
        {
            this.descrição = descrição;
            this.valor = valor;
    
        }
        public string Descrição
        {
            get { return descrição;}
            set { this.descrição = value; }
        }
        public double Valor
        {
            get { return valor; }
            set { this.valor = value; }
        }
    }
}
