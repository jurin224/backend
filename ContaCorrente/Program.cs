using Caixa;

public class Program
{
  public static void Main()
  {
    Console.Clear();

    Menu();
  }

  public static void Menu()
  {
    Console.WriteLine("Titular da sua conta");
    string Titular = Console.ReadLine();
    Console.WriteLine($"Seja bem vindo ao sistema {Titular}");
    ContaCorrente conta = new ContaCorrente(Titular);

    string opcao = "";



    do
    {
      Console.WriteLine("####### M E N U #########");
      Console.WriteLine("1- Consultar saldo");
      Console.WriteLine("2- Depositar");
      Console.WriteLine("3- Sacar");
      Console.WriteLine("0- Para fechar sistema");
      opcao = Console.ReadLine();
      Console.Clear();

      switch (opcao)
      {
        case "0":
          Console.WriteLine("Obrigado");
          System.Threading.Thread.Sleep(2000);
          break;
        case "1":
          conta.VerSaldo();
          break;
        case "2":
          Console.WriteLine("Informe o valor a ser depositado");
          decimal valor = decimal.Parse(Console.ReadLine());
          conta.Depositar(valor);
          break;
        case "3":
          Console.WriteLine("Valor a Depositar");
          conta.Retirar(decimal.Parse(Console.ReadLine()));
          break;
        default:
          Console.WriteLine("Opçao inválida");
          break;
      }
    } while (opcao != "0");
  }
}                                                     //na marcha lenta e a vida sempre acelerada 
