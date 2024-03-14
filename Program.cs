// Loop throught numbers 0 throught 100
// And display is the number is even or odd

for(int number = 0; number <= 100; number++)
{
    // example:
    // 2 / 2 ... 0
    // 5 / 2 = ... 1 leftover
    if (number % 2 == 0)
    {
        Console.WriteLine($"The number {number} is Even");
    }
    else{
        Console.WriteLine($"The number {number} is Odd");
    }
}