using System;

namespace mySolution.u1;


static class Program
{
    
    static void Main()
    {
        //Die Fibonacci-Folge berechnen.
   
     

        Test();

        


    }
    static int forFibo(int n)
    {   
        if(n < 0) throw new ArgumentException("n darf nicht negativ sein!");
        if(n < 2) return 1;

        int fnMinus2 = 1; // fn-2
        int fnMinus1 = 1; // fn-1
        int fn = 1;
        
        for(int i= 2 ;i <=n; i++)
        {
            fnMinus2 = fnMinus1;
            fnMinus1 = fn;
            fn =fnMinus1 + fnMinus2;
        }
        return fn;
    }
    static int doWhileFibo(int n)
    {
        if(n < 0) throw new ArgumentException("n darf nicht negativ sein!");
        if(n <= 2) return 1;

        int i = 2;

        int fb = 0;
        int fb1= 1;
        int fb2= 1;
        do
        {
            fb += fb1 + fb2;
            fb2 = fb1;
            fb1 = fb;

            ++i;

        } while(i < n);

        return fb;
    }
    static int whileFibo(int n)
    {
        if(n < 0) throw new ArgumentException("n darf nicht negativ sein!");
        if(n < 2) return 1;
        return -1;
    }

    static void Test()
    {
        //for(int i = 1; i< 8;i++)
        //Console.WriteLine(forFibo(i));

        for(int i = 1; i< 8;i++)
        Console.WriteLine(doWhileFibo(i));
    }
}