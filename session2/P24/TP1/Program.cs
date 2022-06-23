using System;
using System.Collections;

namespace TP1
{
    class Program
    {   static int nbTickets;
        static Random hasard = new Random(DateTime.Now.Millisecond);
        static int [][] tickets;
        static int [] winningCombination;
        static void Main(string[] args){   
            bool recommencer = false;
            do{
                askUser();
                tickets = generateTickets();
                winningCombination = generateCombination(7);
                afficherWinning();
                validateTickets();
                recommencer  = goAgain();
            }while(recommencer == true);
        }



        static void askUser(){
            bool valid = false;
            do{
                Console.WriteLine("Bonjour! Combien de billets voulez-vous?");
                valid = Int32.TryParse(Console.ReadLine(),out nbTickets) && nbTickets >= 10 && nbTickets <= 200;
            }while(!valid);
        }
        
        static int[] generateCombination(int nbDeNum){
            int[] lign = new int[nbDeNum];
            for (int i = 0; i < nbDeNum; i++){  
                bool doublon;
                
                do{
                    int randomNuber = hasard.Next(1,50);
                    doublon = Array.Exists(lign, element => element == randomNuber);
                    if (doublon == false){
                        lign[i]= randomNuber;
                    } 
                }while(doublon == true);
            } 
            Array.Sort(lign);
            return lign;
        }
        
        
        static int[][] generateTickets(){
            int[][] tickets = new int[nbTickets][];
            for (int i = 0; i < nbTickets; i++){
                tickets[i] = generateCombination(6);
            }
           
            for (int i = 0; i < tickets.Length;i++){
                if(i % 2 == 0 ){
                    Console.WriteLine();
                }
                Console.Write( $"         ticket {i+1} :".PadLeft(3));
                for (int j = 0; j < 6; j++){ 
                    Console.Write(tickets[i][j].ToString().PadLeft(3) +  " ");
                    
                }
            }
          Console.WriteLine();
          return tickets;
        }
        static void validateTickets(){
            int countNum1 = 0;
            int countNum2 = 0;
            int countNum3 = 0;
            int countNum4 = 0;
            int countNum5 = 0;
            int countNum6 = 0;
            int countComp = 0;


            int gagnant2= 0;
            int gagnant2comp=0;
            int gagnant3 = 0;
            int gagnant4 =0;
            int gagnant5 =0;
            int gagnant5comp =0;
            int gagnant6 =0;


            for (int i = 0; i < tickets.Length;i++){
                bool containsComp = false;
                int countWin = 0;
                    
                if( Array.Exists(tickets[i], element => element == winningCombination[0])) {
                    countNum1++;
                    countWin++;
                }
                if( Array.Exists(tickets[i], element => element == winningCombination[1])) {
                        countNum2++;
                        countWin++;
                }if( Array.Exists(tickets[i], element => element == winningCombination[2])) {
                        countNum3++;
                        countWin++;
                }if( Array.Exists(tickets[i], element => element == winningCombination[3])) {
                        countNum4++;
                        countWin++;
                }if( Array.Exists(tickets[i], element => element == winningCombination[4])) {
                        countNum5++;
                        countWin++;
                }if( Array.Exists(tickets[i], element => element == winningCombination[5])) {
                        countNum6++;
                        countWin++;
                }if( Array.Exists(tickets[i], element => element == winningCombination[6])) {
                        countComp++;
                        containsComp = true;
                }

                if(countWin ==2 && containsComp == false ) {
                    Console.WriteLine($"ticket {i+1} remporte une participation gratuite");
                    gagnant2++;
                }
                
                if(countWin ==2 && containsComp == true ) {
                    Console.WriteLine($"ticket {i+1} remporte 5$ ");
                    gagnant2comp++;
                }

                if(countWin ==3) {
                    Console.WriteLine($"ticket {i+1} est un billet gagnant de 10$");
                    gagnant3++;
                }
                if(countWin ==4) {
                    Console.WriteLine($"ticket {i+1} est un billet gagnant de 4");
                    gagnant4++;
                }
                    
                if(countWin ==5) {
                    Console.WriteLine($"ticket {i+1} est un billet gagnant de 5");
                    gagnant5++;

                } if(countWin ==5 && containsComp == true) {
                    Console.WriteLine($"ticket {i+1} est un billet gagnant de 5 + C");
                    gagnant5comp++;
                
                    
                } if(countWin ==6) {
                    Console.WriteLine($"ticket {i+1} est un billet gagnant de 6");
                    gagnant6++;
                    
                }
            }
   
            Console.WriteLine($"Le chiffre {winningCombination[0]} est sorti {countNum1} fois" );
            Console.WriteLine($"Le chiffre {winningCombination[1]} est sorti {countNum2} fois" );
            Console.WriteLine($"Le chiffre {winningCombination[2]} est sorti {countNum3} fois" );
            Console.WriteLine($"Le chiffre {winningCombination[3]} est sorti {countNum4} fois" );
            Console.WriteLine($"Le chiffre {winningCombination[4]} est sorti {countNum5} fois" );
            Console.WriteLine($"Le chiffre {winningCombination[5]} est sorti {countNum6} fois" );
            Console.WriteLine($"Le chiffre {winningCombination[6]} est sorti {countComp} fois" );

        }





         static void afficherWinning(){
            Console.WriteLine("Voici la combinaison gagnante : " );
            for (int i = 0; i < winningCombination.Length;  i++){
                if(i == 6){
                    Console.WriteLine("Complémentaire: " + winningCombination[i]);
                }else{
                Console.Write(winningCombination[i] + " ");
                }
            }
         }



         static bool goAgain(){
            bool valide;
            bool ouiOuNon;
            char reponse;
        
            do{
                Console.WriteLine("\nVoulez vous recommencer? (O)ui ou (N)on");
                valide = Char.TryParse(Console.ReadLine().ToUpper(), out reponse) && reponse == 'O' || reponse =='N';
            }while(!valide);

            ouiOuNon = (reponse =='O')?  true : false;
            return ouiOuNon;
         }
    }
}
