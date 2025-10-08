float lado1, lado2, lado3;
Console.WriteLine("Digite o valor do lado 1:");
lado1 = float.Parse(Console.ReadLine()!);
Console.WriteLine("Digite o valor do lado 2:");
lado2 = float.Parse(Console.ReadLine()!);
Console.WriteLine("Digite o valor do lado 3:");
lado3 = float.Parse(Console.ReadLine()!);

if ((lado1 < (lado2 + lado3)) && (lado2 < (lado1 + lado3)) && (lado3 < (lado1 + lado2)))
{
    if ((lado1 == lado2) && (lado2 == lado3))
    {
        Console.WriteLine("Triangulo Equilatero!");
    }
    else if ((lado1 == lado2) || (lado2 == lado3) || (lado1 == lado3))
    {
        Console.WriteLine("Triangulo Isosceles");
    }
    else
    {
        Console.WriteLine("Triangulo Escaleno");
    }
}
else
{
    Console.WriteLine("Os valores informados não formam um triângulo.");
    return;
}