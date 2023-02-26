using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Funcionario funcionarios = new Funcionario();

            funcionarios.setNome(txtNome.Text);
            funcionarios.setQntdHoras(txtQntdHoras.Text);
            funcionarios.setValorHoras(txtValorHoras.Text);

            FuncionarioBLL.validaDados(funcionarios);
            if(Erro.getErro())
            {
                MessageBox.Show(Erro.getMensagem());
            }
            else
            {
                txtResult.Text = funcionarios.getSalario();
                txtNome.Enabled = false;
                txtQntdHoras.Enabled = false;
                txtValorHoras.Enabled =false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
            txtQntdHoras.Text = "";
            txtValorHoras.Text = "";
            txtResult.Text = "";
            txtNome.Enabled = true;
            txtQntdHoras.Enabled = true;
            txtValorHoras.Enabled = true;
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }
    }
}
