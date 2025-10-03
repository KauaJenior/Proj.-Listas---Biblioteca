using System;
using System.Collections.Generic;
using Proj._Listas___Biblioteca;

namespace Proj._Listas___Biblioteca
{
    class Program
    {
        static void Main(string[] args)
        {
            Livros acervo = new Livros();
            bool sair = false;

            while (!sair)
            {
                Console.WriteLine("\n--- MENU ---");
                Console.WriteLine("0. Sair");
                Console.WriteLine("1. Adicionar livro");
                Console.WriteLine("2. Pesquisar livro (sintético)");
                Console.WriteLine("3. Pesquisar livro (analítico)");
                Console.WriteLine("4. Adicionar exemplar");
                Console.WriteLine("5. Registrar empréstimo");
                Console.WriteLine("6. Registrar devolução");
                Console.Write("Escolha uma opção: ");

                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "0":
                        sair = true;
                        break;

                    case "1":
                        Console.Write("ISBN: ");
                        int isbn = int.Parse(Console.ReadLine());
                        Console.Write("Título: ");
                        string titulo = Console.ReadLine();
                        Console.Write("Autor: ");
                        string autor = Console.ReadLine();
                        Console.Write("Editora: ");
                        string editora = Console.ReadLine();

                        Livro livro = new Livro(isbn, titulo, autor, editora);
                        acervo.adicionar(livro);

                        Console.WriteLine("Livro adicionado!");
                        break;

                    case "2":
                        Console.Write("ISBN do livro para pesquisa: ");
                       int buscaTitulo = int.Parse(Console.ReadLine());
                        Livro livroSint = acervo.pesquisar(buscaTitulo);
                        if (livroSint != null)
                        {
                            Console.WriteLine($"\nTítulo: {livroSint.Titulo}");
                            Console.WriteLine($"Autor: {livroSint.Autor}");
                            Console.WriteLine($"Editora: {livroSint.Editora}");
                            Console.WriteLine($"Total de Exemplares: {livroSint.qtdeExemplares()}");
                            Console.WriteLine($"Disponíveis: {livroSint.qtdeDisponiveis()}");
                            Console.WriteLine($"Total de Empréstimos: {livroSint.qtdeEmprestimos()}");
                            Console.WriteLine($"% Disponibilidade: {livroSint.percDisponibilidade():F2}%");
                        }
                        else
                        {
                            Console.WriteLine("Livro não encontrado.");
                        }
                        break;

                    case "3":
                        Console.Write("ISBN do titulo para pesquisa: ");
                        int buscaTitulo2 = int.Parse(Console.ReadLine());
                        Livro livroAnalit = acervo.pesquisar(buscaTitulo2);
                        if (livroAnalit != null)
                        {
                            Console.WriteLine($"\nTítulo: {livroAnalit.Titulo}");
                            Console.WriteLine($"Autor: {livroAnalit.Autor}");
                            Console.WriteLine($"Editora: {livroAnalit.Editora}");
                            Console.WriteLine($"Total de Exemplares: {livroAnalit.qtdeExemplares()}");
                            Console.WriteLine($"Disponíveis: {livroAnalit.qtdeDisponiveis()}");
                            Console.WriteLine($"Total de Empréstimos: {livroAnalit.qtdeEmprestimos()}");
                            Console.WriteLine($"% Disponibilidade: {livroAnalit.percDisponibilidade():F2}%");

                            Console.WriteLine("\n--- Detalhes dos Exemplares ---");
                            foreach (var ex in livroAnalit.Exemplares)
                            {
                                Console.WriteLine($"Tombo: {ex.Tombo}, Disponível: {ex.disponivel()}, Total Empréstimos: {ex.qtdeEmprestimo()}");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Livro não encontrado.");
                        }
                        break;

                    case "4":
                        Console.Write("ISBN do livro: ");
                        int isbnEx = int.Parse(Console.ReadLine());
                        Livro livroEx = acervo.pesquisar(isbnEx);
                        if (livroEx != null)
                        {
                            Console.Write("Número do tombo do exemplar: ");
                            int tombo = int.Parse(Console.ReadLine());
                            Exemplar ex = new Exemplar(tombo);
                            livroEx.adicionarExemplar(ex);
                            Console.WriteLine("Exemplar adicionado!");
                        }
                        else
                        {
                            Console.WriteLine("Livro não encontrado.");
                        }
                        break;

                    case "5":
                        Console.Write("ISBN do livro: ");
                        int isbnEmp = int.Parse(Console.ReadLine());
                        Livro livroEmp = acervo.pesquisar(isbnEmp);
                        if (livroEmp != null)
                        {
                            Console.Write("Número do tombo do exemplar: ");
                            int tomboEmp = int.Parse(Console.ReadLine());
                            Exemplar exEmp = livroEmp.Exemplares.Find(e => e.Tombo == tomboEmp);
                            if (exEmp != null && exEmp.disponivel())
                            {
                                exEmp.emprestar();
                                Console.WriteLine("Empréstimo registrado!");
                            }
                            else
                            {
                                Console.WriteLine("Exemplar não disponível.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Livro não encontrado.");
                        }
                        break;

                    case "6":
                        Console.Write("ISBN do livro: ");
                        int isbnDev = int.Parse(Console.ReadLine());
                        Livro livroDev = acervo.pesquisar(isbnDev);
                        if (livroDev != null)
                        {
                            Console.Write("Número do tombo do exemplar: ");
                            int tomboDev = int.Parse(Console.ReadLine());
                            Exemplar exDev = livroDev.Exemplares.Find(e => e.Tombo == tomboDev);
                            if (exDev != null && exDev.devolver())
                            {
                                Console.WriteLine("Devolução registrada!");
                            }
                            else
                            {
                                Console.WriteLine("Não foi possível devolver o exemplar.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Livro não encontrado.");
                        }
                        break;

                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
            }
        }
    }
}
