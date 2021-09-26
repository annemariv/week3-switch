using System;

namespace GradingSwitch
{
    class Program
    {
        static void Main(string[] args)
        {

            //programm küsib, mis hinde kasutaja sai
            //kui kasutaja sai "A", konsool kuvab "Suureärane!";
            //kui tulemus on "B", konsool kuvab "Väga hea!";
            //kui tulemus on "C", konsool kuvab "Hea!";
            //kui kasutaja sai "D", konsool kuvab "Rahuldav!";
            //kui kasutja sai "E", konsool kuvab "Kasin!";
            //kui "F", konsool kuvab "Puudulik".
            //kui kasutaja isestab midagi muud, siis konsool kuvab "vale väärtus"

            //kasutame switch

            Console.WriteLine("Sisesta oma tulemus:");
            char userResult = Convert.ToChar(Console.ReadLine().ToUpper());

            switch (userResult)
            {

                case 'A': 
                    Console.WriteLine("Suurepärane");
                    break;
                case 'B':
                    Console.WriteLine("Väga hea!");
                    break;
                case 'C':
                    Console.WriteLine("Hea!");
                    break;
                case 'D':
                    Console.WriteLine("Rahuldav!");
                    break;
                case 'E':
                    Console.WriteLine("Kasin!");
                    break;
                case 'F':
                    Console.WriteLine("Puudulik!");
                    break;
                default:
                    Console.WriteLine($"Vale väärtus.");
                    break;

            }
            Console.WriteLine("Head päeva!");

        }
    }
}
