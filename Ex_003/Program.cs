// using System;

// public class Answer
// {
//     static bool IsPalindrome(int number)
//     {
//         bool result = false;
//         string numberLength = number + "";
//         if (numberLength.Length > 5)
//         {
//             Console.WriteLine("Число не пятизначное");
//             return result;
//         }
//         else
//         {
//             for (int i = 0; i < numberLength.Length / 2; i++)
//             {
//                 if (numberLength[i] == numberLength[numberLength.Length - 1 - i])
//                 {
//                     result = true;
//                 }
//                 else
//                 {
//                     result = false;
//                     return result;
//                 }
//             }
//         }
//         return result;
//     }

//     // Не удаляйте и не меняйте метод Main! 
//     static public void Main(string[] args)
//     {
//         int number;

//         if (args.Length >= 1)
//         {
//             number = int.Parse(args[0]);
//         }
//         else
//         {
//             // Здесь вы можете поменять значения для отправки кода на Выполнение
//             number = 64546;
//         }

//         // Не удаляйте строки ниже
//         bool result = IsPalindrome(number);
//         System.Console.WriteLine($"{result}");
//     }
// }


using System;

public class Answer
{
    static bool IsPalindrome(int number){
        if (number < 10000 || number >= 100000){
            Console.WriteLine("Число не пятизначное");
            return false;
        }

        int reverse = 0;
        int temp = number;
        while (temp > 0){
            reverse = reverse * 10 + temp % 10;
            temp /= 10;
            Console.WriteLine($"{reverse}, {temp}");
        }
        return reverse == number;
    }

      static public void Main(string[] args) {
        int number;

        if (args.Length >= 1) {
            number = int.Parse(args[0]);
        } else {
            number = 64546;
        }

        bool result = IsPalindrome(number);
        System.Console.WriteLine($"{result}");
    }
}
