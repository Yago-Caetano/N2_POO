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

            try
            {
                Funcionario validar = new Funcionario();

                validar = Lista_Funcionarios.Find(Convert.ToInt32(nupCodigoGerente.Value));

                if (validar != null)
                    d.CodGerente = Convert.ToInt32(nupCodigoGerente.Value);
                else
                {
                    MessageBox.Show("O gerente não existe");
                    return;
                }


                d.Codigo = Convert.ToInt32(nupCodigo.Value);
                d.Descrição = txtDescricao.Text;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
                return;
            }

            ListaDepartamentos.Adcionar(d);

            MessageBox.Show("Código: " + d.Codigo.ToString() + Environment.NewLine + "Código Gerente: " + d.CodGerente + Environment.NewLine
                + "Descrição: " + d.Descrição);

            string conteudo = "";
            List<Departamento> aux = new List<Departamento>();

            aux = ListaDepartamentos.ListaGeral();

            foreach (var func in aux)
            {
                conteudo += d.Codigo + "|" + d.CodGerente + "|" + d.Descrição;

            }

            File.WriteAllText("Departamentos.txt", conteudo, Encoding.UTF8);
        }
    }
}
