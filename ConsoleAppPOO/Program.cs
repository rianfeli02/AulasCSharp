using ConsoleAppPOO.Controller;
using ConsoleAppPOO.Model;

/*
Produto produto = new Produto();
List<Produto> listaProduto = new List<Produto>();


produto.Id = 1;
produto.Descricao = "Bola";

Console.WriteLine(produto.Descricao);
// apresentar apaenas um produto
//produto.Apresentar(produto);

listaProduto.Add(produto);

produto = new Produto();
produto.Id = 2;
produto.Descricao = "chuteira";


listaProduto.Add(produto);
// contrutor com parametros
Produto produto2 = new Produto( 3, "luva");
listaProduto.Add(produto2);


produto.ApresentarLista(listaProduto);
*/


Bolacontroller controller = new Bolacontroller();
List<Bola> lista = new List<Bola>();

Bola bola = new Bola(1, "Topper" , 150m);
lista = controller.Adicionar(bola);

bola = new Bola(2, "Adidas", 300m);
lista = controller.Adicionar(bola);

controller.Lista(lista);




