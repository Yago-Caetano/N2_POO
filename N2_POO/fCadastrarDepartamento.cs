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
    public partial class fCadastrarDepartamento : Form
    {
        public fCadastrarDepartamento()
        {
            InitializeComponent();
        }

        private void btnCadastrarDepartamento_Click(object sender, EventArgs e)
        {
            Departamento d = new Departamento();
            Funcionario validar = new Funcionario();

            if(ListaDepartamentos.Tamanho() != 0)
            {
                List<Departamento> repete = ListaDepartamentos.ListaGeral();

                foreach (Departamento dep in repete) //se o codigo ja foi cadastrado em outra departamento
                {
                    if (nupCodigo.Value == dep.Codigo)
                    {
                        MostrarErro($"O Código {nupCodigo.Value} ja foi utilizado!");
                        return;
                    }
                    if(nupCodigoGerente.Value == dep.CodGerente)
                    {
                        MostrarErro($"O Gerente {nupCodigoGerente.Value} ja foi utilizado!");
                        return;
                    }
                }
            }


            if (txtDescricao.Text.Trim() == "") //descrição vazia{
            {
                MostrarErro("Digite uma descrição!!");
                return;
            }

            validar = Lista_Funcionarios.Find(Convert.ToInt32(nupCodigoGerente.Value));

            if (validar != null)//Verifica se o gerente existe
            {
                if (validar.Tipo != 'G')
                {
                    MostrarErro("Selecione Apenas Gerentes!!");
                    return;
                }

                d.CodGerente = Convert.ToInt32(nupCodigoGerente.Value);
            }
            else
            {
                MostrarErro("O gerente não existe!!");
                return;
            }




            d.Codigo = Convert.ToInt32(nupCodigo.Value);
                d.Descrição = txtDescricao.Text;
                d.CodGerente = Convert.ToInt32(nupCodigoGerente.Value);
                ListaDepartamentos.Adcionar(d);

            validar.SetDepartamento(d);

            MessageBox.Show("Código: " + d.Codigo.ToString() + Environment.NewLine + "Código Gerente: " + d.CodGerente.ToString() + Environment.NewLine
                + "Descrição: " + d.Descrição);

            string conteudo = "";
            List<Departamento> aux = ListaDepartamentos.ListaGeral();

            foreach (var departa in aux)
            {
                conteudo += departa.Codigo + "|" + departa.CodGerente + "|" + departa.Descrição + Environment.NewLine;
            }

            File.WriteAllText("Departamentos.txt", conteudo, Encoding.UTF8);
            

            List<Funcionario> fun = Lista_Funcionarios.ListaGeral();

            conteudo = "";
            foreach (var func in fun)
            {
                    conteudo += func.Nome + "|" + func.Codigo + "|" + func.CPF + "|" + func.Nascimento.ToShortDateString() + "|" + func.Salario + "|"
                      + func.GetDepartamento().Codigo + "|" + func.Tipo + Environment.NewLine;
            }

            if(conteudo.Length > 2) //se contiver alguma informação
            {
                File.WriteAllText("Funcionarios.txt", conteudo, Encoding.UTF8); //escreve  no arquivo texto
            }

        }

        private void MostrarErro(string erro)
        {
            MessageBox.Show(erro, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

    }
}
