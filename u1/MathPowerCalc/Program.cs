
/*

- Berechnen Sie $b^n$ ($b$ hoch $n$) für feste natürliche Zahlen $b$ und $n$.
- Implementieren Sie die Methode `Power`, die $b$ und $n$ übergeben bekommt und das Ergebnis zurückgibt.
- Geben Sie das Ergebnis formatiert aus.

*/
using System;
namespace mySolution.u1;

static class Program
{
    static void Main()
    {
        //x hoch n

        int c = Power(2,3);
        Console.WriteLine(c);

    }
    static int Power(int x, int n)
    {
        int result = 1;
        for(int i = 0; i < n; i++)
        {
            result *= x;
        }
        return result ;
    }
}