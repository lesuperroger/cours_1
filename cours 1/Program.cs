// See https://aka.ms/new-console-template for more information
Console.WriteLine("Bonjour bienvenu sur mon aplication veuillez entrer votre nom pour que je puisse vous accellir");
string  nom = Console.ReadLine();
Console.WriteLine("Merci " +  nom + " vous pouvez maintenant entrer les degrés que vous voulez convertir");
etichette1:
double degré = Convert.ToDouble(Console.ReadLine());
double far = (degré * 1.8 + 32);
Console.WriteLine(degré + " degré donne " + far + " en farenheit");

Console.WriteLine(nom + " voulez vous reconvertir un degré? (1 = y) ou (2 = n)");
double rep = Convert.ToDouble(Console.ReadLine());
if (rep == 1 )
{
    Console.WriteLine("Entrez une nouvelle valeur");
    goto etichette1;
}
else
{
    Console.WriteLine("Merci" + nom + " d'avoir utiliser mon programme appuyez maintenant sur la touche entrer pour fermer le programme");
    Console.ReadKey();
}