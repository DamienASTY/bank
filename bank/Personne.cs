using System;
using System.Collections.Generic;
using System.Text;

namespace bank
{
    class Personne
    {

        private string name;
        private float account;

        public Personne(string name, float initialAccount)
        {
            this.name = name;
            this.account = initialAccount;
        }

        public string getName()
        {
            return this.name;
        }

        public float getAccount()
        {
            return this.account;
        }

        public void setAccount(float receive)
        {
            this.account += receive;
        }

        public void transfer(ref Personne give)
        {
            bool ok = false;
            while(ok != true)
            {
                try
                {
                    float ammount;
                    Console.WriteLine($"{this.getName()} combien voulez-vous donner à {give.getName()} ?");
                    Console.WriteLine("Entrez la somme : ");
                    ammount = float.Parse(Console.ReadLine());
                    if (ammount > this.getAccount())
                    {
                        Console.WriteLine("Désolé, vous n'avez pas assez d'argent");
                    }
                    else
                    {
                        give.setAccount(ammount);
                        this.setAccount(-ammount);
                        Console.WriteLine("Ajout effectuer");
                        Console.WriteLine($"{this.getName()}  à {this.getAccount()}€ dans son porte monnaies");
                        Console.WriteLine($"{give.getName()}  à {give.getAccount()}€ dans son porte monnaies");
                    }
                }
                catch
                {
                    Console.WriteLine("NaN");
                }
            }
        }

    }
}
