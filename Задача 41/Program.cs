//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
int [] GetArray(int size)
{
    int[] res = new int [size];
    for (int i = 0; i < size; i++)
    {
        Console.Write("Введите число с индексом [i] ");
        res[i] = int.Parse(Console.ReadLine()!);  
    }
    return res;
}
int FindBigNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count = count + 1;
        }
    }
    return count;
}
Console.Write("Введите количество элементов массива ");
int size2 = int.Parse(Console.ReadLine()!);
int[] array = GetArray(size2);
Console.WriteLine(String.Join(",", array)); 
int count2 = FindBigNumbers(array);
Console.Write($"{count2} - количество чисел больше 0");