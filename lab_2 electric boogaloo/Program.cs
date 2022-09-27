using System;


bool run = true;
while (run)
{
    Console.WriteLine("What is your name?");
    string name = Console.ReadLine();
    Console.WriteLine(" Enter a number 1-100 \n");
    int num = int.Parse(Console.ReadLine());
    
   if (num < 60 && num % 2 == 1)
    {
        Console.WriteLine(" Your number is odd and under 60 \n");
    }
     else if (num > 60 && num % 2 == 1) 
    {
        Console.WriteLine(" Your number is odd and above 60 \n");
    }   
    else if (num < 60 && num % 2 == 0)
    { 
            Console.WriteLine(" Your number is even and under 60 \n");
    }
       if (num % 2 == 0 && num >=2 && num <= 24)
    {
        Console.WriteLine(" This number is even and between 2 and 24 exclusive \n");

    }
      else if (num % 2 == 0 && num >= 2 || num <= 100)
    {
        Console.WriteLine(" Your number is even but not between 2 and 24 inxclusive \n");
    }
    Console.WriteLine(" Would you like to continue \n");
    string input = Console.ReadLine().ToLower();
    if (input == "n")
    {
        run = false;
    }
}
