using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX3
{
    internal class Funcionario
    {
        private String nome;
        private String qntdHoras;
        private String valorHoras;

        public void setNome(string Nome) { nome = Nome; }
        public String getNome() { return nome; }
        public void setQntdHoras(string QntdHoras) { qntdHoras = QntdHoras; }
        public String getQntdHoras() { return qntdHoras; }
        public void setValorHoras(string ValorHoras) { valorHoras = ValorHoras; }
        public String getValorHoras() { return valorHoras; }
        public String getSalario()
        {
            return (int.Parse(getQntdHoras()) * float.Parse(getValorHoras())).ToString();
        }
    }
}
