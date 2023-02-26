using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX3
{
    internal class FuncionarioBLL
    {
        public static void validaDados(Funcionario funcionarios)
        {
            Erro.setErro(false);
            if (funcionarios.getNome().Length == 0)
            {
                Erro.setErro("O campo NOME é de preenchimento obrigatório...");
                return;
            }
            else
            {
                try
                {
                   funcionarios.getNome();
                }
                catch
                {
                    Erro.setErro("O campo NOME deve ser afanumérico...");
                    return;
                }
            }

            if (funcionarios.getQntdHoras().Length == 0)
            {
                Erro.setErro("O campo QNTDHORAS é de preenchimento obrigatório...");
                return;
            }
            else
            {
                try
                {
                    int.Parse(funcionarios.getQntdHoras());
                }
                catch
                {
                    Erro.setErro("O campo QNTDHORAS deve ser numérico...");
                    return;
                }
                if (int.Parse(funcionarios.getQntdHoras()) <= 0)
                {
                    Erro.setErro("O campo QNTDHORAS deve ser maior que zero.");
                    return;
                }

            }
            if (funcionarios.getValorHoras().Length == 0)
            {
                Erro.setErro("O campo VALORHORAS é de preenchimento obrigatório...");
                return;
            }
            else
            {
                try
                {
                    float.Parse(funcionarios.getValorHoras());
                }
                catch
                {
                    Erro.setErro("O campo VALORHORAS deve ser numérico...");
                    return;
                }
                if (float.Parse(funcionarios.getValorHoras()) <= 0)
                {
                    Erro.setErro("O campo VALORHORAS deve ser maior que zero.");
                    return;
                }

            }
        }
    }
}

