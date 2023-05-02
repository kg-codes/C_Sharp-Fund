// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// 1.)
for (int i = 1; i <= 255; i++)
{
    Console.WriteLine(i);
}

// 2.)
Random rand = new Random();
for (int i = 1; i <= 5; i++)
{
    Console.WriteLine(rand.Next(10,21));
}

// 3.)
Random rand = new Random(); // rand is red underlined because you have already declared rand as a new Random in the previous task, so all good.
int sum = 0;
for (int i = 1; i <=5; i++)
{
    int NewRandom = rand.Next(10, 21);
    Console.WriteLine(NewRandom);
    sum += NewRandom;
}
Console.WriteLine(sum);

// 4.)
for (int i = 1; i <= 100; i++)
{
    if ((i % 3 == 0 || i % 5 == 0) && !(i % 3 == 0 && i % 5 ==0))
    {
        Console.WriteLine(i);
    }
}

// 5.)
for (int i = 1; i <= 100; i++)
{
    if (i % 3 == 0 && i % 5 != 0)
    {
        Console.WriteLine(i);
        Console.WriteLine("Fizz");
    }
    else if (i % 5 == 0 && i % 3 != 0)
    {
        Console.WriteLine(i);
        Console.WriteLine("Buzz");
    }
}

// 6.)
for (int i = 1; i <= 100; i++)
{
    if (i % 3 == 0 && i % 5 != 0)
    {
        Console.WriteLine(i);
        Console.WriteLine("Fizz");
    }
    else if (i % 5 == 0 && i % 3 != 0)
    {
        Console.WriteLine(i);
        Console.WriteLine("Buzz");
    }
    else if (i % 3 == 0 && i % 5 == 0)
    {
        Console.WriteLine(i);
        Console.WriteLine("FizzBuzz");
    }
}


