// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int SumNumbers(int M, int N)
{
    if (M == N)
        return M;
    return M + SumNumbers(M + 1, N);
}


int M = ReadNumber("Введите M");
int N = ReadNumber("Введите N");

Console.WriteLine($"Сумма натуральных чисел в промежутке от {M} до {N} составляет: {SumNumbers(M, N)}");

