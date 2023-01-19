// Задайте массив. Напишите программу, которая определяет,
// присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

int [] GetRandomArray (int size, int leftRange, int rightRange)
{
    int[] array = new int [size];
    for (int i = 0; i < array.Length; i++)
    {
       array[i] = new Random().Next(leftRange, rightRange + 1);
    }
    return array;  
}

int[] massive = GetRandomArray(5, -9, 9);
Console.WriteLine(string.Join(",", massive));

Console.WriteLine("Введите число:");
int N = Convert.ToInt32(Console.ReadLine());

for(int i = 0; i < massive.Length; i++)
{
    if (massive[i] == N)
    {
        Console.WriteLine("ДА");
        break;
    }
    else if (i == massive.Length - 1) //проверка на последний элемента массива
    {
        Console.WriteLine("НЕТ");
    }
}