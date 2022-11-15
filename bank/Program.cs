using System;

namespace bank
{
    class Program
    {
        static void Main(string[] args)
        {
            bool ok;
            string[] prenom = new string[2];
            float[] account = new float[2];
            for(int i = 0; i < 2; i++)
            {
                ok = false;
                while (ok != true)
                {
                    try
                    {
                        Console.Write("Prénom : ");
                        prenom[i] = Console.ReadLine();
                        Console.Write("Compte : ");
                        account[i] = float.Parse(Console.ReadLine());
                        ok = true;
                    }
                    catch
                    {
                        Console.WriteLine("Error");
                    }
                }
            }
            Personne p1 = new Personne(prenom[0], account[0]);
            Personne p2 = new Personne(prenom[1], account[1]);

            p1.transfer(ref p2);
            p2.transfer(ref p1);
        }
    }
}
