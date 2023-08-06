/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

int number = GetNumberFromUser("Введите число: ", "Ошибка! Введите целое число."); 
GetSum(number);

int GetNumberFromUser(string message, string errorMessage)
{
    while(true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if(isCorrect)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}

void GetSum (int num)
{
    if (num < 0)
        num = num * -1;
int sum = 0;
int cif = 0;

    while (num > 0)
    {
        cif = num % 10;
        num = num / 10;
        sum = sum + cif;
    }
Console.WriteLine($"{sum}");
}