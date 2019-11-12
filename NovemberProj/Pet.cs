using System;
using System.Collections.Generic;
using System.Text;

namespace NovemberProj
{
    class Pet
    {
        public string name;
        protected string type;
        protected int hp;
        protected int hunger;
        protected int boredom;
        bool isAlive;

        //Konstruktor som bygger upp hudsjuret
        public Pet()
        {
            hp = 10;
            boredom = 0;
            isAlive = true;
        }

        //Metod för att mata husdjuret. Om hunger är lika med 10 går det inte att mata mer.
        void Feed()
        {
            if(hunger == 10)
            {
                hunger++;
            }
        }

        //Metod som kollar om husdjuret lever (isAlive) och returnerar svaret.
        string ReturnAlive()
        {
            if(isAlive == true)
            {
                return ("Your pet is alive and well.");
            }
            else
            {
                return ("Your pet is dead as a rock. Nice job feeding it you lazy tablespoon.");
            }
        }

        //Metod för att namnge husdjuret
        public void GiveName()
        {
            //Låter användaren bestämma variabeln name
            name = Console.ReadLine();
        }

        //Metod som returnerar husdjurets hunger
        public int GetHunger()
        {
            return (hunger);
        }

        //Metod som lägger till 1 på hunger.
        public void AddHunger()
        {
            hunger++;
        }

        //Metod som returnerar husdjurets boredom
        public int GetBoredom()
        {
            return (boredom);
        }

        //Metod som lägger till 1 på boredom.
        public void AddBoredom()
        {
            boredom++;
        }

        //Metod som returnerar ett ljud från husdjuret. Overridas av metoder i subklasserna för respektive ljud.
        public virtual string MakeSound()
        {
            return ("Sound of a generic animal.");
        }

        //Metod som returnerar en ASCII art av djuret. Overridas i subklasserna.
        public virtual string ShowArt()
        {
            return (@":)");
        }
    }
}
