using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N2_POO
{
    class Departamento
    {
        private int codigo;
        private int codGerente;
        private string descricao;

        /// <summary>
        /// Classe responsável por armazenar os dados de departamento
        /// </summary>
        /// <param name="codigo"></param>
        /// <param name="codGerente"></param>
        /// <param name="descricao"></param>
        public Departamento(int codigo, string descricao, int codGerente)
        {
            this.codigo = codigo;
            this.codGerente = codGerente;
            this.descricao = descricao;
        }

        /// <summary>
        /// Classe responsável por armazenar os dados de departamento
        /// </summary>
        /// <param name="codigo"></param>
        /// <param name="descricao"></param>
        public Departamento(int codigo, string descricao)
        {
            this.codigo = codigo;
            this.descricao = descricao;
        }


        /// <summary>
        /// Classe responsável por armazenar os dados de departamento
        /// </summary>
        /// <param name="codigo"></param>
        public Departamento(int codigo)
        {
            this.codigo = codigo;
        }


        /// <summary>
        ///  Classe responsável por armazenar os dados de departamento
        /// </summary>
        public Departamento()
        {

        }


        public int Codigo { get => codigo; set => codigo = value; }

        public int CodGerente
        {
            get => codGerente;
            set => codGerente = value;

        }


        public string Descrição { get => descricao; set => descricao = value; }
    }
}
