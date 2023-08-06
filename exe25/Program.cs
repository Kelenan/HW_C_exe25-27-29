/*Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/
int a = GetNumberFromUser("Введите первое число: ", "Ошибка! Введите целое число.");
int b = GetNumberFromUser("Введите второе число: ", "Ошибка! Введите целое число.");
int result = GetStepen(a, b);

Console.Write($"{a}, {b} -> {result}");

int GetStepen(int A, int B)
{
    int result = A;
    for (int i = 0; i < B-1; i++)
    {
        result = result * A;
    }
    return result;
}

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