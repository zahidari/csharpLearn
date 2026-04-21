using System;

namespace mySolution.u1.Awh;


static class Program
{
    static void Main()
    {
        int n = 100000;
        Console.WriteLine("TeilSummanden:  "+dTeilsummandenAddieren(n));
        Console.WriteLine("Left to Right:  "+ dLeftToRight(n));
        Console.WriteLine("Right to left:  "+dRightToLeft(n));
        
        //10**(-13) faengt erst an die Ungenauhigkeit
        Console.WriteLine($"Korrecte summe: "+ Math.Log(2) );
        Console.WriteLine("decimal n     : "+decimalHar(n));
        ChatGptLosung();
    }
    static double dLeftToRight(int n)
    {
        double sum=0;
        for(int i = 1; i <= n; i++)
        {   
            double t = (double)i;
            if(i%2 == 0)
                sum -= 1 / t;
            else
                sum += 1/ t;
        }
        return sum;
    }
    static double dRightToLeft(int n)
    {
        double sum = 0;
        for(int i = n; i >= 1;  i--)
        {
            if(i % 2 == 0)
                sum -= 1.0/i;
            else
                sum+=1.0/i;
        }
        return sum;
    }
    static double dTeilsummandenAddieren(int n)
    {
        double positivenSummanten = 0;
        double negativenSummanten= 0;

        //Enumerable.Range(1,1000).Select(_=> ).Where()

        for(int i = 1; i <= 1000; i++)
        {
            if(i % 2 == 0)
                negativenSummanten += 1.0/i;
            else
                positivenSummanten +=1.0/i;
        }

        return positivenSummanten - negativenSummanten;
    }
    static decimal decimalHar(int n)
    {
        decimal sum = 0;
        for(int i = 1; i <= n; i++)
        {   
            decimal t = (decimal)i;
            if(i%2 == 0)
                sum -= 1 / t;
            else
                sum += 1 / t;
        }
        return sum;
   }
    static void ChatGptLosung()
    {
        int n = 1000;

        // double

        double leftToRight = 0.0;

        for (int k = 1; k <= n; k++)
        {
            leftToRight += (k % 2 == 1) ? 1.0 / k : -1.0 / k;
        }
        double rightToLeft = 0.0;
        for (int k = n; k >= 1; k--)
        {
            rightToLeft += (k % 2 == 1) ? 1.0 / k : -1.0 / k;
        }
        double positive = 0.0;
        double negative = 0.0;
        for (int k = 1; k <= n; k++)
        {
            if (k % 2 == 1)
                positive += 1.0 / k;
            else
                negative += 1.0 / k;
        }

        double separate = positive - negative;

        Console.WriteLine("double:");
        Console.WriteLine($"links nach rechts:      {leftToRight}");
        Console.WriteLine($"rechts nach links:      {rightToLeft}");
        Console.WriteLine($"positive/negative:      {separate}");
        Console.WriteLine($"ln(2):                  {Math.Log(2)}");
        Console.WriteLine();

        // decimal

        decimal leftToRightDec = 0m;

        for (int k = 1; k <= n; k++)

        {

            leftToRightDec += (k % 2 == 1) ? 1m / k : -1m / k;

        }

        decimal rightToLeftDec = 0m;

        for (int k = n; k >= 1; k--)

        {

            rightToLeftDec += (k % 2 == 1) ? 1m / k : -1m / k;

        }

        decimal positiveDec = 0m;

        decimal negativeDec = 0m;

        for (int k = 1; k <= n; k++)

        {
            if (k % 2 == 1)
                positiveDec += 1m / k;
            else
                negativeDec += 1m / k;
        }
        decimal separateDec = positiveDec - negativeDec;
        Console.WriteLine("decimal:");
        Console.WriteLine($"links nach rechts:      {leftToRightDec}");
        Console.WriteLine($"rechts nach links:      {rightToLeftDec}");
        Console.WriteLine($"positive/negative:      {separateDec}");

    }
}