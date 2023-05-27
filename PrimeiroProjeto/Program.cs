﻿// Musiquer
string msgBoasVindas = "Boas vindas ao Musiquer";



void Escrever(string msg)
    {
    Console.WriteLine(msg);
}
void EscreverAcao(string msg)
{
    Console.Write(msg);
}
void Opcoes()
    {
        // ! no readline é para ser usado quando não queremos que o mesmo retorne valor nulo
        string opcaoEscolhida = Console.ReadLine()!;
        int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida) ;

    switch (opcaoEscolhidaNumerica)
    {
        case 1: RegistrarBandas();
            break;
        case 2: Escrever("Você digitou a opção " + opcaoEscolhida);
            break;
        case 3:
            Escrever("Você digitou a opção " + opcaoEscolhida);
            break;
        case 4:
            Escrever("Você digitou a opção " + opcaoEscolhida);
            break;
        case 5:
            Escrever("Até mais :)");            
            break;
            
        default: Escrever("Opção inválida");
            break;

    }            
    // ! no readline é para ser usado quando não queremos que o mesmo retorne valor nulo
}

void RegistrarBandas()
{
    Console.Clear();
    Escrever("Registro de bandas");
    Escrever("Digite o nome da banda que deseja registrar");
    string nomeDaBanda = Console.ReadLine()!;
    Escrever($"A banda {nomeDaBanda} foi registrada com sucesso");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirOpcoesMenu();

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
    ExibirBoasVindas();
    Escrever("Digite 1 para registrar banda");
    Escrever("Digite 2 para mostrar todas as bandas");
    Escrever("Digite 3 para avaliar uma banda");
    Escrever("Digite 4 para exibir a média de uma banda");
    Escrever("Digite 5 para sair");

    EscreverAcao("\nDigite a sua opção: ");

    Opcoes();

    }  

ExibirOpcoesMenu();