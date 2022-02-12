using System;

namespace LoginValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada kasutajatunnus ja salasõna
            //kui sisestatud kasutajatunnus on "admin" ja salasõna on "admin1234"
            //siis konsoolis kuvatakse "Tere tulemast"
            //muul juhul konsoolis kuvatakse "Vale kasutajatunnus või salasõna. Proovi uuesti."
            //Kasutajal on kolm katset.
            int i = 0;
            while (i < 3)
            {
            Console.WriteLine("Sisesta kasutajatunnus.");
            string userName = Console.ReadLine();
            Console.WriteLine("Siseta salasõna.");
            string userPassword = Console.ReadLine();
            if(userName == "admin" && userPassword == "admin1234")
            {
                Console.WriteLine("Tere tulemast.");
                    break;
            }
            else
            {
                    i = i + 1;
                Console.WriteLine("Vale kasutajatunnus võu salasõna. Proovi uuesti");
                Console.WriteLine($"{3-i} katset on jäänud");
            }
            }
        }
    }
}
