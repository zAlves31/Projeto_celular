using Projeto_Celular_Class;

Celular celular = new Celular();

Console.Write("Informe a cor do celular: ");
celular.Cor = Console.ReadLine();
    
Console.Write("Informe o modelo do celular: ");
celular.Modelo = Console.ReadLine();
    
Console.Write("Informe o tamanho do celular (em polegadas): ");
celular.Tamanho = double.Parse(Console.ReadLine());

Console.WriteLine("Características do celular:");
Console.WriteLine($"Cor: {celular.Cor}");
Console.WriteLine($"Modelo: {celular.Modelo}");
Console.WriteLine($"Tamanho: {celular.Tamanho} polegadas");

bool sair = false;
while (!sair) {
    Console.WriteLine("\nOpções disponíveis:");
    Console.WriteLine("1. Ligar");
    Console.WriteLine("2. Desligar");
    Console.WriteLine("3. Fazer ligação");
    Console.WriteLine("4. Enviar mensagem");
    Console.WriteLine("0. Sair");
    Console.Write("Digite a opção desejada: ");
    int opcao = int.Parse(Console.ReadLine());
    Console.WriteLine();

    switch (opcao) {
        case 1:
            celular.Ligar();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Ligando........");
            Console.ResetColor();
            Console.WriteLine();
            
            break;
        case 2:
            celular.Desligar();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Desligando........");
            Console.ResetColor();
            Console.WriteLine();
            break;
        case 3:
            Console.Write("Digite o número para fazer a ligação: ");
            string numeroLigacao = Console.ReadLine();
            Console.WriteLine();
            celular.FazerLigacao(numeroLigacao);
            break;
        case 4:
            Console.Write("Digite o número para enviar a mensagem: ");
            string numeroMensagem = Console.ReadLine();
            Console.Write("Digite a mensagem a ser enviada: ");
            string mensagem = Console.ReadLine();
            Console.WriteLine();
            celular.EnviarMensagem(numeroMensagem, mensagem);
            break;
        case 0:
            sair = true;
            break;
        default:
            Console.WriteLine("Opção inválida.");
            break;
    }
}

