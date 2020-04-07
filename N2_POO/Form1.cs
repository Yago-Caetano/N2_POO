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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            if (File.Exists("Departamentos.txt"))
            {
                string[] linhas = File.ReadAllLines("Departamentos.txt");

                for (int x = 0; x < linhas.Length; x++)
                {
                    string[] dadosDepartamentos = linhas[x].Split('|');

                    Departamento aux = new Departamento();

                    aux.Codigo = Convert.ToInt32(dadosDepartamentos[0]);
                    aux.CodGerente = Convert.ToInt32(dadosDepartamentos[1]);
                    aux.Descrição = dadosDepartamentos[2];


                    ListaDepartamentos.Adcionar(aux);
                }
            }


            if (File.Exists("Funcionarios.txt"))
            {

                string[] linhas = File.ReadAllLines("Funcionarios.txt");
                
                for (int x = 0; x < linhas.Length; x++)
                {
                    string[] dadosFuncionarios = linhas[x].Split('|');

                    Funcionario aux = new Funcionario();

                    aux.SetNome(dadosFuncionarios[0]);
                    aux.SetCodigo(Convert.ToInt32(dadosFuncionarios[1]));
                    aux.setCPF(dadosFuncionarios[2]);
                    aux.SetNascimento(Convert.ToDateTime(dadosFuncionarios[3]));
                    aux.SetSalario(Convert.ToDouble(dadosFuncionarios[4]));
                    aux.SetTipo(dadosFuncionarios[6][0]);
                    aux.SetDepartamento(ListaDepartamentos.Find(Convert.ToInt32(dadosFuncionarios[5])));

                    Lista_Funcionarios.AdcionarFuncionario(aux);
                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            fCadastrarFuncionarios tela = new fCadastrarFuncionarios();
            tela.ShowDialog();
        }

        private void btnCadastrarDepartamento_Click(object sender, EventArgs e)
        {
            fCadastrarDepartamento tela = new fCadastrarDepartamento();
            tela.ShowDialog();
        }

        private void btnAumento_Click(object sender, EventArgs e)
        {
            fAumento tela = new fAumento();
            tela.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fListar tela = new fListar();
            tela.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
          DialogResult resposta = MessageBox.Show("Tem certeza que quer apagar todos os dados de funcionários e departamentos?", "Apagar", MessageBoxButtons.YesNo);

            if(resposta == DialogResult.Yes)
            {
                File.Delete("Funcionarios.txt");
                File.Delete("Departamentos.txt");

                ListaDepartamentos.Deletar();
                Lista_Funcionarios.Deletar();
                
            }
            else
            {
                return;
            }
        }
    }
}
