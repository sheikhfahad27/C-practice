// string city = "karachi";
// string profession = "web developer";
// int experience = 2;


// Console.WriteLine(city);
// Console.WriteLine(professions);
// Console.WriteLine(experience);


// Console.WriteLine($"I live in {city}");
// Console.WriteLine($"I am a {profession}");
// Console.WriteLine($"I have {experience} years of experience");


// Console.WriteLine("i live in" + city);
// Console.WriteLine("i am a " + professions);
// Console.WriteLine("I have " + experience +  " years of experience");





// int age = 10;

// if (age >= 18)
// {
//     Console.WriteLine("You are an audit");
// }
// else if (age >= 13)
// {
//     Console.WriteLine("Teenager");
// }
// else
// {
//     Console.WriteLine("Child");
// }




// Console.Write("Enter your name: ");
// string name = Console.ReadLine();
// Console.Write("Enter your city: ");
// string city = Console.ReadLine();

// Console.WriteLine("Hello " + name);
// Console.WriteLine("You live in " + city);




// Console.Write("Enter your name: ");
// string name = Console.ReadLine();

// Console.Write("Enter your age: ");
// int age = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Hello " + name);
// Console.WriteLine("Your age is " + age);


// Console.Write("Enter your age: ");
// int age = Convert.ToInt32(Console.ReadLine());

// int nextYear = age + 1;

// Console.WriteLine("Next year you will be " + nextYear);






// Console.Write("Enter your name: ");
// string name = Console.ReadLine();

// Console.WriteLine("Enter your age: ");
// int age = Convert.ToInt32(Console.ReadLine());

// int nextYear = age + 1;


// Console.WriteLine("Hello " + name);
// Console.WriteLine("Your age is " + age);
// Console.WriteLine("Next year you will be " + nextYear);


// if (age >= 18)
// {
//     Console.WriteLine("You are an adult");
// }
// else
// {
//     Console.WriteLine("You are under 18");
// }





// int a = 20;
// int b = 5;

// Console.WriteLine(a + b);
// Console.WriteLine(a - b);
// Console.WriteLine(a * b);
// Console.WriteLine(a / b);
// Console.WriteLine(a % b);







// Console.Write("Enter First number: ");
// int num1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Enter second number: ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(num1 + num2);
// Console.WriteLine(num1 - num2);
// Console.WriteLine(num1 * num2);
// Console.WriteLine(num1 / num2);
// Console.WriteLine(num1 % num2);








// Console.Write("Enter a number: ");
// int number = Convert.ToInt32(Console.ReadLine());

// if (number % 2 == 0)
// {
//     Console.WriteLine("Even");
// }
// else
// {
//     Console.WriteLine("Odd");
// }








// for (int i = 1; i <= 10; i++)
// {
//     Console.WriteLine(i);
// }




// for (int i = 2; i <= 10; i++)
// {
// if (i % 3 == 0)
// {
//     Console.WriteLine(i);
// }
// }




// Console.Write("Enter a number: ");
// int number = Convert.ToInt32(Console.ReadLine());

// for (int i = 1; i <= 10; i++)
// {
//     Console.WriteLine(number + " x " + i + " = " + (number * i));
// }


// Console.Write("Enter a number: ");
// int number = Convert.ToInt32(Console.ReadLine());

// for (int i = 1; i <=10; i++)
// {
//     Console.WriteLine(number + " x " + i + " = " + (number * i));
// }







// int i = 1;

// while (i <= 5)
// {
//     Console.WriteLine(i);
//     i++;
// }


// int i = 1;

// while (i <= 10)
// {
//     Console.WriteLine(i);
//     i++;
// }









// void CalculateSquare(int number)
// {
//     Console.WriteLine("Enter a number " + number);
//      Console.WriteLine("Square: " + (number * number));
    
// }



// CalculateSquare(5);


// Console.Write("Enter a number: ");
// int number = Convert.ToInt32(Console.ReadLine());

// CalculateSquare(number);

// void CalculateSquare(int number)
// {
//     Console.WriteLine("Square: " + (number * number));
// }


// Console.WriteLine("Enter your name");
// string name = Console.ReadLine();

// Console.WriteLine("Hello " + name);


// Console.WriteLine("Enter your age " );
// int age = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Your age is ");


// int age = 19;

// if (age >= 18)
// {
//     Console.WriteLine("You are eligible");
// }

// else
// {
//     Console.WriteLine("you are no eligible");
// }






// Console.WriteLine("Enter your first number: ");
// int a = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Enter your second number: ");
// int b = Convert.ToInt32(Console.ReadLine());


// int result = a + b ;


// Console.WriteLine("First number: " + a);
// Console.WriteLine("Second number: " + b);


// Console.WriteLine("Addition = " + result);



// Console.WriteLine("Enter your first number: ");
// int a = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Enter your Second number: ");
// int b = Convert.ToInt32(Console.ReadLine());


// int result = a - b ;

// //  Console.WriteLine("First number: " - a);
// //  Console.WriteLine("Second number: " - b);

// Console.WriteLine("Subtraction = " + result);



// DateTime dt = DateTime.Now;
// Console.WriteLine("{0:d}" , dt);
// Console.WriteLine("{0:f}" , dt);
// Console.WriteLine("{0:F}" , dt);
// Console.WriteLine("{0:g}" , dt);
// Console.WriteLine("{0:d} {1:D}" , dt , dt);
// Console.WriteLine("{0:yyy}" , dt);
// Console.WriteLine("{0:dd/MM/yyyy}" , dt);
// Console.ReadLine();









// class Program
// {
    
//     public const string company_name  = "My company";

//     static void Main (string [] args)
//     {
//         Console.WriteLine(company_name);
//         Console.ReadLine();
//     }
// }



// class Program
// {

//     static void Main (string [] args)
//     {
//        int a = 10 , b = 5 , c , d , e ,f ,g;
//     c = a + b;
//     d = a - b;
//     e = a * b;
//     f = a / b;
//     g = a % b;

//         Console.WriteLine(c);
//         Console.WriteLine(d);
//         Console.WriteLine(e);
//         Console.WriteLine(f);
//         Console.WriteLine(g);

//         Console.ReadLine();
//     }
// }





class Program
{

    static void Main (string [] args)
    {
        int a = 20;
        int b = 30;

        // bool c = a <= b;
        // bool c = a == b;
        // bool c = a >= b;
        bool c = a != b;
        

        Console.WriteLine(c);
        

        Console.ReadLine();
    }
}