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

            try
            {

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
                d.CodGerente = Convert.ToInt32(nupCodigoGerente.Value);


            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
                return;
            }

            ListaDepartamentos.Adcionar(d);           

            MessageBox.Show("Código: " + d.Codigo.ToString() + Environment.NewLine + "Código Gerente: " + d.CodGerente.ToString() + Environment.NewLine
                + "Descrição: " + d.Descrição);

            string conteudo = "";
            List<Departamento> aux = new List<Departamento>();

            aux = ListaDepartamentos.ListaGeral();

            foreach (var departa in aux)
            {
                conteudo += departa.Codigo + "|" + departa.CodGerente + "|" + departa.Descrição + Environment.NewLine;

            }

            File.WriteAllText("Departamentos.txt", conteudo, Encoding.UTF8);

           
        }
    }
}
