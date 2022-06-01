using System;

namespace tableau
{
    class Program
    {
        static void Main(string[] args)
        {

            // For each de base avec boucle for et input sans validation tableau VECTEUR
     
            // int i;
            // string[] legumes = new string[4];
            
            // for (i = 0; i < 3; i++)
            // {
            //     Console.WriteLine("Entres le nom d'un legume");
            //     legumes[i] = Console.ReadLine();
                
            // }

            


            // foreach(string leg in legumes){
            //     Console.WriteLine(leg);;
            // }
            //--------------------------------------------------------------------------------

            char[,] tableau = new char [10,10];
            int ligne,col;

            for(ligne = 0;ligne <10 ;ligne++){
                for(col = 0;col <10 ;col++){
                    tableau[ligne,col] = '.';
                    if(ligne == col){
                    tableau[ligne,col] = 'x';

                    }if(ligne +col == 9) {
                    tableau[ligne,col] = 'x';

                    }

                }
            }
            
            for(ligne = 0;ligne <10 ;ligne++){
                            Console.WriteLine();
                            for(col = 0;col <10 ;col++){
                                Console.Write(tableau[ligne,col]);

                            }
                        }




        }
    }
}
