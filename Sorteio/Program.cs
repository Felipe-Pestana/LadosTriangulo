int palpite, sorteado;


Random aleatorio = new Random();
sorteado = aleatorio.Next(1, 51);

do
{
    Console.WriteLine("Informe o numero do palpite: ");
    palpite = int.Parse(Console.ReadLine()!);

    if(palpite < sorteado)
        Console.WriteLine("Errou! O palpite é menor que o numero sorteado!");
    else if(palpite > sorteado)
        Console.WriteLine("Errou! O palpite é maior que o numero sorteado!");

} while (palpite != sorteado);
Console.WriteLine("Parabéns, você acertou o número sorteado: " + sorteado);