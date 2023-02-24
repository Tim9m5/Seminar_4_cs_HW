// Home Work Seminar 4 C#

// Задача 25
// Напишите цикл, который принимает на вход два числа и возводит число А в степень В.
/*
Console.WriteLine("Введите число А: ");
int A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число B: ");
int B = Convert.ToInt32(Console.ReadLine());
int result = A; 
int count = 0;
 while(count < B-1)
 {
    
    result = result * A;
    count++;

 }

 Console.WriteLine("A в степени B равно: " + result);
*/

//-----------------------------------------------------------------------

// Задача 27
// Напишите программу, которая принимает на вход число и выдает сумму цифр этого числа
/*
Console.WriteLine("Введите число А: ");
int A = Convert.ToInt32(Console.ReadLine());
if (A < 0) A *= -1;
int n = 0;
while (A > 0)
{
    n = n + A % 10;
    A = A / 10;

}

Console.WriteLine($"Сумма цифр из числа А = {n}");
*/

//---------------------------------------------------------------------

// Задача 29
// Напишите программу, котрая задает массив из N элементов и выводит их на экран
/*
Console.Write("Введите второе число диапазона от 0 до ");
int y = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите длину массива: ");
int x = Convert.ToInt32(Console.ReadLine());
int[] GetBinaryArray(int size)
{
    int [] array = new int[size];
    for ( int i = 0; i < size; i++)
    {
        
        array [i] = new Random().Next(y);
    }
    return array;
}

int [] resultArray = GetBinaryArray(x);
for ( int i=0; i < resultArray.Length; i++)
{
    Console.Write(resultArray[i] + "\t");
}
*/