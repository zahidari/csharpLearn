using System;
namespace mySolution.u1;

static class Program
{
    static void Main()
    {
        Tests();
        
    }
    static bool isPrime(int n)
    {   
        if(n < 2)return false;

        for(int i = 2; i <= n/2; i++)
        {
            if(n % i == 0)
                return false;
        }
        return true; 
    }
    static void PrintPrimes(int n)
    {
        for(int i = 1; i <= n; i ++)
        {
            if(isPrime(i))
                Console.WriteLine(i);
        }
    }
    static void Tests()
    {
        Console.WriteLine(isPrime(1));
        Console.WriteLine(isPrime(13));
        Console.WriteLine(isPrime(4));
        PrintPrimes(5);
        PrintPrimes(100);
    }
}