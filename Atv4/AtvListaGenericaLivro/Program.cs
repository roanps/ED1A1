using AtvListaGenericaLivro;

List <Livro> livros = new List<Livro>();

do {
    Console.WriteLine("Opções:\n 1 - Exibir Livros\n 2 - Adicionar livros\n 3 - Ver livro com maior número de páginas");
    int? opcao = Console.ReadLine();
    if(opcao == 1){
        foreach(Livro l in livros){
            Console.WriteLine(l.Nome);
            Console.WriteLine(l.Editora);
            Console.WriteLine(l.Autor);
            Console.WriteLine(l.Paginas);
        }
    }else if(opcao == 2){
        livros.Add(new Livro(){
            Nome = "A",
            Editora = "B",
            Autor = "C",
            Paginas = 30
        });
        livros.Add(new Livro(){
            Nome = "E",
            Editora = "F",
            Autor = "G",
            Paginas = 50
        });
        livros.Add(new Livro(){
            Nome = "H",
            Editora = "I",
            Autor = "J",
            Paginas = 37
        });
        livros.Add(new Livro(){
            Nome = "K",
            Editora = "L",
            Autor = "M",
            Paginas = 62
        });
        livros.Add(new Livro(){
            Nome = "N",
            Editora = "O",
            Autor = "P",
            Paginas = 43
        });

    }else if(opcao == 3){

    }else{
        Console.WriteLine("Opção Inválida! Programa encerrado");
    }
}while(true);