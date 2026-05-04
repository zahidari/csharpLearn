/*
### Ziel

Mathematische Funktion mit Fallunterscheidung erzeugen.

### Schritte

- Legen Sie ein neues Konsolen-Projekt an.
- Implementieren Sie eine Methode, die die folgende Funktion für Integer implementiert: $f(n) = \frac{n}{2}$, falls $n \ge 0$ und gerade; $f(n) = 0$ sonst.
- Nutzen Sie den Modulo-Operator `%` und den Bedingungsoperator `?`
- Testen Sie die Methode mit einigen Beispielzahlen und einer formatierten Ausgabe.
*/


using System;
namespace u2.batha;

static class Program
{
    static int func(int  n)
    {
        return (n >= 0 && n%2 == 0)? n/2 : 0;
    }

    static void Main()
    {
        var n = func(28);
        System.Console.WriteLine($"n ist : {n:b}");

        var pi = 31.41592123;
        Console.WriteLine($"pi ist: {pi:f3}");
        Console.WriteLine($"pi ist: {pi:e2}");
        Console.WriteLine($"pi ist: {pi:#.###}");
        var prozent = 0.213;
        Console.WriteLine($"pi ist: {prozent:p1}");
        


     
    }
}