using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N2_POO
{
    public partial class fListar : Form
    {
        public fListar()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            List<Funcionario> aux = new List<Funcionario>();

            aux = Lista_Funcionarios.ListaGeral();
            string conteudo = "";

            foreach (var func in aux)
            {
                if (func.GetDepartamento() == null)
                    conteudo += "Nome: " + func.Nome + Environment.NewLine + "Código: " + func.Codigo + Environment.NewLine + "CPF: "
                        + func.CPF + Environment.NewLine+ "Data de Nascimento: " + func.Nascimento.ToShortDateString() + Environment.NewLine + "Salário: R$"
                        + func.Salario + Environment.NewLine + "Departamento: " + 0 + Environment.NewLine + "Tipo: " + func.Tipo + Environment.NewLine + Environment.NewLine;

                else
                    conteudo += "Nome: " + func.Nome + Environment.NewLine + "Código: " + func.Codigo + Environment.NewLine +  "CPF " +
                       func.CPF + Environment.NewLine + "Data de Nascimento: " + func.Nascimento.ToShortDateString() + Environment.NewLine + "Salário: R$"
                        + func.Salario + Environment.NewLine + "Departamento: " + func.GetDepartamento().Codigo + Environment.NewLine + "Tipo: " + func.Tipo + Environment.NewLine + Environment.NewLine;


            }

            rtxtdados.AppendText(conteudo);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            rtxtdados.Text = "";
        }

        private void btnListarDepartamento_Click(object sender, EventArgs e)
        {
            List<Funcionario> aux = new List<Funcionario>();
            string conteudo = $"Departamento {nupCodigoDepartamento.Value}" + Environment.NewLine;

            aux = Lista_Funcionarios.ListaDepartamento(ListaDepartamentos.Find(Convert.ToInt32(nupCodigoDepartamento.Value)));

            foreach (var func in aux)
            {
                conteudo += "Nome: " + func.Nome + Environment.NewLine + "Código: " + func.Codigo + Environment.NewLine + "CPF: " + func.CPF
                +Environment.NewLine + "Data de Nascimento: " + func.Nascimento.ToShortDateString() + Environment.NewLine + "Salário: R$"
                    + func.Salario + Environment.NewLine + "Departamento: " + func.GetDepartamento().Codigo + Environment.NewLine + "Tipo: " + func.Tipo + Environment.NewLine + Environment.NewLine;

            }

            rtxtdados.AppendText(conteudo);
        }

        private void btnCodGerente_Click(object sender, EventArgs e)
        {
            List<Funcionario> aux = new List<Funcionario>();
            string conteudo = "";

            try
            {
                aux = Lista_Funcionarios.ListarPorGerente(Lista_Funcionarios.Find(Convert.ToInt32(nupeCodGerente.Value)));
            }
            catch(Exception erro)
            {
                MessageBox.Show(erro.Message);
                return;
            }

            conteudo = $"Gerente {Lista_Funcionarios.Find(Convert.ToInt32(nupeCodGerente.Value)).Nome}" + Environment.NewLine + Environment.NewLine;

            foreach (var func in aux)
            {
                conteudo += "Nome: " + func.Nome + Environment.NewLine + "Código: " + func.Codigo + Environment.NewLine + "CPF: " + func.CPF
                + Environment.NewLine + "Data de Nascimento: " + func.Nascimento.ToShortDateString() + Environment.NewLine + "Salário: R$"
                    + func.Salario + Environment.NewLine + "Departamento: " + func.GetDepartamento().Codigo + Environment.NewLine + "Tipo: " + func.Tipo + Environment.NewLine + Environment.NewLine;

            }

            rtxtdados.AppendText(conteudo);
        }

        private void btnListarGerentes_Click(object sender, EventArgs e)
        {
            List<Funcionario> aux = new List<Funcionario>();

            try
            {
                aux = Lista_Funcionarios.ListaGerentes();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
                return;
            }

            List<Departamento> departamentos =  ListaDepartamentos.ListaGeral();

            for(int x = 0; x < aux.Count; x++)
            {
                for(int y = 0; y < departamentos.Count; y++)
                {
                    if (aux[x].Codigo == departamentos[y].CodGerente)
                    {
                        List<Funcionario> funcionariosDoDepartamento = Lista_Funcionarios.ListaDepartamento(departamentos[y]);
                        string gerente = $"Gerente: Código: {aux[x].Codigo} - Nome: {aux[x].Nome}" + Environment.NewLine;

                        
                        string funcionarios = "";

                        foreach( Funcionario f in funcionariosDoDepartamento)
                        {
                            funcionarios += $"Código: {f.Codigo} - Nome: {f.Nome} - CPF {f.CPF}" + Environment.NewLine;
                        }

                        rtxtdados.SelectionColor = Color.Yellow;
                        rtxtdados.AppendText(gerente + Environment.NewLine);

                        rtxtdados.SelectionColor = Color.Black;
                        rtxtdados.AppendText("Funcionárigios gerenciados:" + Environment.NewLine);
                        rtxtdados.AppendText(funcionarios + Environment.NewLine + Environment.NewLine);

                    }
                }

            }

        }
    }
}
