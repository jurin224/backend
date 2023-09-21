using Sesi.Models;

class Program
{
public static void Main()
{
    Gato meuGato = new Gato();
    meuGato.nome = "charlinho";
    meuGato.cor = "Branco";
    meuGato.idade = 1;
    meuGato.especi =  "de rua";
    meuGato.genero = "hetero top";
    meuGato.peso = 1;


    Peixe meuPeixe = new Peixe();
    meuPeixe.especi =  "Palhaço";
    meuPeixe.cor = "Laranja";
    meuPeixe.peso = 1;
    meuPeixe.tamanho = 0.20M;

}
}