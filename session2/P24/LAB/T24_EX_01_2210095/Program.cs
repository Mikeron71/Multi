using System;


namespace T24_EX_01_2210095
{
    class Program
    {
        public enum cours {
                
                M14,
                P14,
                S14,
                T14,
                T24,
                A14,
                P24,
                P34,
                S34,
                W14
            }

        public struct etudiant{
            public string prenom;
            public string nom;
            public int age;
            public int DA;
            public cours choixCours;
            
          
        }

        public struct note{
            int noteTp1;
            int noteTp2;
            int noteIntra;
            int noteFinal;
        }
        static void Main(string[] args)
        {



            double noteSession;
            double noteTp1;
            double noteTp2;
            double noteIntra;
            double noteFinal;
            double tp1sur100;
            double tp2sur100;
            double intrasur100;
            double finalsur100;
            char reponse;
            bool valide = true;
            bool continuer = false;
        
      
            etudiant unEtudiant;

            do{
                Console.WriteLine("Veuillez entrer le prenom de l'etudiant");
                unEtudiant.prenom = Console.ReadLine();
        
                Console.WriteLine("Veuillez entrer le nom de l'etudiant");
                unEtudiant.nom = Console.ReadLine();
          

                do{
                    Console.WriteLine("Veuillez entrer votre année de naissance");
                    valide = Int32.TryParse(Console.ReadLine(),out int anneeNaissance) && anneeNaissance >=14 && anneeNaissance <=102;
                    unEtudiant.age = DateTime.Now.Year - anneeNaissance;

                
                }while(!valide);

                do{
                    Console.WriteLine("Veuillez entrer le DA de l'etudiant");
                    valide = Int32.TryParse(Console.ReadLine(),out unEtudiant.DA) ;
                
                }while(!valide);
                
                Console.WriteLine(@"Pour quel cours voulez-vous entrer les les notes?
                entrez:
                0   pour M14
                1   pour P14 
                2   pour S14 
                3   pour T14
                4   pour T24
                5   pour A14
                6   pour P24
                7   pour P34
                8   pour S34
                9   pour W14
                ");

                unEtudiant.choixCours = (cours)Int32.Parse(Console.ReadLine());
                
                do{            
                    Console.WriteLine("Veuillez entrer la note du tp1");
                    valide = double.TryParse(Console.ReadLine(),out noteTp1) && noteTp1 >=0 && noteTp1 <=100 ;
                    tp1sur100 = noteTp1*10/100;
                }while(!valide);

                do{            
                    Console.WriteLine("Veuillez entrer la note du tp2");
                    valide = double.TryParse(Console.ReadLine(),out noteTp2) && noteTp2 >=0 && noteTp2 <=100 ;
                    tp2sur100 = noteTp2*10/100;
                }while(!valide);
                
                do{            
                    Console.WriteLine("Veuillez entrer la note de l'examen intra");
                    valide = double.TryParse(Console.ReadLine(),out noteIntra) && noteIntra >=0 && noteIntra <=100 ;
                    intrasur100 = noteIntra*40/100;
                }while(!valide);
                
                do{            
                    Console.WriteLine("Veuillez entrer la note de l'examen final");
                    valide = double.TryParse(Console.ReadLine(),out noteFinal) && noteFinal >=0 && noteFinal <=100 ;
                    finalsur100 = noteFinal*40/100;
                }while(!valide);

                noteSession = tp1sur100+tp2sur100+intrasur100+finalsur100;

                Console.WriteLine(@$"
                Étudiant:   {unEtudiant.prenom} {unEtudiant.nom} {unEtudiant.DA}
                Age:        {unEtudiant.age} ans
                DA:         {unEtudiant.DA}

                Voici les notes pour le cours {unEtudiant.choixCours}
                TP1:        {noteTp1}   %
                TP2:        {noteTp2}   %
                Intra:      {noteIntra} %
                Final:      {noteFinal} %

                Moyenne:    {noteSession} % ");

                
              do{
                    Console.WriteLine("Voulez vous entrer d'autres notes? (O)ui ou (N)on");
                    valide = Char.TryParse(Console.ReadLine().ToUpper(), out reponse) && reponse == 'O' || reponse =='N';}
                    while(!valide);

                continuer = (reponse =='O')?  true : false;

            }while(continuer);
        }
    }
}
