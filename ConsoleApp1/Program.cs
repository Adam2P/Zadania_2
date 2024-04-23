using ConsoleApp1;

class program
{
    static void Main(string[] args)
    {
        Tablice tablice = new Tablice();
        tablice.Powitanie();

        int[] tab = tablice.Stworz_tablice();
        
        Console.Clear();
        tablice.Wyswietl_Tablice(tab);
    }
}