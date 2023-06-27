// Задача 29: Напишите программу, которая задаёт
// массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

void ArraySet(int[] arr)
{
    for (int i = 1; i <= arr.Length; ++i)
    {
        Console.WriteLine($"задайте массиф {i}-элемент: ");
        arr[i-1] = Convert.ToInt32(Console.ReadLine());
    }
}
void ArrayPrint(int[] arr)
{
    for (int i = 1; i <= arr.Length; ++i)
        Console.WriteLine(arr[i-1]);
}
int[] arr = new int[8];
ArraySet(arr);
ArrayPrint(arr);
