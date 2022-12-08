// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.

int size = ReadInt("Введите размерность массива: ");
int min = ReadInt("Введите минимальное число массива: ");
int max = ReadInt("Введите максимальное число массива: ");
int [] num = new int[size];

FillArrayRandomNumbers(num);
PrintArray(num);

int maxFillarray = num[0];
int minFillarray = num[0];

for (int i = 0; i < num.Length; i++)
{
    if (num[i] > maxFillarray)
    {
        maxFillarray = num[i];
    }
    if (num[i] < minFillarray)
    {
        minFillarray = num[i];
    }
}
Console.WriteLine($"Разница  максимального и минимального числа = {maxFillarray - minFillarray}");

// Ввод

int ReadInt(string message)  

{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}    

//Заполнение массива

void FillArrayRandomNumbers(int [] array) 
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max);
    }
}

//Вывод массива 

void PrintArray(int[] array) 
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

