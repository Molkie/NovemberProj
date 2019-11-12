﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NovemberProj
{
    class Cat : Pet 
    {
        //Metod som overridar MakeSound i basklassen Pet. Returnerar ljudet av en katt.
        public override string MakeSound()
        {
            return ("Purr");
        }

        //Metod som overridar ShowArt i basklassen Pet. Returnerar ASCII art av en katt.
        public override string ShowArt()
        {
            return (@"
|\---/|
| o_o |
 \_^_/

");
        }

        public Cat()
        {
            type = "Feline";
        }




    }
}
