int numero, pares = 0, impares = 0;

for(int i = 0; i < 10; i++)
{
    Console.WriteLine("Digite um numero inteiro: ");
    numero = int.Parse(Console.ReadLine()!);
    if (numero % 2 == 0){
        Console.WriteLine("O numero é par!");
        pares++;
    }
    else {
        Console.WriteLine("O numero é impar!");
        impares++;
    }

}
    Console.WriteLine("Quantidade de numeros pares: " + pares);
    Console.WriteLine($"Quantidade de numeros impares: {impares}");