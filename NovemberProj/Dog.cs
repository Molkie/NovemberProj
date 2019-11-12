using System;
using System.Collections.Generic;
using System.Text;

namespace NovemberProj
{
    class Dog : Pet
    {
        //Metod som overridar MakeSound i basklassen Pet. Returnerar ljudet av en hund.
        public override string MakeSound()
        {
            return ("Woof!");
        }

        //Metod som overridar ShowArt i basklassen Pet. Returnerar ASCII art av en hund.
        public override string ShowArt()
        {
            return (@"
_     /)---(\  
\\   (/ . . \)      
 \\__)-\(*)/    
 \_       (_  
 (___/-(____)

");
        }

        public Dog()
        {
            type = "Feline";
        }
    }
}
