using System;
using System.ComponentModel;
using System.Security.Cryptography;

namespace factorialdealings;
public class factorial
{
    public int num1;
    public int n, r, npr, ncr;

    public  int fact(int num)
    {
        int factorial1 = 1;
        for (int i=1; i<=num; i++)
        {
            factorial1 = factorial1 * i;
        }
        return factorial1;
    }
    public void combnumber()
    {
        Console.WriteLine("ENter the value of N");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("ENter the value of R");
        int r = Convert.ToInt32(Console.ReadLine());
        ncr = combination(n, r);
        npr = permutation(n, r);
        Console.WriteLine(npr);
        Console.WriteLine(ncr);
    }
    public void number()

    {
        Console.WriteLine("ENter the number to find it factorial");
        num1 = Convert.ToInt32((Console.ReadLine()));

    }
    public void display()
    {
        number();
        Console.WriteLine(fact(num1));

    }
    public void d2()
    {
        combnumber();
       
    }

    public int permutation(int n, int r)
    {
        //n!/(n-R)!
       
       npr = ((fact(n))/(fact(n-r)));
        return npr;
    }
    public int combination(int n, int r)
    {
        //n!/(n-r)!r!
        ncr = ((fact(n)) / ((fact(n - r)) * fact(r)));
        return ncr;
    }


    public static void Main(string[] args)
    {
        int r1, n1;
        int npr, cnr;
        factorial fb = new factorial();
        fb.display();
       fb.d2();
       
     /*   Console.WriteLine("ENter the value of N");
        n1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("ENter the value of R");
        r1 = Convert.ToInt32(Console.ReadLine());
        npr = fb.combination(n1, r1);
        Console.WriteLine(npr);*/
        /* Console.WriteLine("Enter number");
         int numb = int.Parse(Console.ReadLine());
         int ans = fb.fact(numb);
         Console.WriteLine(ans);*/
    }
}