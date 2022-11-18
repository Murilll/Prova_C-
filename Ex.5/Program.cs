using System;
using System.IO;

List<Cliente> listCliente = new List<Cliente>();
List<Produto> listProduto = new List<Produto>();

string nome = string.Empty;
bool premiun = false;
int dia = -1;

//Vou completar esta bela obra semana que vem,
//se não for demitido né vai que kkkk
//caracteres úteis: ─│┌┐└┘├┤┬┴┼
Console.WriteLine("┌───┐ ┌───┐");
Console.WriteLine("│┌─┐│ │┌─┐│");
Console.WriteLine("│└─┘│ ││ ││");
Console.WriteLine("│ ┌─┘ ││ ││");
Console.WriteLine("│ └─┐ ││ ││");
Console.WriteLine("│┌─┐│ ││ ││");
Console.WriteLine("│└─┘│ │└─┘│");
Console.WriteLine("└───┘ └───┘");
Console.WriteLine("\t\tTecnologia para a vida");
Console.WriteLine("");
Console.WriteLine("Pressione qualquer tecla para começar...");
Console.ReadKey(true);


bool running = true; 
while (running)
{
    Console.Clear();
    Console.WriteLine("O que você quer fazer?");
    Console.WriteLine("1 - Cadastrar Novo cliente");
    Console.WriteLine("2 - Ler dados do cliente");
    Console.WriteLine("3 - Cadastrar Novo produto");
    Console.WriteLine("4 - Ler dados do produto");
    Console.WriteLine("5 - Sair");
    int id = int.Parse(Console.ReadLine());
    switch(id)
    {
        case 1:
            Console.Write("Digite o nome do Cliente:");
            string nomeCliente = Console.ReadLine();
            Console.Write("Você possui conta premium? s/n:");
            string premiumyes = Console.ReadLine();
                if (premiumyes == 's')
                premiun = true;
                 
            Console.Write("Digite o dia do seu nascimento:");
            int dianas = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o mês do seu nascimento:");
            int mesnas = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o ano do seu nascimento:");
            int anonas = Convert.ToInt32(Console.ReadLine());
            listCliente.Add(new Cliente() {Nome = nomeCliente,
                                        DiaNascimento = dianas,
                                        MesNascimento = mesnas,
                                        AnoNascimento = anonas});

            Cliente cliente = new Cliente(nome, premiun, dia, -1, -1);
            cliente.Save();
            break;

        case 2:
            Console.WriteLine("Dados do Cliente");
            foreach (var item in listCliente)
            {
                Console.WriteLine($"Nome - {item.Nome}     Premium - {item.Premium}     Dia/Nascimento - {item.DiaNascimento}/{item.MesNascimento}/{item.AnoNascimento}");
            }
            Console.WriteLine("\nDigite qualquer coisa para sair dos dados.");
            string sair = Console.ReadLine();
                break;

        case 3:
            Console.WriteLine("Digite o Nome do novo produto:");
            string nomeProduto = Console.ReadLine();

            Console.WriteLine("Digite o Código do novo produto:");
            int codProduto = Convert.ToInt32(Console.ReadLine());

            listProduto.Add(new Produto() {Nome = nomeProduto,
                                        Codigo = codProduto});

                break;

        case 4:
            Console.WriteLine("Dados do Produto");
            foreach (var item in listProduto)
            {
                Console.WriteLine($"Nome - {item.Nome}     Cod - {item.Codigo}");
            }
            Console.WriteLine("\nDigite qualquer coisa para sair dos dados.");
            string sair1 = Console.ReadLine();
                break;


        case 5:
        Console.WriteLine("Console Fechado");
            running = false;
            break;
    }
}