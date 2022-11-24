// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
int SumElement(int m, int n){
    if(m == n + 1) return 0;
    return m + SumElement(m+1,n);
}
Console.Write("Задайте значения для двух натуральных чисел M = ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("N = ");
int n = Convert.ToInt32(Console.ReadLine());
if(n < m){
    int temp = n;
    n = m;
    m = temp;
}
Console.Write($"В промежутке от {m} до {n} сумма элементов = {SumElement(m,n)}");

