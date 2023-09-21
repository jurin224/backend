namespace Models
{
    public class Pessoa
    {
        //atributos da nossa class pessoa
        private string nome { get; set; }
        private int idade { get; set; }

        //criando nosso método construtor 
         public Pessoa (string nome, int idade)     
         {
            this.nome = nome;
            this.idade = idade;
         }        

        //metodos da classe pessoa
        public void Cantar()
        {
            Console.WriteLine($"{nome} está cantando");
        }
    }
}