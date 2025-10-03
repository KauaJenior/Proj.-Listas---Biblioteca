using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Proj._Listas___Biblioteca
{
    public class Livros
    {
        private List<Livro> acervo;

        public List<Livro> Acervo { get => acervo; set => acervo = value; }


        public Livros() { acervo = new List<Livro>(); }

        public void adicionar(Livro livro)
        {
            acervo.Add(livro);
        }

        public Livro pesquisar(int isbn)
            {

            foreach (var livro1 in acervo)
            {
                if (livro1.Isbn == isbn)
                {
                    return livro1;
                }   
            }
            return null;
    
            }
    }
}
