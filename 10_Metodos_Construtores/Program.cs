using Models;

public class Program
{
    public static void Main()
    {
        //criar um objeto da classe pessoa 
        /*
        //instanciando objeto sem método contrutor
        Pessoa pessoa1 = new Pessoa();
        pessoa1.nome = "Adalberto";
        pessoa1.idade = 62;

        //Alternativa de um  objeto instanciando sem construtor 
        Pessoa pessoa1 = new Pessoa {
            nome = "Julio",
            idade = 16
        }
        */

        //isntanciando um objeto com o método construtor
        Pessoa pessoa1 = new Pessoa("Roberto Alberto", 68);

        //chamando o metodo cantar da classe pessoa 
        pessoa1.Cantar();

        Pessoa pessoa2 = new Pessoa("Lusquinha", 69);
        pessoa2.Cantar();

        Pessoa pessoa3 = new Pessoa("João André", 113);
        pessoa3.Cantar();

    }
}