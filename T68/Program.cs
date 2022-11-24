// Задача 68: Напишите программу вычисления функции Аккермана с 
// помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
int Akkerman(int m, int n)
{
    if (m == 0) return n + 1;
    if (n == 0 && m != 0) return Akkerman(m - 1, 1);
    if(m > 0 && n > 0) return Akkerman(m - 1, Akkerman(m, n - 1));
    return Akkerman(m,n);
}
Console.Write("Введите целые числа от 1 до 4 . Число m = ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Число n = ");
int n = Convert.ToInt32(Console.ReadLine());
if( m > 0 && m < 4 && n > 0 && n < 4){
int x = Akkerman(m, n);
Console.Write($" m = {m}, n = {n} -> A({m},{n}) = {x}");
}
else Console.Write("Неправильный ввод даннх");