using System;
using System.Collections.Generic;

namespace NovemberProj
{
    //Det här programmet fungerar lite som en Tamagotchi. Man kan skapa nya husdjur samt ladda gamla. Man kan ha flera
    //husdjur samtidigt. Man kan ladda ett husdjur och leka med det. Det finns flera olika sorters husdjur. Dessa husdjur
    //är alla underklasser till klassen Pet.

    class Program
    {
        //Lista för alla husdjur
        static List<Pet> petList = new List<Pet>();

        static void Main(string[] args)
        {
            //Kallar metoden MainMenu().
            MainMenu();

            Console.WriteLine();

            Console.ReadLine();
        }

        //Metod som skriver ut main menyn till programmet.
        static void MainMenu()
        {
            //Rensar konsollen
            Console.Clear();
            //Menyval
            Console.WriteLine("Hello, what do you want to do?");
            Console.WriteLine("1. Create a new pet");
            Console.WriteLine("2. Load an old pet");
            Console.WriteLine("3. Quit program");
            int answer = Input();
            //Kollar vad svaret var och kallar den respektive metoden.
            //Svar 1 kallar metoden CreatePet som skapar ett nytt husdjur.
            if(answer == 1)
            {
                CreatePet();
            }
            //Om svaret är 2 kallas metoden LoadPet där man laddar ett tidigare sparat husdjur från listan.
            else if(answer == 2)
            {
                LoadPet();
            }
            //Om svaret är 3 avslutas programmet.
            else if(answer == 3)
            {
                Console.WriteLine("Exiting programm...");
            }

        }

        //Metod för att leka med husdjuret.
        static void PetMenu(Pet currentPet)
        {
            //Bool som är true så länge spelaren vill leka med detta husdjur.
            bool playing = true;
            //Loop som körs så länge playing är true.
            while(playing == true)
            {
            //Rensar konsollen.
            Console.Clear();
            //Hämtar husdjurets ASCII - art.
            string face = currentPet.ShowArt();
            //Skriver ut ASCII - arten.
            Console.WriteLine(face);
            //Skriver ut husdjurets namn.
            Console.WriteLine("Name: " + currentPet.name);
            //Hämtar husdjurets hunger.
            int hunger = currentPet.GetHunger();
            //Skriver ut hungern.
            Console.WriteLine("Hunger: " + hunger);
            //Hämtar husdjurets boredom.
            int boredom = currentPet.GetBoredom();
            //Skriver ut boredom.
            Console.WriteLine("Boredom: " + boredom);

            //Menyval
            Console.WriteLine("1. Pet");
            Console.WriteLine("2. Feed");
            Console.WriteLine("3. Exit");
            
            //Låter användaren skriva in ett val.
            int input = Input();
            //Om svaret är 1 (Pet) blir husdjuret gladare och gör ett ljud.
            if(input == 1)
            {
                //Hämtar husdjurets "sound" genom metoden MakeSound.
                string sound = currentPet.MakeSound();
                //Skriver ut djurets sound.
                Console.WriteLine(sound);
                //Lägger till en poäng på boredom om boredom är under 10.
                if(boredom < 10)
                {
                     //Anropar metoden AddBoredom i Pet som lägger till en poäng på boredom.
                     currentPet.AddBoredom();
                }
            }
            //Om svaret är 2 (Feed) blir husdjuret mättare
            if(input == 2)
            {
                //Skriver att husdjuret blir matad så att användaren får tydliga anvisningar om vad som händer.
                Console.WriteLine("Feeding pet");
                //Lägger till en poäng på hunger om hunger är under 10.
                if(hunger < 10)
                {
                     //Anropar metoden Addhunger i Pet som lägger till en poäng på hunger.
                     currentPet.AddHunger();
                }
            }
            //Menyval 3 avslutar lekstunden genom att sätta playing till false och kallar metoden MainMenu().
            if(input == 3)
            {
                playing = false;
                MainMenu();
            }
            Console.ReadLine();
            }
        }

        //Metod som låter användaren välja ett hudsjur att leka med.
        static void LoadPet()
        {
            //Om användaren har sparade husdjur:
            if(petList.Count > 0)
            {
                //Skriver ut en lista på alla sparade husdjur.
                for (int i = 0; i < petList.Count; i++)
                {
                    //Skriver ut husdjurets namn med en siffra framför.
                    Console.WriteLine(i + ": " + petList[i].name);
                }
                //Låter användaren skriva ett nummer.
                int ans = Input();
                //Kollar om svaret är över antal husdjur eller under 0, låter användaren skriva igen om detta inte stämmer.
                while (ans > petList.Count || ans < 0)
                {
                    Console.WriteLine("Please type a valid number.");
                    ans = Input();
                }
                //Kallar metoden PetMenu med det valda husdjuret som parameter.
                PetMenu(petList[ans]);
            }
            else
            {
                //Förklarar för användaren att denne inte har några husdjur sparade.
                Console.WriteLine("You do not have any pets, you need to make one.");
                //Låter användaren återgå till main menyn genom att klicka på enter.
                Console.ReadLine();
                MainMenu();
            }
        }

        //Metod för att skapa ett nytt husdjur.
        static void CreatePet()
        {
            //Menyval till användaren.
            Console.WriteLine("What kind of pet do you want?");
            Console.WriteLine("1. Cat");
            Console.WriteLine("2. Dog");
            Console.WriteLine("3. Rabbit");
            //Låter användaren välja ett djur.
            string ans = Console.ReadLine();
            //Kollar vad svaret är.
            //Om svaret är 1 (katt):
            if (ans == "1")
            {
                //Skapar en katt
                Pet katt = new Cat();
                //Instruktion
                Console.WriteLine("Give your cat a name: ");
                //Anropar metoden GiveName i Pet klassen.
                katt.GiveName();
                //Lägger till katten i listan över pets.
                petList.Add(katt);
                //Användarinformation
                Console.WriteLine("New cat created!");
                //Rensar konsollen efter att användaren har klickat på enter
                Console.ReadLine();
                Console.Clear();
                //Kallar metoden MainMenu igen.
                MainMenu();
            }
            //Om svaret är 2 (Hund):
            else if(ans == "2")
            {
                //Skapar en ny hund
                Pet dog = new Dog();
                //Instruktion
                Console.WriteLine("Give your dog a name: ");
                //Anropar metoden GiveName i Pet klassen.
                dog.GiveName();
                //Lägger till hunden i listan över pets.
                petList.Add(dog);
                //Användarinformation
                Console.WriteLine("New dog created!");
                //Rensar konsollen efter att användaren har klickat på enter
                Console.ReadLine();
                Console.Clear();
                //Kallar metoden MainMenu igen.
                MainMenu();
            }
            //Om svaret är 3 (Kanin):
            else if (ans == "3")
            {
                //Skapar en ny kanin
                Pet rabbit = new Rabbit();
                //Instruktion
                Console.WriteLine("Give your rabbit a name: ");
                //Anropar metoden GiveName i Pet klassen.
                rabbit.GiveName();
                //Lägger till kaninen i listan över pets.
                petList.Add(rabbit);
                //Användarinformation
                Console.WriteLine("New rabbit created!");
                //Rensar konsollen efter att användaren har klickat på enter
                Console.ReadLine();
                Console.Clear();
                //Kallar metoden MainMenu igen.
                MainMenu();
            }
            //Om svaret inte är giltit får användaren en instruktion och blir skickad till startmenyn.
            else
            {
                Console.WriteLine("That is not a valid answer, please type a number between 1 - 3 next time.");
                Console.ReadLine();
                MainMenu();
            }
        }

        //Metod för användarinput.
        static int Input()
        {
            //Variabel för resultatet.
            int result;
            //String för användarens input.
            string input = Console.ReadLine().Trim();
            //TryParsar svaret och låter bool succes vara true om det går att TryParsa.
            bool succes = int.TryParse(input, out result);
            //Loop som körs så länge man inte svarar med en siffra.
            while(succes != true)
            {
                //Användarinstruktioner.
                Console.WriteLine("Sorry, thats not a valid answer. Please try again.");
                //Låter användaren skriva igen.
                input = Console.ReadLine().Trim();
                //TryParsar igen.
                succes = int.TryParse(input, out result);
            }
            //Returnar resultatet.
            return (result);
        }
    }
}
