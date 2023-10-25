// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, 
// сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int CountMoreZero(string numbers)
{
    string[] splitString = numbers.Split(','); //Разделяем введенную строку по запятой
    int[] array = new int[splitString.Length]; //Объявляем массив
    int count = 0; //Объявление счетчика с присваиванием ему нулевого значения

    //Цикл преобразования string в int и подсчет значений > 0
    for (int i = 0; i < splitString.Length; i++)
    {
        if (Convert.ToInt32(splitString[i]) > 0) //Конвертация строки в число с одновременным поиском числа > 0
        {
            count++; //Увеличение счетчика, в случае числа > 0
        }
    }
    return count; //Вывод значения счетчика
}

Console.WriteLine("Решение Задачи 41.\n");
Console.Write("Введите числа, через запятую: ");
string? numbers = Console.ReadLine();
Console.WriteLine(CountMoreZero(numbers));




// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

string CrossLine(double b1, double k1, double b2, double k2)
{
    if (k1 == k2) //Проверка на параллельность
    {
        if (b1 == b2) //Проверка на совпадение
        {
            return "Прямые совпадают!";
        }
        return "Прямые параллельны!";
    }
    double x = (b2 - b1) / (k1 - k2); //Вычисление координаты x
    double y = (k1 * b2 - k2 * b1) / (k1 - k2); //Вычисление координаты y
    return $"Точка пересечения: ({x};{y})";
}


Console.WriteLine("Решение Задачи 41\n");
Console.Write("Введите значение b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine(CrossLine(b1, k1, b2, k2));


