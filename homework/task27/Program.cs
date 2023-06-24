// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int SumOfDigits(int Number)
{
    int sum = 0;
    while (Number > 0)
    {
        sum = sum + Number % 10;
        Number = Number / 10;
    }
    return sum;
}

Console.WriteLine("Input your number: ");
int Num = Convert.ToInt32(Console.ReadLine());

if (Num >= 0)
    Console.WriteLine($"Your sum is {SumOfDigits(Num)}");
else
{
    Num = (-1) * Num;
    Console.WriteLine($"Your sum is {SumOfDigits(Num)}");
}