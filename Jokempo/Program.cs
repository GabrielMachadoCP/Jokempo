using System;

Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.WriteLine("😀 Olá! Vamos jogar Jokempo?");
Console.WriteLine("1 - Sim ou 0 - Não");
if (Console.ReadKey().KeyChar == '1')
{
    Console.WriteLine("\n\nEntão vamos começar... Escolha uma opção:");
    Console.WriteLine("\n0 - Pedra, \n1 - Papel  \n2 - Tesoura");
    var opcao = Console.ReadKey().KeyChar;
    int escolha = Convert.ToInt32(opcao.ToString());
    Random random = new Random();
    int jogadaComputador = (int)random.Next(0, 3);

    //Jogador vencendo
    if (jogadaComputador == 0 && escolha == 1 || jogadaComputador == 1 && escolha == 2 || jogadaComputador == 2 && escolha == 0)
    {
        Console.WriteLine($"\n\nParabéns você Venceu!\n\nEscolha do Adversário:{jogadaComputador}\nSua Escolha:{escolha}");
    }
    //Jogador Perdendo
    else if (jogadaComputador == 0 && escolha == 2 || jogadaComputador == 1 && escolha == 0 || jogadaComputador == 2 && escolha == 1)
    {
        Console.WriteLine($"\n\nNão foi dessa vez! Você Perdeu!\n\nEscolha do Adversário:{jogadaComputador}\nSua Escolha:{escolha}");
    }
    //Empate
    else { Console.WriteLine($"\n\nEssa rodada deu empate!\n\nEscolha do Adversário:{jogadaComputador}\nSua Escolha:{escolha}"); }

}
else { Console.WriteLine("Tchau! Jogamos depois!"); }
