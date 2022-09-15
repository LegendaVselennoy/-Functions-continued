//Задача 1 : Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
//которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

// Решение 1

void PrintArray(int[] num)
{
        for (int i=0;i<num.Length;i++)
   {
      if (i!=num.Length-1) Console.Write($"{num[i]}, ");
    else Console.Write($"{num[i]}] -> ");
   }
}

int[] count(int n)
{
    int[] array=new int[n];
    for (int i = 0; i < array.Length; i++)
    {
        array[i]=new Random().Next(100,1000);
    }
    return array;
}

void Parity(int[] someArray)
{
    int score=0;
    for (int i = 0; i < someArray.Length; i++)
    {
        if(someArray[i]%2==0)
        {
            score++;
        }
    }
    Console.Write(score);
}

int[] array1=count(4);
Console.Write("[");
PrintArray(array1);
Parity(array1);

/////////////////////////////////////////////////////////////////////////////

//Задача 2: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

//Решение 2

int[] array=count(4);
Console.Write("[");
PrintArray(array);
TheSumOfOddPositionsInTheArray(array);

int[] count(int n)
{
    int[] array=new int[n];
    for (int i = 0; i < array.Length; i++)
    {
        array[i]=new Random().Next(-50,51);
    }
    return array;
}

void PrintArray(int[] num)
{
        for (int i=0;i<num.Length;i++)
   {
      if (i!=num.Length-1) Console.Write($"{num[i]}, ");
    else Console.Write($"{num[i]}] -> ");
   }
}

void TheSumOfOddPositionsInTheArray(int [] mas)
{
    int sum=0;
    for (int i = 0; i < mas.Length; i++)
    {
         if(i%2==1)
        {
            sum+=mas[i];
        }
    }
  Console.Write(sum);
}


////////////////////////////////////////////////////////////////////

//Задача 3: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

//Решение 3

double[]result=Count(5);
Console.Write("[");
PrintArray(result);
Difference(result);

double[] Count(int n)
{
    double[] array=new double[n];
    for (int i = 0; i < array.Length; i++)
    {
        array[i]=new Random().NextDouble()*100;
    }
    return array;
}

void PrintArray(double[] num)
{
        for (int i=0;i<num.Length;i++)
   {
      if (i!=num.Length-1) Console.Write($"{num[i]}, ");
    else Console.Write($"{num[i]}] -> ");
   }
}

void Difference(double[] num)
{
    int j=0;
    double max=num[j];
    double min=num[j];
    for (int i = 0; i < num.Length; i++)
    {
        
        if(num[i]>max)
        {
        max=num[i];
        }else if(num[i]<min)
        {
            min=num[i];
        }
    }
    Console.Write("Разница между максимальным и минимальным элементом массива = " + $"{max-min}");
}