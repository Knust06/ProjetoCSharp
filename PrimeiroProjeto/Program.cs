// Musiquer
string msgBoasVindas = "Boas vindas ao Musiquer";



void Escrever(string msg)
    {
    Console.WriteLine(msg);
}
void EscreverAcao(string msg)
{
    Console.Write(msg);
}
void Opcaos()
    {
        string opcaoEscolhida = Console.ReadLine()!;
        int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida) ;
        if (opcaoEscolhidaNumerica == 1)
        {
            Escrever("Você digitou a opção " + opcaoEscolhida);
        }
        // ! no readline é para ser usado quando não queremos que o mesmo retorne valor nulo
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

    EscreverAcao("\nDigite a sua opção: ");

    Opcaos();

    }

ExibirBoasVindas();    

ExibirOpcoesMenu();