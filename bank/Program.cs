using System;

namespace bank
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Personne beb = new Personne("beb", -12);
            Personne beatrice = new Personne("Béatrice", 5000);

            beatrice.transfer(ref beb);
            beb.transfer(ref beatrice);
        }
    }
}
