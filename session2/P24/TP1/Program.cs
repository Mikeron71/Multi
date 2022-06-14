using System;

namespace TP1
{
    class Program
    {   static int nbTickets;
        static Random hasard = new Random(DateTime.Now.Millisecond);
        static void Main(string[] args)
        {   bool continuer = false;
            do{
                askUser();
                generateCombination();
                int[][] tickets = generateTickets();
                int [] winnigCombination = generateCombination();
                int complementaire = hasard.Next(0,50);
                // generateStats();
                // showStats();


            }while(continuer);
            
        }
        static void askUser(){
            bool valid = false;
            do{
                Console.WriteLine("Hi!  How many tickets do you need?");
                valid = Int32.TryParse(Console.ReadLine(),out nbTickets) && nbTickets > 9 && nbTickets < 201;
            }while(!valid);
        }
        
        static int[] generateCombination(){
            int[] lign = new int[6];
            for (int i = 0; i < 6; i++)
            {  
                lign[i] = hasard.Next(0,50);
            }

            
                return lign;
        }
        
        
        static int[][] generateTickets(){
            
             int[][] jaggedArray = new int[nbTickets][];
           

           for (int i = 0; i < nbTickets; i++){
                jaggedArray[i] = generateCombination();
           }

            for (int i = 0; i < jaggedArray.Length;i++){
                Console.WriteLine();
                Console.Write($"ticket{i+1} :    ");
                for (int j = 0; j < 6; j++){ 
                    Console.Write(jaggedArray[i][j]);
                    Console.Write(" ");
                }
            }
            return jaggedArray;
        }
    }
}
