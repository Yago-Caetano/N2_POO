using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace N2_POO
{
    public partial class fAumento : Form
    {
        public fAumento()
        {
            InitializeComponent();
        }

        private void btnAumentoFixo_Click(object sender, EventArgs e)
        {
            List<Funcionario> Funcio = Lista_Funcionarios.ListaGeral();

            foreach (Funcionario f in Funcio)
            {
                f.AumentoSalario(Convert.ToDouble(nupAumentoFixo.Value));
            }

            string conteudo = "";
            List<Funcionario> aux = Lista_Funcionarios.ListaGeral();

            foreach (var func in aux)
            {
                if (func.GetDepartamento() == null)
                    conteudo += func.Nome + "|" + func.Codigo + "|" + func.CPF + "|" + func.Nascimento.ToShortDateString() + "|" + func.Salario + "|"
                  + 0 + "|" + func.Tipo + Environment.NewLine;
                else
                    conteudo += func.Nome + "|" + func.Codigo + "|" + func.CPF + "|" + func.Nascimento.ToShortDateString() + "|" + func.Salario + "|"
                      + func.GetDepartamento().Codigo + "|" + func.Tipo + Environment.NewLine;

            }

            File.WriteAllText("Funcionarios.txt", conteudo, Encoding.UTF8);

            MessageBox.Show("Foi dado um aumento de R$" + nupAumentoFixo.Value.ToString() + " a todos os funcionários");
        }

        private void btnAumentoPercentual_Click(object sender, EventArgs e)
        {
            List<Funcionario> Funcio = Lista_Funcionarios.ListaGeral();

            foreach (Funcionario f in Funcio)
            {
                f.AumentoSalario(float.Parse(nupPorcentagem.Value.ToString()));
            }

            string conteudo = "";
            List<Funcionario> aux = Lista_Funcionarios.ListaGeral();

            foreach (var func in aux)
            {
                if (func.GetDepartamento() == null)
                    conteudo += func.Nome + "|" + func.Codigo + "|" + func.CPF + "|" + func.Nascimento.ToShortDateString() + "|" + func.Salario + "|"
                  + 0 + "|" + func.Tipo + Environment.NewLine;
                else
                    conteudo += func.Nome + "|" + func.Codigo + "|" + func.CPF + "|" + func.Nascimento.ToShortDateString() + "|" + func.Salario + "|"
                      + func.GetDepartamento().Codigo + "|" + func.Tipo + Environment.NewLine;

            }

            File.WriteAllText("Funcionarios.txt", conteudo, Encoding.UTF8);

            MessageBox.Show("Foi dado um aumento de " + nupPorcentagem.Value.ToString() + "%" + " a todos os funcionários");
        }
    }
}
