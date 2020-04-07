using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N2_POO
{
    static class Lista_Funcionarios
    {
        static List<Funcionario> funcionarios = new List<Funcionario>(); //armazena os funcionarios 


        /// <summary>
        /// Adciona um funcionario na lista
        /// </summary>
        /// <param name="f"></param>
        static public void AdcionarFuncionario(Funcionario f)
        {
            if(f != null)
            {
                funcionarios.Add(f);
            }
            else
            {
                throw new Exception("Não é possível adcionar um elemento null na lista");
            }
        }


        /// <summary>
        /// Remove um funcionário da lista 
        /// </summary>
        /// <param name="f"></param>
        static public void RemoverFuncionario(Funcionario f)
        {
            if(funcionarios.Contains(f))
            {
                funcionarios.Remove(f);
            }
            else
            {
                throw new Exception("Elemento não está presente na lista");
            }
        }


        /// <summary>
        /// Retorna um funcionario dentro da lista
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        static public Funcionario GetFuncionario(int index)
        {
            if(index < funcionarios.Count)
            {
                throw new Exception("Indice fora dos limites");
            }
            else
            {
                return (funcionarios[index]);
            }
        }

        /// <summary>
        /// Retorna o tamanho da lista
        /// </summary>
        /// <returns></returns>
        static public int Tamanho()
        {
            return funcionarios.Count;
        }


        /// <summary>
        /// retorna todos os funcionarios cadastrados
        /// </summary>
        /// <returns></returns>
        static public List<Funcionario> ListaGeral()
        {
            if(funcionarios.Count > 0)
            {
                return funcionarios;
            }
            else
            {
                throw new Exception("Não há funcionários cadastrados");
            }
        }


        /// <summary>
        /// Retorna todos os funcionários pertencentes ao departamento
        /// </summary>
        /// <param name="departamento"></param>
        /// <returns></returns>
        static public List<Funcionario> ListaDepartamento(Departamento departamento)
        {
            List<Funcionario> retornaFuncio = new List<Funcionario>();

            if (funcionarios.Count > 0)
            {
                foreach(Funcionario f in funcionarios)
                {
                    if(f.GetDepartamento() != null && f.GetDepartamento().Equals(departamento))
                    {
                        retornaFuncio.Add(f);
                    }
                }
                return retornaFuncio;
            }
            else
            {
                throw new Exception("Não há funcionários cadastrados");
            }
        }

        /// <summary>
        /// Retorna a lista de funcionários que pertencem ao departamento gerenciado pelo gerente informado
        /// </summary>
        /// <param name="f"></param>
        /// <returns></returns>
        static public List<Funcionario> ListarPorGerente(Funcionario f)
        {
            List<Funcionario> retornaFuncio = new List<Funcionario>();
            
            if(f.Tipo == 'G')
            {
               int codigo = f.Codigo;
               Departamento depAux;
               for(int i = 0; i<ListaDepartamentos.Tamanho();i++)
               {
                    if(ListaDepartamentos.GetItem(i).CodGerente == f.Codigo)
                    {
                        depAux = ListaDepartamentos.GetItem(i);
                        retornaFuncio = ListaDepartamento(depAux);
                        return retornaFuncio;
                    }
               }
               throw new Exception("Não foi encontrado nenhum Departamento");
            }
            else
            {
                throw new Exception("O funcionário deve ser do tipo GERENTE");
            }
        }


        
        /// <summary>
        /// Lista os funcionarios pelo mes da data de nascimento
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        static public List<Funcionario> ListaPorNascimento(DateTime data)
        {
            List<Funcionario> retornaFuncio = new List<Funcionario>();

            if(funcionarios.Count > 0)
            {
                foreach (Funcionario f in funcionarios)
                {
                    if (f.Nascimento.Month == data.Month)
                    {
                        retornaFuncio.Add(f);
                    }
                }
                return retornaFuncio;
            }
            else
            {
                throw new Exception("A lista está vazia");
            }

        }


        /// <summary>
        /// Retorna todos os Gerentes
        /// </summary>
        /// <returns></returns>
        static public List<Funcionario> ListaGerentes()
        {

            if(funcionarios.Count > 0)
            {
                List<Funcionario> retornaFuncio = new List<Funcionario>();
                foreach (Funcionario f in funcionarios)
                {
                    if (f.Tipo == 'G')
                    {
                        retornaFuncio.Add(f);
                    }
                }
                return retornaFuncio;
            }
            else
            {
                throw new Exception("A lista está vazia");
            }
        }
        /// <summary>
        /// Procura um funcionário através do codigo do funcionário se o encontrar o devolve caso contrário devolve null
        /// </summary>
        /// <param name="codigoFuncionario"></param>
        /// <returns></returns>
        static public Funcionario Find(int codigoFuncionario)
        {
           return  funcionarios.Find(x => x.Codigo == codigoFuncionario);

        }
        /// <summary>
        /// Apaga todos os dados da lista
        /// </summary>
        static public void Deletar()
        {
            funcionarios.Clear();
        }

    }
}
