// See https://aka.ms/new-console-template for more information




string msgInstructions = "Veuillez entrer votre prénom.";
Console.WriteLine(msgInstructions);

int fraisFixes = 50;
double prix0a200 = 0.5;
double prix200a500 = 0.25;
double prix500Plus = 0.1;
double total = 0;


string prenomClient = (Console.ReadLine());
msgInstructions = "Veuillez entrer votre nom.";

Console.WriteLine(msgInstructions);
string nomClient = (Console.ReadLine());

msgInstructions = "Veuillez entrer votre consommation électrique de la dernière période en kWh.";
Console.WriteLine(msgInstructions);
double consommationClient  = int.Parse((Console.ReadLine()));

if (consommationClient > 0 && consommationClient <=200)
   
    {total = consommationClient*prix0a200 + fraisFixes;}

else if (consommationClient > 200 && consommationClient <=500)
    {double dejaPaye = 100;
    total = (consommationClient-200)*prix200a500 + dejaPaye + fraisFixes;}


else if (consommationClient > 500 )
    {double dejaPaye = 175;
    total = (consommationClient-500)*prix500Plus + dejaPaye + fraisFixes;}


   
   
 Console.WriteLine($"L'utilisation électrique de {prenomClient} {nomClient} pour la dernière période est de {consommationClient} kWh. Le montant a payer est de {total} $ ");