using System;

namespace Challenge1
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Choose a Funtion!");
            Console.WriteLine("[0]-HexFuntion");
            Console.WriteLine("[1]-NextPrimeNumber");
            int option;
            option = int.Parse(Console.ReadLine());
            while(true)
            {
                switch(option)
                {
                    case 0: 
                    Console.WriteLine("---Hex Function---");
                    HexFunction();
                    break;
                    
                    case 1: 
                    Console.WriteLine("---Next Prime Number---");
                    NextPrimeNumber();
                    break;
                    default:
                    Console.WriteLine("Your input was not an option pleas enter either 0 or 1.");
                    break;
                }
            }
        }

        static void HexFunction()
        {
                Console.WriteLine("This function determines whether a string is a valid hex code.");
            while(true)
            {
                    string[] GZ = {"G","H","I","J","K","L","M","N","O","P","Q","R","S","T","U","V","W","X","Y","Z",
                                "g","h","i","j","k","l","m","n","o","p","q","r","s","t","u","v","w","x","y","z",
                                "!","@","$","%","^","&","*","(",")","`","~","-","_","+","=","{","}","[","]","|","/","?","<",">",",",".", "'"};
                    bool containsGZ = false;
                    Console.WriteLine("Please input a hex code.");
                try
                {
                    string input;
                    Console.Write("Your input: ");
                    input = Console.ReadLine();
                    string hashtag = input.Substring(0, 1);
                
                    foreach (string letter in GZ)
                    {
                        if(input.Contains(letter))
                        {
                            containsGZ = true;
                        }
                    }
                    if(input.Length != 7 || hashtag != "#" || containsGZ)
                    {
                        
                        Console.WriteLine(input + " is not valid Hex!");
                        Console.WriteLine("Make sure the hex code starts with '#', has a length of 7 including the hashtag, has no special characters, and only contains digits 0-9 and letters A-F.");
                        Console.WriteLine(" ");
                    }
                    else
                    {
                        Console.WriteLine(input + " is valid hex code.");
                        break;
                    }
                }
                catch(ArgumentOutOfRangeException)
                {
                    Console.WriteLine("Your input could not be read, please enter a hex code!");
                    Console.WriteLine(" ");
                }
                
            }

        }


        static void NextPrimeNumber()
        {
            Console.WriteLine("This function finds the next prime number after an input.");
            Console.WriteLine("Please input any positive number.");
            
            int input;
            while(true)
            {
                Console.Write("Your Input: ");
                try
                {
                    input = int.Parse(Console.ReadLine());
                    bool Pinput = false;
                    if(IsPrime(input))
                    {
                        Console.WriteLine(input + " is a prime number!");
                        Pinput = true;
                    }
                    else
                    {
                        while(Pinput == false)
                        {
                            input++;
                            if(IsPrime(input))
                            {
                                Pinput = true;
                            }
                        }
                        Console.WriteLine("The Next Prime is " + input);
                    }
                }
                catch(FormatException)
                {
                    Console.WriteLine("Your input could not be read, please enter a number!");
                    Console.WriteLine(" ");
                }
                
            }


        }
        static bool IsPrime(int num)
        {
            if(num <= 1) return false;
            if(num <= 3) return false;

            if(num % 2 == 0 || num % 3 == 0)
            return false;

            for(int i = 5; i * i <= num; i = i + 6)
            {
                if(num % i == 0 || num % (i + 2) == 0)
                return false;
            }

            return true;
        }
    }
}