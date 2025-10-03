# Sistema de Biblioteca Console - C#

## Descrição
Este projeto é uma aplicação **Console em C#** que simula o gerenciamento de uma biblioteca.  
Permite cadastrar livros, adicionar exemplares, registrar empréstimos e devoluções, e consultar informações do acervo de forma sintética ou analítica.

---

## Funcionalidades

- **Adicionar livro**: cadastra livros com ISBN, título, autor e editora.
- **Pesquisar livro (sintético)**: mostra dados básicos do livro, quantidade de exemplares, exemplares disponíveis, total de empréstimos e percentual de disponibilidade.
- **Pesquisar livro (analítico)**: além das informações sintéticas, exibe detalhes de cada exemplar e seus empréstimos.
- **Adicionar exemplar**: permite adicionar um exemplar a um livro já cadastrado, com número de tombo único.
- **Registrar empréstimo**: permite emprestar um exemplar disponível.
- **Registrar devolução**: permite devolver um exemplar emprestado, tornando-o disponível novamente.

---

## Estrutura do Projeto

### Classes Principais

- **Livro**
  - Atributos: `isbn`, `titulo`, `autor`, `editora`, `exemplares`
  - Métodos: `adicionarExemplar()`, `qtdeExemplares()`, `qtdeDisponiveis()`, `qtdeEmprestimos()`, `percDisponibilidade()`

- **Exemplar**
  - Atributos: `tombo`, `emprestimos`
  - Métodos: `emprestar()`, `devolver()`, `disponivel()`, `qtdeEmprestimos()`

- **Emprestimo**
  - Atributos: `dtEmprestimo`, `dtDevolucao`

- **Livros**
  - Atributos: `acervo`
  - Métodos: `adicionar()`, `pesquisar()`

---




