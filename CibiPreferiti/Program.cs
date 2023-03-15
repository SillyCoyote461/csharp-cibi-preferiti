//cibi
string[] favoriteFoods = {"Pasta", "Cioccolato", "Carne", "Kebab", "Hamburger", "Verdura"};
//totale cibi + classifica
Console.WriteLine("Totale cibi: " + favoriteFoods.Length);
Console.WriteLine("Classifica cibi");
{
        int pos = 0;
    for(int i = 0; i < favoriteFoods.Length; i++)
    {
        pos++;
        Console.WriteLine(pos + " posizione: " +favoriteFoods[i]);
    }
}
//migliore e peggiore cibo
Console.WriteLine("Cibo migliore: " + favoriteFoods[0]);
Console.WriteLine("Peggiore miglior cibo: " + favoriteFoods[4]);

//cibo metá classifica
int middle = favoriteFoods.Length / 2;
{
    int x = favoriteFoods.Length % 2;
    if(x != 0)
    {
        Console.WriteLine("Cibo di metá classifica: " + favoriteFoods[middle]);
    }
    else
    {
        Console.WriteLine("Cibi di metá classifica: " + favoriteFoods[middle - 1] + ", " + favoriteFoods[middle]);
    }
}


