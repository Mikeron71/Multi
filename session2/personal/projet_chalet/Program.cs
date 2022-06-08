using System;

namespace projet_chalet
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] tableau = new int [10,30];
            
            for (int ligne = 0;  ligne < 10; ligne  ++){   
                
                for (int col = 0; col < 30; col++){
                    if(ligne==col){
                        tableau[ligne,col] = 8;
                    }else {
                        tableau[ligne,col] =0;
                    }
                }
            }
           
            for (int ligne = 0;  ligne < 10; ligne  ++){ 
                for (int col = 0; col <30; col++){
                    Console.Write(tableau[ligne,col]);
                }
                Console.WriteLine();
            }
        }
    }
}
