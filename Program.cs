// See https://aka.ms/new-console-template for more information


Console.Write("Qual o tamanho do arquivo? ");
int tamArq = int.Parse(Console.ReadLine());
Console.Write("Qual a velocidade da conexão? ");
double velocidade = double.Parse(Console.ReadLine());
double tempo = tamArq / velocidade;
Console.WriteLine("O tempo de download é de " + tempo.ToString("F2") + " segundos" );
