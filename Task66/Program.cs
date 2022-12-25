// Задача 66: Задайте значения M и N. 
//Напишите программу, которая найдёт 
//сумму натуральных элементов в промежутке от M до N.

//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

Console.Write("Введите значение M, которая будет начальной точкой: ");
int M = int.Parse(Console.ReadLine()!);
Console.Write("Введите значение N, которая будет конечной точкой: ");
int N = int.Parse(Console.ReadLine()!);

int SumOfNumbers(int start, int end)
{
    if (start == end) return start;
    return end + SumOfNumbers(start, end - 1);
}
Console.WriteLine();
Console.WriteLine($"Сумма всех элементов от {M} до {N} включительно = {SumOfNumbers(M, N)}");