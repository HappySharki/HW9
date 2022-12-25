// Задача 68: Напишите программу вычисления функции Аккермана 
//с помощью рекурсии. Даны два неотрицательных числа m и n.

//m = 2, n = 3 -> A(m,n) = 9
//m = 3, n = 2 -> A(m,n) = 29

Console.Write("Введите значение M: ");
int M = int.Parse(Console.ReadLine()!);
Console.Write("Введите значение N: ");
int N = int.Parse(Console.ReadLine()!);

int AckerManFunction(int M, int N)
{
  if (M == 0) return N + 1;
  else if (N == 0) return AckerManFunction(M - 1, 1);
  else return AckerManFunction(M - 1, AckerManFunction(M, N - 1));
}
Console.WriteLine($"A(M,N) = {AckerManFunction(M,N)}");