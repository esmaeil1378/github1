﻿class program
{
    
    static void Main()
    {

        Console.WriteLine(  "please enter a number :");
        int num;
        num = int.Parse(Console.ReadLine());
        switch (num)
        {
            case 1:
                Console.WriteLine("one");
                break;
            case 2:
                Console.WriteLine("two");
                break;
            case 3:
                Console.WriteLine("three");
                break;
            default:
                Console.WriteLine("error");
                break;
        }






    }

}