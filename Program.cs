// Task64. Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// void ShowNNumbers(int n)
// {
//     Console.Write(n + " ");
//     if (n>1) ShowNNumbers(n-1);
// }
// ShowNNumbers(10);

// Task66. Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// int ShowSumNaturalNumbersInCut (int m, int n)
// {
//     if (m<n) return m + ShowSumNaturalNumbersInCut(m+1,n);
//     if (n<m) return ShowSumNaturalNumbersInCut(n,m);
//     else return m;
// }
// Console.WriteLine(ShowSumNaturalNumbersInCut(1,15));

// Task68. Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// double AkkermanFunction (double m, double n)
// {
//     if (m>0 && n>0) return AkkermanFunction(m-1, AkkermanFunction(m,n-1));
//     if (m==0) return n+1;
//     if (n==0 && m>0) return AkkermanFunction(m-1,1);
//     else return 1;
// }
// double result = AkkermanFunction(0,0);
// Console.WriteLine(result);