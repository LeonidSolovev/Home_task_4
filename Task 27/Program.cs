// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();

int number = GetUserInput("Введите целое число: ", "Ошибка ввода!");

int sum = GetSumOfNums(number);

Console.WriteLine($"{number} -> {sum}");




static int GetSumOfNums(int number)
{
    int i = 0;
    int j;
    while (number > 0)
    {
        j = number;
        number = number / 10;
        i = i + j % 10;
    }
    return i;
}

static int GetUserInput(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        if (int.TryParse(Console.ReadLine(), out int userNumber))
            return userNumber;

        Console.WriteLine(errorMessage);
    }

}