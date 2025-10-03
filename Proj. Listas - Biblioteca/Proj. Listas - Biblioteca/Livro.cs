using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj._Listas___Biblioteca
{
    public class Livro
    {
        private int isbn;
        private String titulo;
        private String autor;
        private String editora;
        private  List<Exemplar> exemplares;

       
        public int Isbn { get => isbn; set => isbn = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public string Autor { get => autor; set => autor = value; }
        public string Editora { get => editora; set => editora = value; }

        internal List<Exemplar> Exemplares { get => exemplares; set => exemplares = value; }

        public Livro(int isbn, string titulo, string autor, string editora)
        {
            this.isbn = isbn;
            this.titulo = titulo;
            this.autor = autor;
            this.editora = editora;
            this.exemplares = new List<Exemplar>();
        }

        public void adicionarExemplar(Exemplar Exemplares)
        {
            exemplares.Add(Exemplares);
        }
        public int qtdeExemplares()
        {
            return exemplares.Count;
        }

        public int qtdeDisponiveis()
        {
            int qnt = 0;

            foreach (var ex in exemplares)
            {
                if (ex.disponivel())
                {
                    qnt++;
                }
            }
            return qnt;
        }

        public int qtdeEmprestimos()
        {
            int qnt = 0;
            foreach (var ex in exemplares)
            {
                qnt += ex.qtdeEmprestimo();
                
            }
            return qnt;
        }

        public int percDisponibilidade()
        {
            return (qtdeDisponiveis() / qtdeExemplares()) * 100;
        }

      
    }
}
