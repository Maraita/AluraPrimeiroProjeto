// Screen Sound
string mensagemDeBoasVindas = "Boas vindas ao Screen Sound";
//ExibirMensagemDeBoasVindas();
//ExibirOpcoesDoMenu();
List<string> listaDasBandas = new List<string> { "U2", "Beatles", "Deep Purple", "Yes", "Dire Straits", "Calypso"};
void ExibirLogo()
{
    Console.WriteLine(@"

█▀ █▀▀ █▀█ █▀▀ █▀▀ █▄░█   █▀ █▀█ █░█ █▄░█ █▀▄
▄█ █▄▄ █▀▄ ██▄ ██▄ █░▀█   ▄█ █▄█ █▄█ █░▀█ █▄▀");

    //Console.WriteLine();
    Console.WriteLine(mensagemDeBoasVindas);
}
void ExibirOpcoesDoMenu()
{
  ExibirLogo();
  Console.WriteLine("\nDigite 1 para registrar uma banda");
  Console.WriteLine("Digite 2 para mostrar todas as bandas");
  Console.WriteLine("Digite 3 para avaliar uma banda");
  Console.WriteLine("Digite 4 para exibir a média de uma banda");
  Console.WriteLine("Digite -1 para sair");

  Console.Write("\nDigite a sua opção:  ");
  string opcaoEscolhida = Console.ReadLine()!;
  
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);
  
    switch (opcaoEscolhidaNumerica)
    {
        case 1: RegistrarBanda();
            break;
        case 2: MostrarBandasRegistradas();
            break;
        case 3: Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaNumerica);
            break;
        case 4: Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaNumerica);
            break;
        case -1: Console.WriteLine("Tchau Tchau :)");
            break;
        default: Console.WriteLine("Opção Inválida");
            break;
    }
    //teste

}

void RegistrarBanda()
{
    Console.Clear();
    Console.WriteLine("*********************");
    Console.WriteLine("Registro de bandas");
    Console.WriteLine("*********************\n");
    Console.Write("Digite o nome da banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    listaDasBandas.Add(nomeDaBanda);
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
    Thread.Sleep(2000);
    Console.Clear();
    //ExibirLogo();
    ExibirOpcoesDoMenu();
 }

void MostrarBandasRegistradas()
{

    Console.Clear();
    Console.WriteLine("***************************************");
    Console.WriteLine("Exibindo todas as bandas registradas");
    Console.WriteLine("***************************************\n");
    
    //for (int i = 0; i < listaDasBandas.Count; i++)
    //{
        //Console.WriteLine($"Banda: {listaDasBandas[i]}");
    //}

    foreach (string banda in listaDasBandas)
    {
        Console.WriteLine($"Banda: {banda}");

    }


    Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();

}


//ExibirLogo();
ExibirOpcoesDoMenu();