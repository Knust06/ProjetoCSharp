// Musiquer
string msgBoasVindas = "Boas vindas ao Musiquer";



void Escrever(string msg)
    {
    Console.WriteLine(msg);
}


void ExibirBoasVindas()
    {
    Escrever
    (@"
            ███╗░░░███╗██╗░░░██╗░██████╗██╗░██████╗░██╗░░░██╗███████╗██████╗░
            ████╗░████║██║░░░██║██╔════╝██║██╔═══██╗██║░░░██║██╔════╝██╔══██╗
            ██╔████╔██║██║░░░██║╚█████╗░██║██║██╗██║██║░░░██║█████╗░░██████╔╝
            ██║╚██╔╝██║██║░░░██║░╚═══██╗██║╚██████╔╝██║░░░██║██╔══╝░░██╔══██╗
            ██║░╚═╝░██║╚██████╔╝██████╔╝██║░╚═██╔═╝░╚██████╔╝███████╗██║░░██║
            ╚═╝░░░░░╚═╝░╚═════╝░╚═════╝░╚═╝░░░╚═╝░░░░╚═════╝░╚══════╝╚═╝░░╚═╝
        ");
    Escrever(msgBoasVindas);
    }

void ExibirOpcoesMenu()
    {
    Escrever("Digite 1 para registrar banda");
    Escrever("Digite 2 para mostrar todas as bandas");
    Escrever("Digite 3 para avaliar uma banda");
    Escrever("Digite 4 para exibir a média de uma banda");
    Escrever("Digite 5 para sair");

    }

ExibirBoasVindas();    

ExibirOpcoesMenu();