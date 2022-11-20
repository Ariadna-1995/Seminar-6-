//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write("Введите число с индексом [i] ");
        res[i] = int.Parse(Console.ReadLine()!);
    }
    return res;
}
void IntersectionPoint(int[] array)
{
    int b1 = array[0];
    int k1 = array[1];
    int b2 = array[2];
    int k2 = array[3];
    double x,y;
    
    if (b1 == b2 && k1 == k2)
    {
        Console.WriteLine("Прямые совпадают");
    }
    else if (k1 == k2)
    {
        Console.WriteLine("Прямые параллельные друг другу");
    }
    else
    {
        x = (b2 - b1) / (k1 - k2);
        y = k1 * x + b1;
        Console.Write($"Точка пересечения "+" ("+ x + "; "+ y +")");
    }
        
}
int[] array = GetArray(4,-100,100);
Console.WriteLine(String.Join(",", array));
IntersectionPoint(array); 

