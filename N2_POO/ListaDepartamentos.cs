using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N2_POO
{
    static class ListaDepartamentos
    {
        static private List<Departamento> departamentos = new List<Departamento>();

        /// <summary>
        /// Incrementa um departamento na lista
        /// </summary>
        /// <param name="departamento"></param>
        static public void Adcionar(Departamento departamento)
        {
            if(departamento != null)
            {
                departamentos.Add(departamento);
            }
            else
            {
                throw new Exception("Não é possível adcionar um departamento vazio");
            }
        }

        /// <summary>
        /// Remove um departamento e indica se houve sucesso
        /// </summary>
        /// <param name="cod"></param>
        static public bool Remover(int cod)
        {
            foreach(Departamento d in departamentos)
            {
                if(d.Codigo == cod)
                {
                    departamentos.Remove(d);
                    return true;
                }
            }
            return false; 
        }


        /// <summary>
        /// Retorna o departamento desejado
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        static public Departamento GetItem(int index)
        {
            if(index > departamentos.Count)
            {
                throw new Exception("Indice fora dos limites");
            }
            else
            {
                return departamentos[index];
            }
        }

        /// <summary>
        /// Verifica se o departamento inserido está presente na lista
        /// </summary>
        /// <param name="d"></param>
        /// <returns></returns>
        static public bool Contains(Departamento dep)
        {
            foreach (Departamento d in departamentos)
            {
                if (d.Equals(dep)) 
                {
                    return true;
                }
            }
            return false;
        }


        /// <summary>
        /// Retorna o tamanho da Lista
        /// </summary>
        /// <returns></returns>
        static public int Tamanho()
        {
            return departamentos.Count;
        }

        static public List<Departamento> ListaGeral()
        {
            if (departamentos.Count > 0)
            {
                return departamentos;
            }
            else
            {
                throw new Exception("Não há departamentos cadastrados");
            }
        }

    }
}
