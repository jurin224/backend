using Sesi.Model;

class Program
{
    public static void Main()
    {
        //criando uma variavel aluno1 e instanciando da class Aluno
        //Criando nosso objeto
        var aluno1 = new Aluno();
        aluno1.nome = "Rafinha";
        aluno1.idade = 17;
        aluno1.turma = "2º EM";


        //chamando o método da classe Aluno
        aluno1.Apresentar();

        Aluno aluno2 = new Aluno();
        aluno2.nome = "Rafinha2.0";
        aluno2.idade = 17;
        aluno2.turma = "3º EM";

        aluno2.Apresentar();
        aluno2.AdicionarFaltas(10);
        aluno2.Apresentar();

        //chmar método ResumoFaltas
        aluno2.ResumoFaltas();
        
    }
}