using System;

namespace Ex6
{
    class Program
    {
        static void Main(string[] args)
        {
                //Declarer et initialiser constantes
        string MSG_ANALYSTE = "Sans nous il n'y a pas de structure!";
        string MSG_PROG = "C'est nous qui faisons tout!";
        string MSG_ADMIN_RESEAU = "Sans nous tout ça ne sert à rien!";

        //Declarer variables
        string	msgInstructions;
        char	titrePoste = default;
        char	reponse;
        int	nbrAnalystes = 0 ;
        int	nbrProgs = 0 ;
        int	nbrAdminsReseau = 0 ;
        bool	continuer;
        bool valide = false ;

        // Assignations prealables
        msgInstructions = "Veuillez entrer le caractere correspondant au poste. (A)nalyste, (P)rogrammeur et (R)eseau.";

        continuer = true;

        while(continuer) {
            //Afficher instructions et faire la saisie
            while(valide == false){
                try{
                    Console.WriteLine(msgInstructions);
                    titrePoste =Char.Parse((Console.ReadLine().ToUpper()));
                    if(titrePoste == 'A'){
                        Console.WriteLine(MSG_ANALYSTE);
                        nbrAnalystes ++;
                        valide = true;
                    }else if(titrePoste == 'P'){
                        Console.WriteLine(MSG_PROG);
                        nbrProgs++;
                        valide = true;
                    }else if(titrePoste == 'R')
                        {Console.WriteLine(MSG_ADMIN_RESEAU);
                        nbrAdminsReseau ++;
                        valide = true;
                        }
            }catch(Exception e){
                Console.WriteLine("ERREUR ERREUR ALERTE ALERT MAUDIT NONO");

            }
            }
            valide = false;
            Console.WriteLine("Voulez-vous entrez le poste d'une autre personne? (O)ui pour continuer.");
            //continuer <-- Saisir() == 'O'
            reponse = Char.Parse(Console.ReadLine().ToUpper());
            continuer = reponse == 'O';
        }
        Console.WriteLine("Voulez-vous afficher les statistiques?. (O)ui pour afficher (N)on pour quitter.");
        reponse = Char.Parse(Console.ReadLine().ToUpper());

        if(reponse == 'O'){
            Console.WriteLine($"nombre analystes       : {nbrAnalystes}");
            Console.WriteLine($"nombre programmeurs    : {nbrProgs}");
            Console.WriteLine($"nombre d'admins réseau : {nbrAdminsReseau}");
        }
        else if(reponse == 'N')
            {Console.WriteLine("Mais pourquoi?");
            }

        }
    }
}


