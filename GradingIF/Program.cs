using System;

namespace GradingIF
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

            //kasutame IF

            Console.WriteLine("Sisesta oma tulemus:");
            //char = character
            char userResult = Convert.ToChar(Console.ReadLine().ToUpper());

            if(userResult == 'A')
            {
                Console.WriteLine("Suurepärane!");

            }
            else if (userResult == 'B')
            {
                Console.WriteLine("Väga hea!");
            }
            else if (userResult == 'C')
            {
                Console.WriteLine("Hea!");
            }
            else if (userResult == 'D')
            {
                Console.WriteLine("Rahuldav!");
            }
            else if (userResult == 'E')
            {
                Console.WriteLine("Kasin!");
            }
            else if (userResult == 'F')
            {
                Console.WriteLine("Puudulik!");
            }
            else
            {
                Console.WriteLine($"Vale väärtus.");

            }

            Console.WriteLine("Head päeva!");
        }


        }
    }
