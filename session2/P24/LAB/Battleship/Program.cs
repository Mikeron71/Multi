using System;

namespace _1_Battleship
{
    class Program
    {
        static void Main(string[] args)
        {   
            
            int count = 0;
            int ligneAttaque =0;
            int coloneAttaque =0;
            int ligne;
            int col;
            
            
            char[,] blank = creerBlank();
            char[,] battle  = creerBattle();


            do{

                attaquer(ref ligneAttaque,ref coloneAttaque);

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
          static char[,] creerBattle() {
        
            int ligne;
            int col;
            char[,] battle = new char[10,10];
            Random hasard = new Random(DateTime.Now.Millisecond);
            int ligneOuCol = hasard.Next(0,2);

            for (ligne = 0; ligne < 10; ligne++){
                for (col = 0; col < 10; col++){
                    battle[ligne,col] = '.';
                }
                
            }
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
            return battle;
    
        }
        static char[,] creerBlank(){
            int ligne;
            int col;
            char[,] blank = new char[10,10];
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
            return blank;
        }
        static void attaquer(ref int ligneAttaque,ref int coloneAttaque){
            bool valide;
            do{
                    Console.WriteLine("\n Entrez la ligne de votre attaque");
                    valide = Int32.TryParse(Console.ReadLine(),out ligneAttaque)&& ligneAttaque >=0 && ligneAttaque <=10;
                }while(!valide);
                
                do{
                    Console.WriteLine("Entrez la colone de votre attaque");
                    valide = Int32.TryParse(Console.ReadLine(),out coloneAttaque)&& coloneAttaque >=0 && coloneAttaque <=10;
            }while(!valide);
          
        }
     }     
}   

// CECI EST MA PREMIERE VERSION DE BATTLESHIP
// j'ai bien avancé dans mon battleship2.0 a deux joueurs mais j'ai tout brisé en mergant sur github. Disons que j'ai plus appris sur github par la suite.