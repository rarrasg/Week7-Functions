using System;

namespace UserNameDataTask
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja eesnime
            //programm palub kasutajal sisestada numbrit 1-3
            //kui kasutaja sisestab '1', siis kuvatakse kasutaja eesnime tagurpidi
            //kui kasutaja sisestab '2', siis kuvatakse kasutaja eesnime esimest tähte
            //kui kasutaja valib 3, siis kuvatakse kasutaja eesnime pikkust

            Console.WriteLine("Sisesta oma eesnimi:");
            string userName = Console.ReadLine();

            Console.WriteLine("Sisesta number 1-3.");
            char userNumber = Convert.ToChar(Console.ReadLine());

            switch(userNumber)
            {
                case '1':
                    UserNameReversed(userName);
                    break;
                case '2':
                    UserNameFirstChar(userName);
                    break;
                case '3':
                    UserNameLength(userName);
                    break;             
            }
        }

        public static void UserNameReversed(string userInput)
        {
            Console.Write("Sinu nimi tagurpidi kirjutatuna on: ");
            for(int i = userInput.Length - 1; i >= 0; i--)
            {
                Console.Write(userInput[i]);
            }              
        }

        public static void UserNameFirstChar(string userInput)
        {
            Console.WriteLine($"Sinu eesnime esimene täht on: {userInput[0]}");
        }
        
        public static void UserNameLength(string userInput)
        {
            Console.WriteLine($"Sinu eesnime pikkus on: {userInput.Length} sümbolit.");
        }
    }
}
