const int NbreMystere = 7;
const int nbreMax = 10;
const int nbreMin = 1;

bool gagne = false;

Console.WriteLine("Salut ! Comment vous vous appellez ? ");
string prenom = Console.ReadLine();

Console.WriteLine($"Merci pour votre comprehension {prenom} !");
Console.WriteLine("");

List<int> malist = [];
String indication = "";


while (gagne == false)
{
    Console.Clear();

    if (malist is not [])
    {
        Console.Write("Les Chiffres deja fait sont :");
        foreach (int i in malist)
        {
            Console.Write($" {i}");
        }
        Console.WriteLine("");
    }

    if(indication !="")
    {
        Console.WriteLine(indication);
    }

    Console.Write($"{prenom} Fait un choix entre {nbreMin} et {nbreMax} :");
    // Faire le boucle pour s'assurer que la valeur est exactement un chiffre dans l'interval et pas une lettre ou nom
    int nbreChoix = 0;
    while (nbreChoix<nbreMin || nbreChoix>nbreMax)
    {
        try
        { 
            nbreChoix = int.Parse(Console.ReadLine());
            
        }
        catch
        {
            
            Console.Write($"Essaie encore car le nobre est invalide {nbreChoix} :");
        }    
    }

    // ajoute l'entree a la liste Malist
    malist.Add(nbreChoix);
    
    if (nbreChoix == NbreMystere )
    {
        Console.WriteLine($"Bravooo!! {prenom} vous avez fait le bon Choix qui est {NbreMystere} et par consequent vous avez gagne");
        gagne = true;
    }
    else
    {
        if (nbreChoix > NbreMystere)
        {
            indication = $"Desolee {prenom} vous avez perdu. Votre choix: {nbreChoix} est plus grand !";
        }
        else
        {
            indication = $"Desolee {prenom} vous avez perdu. Votre choix: {nbreChoix} est plus petit!";
        }
    }
}



//tableaux et Liste
// string[] NameTableau = new string[10];
// List<int> NameList = new List<int>();---->NameList.Add(56);

//bool choix = nbreChoix != NbreMystere;



