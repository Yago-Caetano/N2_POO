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
    public partial class fCadastrarFuncionarios : Form
    {
        public fCadastrarFuncionarios()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Funcionario f = new Funcionario();

            try
            {
                f.SetCodigo(Convert.ToInt32(nupCodigo.Value));
                f.setCPF(txtCpf.Text);
                f.SetNascimento(Convert.ToDateTime(txtData.Text));
                f.SetNome(txtNome.Text);
                f.SetSalario(Convert.ToInt32(nupSalario.Value));

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
                return;
            }

            if (cbTipo.SelectedItem == null)
            {
                if (cbTipo.Text[0] != 'F' || cbTipo.Text[0] != 'G')
                {
                    MessageBox.Show("Tipo inválido");
                    return;
                }
                else if (cbTipo.Text[0] == 'G')
                {
                    f.SetTipo(cbTipo.SelectedItem.ToString()[0]);
                    Lista_Funcionarios.AdcionarFuncionario(f);
                }
                else
                {
                    f.SetTipo(cbTipo.SelectedItem.ToString()[0]);
                    f.SetDepartamento(ListaDepartamentos.Find(Convert.ToInt32(nupDepartamento.Value)));
                    Lista_Funcionarios.AdcionarFuncionario(f);
                }

            }
            else if (cbTipo.SelectedItem.ToString()[0] == 'G')
            {
                f.SetTipo(cbTipo.SelectedItem.ToString()[0]);
                Lista_Funcionarios.AdcionarFuncionario(f);
            }
            else
            {
                f.SetTipo(cbTipo.SelectedItem.ToString()[0]);

                if (ListaDepartamentos.Find(Convert.ToInt32(nupDepartamento.Value)) == null)
                {
                    MessageBox.Show("O Departamento não existe");
                    return;
                }
                else
                    f.SetDepartamento(ListaDepartamentos.Find(Convert.ToInt32(nupDepartamento.Value)));

                Lista_Funcionarios.AdcionarFuncionario(f);
            }


            MessageBox.Show(f.Nome + Environment.NewLine + f.Codigo + Environment.NewLine + f.CPF + Environment.NewLine
               + f.Nascimento.ToShortDateString() + Environment.NewLine + "R$" + f.Salario.ToString() + Environment.NewLine + f.Tipo);

            string conteudo = "";
            List<Funcionario> aux = new List<Funcionario>();

            aux = Lista_Funcionarios.ListaGeral();

            foreach (var func in aux)
            {
                if (func.GetDepartamento() == null)
                    conteudo += func.Nome + "|" + func.Codigo +"|"+ func.CPF + "|" + func.Nascimento.ToShortDateString() + "|" + func.Salario + "|"
                  + 0 + "|" + func.Tipo + Environment.NewLine;
                else
                    conteudo += func.Nome + "|" + func.Codigo + "|" + func.CPF + "|" + func.Nascimento.ToShortDateString() + "|" + func.Salario + "|"
                      + func.GetDepartamento().Codigo + "|" + func.Tipo + Environment.NewLine;


            }

            File.WriteAllText("Funcionarios.txt", conteudo, Encoding.UTF8);

        }
    }
}
