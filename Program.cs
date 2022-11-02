double possiblePoints = 0;
double points = 0;

Console.WriteLine("Did you participated the first exam? ");
string first = Console.ReadLine()!;

switch (first)
{
   case "yes": 
   Console.WriteLine("How many points did you get (0-20)?");
   points += int.Parse(Console.ReadLine()!);
   possiblePoints+=20;
   break; 
}


Console.WriteLine("Did you participated the second exam? ");
string second = Console.ReadLine()!;

switch (second)
{
   case "yes": 
   Console.WriteLine("How many points did you get (0-20)?");   
   points += int.Parse(Console.ReadLine()!);
   possiblePoints+=20;
   break; 
}


Console.WriteLine("Have you done an oral exam? ");
string oral = Console.ReadLine()!;

switch (oral)
{
   case "yes": 
   Console.WriteLine("How many points did you get (0-20)?");
   points += int.Parse(Console.ReadLine()!);
   possiblePoints+=20;
   break; 
}


Console.WriteLine("How many points did you get for your homework(0-20)? ");
double pointsHomework = double.Parse(Console.ReadLine()!);
possiblePoints += 20;

double percentage = points/ possiblePoints * 100;


if (percentage < 50)
{
    Console.WriteLine("Your grade is: 5");
}

else if (percentage < 63)
{
    Console.WriteLine("Your grade is: 4");
}

else if (percentage < 76)
{
    Console.WriteLine("Your grade is: 3");
}

else if (percentage < 89)
{
    Console.WriteLine("Your grade is: 2");
}

else if (percentage >= 89)
{
   Console.WriteLine("Your grade is: 1");
}


double percentageHomework = (points + 20)/ possiblePoints * 100;

if (percentageHomework < 50)
{
    Console.WriteLine("Your grade is: 5");
}

else if (percentageHomework < 63)
{
    Console.WriteLine("Your grade is: 4");
}

else if (percentageHomework < 76)
{
    Console.WriteLine("Your grade is: 3");
}

else if (percentageHomework < 89)
{
    Console.WriteLine("Your grade is: 2");
}

else if (percentageHomework >= 89)
{
   Console.WriteLine("Your grade is: 1");
}


if (percentageHomework > percentage)
{
   Console.WriteLine("You could have gotten a better grade if you had done the homework!");
}
