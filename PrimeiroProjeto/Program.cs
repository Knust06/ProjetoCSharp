// Musiquer

string msgBoasVindas = "Boas vindas ao Musiquer";

//List<string> listaDasBandas = new List<string> { "NEFFEX", "Beatles", "Machine Gun Kelly" };

Dictionary<string, List<int>> bandas = new Dictionary<string, List<int>>();
bandas.Add("Linkin Park", new List<int> { 10, 5, 9});
bandas.Add("NEFFEX", new List<int> ());

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
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaNumerica)
    {
        case 1: RegistrarBandas();
            break;
        case 2:
            ExibirBandasRegistradas();
            break;
        case 3:
            AvaliarBanda();
            break;
        case 4:
            MediaBanda();
            break;
        case 5:
            Escrever("Até mais :)");            
            break;
            
        default: Escrever("Opção inválida");
            break;

    }            
    // ! no readline é para ser usado quando não queremos que o mesmo retorne valor nulo
}

void MostraTitulo(string titulo)
{
    int quantidadeCaracteres = titulo.Length;
    string estrelas = string.Empty.PadLeft(quantidadeCaracteres, '*');
    Escrever(estrelas);
    Escrever(titulo);
    Escrever(estrelas + "\n");
}

void RegistrarBandas()
{
    Console.Clear();
    MostraTitulo("Registro das bandas");
    //Escrever("****************************");
    //Escrever("Registro de bandas");
    //Escrever("****************************\n");
    Escrever("Digite o nome da banda que deseja registrar");
    string nomeDaBanda = Console.ReadLine()!;
    Escrever($"A banda {nomeDaBanda} foi registrada com sucesso");
    //listaDasBandas.Add(nomeDaBanda);
    bandas.Add(nomeDaBanda, new List<int>());
    Thread.Sleep(3000);
    Console.Clear();
    ExibirOpcoesMenu();
}

void ExibirBandasRegistradas()
{
    Console.Clear();
    MostraTitulo("Exibindo as bandas registradas");
    //Escrever("******************************");
    //Escrever("Exibindo as bandas registadas");
    //Escrever("******************************\n");
    //for (int i = 0; i < listaDasBandas.Count; i++)
    //{
    //    Escrever($"Banda: {listaDasBandas[i]}");
    //}

    foreach(string banda in bandas.Keys)
    {
        Escrever($"Banda: {banda}");
    }
    Escrever("\nAperte em qualquer tecla para voltar ao menu principal");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesMenu();
}

void AvaliarBanda()
{
    //Digitar a banda a ser avaliada
    //Ver se a banda existe no dicionário >> atribuir uma nota
    // "else" volta ao menu principal
    Console.Clear();
    MostraTitulo("Avalie a banda");
    EscreverAcao("Digite o nome da banda que deseja avaliar: ");
    string nomeBanda = Console.ReadLine()!;
    if (bandas.ContainsKey(nomeBanda))
    {
        EscreverAcao($"Qual a nota que a banda {nomeBanda} você deseja atribuí-la ? ");
        int nota = int.Parse(Console.ReadLine()!);
        bandas[nomeBanda].Add(nota);
        Escrever($"\nA nota {nota} foi registrada para a banda {nomeBanda}");
        Thread.Sleep(2000);
        Console.Clear();
        ExibirOpcoesMenu();
    }
    else
    {
        Escrever($"\nA banda {nomeBanda} não foi encontrada :( ");
        Escrever("Digite qualquer tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesMenu();        
    }
        
}
void MediaBanda()
{
    Console.Clear();
    MostraTitulo("Media das bandas");
    Escrever("Digite a banda que deseja ver a média: ");
    string nomeBanda = Console.ReadLine()!;
    if (bandas.ContainsKey (nomeBanda))
    {
        List<int> notasBanda = bandas[nomeBanda];
        Escrever($"A média da banda {nomeBanda} é {notasBanda.Average()}");
        Escrever("Digite qualquer tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();       
        ExibirOpcoesMenu();
    }
    else
    {
        Escrever($"\nA banda {nomeBanda} não foi encontrada :( ");
        Escrever("Digite qualquer tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesMenu();
    }
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