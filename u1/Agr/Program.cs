using System;
using System.Linq; // für Enumerable
using System.Collections.Generic; // Datenstrukturen (list, Dictionary,hashset,queue,stack,linkedlsist)

namespace mySolution.u1.Agr;

static class Program
{
    static void Main()
    {
        //array mit 10 zufallszahlen zwischen 1 - 100, for ausgeben
        int [] randomNums;
        //namespace ist System für random numbers erzeugen.
        var rand = new Random();
        randomNums = rand.GetItems<Int32>(
            Enumerable.Range(1,100).ToArray(),
            4
        );
        int randNumber = rand.Next(1,101);
        System.Console.WriteLine($"random Number: {randNumber}\n");

        for(int i = 0; i< randomNums.Length; i++)
        {
        Console.WriteLine(randomNums[i]);
        }
        //dynamische liste mit zufallszahlen auch von 1 bis 100 mit foreach ausgeben
        /*  
        var even = Enumerable
            .Repeat(0, 10)
            .Select(_ => System.Security.Cryptography.RandomNumberGenerator.GetInt32(1, 101))
            .Where(.Where(Int32.IsEvenInteger(even)); // x => x % 2 == 0

        Console.WriteLine(string.Join(",", even));*/
        List<int> numberList = Enumerable
                                .Range(1,10)
                                .Select( _ => rand.Next(1,101))
                                .ToList();

        foreach( var x in numberList)
        {
            Console.Write(x);
            Console.Write(",");
        }
        Console.WriteLine("\n");
        //string.join() mit string interpolation nutzen
        string numberOutput = string.Join(",", numberList);
        Console.WriteLine(numberOutput);

        //zweite array erzeugen mit gerden zahlen, aus der ersrten array
        var arrayMitGerade = numberList
                            .Where(x => x %2 == 0)
                            .ToArray();
        Console.WriteLine(string.Join(",",arrayMitGerade));         

    }
}