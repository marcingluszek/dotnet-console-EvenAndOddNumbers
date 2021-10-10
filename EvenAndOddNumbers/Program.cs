using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Napisz aplikację, która na podstawie wprowadzonej przez użytkownika liczby, wyświetli odpowiedni komunikat. Jeżeli jest to liczba parzysta – „Liczba parzysta” lub jeżeli jest to liczba nieparzysta –„Liczba nieparzysta”. Wprowadź również walidację danych wprowadzanych przez użytkownika, to znaczy jeżeli użytkownik poda wartość, która nie jest liczbą, to wtedy również powinien zostać wyświetlony odpowiedni komunikat.

2021-10-10
*/

namespace EvenAndOddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome in the EvenAndOddNumbers! We'll check if your number is even or odd!");

            while (true)
            {
                Console.WriteLine("\nType your number:");
                if(int.TryParse(Console.ReadLine(), out int userNum))
                {
                    if (userNum % 2 == 0)
                    {
                        Console.WriteLine("It's the even number!");
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("It's the odd number!");
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine("It's not the number (or it's out of range)!");
                    continue;
                }
            }

            Console.ReadLine();
        }
    }
}
