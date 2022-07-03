// Задача 1. Напишите задачу, которая принимает на вход число (А) и выдает сумму чисел от 1 до А

/*Console.WriteLine("введите число");
int A = int.Parse(Console.ReadLine());

int sum = 0;

for (int i = 0; i <= A; i++)
{
    sum+=i;
}

Console.WriteLine(sum);*/

// Функции

/*void func(int n, string s, bool b)
{
    Console.WriteLine("Запуск функции! " + n + " " + s + " " + b);
}

int num = 765543;
func(num, "qwerty", true); */

/*int func(int length)
{
    int sum = 0;

    for (int i = 0; i <= length; i++)
    {
        sum+=i;
    }
    return sum;
}

Console.WriteLine(func(7));
Console.WriteLine(func(4));
Console.WriteLine(func(8)); */

// Задача 2. Напишите программу, которая принимает на вход число и выдает количество цифр в числе.

//456 -> 3
//78 -> 2
//89126 -> 5

/*Console.WriteLine("введите число ");
int num = int.Parse(Console.ReadLine());
int count = 0;

while(num > 0)
{
    num = num / 10;
    count++;
}
Console.WriteLine(count);*/

// решение через функцию 

/* int func(int num)
{
    int count = 0;

while(num > 0)
{
    num = num / 10;
    count++;
}
return count;
}
Console.WriteLine(func(123456)); */

// решение через массив

/*Console.WriteLine("введите число ");
int A = int.Parse(Console.ReadLine());

Console.WriteLine(A.ToString().Length);*/



// Задача 3. Напишите программу, которая принимает на вход число N и выдает произведение чисел от 1 до N;
// 4 -> 24
// 5 -> 120

/*Console.WriteLine("введите число");
int A = int.Parse(Console.ReadLine());

int inc = 1;

for (int i = 1; i <= A; i++)
{
    inc*=i;
}

Console.WriteLine(inc); */

// решение через функцию

/* int func(int N)
{
    int inc = 1;

for (int i = 1; i <= N; i++)
{
    inc *= i;
}
return(inc);
}
Console.WriteLine(func(5)); */

// Задача 4. Напишите программу, которая выводит массив из 8 элементов, 
// заполненный нулями и елдиницами в слукчайном порядке
// { 1,0,1,1,0,1,0,0 }
    
/* void FillArray(int [] collection)
{
    int length = collection.Length;
    int index = 0;
   while (index < length)
    {
        collection [index] = new Random().Next(0,2);
        index++;
    }
}
int [] mass = new int [8];
FillArray(mass);
Console.WriteLine(mass);

for (int i = 0; i < mass.Length; i++)
{
    Console.Write(mass[i] + " ");
}
*/

// решение через функцию

 void FillArray(int [] collection)
{
    int length = collection.Length;
   
for (int index = 0; index < length; index++)
{
        collection [index] = new Random().Next(0,2);
}
}

int[] mass = new int[8];
FillArray(mass);

void PrintArray(int[] col)
{
    for (int i = 0; i < mass.Length; i++)
    {
        Console.Write(mass[i] + " ");
    }
}    

PrintArray(mass);