using System;

namespace ovningsuppgfit
{ 
    class Program
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Berätta din ålder för att ta reda på om du får vara med i tävlingen");
            int ålder = int.Parse(Console.ReadLine());

            if (ålder >= 16 && ålder <= 19)
            {
                Console.WriteLine("Du får vara med i tävlingen");
            }
            
            else
            {
                Console.WriteLine("Du får tyvärr inte vara med i tvävlingen");
            }
        }
    }
}
