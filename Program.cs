// Nesta aula vamos aplicar o seguinte projeto para gerenciamento de 10 produtos pelo console:

// Os produtos terão os seguintes atributos:
// string Nome
// float Preco
// bool Promocao (se está em promoção ou não)

// O sistema deverá ter as seguintes funcionalidades:
// CadastrarProduto
// ListarProdutos
// MostrarMenu
// Crie função(ões) para otimizar o código.
// Incremente o que achar necessário. Utilize sua lógica e sua criatividade.



bool promo = false;

Console.WriteLine($"Bem vindo ao programa produtos");


static string mostrarMenu()
{
    Console.WriteLine($"MENU");
    Console.WriteLine(@$"
            1-Cadastrar Produtos
              2- Listar Produtos
                 0- Sair");


    return Console.ReadLine();
}

mostrarMenu();

do
{
    switch (mostrarMenu())
    {
        case "1":
            Console.WriteLine($" ******************");
            Console.WriteLine($" ** Cadastre seu **");
            Console.WriteLine($" ***** Produto ****");

            for (var i = 0; i < 2; i++)
            {
                Console.WriteLine($"Insira o noem do produto:");
                string nome = Console.ReadLine();

                Console.WriteLine($"Insira o preço do produto:");
                float preco = float.Parse(Console.ReadLine());
                

                Console.WriteLine($"O prodtudo está em promoção ? s-Sim ou n-Não");
                string respostaPromo = Console.ReadLine();

                if (respostaPromo == "s")
                {
                    promo = true;
                    Console.WriteLine($"Está em promoção");

                }

                else if (respostaPromo == "n")
                {
                    promo = promo;

                    Console.WriteLine($"Não está em promoção");

                }
            }

            break;
            case "2":
            
        default:
            break;
    }

}
while (mostrarMenu() != "0");







