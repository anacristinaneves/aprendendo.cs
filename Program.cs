//Jogo de Advinha 

using System.ComponentModel.Design;

Random aleatorio = new Random();
int numeroSecreto = aleatorio.Next(1, 101);

do {
    Console.WriteLine ("Digite um número entre 1 e 100: ");
    int chute = int.Parse(Console.ReadLine());

    if (chute == numeroSecreto){
        Console.WriteLine($"Você acertou! O número era {numeroSecreto} ");
        break;
    } else if (chute < numeroSecreto){
        Console.WriteLine("O número secreto é maior.");
    } else {
        Console.WriteLine("O número é menor");
    }

} while (true);

Console.WriteLine("Parabéns! O jogo acabou!");