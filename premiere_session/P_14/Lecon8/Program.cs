using System;

namespace lecon8
{
    class Program
    {
        static void Main(string[] args)
        {
          
            int ageMajorite = 18;
            bool valide = false;
            int age = 0;



            do{
                Console.WriteLine("Entrez votre age");
                valide = Int32.TryParse(Console.ReadLine(),out age ) && age > 0 && age < 104 ;
        
          

            } while(!valide);

            if(age >= ageMajorite){
                Console.WriteLine("Beau majeur");
            
            }else{
                Console.WriteLine("Pas majeur lala");

            }

      


        }
    }
}
