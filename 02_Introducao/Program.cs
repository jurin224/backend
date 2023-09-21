// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("seja bem vindo ao segundo semestre");

//somente declaramos a variavel como inteira e atribuimos valor
int num1;

//Declarando uma variavel do tipo string
int num2 = 5;

//variavel do tipo decimal - mais usada para valor monetario
decimal valor = 1.80M;

int idade= 16;
string nome = "Julio";
Console.WriteLine($"Meu nome é {nome} e tenho {idade} anos");

Console.WriteLine("Em que cidade voce mora?");
//recebendo uma informação do usuario na variavel 
string cidade = Console.ReadLine();
Console.WriteLine($"Voce nasceu em {cidade}");

int novaIdade = idade + 5;
int anoNascimento = 2903 - idade;
Console.WriteLine($"Voce nasceu em {anoNascimento}e dequi 5 anos terá {novaIdade}");
