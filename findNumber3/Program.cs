using System.Collections;

int number, inf, sup;
Random rnd = new Random();
ArrayList choix = new ArrayList();
int i = 0;
entrerBornes:
Console.WriteLine("Entrer la borne inférieure:");
string stringInf = Console.ReadLine();
Console.WriteLine("Entrer la borne supérieure:");
string stringSup = Console.ReadLine();
if (!int.TryParse(stringInf, out inf) || !int.TryParse(stringSup, out sup))
{
    goto entrerBornes;
}
int nbreMystere = rnd.Next(inf, sup + 1);
entrerNombre:
Console.WriteLine("Entrer un nombre compris entre " + inf + " et " + sup + ":");
string stringNumber = Console.ReadLine();
if (!int.TryParse(stringNumber, out number))
{
    choix.Add(stringNumber);
    goto entrerNombre;
}
else
{
    if (number < inf || number > sup)
    {
        choix.Add(number);
        goto entrerNombre;
    }
}
if (number == nbreMystere)
{
    Console.WriteLine("Vous avez gagné");
    Console.WriteLine("Tentatives: ");
    foreach (var nbr in choix)
    {
        Console.Write(nbr + " ");
    }
}
else
{
    Console.WriteLine("vous avez perdu!");
    choix.Add(number);
    goto entrerNombre;
}

