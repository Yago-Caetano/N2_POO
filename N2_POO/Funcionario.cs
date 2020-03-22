using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N2_POO
{
    class Funcionario
    {
        private int codigo;
        private string nome;
        private string Cpf;
        private DateTime nascimento;
        private double salario;
        private char tipo;
        private Departamento departamento;


        /// <summary>
        /// Guarda as informações dos funcionários
        /// </summary>
        /// <param name="codigo"></param>
        /// <param name="nome"></param>
        /// <param name="cpf"></param>
        /// <param name="nascimento"></param>
        /// <param name="salario"></param>
        /// <param name="tipo"></param>
        /// <param name="departamento"></param>
        public Funcionario(int codigo, string nome, string cpf, DateTime nascimento, double salario, char tipo, Departamento departamento)
        {
            this.codigo = codigo;
            this.nome = nome;
            this.Cpf = cpf;
            this.nascimento = nascimento;
            this.salario = salario;
            this.tipo = tipo;
            this.departamento = departamento;
        }

        /// <summary>
        ///  Guarda as informações dos funcionários
        /// </summary>
        /// <param name="codigo"></param>
        /// <param name="nome"></param>
        /// <param name="cpf"></param>
        /// <param name="nascimento"></param>
        /// <param name="salario"></param>
        /// <param name="tipo"></param>
        public Funcionario(int codigo, string nome, string cpf, DateTime nascimento, double salario, char tipo)
        {
            this.codigo = codigo;
            this.nome = nome;
            this.Cpf = cpf;
            this.nascimento = nascimento;
            this.salario = salario;
            this.tipo = tipo;
        }


        /// <summary>
        /// Guarda as informações dos funcionários
        /// </summary>
        /// <param name="codigo"></param>
        /// <param name="nome"></param>
        /// <param name="cpf"></param>
        /// <param name="nascimento"></param>
        /// <param name="salario"></param>
        public Funcionario(int codigo, string nome, string cpf, DateTime nascimento, double salario)
        {
            this.codigo = codigo;
            this.nome = nome;
            this.Cpf = cpf;
            this.nascimento = nascimento;
            this.salario = salario;
        }


        /// <summary>
        /// Guarda as informações dos funcionários
        /// </summary>
        /// <param name="codigo"></param>
        /// <param name="nome"></param>
        /// <param name="cpf"></param>
        /// <param name="nascimento"></param>
        public Funcionario(int codigo, string nome, string cpf, DateTime nascimento)
        {
            this.codigo = codigo;
            this.nome = nome;
            this.Cpf = cpf;
            this.nascimento = nascimento;
        }


        /// <summary>
        /// Guarda as informações dos funcionários
        /// </summary>
        /// <param name="codigo"></param>
        /// <param name="nome"></param>
        /// <param name="cpf"></param>
        public Funcionario(int codigo, string nome, string cpf)
        {
            this.codigo = codigo;
            this.nome = nome;
            this.Cpf = cpf;
        }

        /// <summary>
        /// Guarda as informações dos funcionários
        /// </summary>
        /// <param name="codigo"></param>
        /// <param name="nome"></param>
        public Funcionario(int codigo, string nome)
        {
            this.codigo = codigo;
            this.nome = nome;
        }

        /// <summary>
        /// Guarda as informações dos funcionários
        /// </summary>
        /// <param name="codigo"></param>
        public Funcionario(int codigo)
        {
            this.codigo = codigo;
        }

        /// <summary>
        /// Guarda as informações dos funcionários
        /// </summary>
        public Funcionario() { }


        /// <summary>
        /// Recupera o código
        /// </summary>
        public int Codigo { get => codigo; }


        /// <summary>
        /// Define o código 
        /// </summary>
        /// <param name="valor"></param>
        public void SetCodigo(int valor)
        {
            if (valor < 0)
            {
                throw new Exception("Código Inválido");
            }
            else
            {
                codigo = valor;
            }
        }


        /// <summary>
        /// Recupera o Nome
        /// </summary>
        public string Nome { get => nome; }


        /// <summary>
        /// Define o Nome 
        /// </summary>
        /// <param name="nome"></param>
        public void SetNome(string nome)
        {
            if (nome.Length > 0)
            {
                this.nome = nome;
            }
            else
            {
                throw new Exception("Nome Inválido");
            }
        }


        /// <summary>
        /// Recupera a data de Nascimento
        /// </summary>
        public DateTime Nascimento { get => nascimento; }


        /// <summary>
        ///  Define a data de Nascimento
        /// </summary>
        /// <param name="Data"></param>
        public void SetNascimento(DateTime Data)
        {
            if (DateTime.Now.Ticks < Data.Ticks)
            {
                throw new Exception("Data Inválida");
            }
            else
            {
                nascimento = Data;
            }
        }

        /// <summary>
        /// Recupera o Salario
        /// </summary>
        public double Salario { get => salario; }


        /// <summary>
        /// Define  o salário 
        /// </summary>
        /// <param name="salario"></param>
        public void SetSalario(double salario)
        {
            if (salario < 0)
            {
                throw new Exception("Salário Inválido");
            }
            else
            {
                this.salario = salario;
            }
        }

        /// <summary>
        /// Recupera o Tipo
        /// </summary>
        public char Tipo { get => tipo; }

        /// <summary>
        /// Recupera o CPF
        /// </summary>
        public string CPF { get => Cpf; }


        /// <summary>
        /// Retorna o departamento do funcionário
        /// </summary>
        /// <returns></returns>
        public Departamento GetDepartamento()
        {
            if (departamento == null)
                return null;
            else
                return departamento;
        }


        /// <summary>
        /// Define o departamento
        /// </summary>
        /// <param name="departamento"></param>
        public void SetDepartamento(Departamento departamento)
        {
            if (!ListaDepartamentos.Contains(departamento))
            {
                throw new Exception("Departamento Inexistente");
            }
            else
            {
                this.departamento = departamento;
            }
        }


        /// <summary>
        /// Define o CPF
        /// </summary>
        /// <param name="CPF"></param>
        public void setCPF(string CPF)
        {
            if (CPF.Length < 11)
            {
                throw new Exception("CPF Inválido");
            }
            else
            {
                //formata o CPF para o padrão
                string CPFormat = CPF.Replace(".", "").Replace("-", "");
                CPFormat = CPFormat.Insert(3, ".").Insert(7, ".").Insert(11, "-");
                this.Cpf = CPFormat;
            }
        }



        /// <summary>
        /// Define o tipo 
        /// </summary>
        /// <param name="tipo"></param>
        public void SetTipo(char tipo)
        {
            if ((tipo == 'G') || (tipo == 'F'))
            {
                this.tipo = tipo;
            }
            else
            {
                throw new Exception("Tipo Inválido");
            }
        }

        /// <summary>
        ///  Aumenta o salário 
        /// </summary>
        /// <param name="Aumento"></param>
        public void AumentoSalario(double Aumento)
        {
            salario += Aumento;
        }

        /// <summary>
        /// Aumenta o salário
        /// </summary>
        /// <param name="Percentual"></param>
        public void AumentoSalario(float Percentual)
        {
            salario = (salario * (Percentual / 100));
        }

    }
}
