/*Задача 29: Напишите программу, которая задаёт
 массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

Console.Write("Введите размер массива: ");
int N = Convert.ToInt32(Console.ReadLine());


void printArray(int size)
{
    int[] arr = new int[size];
    Console.WriteLine("Введите элементы массива: ");
    for (int i = 0; i < size; i++)
    {
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }

    Console.Write("[");
    for (int i = 0; i < size - 1; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.Write($"{arr[arr.Length - 1]}]");
}
printArray(N);