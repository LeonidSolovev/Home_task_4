// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
Console.Clear();

int num1 = GetUserInput("Введите целое число: ", "Ошибка ввода!");
int num2 = GetUserInput("Введите степень, в которую нужно возвести число: ", "Ошибка ввода!");
GetSum(num1, num2);


static int GetSum(int number1, int number2){
int count = 1;
for (int i = 1; i <= number2; i++)
    count = count *number1;

Console.Write($"{number1}, {number2} -> {count}");
return count;
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