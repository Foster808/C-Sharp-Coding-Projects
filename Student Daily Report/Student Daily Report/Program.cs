using System;

    class Program
    {
        static void Main()
        {
        Console.WriteLine("The Tech Academy");
        Console.WriteLine("Student Daily Report");
        Console.WriteLine("Hit ENTER to proceed with each step and question");
        Console.ReadLine();

        Console.WriteLine("What course are you on?");
        string studentInput = Console.ReadLine();
        Console.WriteLine("Your current course is: " + studentInput);
        Console.ReadLine();

        Console.WriteLine("What page number?");
        string studentInput1 = Console.ReadLine();
        Console.WriteLine("Your current page number is: " + studentInput1);
        Console.ReadLine();


        //start true/false
        Console.WriteLine("Please answer True or False...");
        Console.WriteLine("Do you need help with anything?");
        Console.ReadLine();

        bool inputTrue = true;

        if (inputTrue == true)
        {
            Console.WriteLine("Great. An Instructor will be in touch with you shortly.");
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("Awesome. You're doing fantastic!");
        }
        Console.ReadLine();
        //end of true/false

        Console.WriteLine("Were there any positive experiences? Please give specifics.");
        Console.ReadLine();

        Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
        Console.ReadLine();

        Console.WriteLine("How many hours did you study today?");
        string studentInput2 = Console.ReadLine();
        Console.WriteLine("Your hours studied today are " + studentInput2);
        Console.ReadLine();

        Console.WriteLine("Thank You for your answers. An instructor will respond to this shortly. Have a great day!");
        Console.ReadLine();
        }
    }
