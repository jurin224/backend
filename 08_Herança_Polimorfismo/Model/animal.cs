namespace Sesi.Models
{
    public class Animal
    {
        public string cor { get; set; }
       
        public string especie { get; set; }
        
        public string peso { get; set; }

         public void EmitirSom(){
        console.WriteLine("Emitindo som");
    }

    }
   
}