using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj._Listas___Biblioteca
{
    public class Exemplar
    {
        private int tombo;
        private List<Emprestimo> emprestimos;

        public int Tombo { get => tombo; set => tombo = value; }
        public List<Emprestimo> Emprestimos { get => emprestimos; set => emprestimos = value; }

        public Exemplar(int tombo)
        {
            this.tombo = tombo;
            this.emprestimos = new List<Emprestimo>();
        }

        public bool emprestar()
        {
            if (disponivel())
            {
             Emprestimo em1 = new Emprestimo(DateTime.Now, DateTime.Now.AddDays(15));

                emprestimos.Add(em1);

                return true;
            }
            else
            {
                return false;
            }
        }




        public bool devolver()
        {
            foreach (var em in emprestimos)
            {
                
                if (em.DtDevolucao == null || em.DtDevolucao == DateTime.MinValue)
                {
                    em.DtDevolucao = DateTime.Now; 
                    return true; 
                }
            }
            return false; 
        }

        public bool disponivel()
        {
            
            foreach (var em in emprestimos)
            {
                
                if (em.DtDevolucao  == null || em.DtDevolucao == DateTime.MinValue) 
        {
                   
                    return false;
                }
            }

            
            return true;
        }


        public int qtdeEmprestimo()
        {
            return emprestimos.Count;
        }

        

    }
}
