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

            if (txtCpf.Text.Replace(".", "").Replace("-", "").Trim().Length < 11) // Validar CPF
            {
                MessageBox.Show("CPF inválido!!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Lista_Funcionarios.Tamanho() != 0)
            {
                List<Funcionario> repete = Lista_Funcionarios.ListaGeral();
                foreach (Funcionario fu in repete)
                {
                    if (nupCodigo.Value == fu.Codigo)
                    {
                        MessageBox.Show($"O código {nupCodigo.Value} ja foi cadastrado!!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            

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
                MessageBox.Show("Selecione o Tipo","Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;

            }
            else if (cbTipo.SelectedItem.ToString()[0] == 'G')
            {
                f.SetTipo(cbTipo.SelectedItem.ToString()[0]);
                Lista_Funcionarios.AdcionarFuncionario(f);
            }
            else
            {
                f.SetTipo(cbTipo.SelectedItem.ToString()[0]);

                if (ListaDepartamentos.Find(Convert.ToInt32(nupDepartamento.Value)) == null) //verifica se o departamento existe
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
            List<Funcionario> aux = Lista_Funcionarios.ListaGeral();

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
