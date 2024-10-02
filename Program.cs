// See https://aka.ms/new-console-template for more information


Console.Write("Enter a Number");

int number = Convert.ToInt32(Console.ReadLine());
if (number % 5 == 0)
{
    Console.WriteLine("Output:Yes");
}
else
{
    Console.WriteLine("Output:No");

}

int x1 = 5;
int y1 = 10;
Console.WriteLine("x = 5;y=10");
Console.WriteLine($"x+y={x1 + y1}");
if (x1 > y1)
{
    Console.WriteLine($"x-y={x1 - y1}");

}
else
{
    Console.WriteLine($"y-x={y1 - x1}");

}

Console.WriteLine($"x*y={x1 * y1}");


Console.WriteLine($"x/y={x1 / y1}");

if (y1 != 0 && x1 != 0)
{
    if (x1 > y1)
    {
        Console.WriteLine($"x/y={x1 / y1}");
    }
    else
    {
        Console.WriteLine("not allowed to divide by zero");
    }
}



int x2 = 0;
int y2 = 20;
Console.WriteLine("x = 0;y=20");
Console.WriteLine($"x+y={x2 + y2}");
if (x2 > y2)
{
    Console.WriteLine($"x-y={x2 - y2}");
}
else
{
    Console.WriteLine($"y-x={y2 - x2}");
}

Console.WriteLine($"x*y={x2 * y2}");
if (y2 != 0 && x2 != 0)
{
    if (x2 > y2)

    {
        Console.WriteLine($"x/y={x2 / y2}");
    }


}
else
{
    Console.WriteLine("not allowed to divide by zero");
}

int x = 5;
int y = 12;
int temp;
temp = x;
x = y;
y = temp;
Console.WriteLine($"after swap: x={x}, y={y}");



int input = 5;
for (int i = 1; i <= 9; i++)
{
    Console.WriteLine($"{input} *{i}={input * i}");
}

int n = 10;
for (int i = 1; i <= n; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine($"{i * i}");

    }
}