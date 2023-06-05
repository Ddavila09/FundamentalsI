// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// 1
for (int i = 1; i <= 255; i++)
{
    Console.WriteLine(i);
}

// 2
Random random = new Random();

for (int i = 0; i < 5; i++)
{
    int randomNumber = random.Next(10, 21);
    Console.WriteLine(randomNumber);
}

// 3
Random randoms = new Random();
int sum = 0;

for (int i = 0; i < 5; i++)
{
    int randomNumb = randoms.Next(10, 21);
    Console.WriteLine(randomNumb);
    sum += randomNumb;
}

Console.WriteLine("Sum: " + sum);

// 4
for (int i = 1; i <= 100; i++)
{
    if ((i % 3 == 0 || i % 5 == 0) && !(i % 3 == 0 && i % 5 == 0))
    {
        Console.WriteLine(i);
    }
}

// 5
for (int i = 1; i <= 100; i++)
{
    if (i % 3 == 0)
    {
        Console.WriteLine("Fizz");
    }

    if (i % 5 == 0)
    {
        Console.WriteLine("Buzz");
    }

    if (i % 3 != 0 && i % 5 != 0)
    {
        Console.WriteLine(i);
    }

    Console.WriteLine();
}

// 6
for (int i = 1; i <= 100; i++)
{
    if (i % 3 == 0 && i % 5 == 0)
    {
        Console.WriteLine("FizzBuzz");
    }

    else if (i % 3 == 0)
    {
        Console.WriteLine("Fizz");
    }

    else if (i % 5 == 0)
    {
        Console.WriteLine("Buzz");
    }

    else 
    {
        Console.WriteLine(i);
    }

}