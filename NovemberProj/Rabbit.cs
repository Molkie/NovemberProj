using System;
using System.Collections.Generic;
using System.Text;

namespace NovemberProj
{
    class Rabbit : Pet
    {
        //Metod som overridar MakeSound i basklassen Pet. Returnerar ljudet av en katt.
        public override string MakeSound()
        {
            return ("Happy Rabbit noise");
        }

        //Metod som overridar ShowArt i basklassen Pet. Returnerar ASCII art av en katt.
        public override string ShowArt()
        {
            return (@"
             ,\
             \\\,_
              \` ,\
         __,.-' = __)
       .'        )
    ,_ /   ,    \/\_
    \_ |    )_ -\ \_ -`
       `-----` `--`
");
        }

        public Rabbit()
        {
            type = "Jumpy boi";
        }

    }
}
