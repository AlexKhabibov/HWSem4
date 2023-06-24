// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

void NumberPower (int numberA, int numberB)
{
int result = 1;
for (int power = 1; power <= numberB; power++)
    result *= numberA;
    Console.WriteLine($"Your result is {result}");
}

 Console.WriteLine("Input your first number: ");
 int numA = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine("Input your second number: ");
 int numB = Convert.ToInt32(Console.ReadLine());

 if (numB > 0)
     NumberPower(numA, numB);
 else if (numB == 0)
     Console.WriteLine("Your result is 1");
 else if (numB < 0)
     Console.WriteLine ("Your second number must be positive. Try again with another second number.");
