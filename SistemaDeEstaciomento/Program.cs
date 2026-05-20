using SistemaDeEstaciomento;

decimal precoInicial = 0;
decimal precoHora = 0;
bool exibirMenu = true;

Console.WriteLine("Digite o valor inicial do estacionamento..: ");
precoInicial = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite o valor por hora do estacionamento..: ");
precoHora = Convert.ToDecimal(Console.ReadLine());

Estacionamento est = new Estacionamento(precoInicial, precoHora);

Console.WriteLine("Bem-vindo(a) ao estacionamento KN!");

while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine("Bem-vindo(a) ao estacionamento KN!");
    Console.WriteLine();
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Cadastrar veículo");
    Console.WriteLine("2 - Remover veículo");
    Console.WriteLine("3 - Listar veículos");
    Console.WriteLine("4 - Encerrar");

    switch (Console.ReadLine())
    {
        case "1":
            Console.Clear();
            est.CadastrarVeiculo();
            break;

        case "2":
            Console.Clear();
            est.RemoverVeiculo();
            break;

        case "3":
            Console.Clear();
            est.ListarVeiculos();
            break;

        case "4":
            exibirMenu = false;
            break;

        default:
            Console.WriteLine("Comando não encontrado...");
            break;
    }

    Console.WriteLine();
    Console.WriteLine("Pressione qualquer tecla para sair... ");
    Console.ReadKey();
}
Console.Clear();
Console.WriteLine("O programa se encerrou.");