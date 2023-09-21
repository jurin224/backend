class Program
{
public static string[] poltronas = new string[14];
    public static void Main()
    {
        Console.Clear();
        Console.WriteLine("Bem-Vindo ao US-BRUTUS-TUR");
        Console.WriteLine("----");
        Console.WriteLine("Temo 13 lugar disponeveis");
        
        Menu();
    }

    public static void Menu(){
        string opcao = "";

    do{
        Console.WriteLine("####");
        Console.WriteLine("1 - Para comprar passagem");
        Console.WriteLine("2 - Para banco disponivel");
        Console.WriteLine("3 - Quantidade Disponivel");
        Console.WriteLine("0 - Para fechar sistema");
        opcao = Console.ReadLine();
        Console.Clear();

        switch (opcao){
            case "0":
                Console.WriteLine("Obrigado, volte sempre !!!");
                System.Threading.Thread.Sleep(2000);
                break;
                case "1":
                ComprarPassagem();
                break;
                case "2":
                PoltronasDisponiveis();
                break;
                case "3":
                QuantidadeDisponivel();
                break;
                default:
                Console.WriteLine("Opçao invalida !!");
                break;
        }
        
    } while (opcao != "0");

    }
    public static void ComprarPassagem(){
        Console.WriteLine("Quantas passagens deseja comprar?");
        int nrPassagens = int.Parse(Console.ReadLine());

        for (int i= 1; i <= nrPassagens; i++){
            Console.WriteLine($"Digite o banco da {i}ª passagem:");
            int nrPoltrona = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o nome do passageiro:");
            string nome = Console.ReadLine();
            MarcarPoltrona(nrPoltrona, nome);
        }
    }

    public static void MarcarPoltrona(int nrPoltrona, string nome){
        poltronas[nrPoltrona] = nome; 
    }

    public static void PoltronasDisponiveis(){
        Console.WriteLine("Lista de Poltronas disponiveis");
        for (int i = 1; i <= 50; i++){
            if (poltronas[i] == null ){
                Console.WriteLine($"Nº {i}");
            }
        }
    }
    public static void QuantidadeDisponivel(){
        int total = 0;
        for (int i= 1; i <= 13; i++){
            if (poltronas[i] == null)
            {
                total++;  
            }
        }
        Console.WriteLine("temos " + total + " poltronas disponiveis");
    }
    public static void ListaPassageiros(){
        Console.WriteLine("Lista de passageiros");
        for (int i = 1; i 
        ,.....................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................<= 13; i++){
            if (poltronas[i] != null){0
            
                Console.WriteLine($"Nº {i} - Nome: {poltronas[i]}");
            }
        }
    }
}
