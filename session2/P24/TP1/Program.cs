using System;

namespace TP1
{
    class Program
    {   static int nbTickets;
        static Random hasard = new Random(DateTime.Now.Millisecond);
        int [][] tickets;
        static void Main(string[] args)
        {   bool continuer = false;
            do{
                askUser();
                generateCombination();
                generateTickets();
                int [] winnigCombination = generateCombination();
                int complementaire = hasard.Next(1,50);
            
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
                int randomNuber = hasard.Next(1,50);
                lign[i]= randomNuber;
                // if(Array.Exists(lign,chiffre =>chiffre == randomNuber)){
                    
                // } 
            }

            
                return lign;
        }
        
        
        static void generateTickets(){
            
             int[][] tickets = new int[nbTickets][];
           

           for (int i = 0; i < nbTickets; i++){
                tickets[i] = generateCombination();
           }

            for (int i = 0; i < tickets.Length;i++){
                Console.WriteLine();
                Console.Write( $"ticket {i+1} :    ");
                for (int j = 0; j < 6; j++){ 
                    Console.Write(tickets[i][j] + " ");
                    
                }
            }
          
        }
    }
}
