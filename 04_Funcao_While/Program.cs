class SESI
{
    //Método Main é o ponto de entrada de um programa em C#
    public static void Main(){

    Console.WriteLine("Estou no método Main");
    Metodo();
    ImprimeDataHora();
    ImprimeDataHora();


    //chamando o método somar enviando os parâmetros 3 e 8
    int resultadoSoma = Somar(954, 8);
    Console.WriteLine(resultadoSoma);

    ContagemRegressiva(995);

    JogoQueNrSouEu();
}

 public static void Metodo(){
     Console.WriteLine("Estou no método / função");
 }
   
   public static void ImprimeDataHora(){
    Console.WriteLine(DateTime.Now.ToShortDateString());
    Console.WriteLine(DateTime.Now.Hour.ToString());
    Console.WriteLine(DateTime.Now.ToString());
}

 public static int Somar(int n1, int n2)
 {
    int soma = n1 + n2;
    return soma;

}

public static void ContagemRegressiva(int n){
    while (n >= 0){
        Console.WriteLine(n);
        n--; // n = n - 1; msm coisa de n--
        System.Threading.Thread.Sleep(1000); //Pausa de 1s - 1000ms
    }
      Console.WriteLine("CABO O ALMOÇO");
}

public static void JogoQueNrSouEu(){
    Console.WriteLine("***");
    Console.WriteLine("       Bem Vindo ao Jogo     ");
    Console.WriteLine("Sortei um n* de 1 a 20, tente adivinha-lo");
    Console.WriteLine("****");
    Console.WriteLine(""); //Linha em branco

    Random rnd = new Random();
    int nrSorteado = rnd.Next(20);
    int nrDigitado = -1;

    do{
        Console.WriteLine("Digite um n*");
        nrDigitado = int.Parse(Console.ReadLine());
        if (nrDigitado > nrSorteado)
          Console.WriteLine("O número digitado é MAIOR que o sorteado");
        else inf (nrDigitado < nrSorteado)
          Console.WriteLine("O numero digitado é MENOR que o sorteado")
          } while (nrDigitado != nrSorteado);


          Console.WriteLine("Parabens voce acertou");
          
}

}