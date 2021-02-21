using System;

namespace LesBouclesExo1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            /*Afficher 10 fois le message suivant dans la console :
            «Bonjour, je ne suis qu'un simple message.»*/

            int counter = 0;
            while (counter < 10)
            {
                Console.WriteLine($"Bonjour, je ne suis qu'un simple message {counter}");
                counter++;
            }
        }
    }
}
