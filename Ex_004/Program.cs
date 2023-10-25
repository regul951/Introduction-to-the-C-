// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

static int exponentiation(int numA, int numB)
{
    int result = numA;
    int i = 2;
    while (i <= numB)
    {
        result *= numA;
        i++;
    }
    return result;
}

int numA = 3;
int numB = 5;

int result25 = exponentiation(numA, numB);
Console.WriteLine($"result25: {result25}\n");



// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

static int sumNumber(int num)
{
    int sum = 0;
    int numLength = (int)Math.Log10(num) + 1;
    for (int i = 0; i <= numLength; i++)
    {
        sum += num % 10;
        num = num / 10;
    }
    return sum;
}

int num = 33;

int result27 = sumNumber(num);
Console.WriteLine($"result27: {result27}\n");


// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

void prntArray(int[] ar)
{
    foreach (var num in ar)
    {
        
        Console.Write($"{num}\t");
    }
}

int[] arr = { 1, 2, 5, 7, 19, 6, 1, 33 };

Console.WriteLine("result29:");
prntArray(arr);