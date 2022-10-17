// Задача 34
// Задайте массив, заполненный случайными положительными трехзначными числами. 
// Напишите программу, которая покажет количество четных чисел в массиве
/*
int[] basearray = GetArray(10, 100, 1000);
Console.WriteLine(String.Join(", ", basearray));
Console.WriteLine($"Количество четных чисел в массиве {String.Join(", ", CountEvenNumber(basearray))}");

int CountEvenNumber(int[] array)
{
    int count = 0;
    foreach (int n in array)
    {
        if (n%2 == 0) count ++;        
    }
    return count;
}  

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for(int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res; 
}
*/

// Задача 36
// Задайте одномерный массив, заполненный случайными числами
// Найдите сумму элементов, стоящих на нечетных позициях
/*
int[] basearray = GetArray(6, 1, 10);
Console.WriteLine(String.Join(", ", basearray));
Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях, равна {String.Join(", ", Sum(basearray))}");


int Sum(int[] array)
{
    int result = 0;
    for(int i = 1; i < array.Length; i += 2)
    {
        result = result + array[i];        
    }
    return result;
}

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for(int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res; 
}
*/

// Задача 38
// Задайте массив вещественных чисел. надите разницу между максимальным и минимальным элементами массива
/*
int[] basearray = GetArray(10, -1000, 1000);
Console.WriteLine(String.Join(", ", basearray));
Console.WriteLine($"Разница между максимальным и минимальным элементами массива равна {String.Join(", ",difference(basearray))}");

int difference(int[] array)
{
    int Max = array[0];
    int Min = array[0];
    
    for(int i = 1; i < array.Length; i ++)
    {
        if(array[i] > Max) Max = array[i];             
        if(array[i] < Min) Min = array[i];       
    }
    Console.WriteLine($"Максимальный элемент массива равен {Max}");
    Console.WriteLine($"Минимальный элемент массива равен {Min}");
    return Max - Min;
}

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for(int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res; 
}
*/