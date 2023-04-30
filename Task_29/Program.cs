// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int a = 8;
int [] massiv = new int [8];
FillArray(massiv);
PrintArray(massiv);

// static int CreateArray(int len)
// {
//     int[] array = new int [len];
//     return array;
// }

static void FillArray(int[] array)
{
    Random random = new Random();
        for (int i = 0; i < array.Length; i++){
        array[i] = random.Next(0,10);
    }
}
static void PrintArray(int[] array)
{
    for (int i =0; i< array.Length; i++)
    {
    Console.Write($"{array[i]}, ");
    }
    Console.Write($" -> [");
     for (int i =0; i< array.Length; i++)
    {
    Console.Write($"{array[i]}, ");
    }
    Console.Write($"]");
}
