using System.Collections.Generic;
using Sesi.Models;

public class Program
{
    public static void Main()
    {
        //criando uma lista de numeros inteiro
            List<int> listaNumeros = new List<int>();

            //adicionando elementos para lista 
            listaNumeros.Add(10);  //posição [0]
            listaNumeros.Add(20);  //posição [1]
            listaNumeros.Add(45);  //posição [2]

            //contando a quantidade de elmentos na nossa lista 
            Console.WriteLine($"Neste momento temos {listaNumeros.Count} números");
    
            //acessando os dados da lista pelo indici 
            Console.WriteLine(listaNumeros[1]);

            listaNumeros.Add(6);  //posição [3]
            Console.WriteLine($"Neste momento temos {listaNumeros.Count} números");

            Console.WriteLine("----------------------------------------------------");

            //criem uma nova lista de nomes e adicione alguns nomes a ela
            //e exibam a quantidade de nomes que contem nessa lista 

             List<string> listaNomes = new List<string>();
             //para nome usar o "string" JOIA
            
             listaNomes.Add("Rogerio");
             listaNomes.Add("Roberto");
             listaNomes.Add("Geraldo");
             
             Console.WriteLine($"Temos esses nomes {listaNomes.Count} Nomes Adicionados");

              foreach (string intem in listaNomes)
              {
                Console.WriteLine(intem);
              }




             Console.WriteLine("----------------------------------------------------");
               
             //criando uma lista ja atribuindo valores
              List<int> Numeros = new List<int> {1, 2, 3, 4, 5, 6, 7, 8, 9,};
              Numeros.Add(10);

              //interando sobre todos os intens da lista 
                Numeros.Remove(2); //remove o elemento buscando pelo conteudo 
                Numeros.RemoveAt(4); //remove pela posição 
                Numeros.RemoveRange(2, 2); //remove o elemento da posição 2 e os próximos 2 
              
              foreach (int intem in Numeros)
              {
                Console.WriteLine(intem);
              }

              //criando uma nova lista com objetos da classe aluno 
              List<Aluno> listaAlunos = new List<Aluno> ();

              //adicionando um novo aluno a lista aluno
              Aluno novoAluno = new Aluno ("Gregorio", 18);
              listaAlunos.Add (novoAluno);
              
              listaAlunos.Add(new Aluno ("Cesar", 17));
              listaAlunos.Add(new Aluno ("Rafinha", 18));
              listaAlunos.Add(new Aluno ("Carlao", 63));
              listaAlunos.Add(new Aluno ("Roberto", 45));
              listaAlunos.Add(new Aluno ("Junin", 9));

               foreach (Aluno item in listaAlunos)
              {
                Console.WriteLine($"Nome aluno: {item.nome} idade {item.idade}");
              }

              //criando uma nova lista, filtrando e ordenando por nome 
              //LINQ utiizando Sintaxe de consulta
              var consulta = from aluno in listaAlunos
                                where aluno.idade > 18
                                orderby aluno.nome
                                select aluno;

               
             Console.WriteLine("----------------------------------------------------");
               Console.WriteLine ("Lista de alunos maiores de 18 anos");
               foreach (var item in consulta)
              {
                Console.WriteLine($"Nome aluno: {item.nome} idade {item.idade}");
              }
              Console.WriteLine("----------------------------------------------------");

              //LINQ utilizando sintaxe do método
              var metodo = listaAlunos 
                                .Where (aluno => aluno.idade < 18)
                                .OrderBy(aluno => aluno.nome);

             Console.WriteLine ("Lista de alunos menores de 18 anos");
                                 foreach (var item in metodo)
              {
                Console.WriteLine($"Nome aluno: {item.nome} idade {item.idade}");
              }



            Console.WriteLine("----------------------------------------------------");

                       
 
   
    }
}