Console.WriteLine("Digital o valor de x.");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("D:gite o valor de y:");
int y = int.Parse(Console.ReadLine());

//Exemplo de operadores aritimedicos
int soma = x + y;
int subtracao = x - y;
int multiplicacao = x * y;
int divisao = x / y;
int resto = x % y;
int restoiv2 = x % 2;

Console.WriteLine("Some:" + soma);
Console.WriteLine("Subtração:" + subtracao);
Console.WriteLine("Multiplicação:" + multiplicacao);
Console.WriteLine("Divisão:" + divisao);
Console.WriteLine("Restor:" + resto);


if (restoiv2 == 0)
{
    Console.WriteLine{$"{x} é par"}
} else {
    Console.WriteLine  ($"{x} é impar");
}

OperatingSystem string ePar = (restoiv2 == 0) ? "par": "impar" ;

