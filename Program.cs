// ДЗ 

// Задайте значения M и N. Напишите программу,
// которая выведет все натуральные числа в промежутке от M до N.

// Console.WriteLine("Введите M: ");
// int M = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите N: ");
// int N = Convert.ToInt32(Console.ReadLine());
// void  PrintNumbers (int startm, int endn)
// {
// if (endn > startm)
//     {
//     PrintNumbers(startm,endn-1);
//     }
//     Console.Write($"{endn} ");
// }
// if (M < N)
// {
//     PrintNumbers(M,N);
// }
// else
// {
//     PrintNumbers(N,M);
// }

// 2 Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n. (Если честно не особо понял что функция Аккермана делает соответсвено написал наверно неверно)

// Console.WriteLine("Введите M: ");
// int  M = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите N: ");
// int  N = Convert.ToInt32(Console.ReadLine());

// int Ackermann(int m, int n)
//     {
//         if (m == 0)
//         {
//             return n + 1;
//         }
//         else if (n == 0)
//         {
//             return Ackermann(m - 1, 1);
//         }
//         else
//         {
//             return Ackermann(m - 1, Ackermann(m, n - 1));
//         }
//     }
// Console.WriteLine(Ackermann(M,N));

// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.
 



int [] CreateArray(int size, int minRange, int maRange)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(minRange, maRange + 1);
    }
    return array;
}

void ReverseArray (int[] arr, int i=0)
{
    
    if (arr.Length > i)
    {
        Console.Write($"{arr[arr.Length-i-1]} ");
    }
    if (i < arr.Length)
    {
        ReverseArray(arr, i + 1);
    }

}
int[] array = (CreateArray(5, 0, 100));
Console.WriteLine($"Массив ДО :[{string.Join("; ", array)}]");
ReverseArray(array);
