using Tableaux;
Console.WriteLine("Veuillez choisir le nombre de cases de votre tableau");
string entreeUtilisateur = Console.ReadLine();
int saisieUtilisateur = int.Parse(entreeUtilisateur);

string[] tableau1 = new string[saisieUtilisateur];

for (int i = 0; i < tableau1.Length; i++)
{
    Console.WriteLine("Veuillez choisir une valeur pour la case " + i);
    string saisieTableauUtilisateur = Console.ReadLine();
    tableau1[i] = saisieTableauUtilisateur;
}

for (int i = 0; i < tableau1.Length; i++)
{
    Console.WriteLine("["+tableau1[i]+"]");
}
