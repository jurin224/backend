class Program
{
    public static void Main()
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"Estou passando pela {i}ª vez no bloco");
        }

        //Criando uma tabuada utilizando o for
        int num = 5;
        for (int cont = 1; cont <= 10; cont++)
        {
            //num é variável que estou gerando a tabuada
            //cont é a variável contadora até 10
            Console.WriteLine($"{num} x {cont} = {cont * num}");
        }

        //Declarando um vetor do tipo inteiro com 4 espaços
        int[] notas = new int[4];
        //Declarando um vetor atribuido valores
        string meses = {"Jan", "Fev"};

        int nota1 = 10;
        int nota2 = 8;
        int nota3 = 7;
        int nota4 = 9;
        int [] notas = {10, 8, 7, 9};

        alunos[3] = 7;
        alunos[0] = 20;
        alunos[2] = 8;
        alunos[1] = 12;

        int soma = 0;
        int maior = 0;
        int menor = 10000;

        for (int i = 0; i < alunos.Length; i++){
            foreach (int douglas in alunos){
                soma = soma + douglas;
                if (douglas > maior){
                    maior = douglas;
                }
                if (douglas < menor){
                    menor = douglas;
                }
            }
        }
        Console.WriteLine($"Soma é {soma} o maior é {maior} e o menor é {menor}");
        Array.Sort(alunos);
            for (int i = 0; i < alunos.Length; i++){
                Console.WriteLine($"Aluno na posição {i} tem o valor {alunos[]}")
            }
    }
}