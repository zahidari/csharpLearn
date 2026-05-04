/*
Ziel
Schaltjahre prüfen.

Erläuterung
Der gregorianische Kalender wurde 1582 von Papst Gregor XIII. als Reform des julianischen Kalenders eingeführt und 
ist heute der weltweit meistgenutzte Kalender.

Der Kalender führte eine Verfeinerung des Schaltregel ein: 

demnach ist ein Jahr ein Schaltjahr, falls die Jahreszahl durch vier teilbar ist, aber nicht durch 100,
es sei denn, sie ist durch 400 teilbar. Demnach waren die Jahre 1700, 1800 und 1900 keine Schaltjahre, 
die Jahre 1600 und 2000 aber schon.

Schritte
Legen Sie ein neues Konsolen-Projekt an.
Implementieren Sie die Methode IsLeapYear, die als Parameter eine Jahreszahl als Integer
 entgegennimmt und den entsprechenden Booleschen Wert zurückliefert, falls das Jahr ein Schaltjahr ist.
Testen Sie Ihre Methode mit geeigneten Jahreszahlen und einer formatierten Ausgabe.
*/


using System;
namespace u2.Bavronil;

static class Program
{
    static bool Durch4(int jahr)   => jahr % 4   == 0;
    static bool Durch100(int jahr) => jahr % 100 == 0;
    static bool Durch400(int jahr) => jahr % 400 == 0;

    static bool IsLeapYear(int jahr)
    {
        if (Durch400(jahr)) return true;
        if (Durch100(jahr)) return false;
        return Durch4(jahr);
    }

    static void Main()
    {
        Console.WriteLine(IsLeapYear(1600));
        




    }
}