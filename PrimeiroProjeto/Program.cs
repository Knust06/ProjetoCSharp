// Musiquer
string msgBoasVindas = "Boas vindas ao Musiquer";


void ExibirBoasVindas()
    {
        Console.WriteLine
        (@"
            ███╗░░░███╗██╗░░░██╗░██████╗██╗░██████╗░██╗░░░██╗███████╗██████╗░
            ████╗░████║██║░░░██║██╔════╝██║██╔═══██╗██║░░░██║██╔════╝██╔══██╗
            ██╔████╔██║██║░░░██║╚█████╗░██║██║██╗██║██║░░░██║█████╗░░██████╔╝
            ██║╚██╔╝██║██║░░░██║░╚═══██╗██║╚██████╔╝██║░░░██║██╔══╝░░██╔══██╗
            ██║░╚═╝░██║╚██████╔╝██████╔╝██║░╚═██╔═╝░╚██████╔╝███████╗██║░░██║
            ╚═╝░░░░░╚═╝░╚═════╝░╚═════╝░╚═╝░░░╚═╝░░░░╚═════╝░╚══════╝╚═╝░░╚═╝
        ");
        Console.WriteLine(msgBoasVindas);
    }

void ExibirOpcoesMenu()
    {
    Console.WriteLine("Digite 1 para registrar banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite 5 para sair");

    }

ExibirBoasVindas();    

ExibirOpcoesMenu();