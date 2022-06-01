using System;

namespace _1_Battleship
{
    class Program
    {
        static void Main(string[] args)
        {   
            char[,] battle = new char[10,10];
            char[,] blank = new char[10,10];
            int count = 0;
            bool valide;
            int ligneAttaque;
            int coloneAttaque;



            int ligne;
            int col;

            for (ligne = 0; ligne < 10; ligne++){
                for (col = 0; col < 10; col++){
                    battle[ligne,col] = '.';
                }
                
            }
             for (ligne = 0; ligne < 10; ligne++){
                for (col = 0; col < 10; col++){
                    blank[ligne,col] = '.';
                }
                
            }
         
            for (ligne = 0; ligne < 10; ligne++){
                Console.WriteLine();
                for (col = 0; col < 10; col++){
                    Console.Write(blank[ligne,col]);
                }
                
            }

       

            Random hasard = new Random();

            int ligneOuCol = hasard.Next(0,2);


            if (ligneOuCol == 0){
              
                int ligneAuHasard = hasard.Next(0,8);
                battle[ligneAuHasard,ligneAuHasard] = 'S';
                battle[ligneAuHasard,ligneAuHasard+1] = 'S';
                battle[ligneAuHasard,ligneAuHasard+2] = 'S';
           
                    
            }else if (ligneOuCol ==1){
                 
                int colAuHasard = hasard.Next(0,8);
                battle[colAuHasard,colAuHasard] = 'S';
                battle[colAuHasard+1,colAuHasard] = 'S';
                battle[colAuHasard+2,colAuHasard] = 'S';
             
            }

        

            do{

            do{
            Console.WriteLine("\n Entrez la ligne de votre attaque");
            valide = Int32.TryParse(Console.ReadLine(),out ligneAttaque)&& ligneAttaque >=0 && ligneAttaque <=10;
            }while(!valide);
            
            do{
            Console.WriteLine("Entrez la colone de votre attaque");
            valide = Int32.TryParse(Console.ReadLine(),out coloneAttaque)&& coloneAttaque >=0 && coloneAttaque <=10;
            }while(!valide);
            



            Console.WriteLine(battle[ligneAttaque-1 ,coloneAttaque-1]);

            if(battle[ligneAttaque-1 ,coloneAttaque-1]=='S'){
            blank[ligneAttaque-1,coloneAttaque-1]= 'S';
            count++;
            
            } else{
                 blank[ligneAttaque-1,coloneAttaque-1]= 'X';
            }

         
            
            for (ligne = 0; ligne < 10; ligne++){
                Console.WriteLine();
                for (col = 0; col < 10; col++){
                    Console.Write(blank[ligne,col]);
                }
            }
            }while(count <3);



        






        }
    
     }     
}   
