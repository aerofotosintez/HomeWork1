// Напишите программу вычисления функции Аккермана с 
// помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 3, n = 2 -> A(n,m) = 9
// m = 2, n = 3 -> A(n,m) = 29


Console.WriteLine("введите число N");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число M");
int b = Convert.ToInt32(Console.ReadLine());

int AccermanRec(int n, int m)
{
    if(n < 0 || m < 0) return 0;
    if(n == 0) return m + 1;
    if(m == 0) return AccermanRec(n - 1, 1);
    return AccermanRec(n - 1, AccermanRec(n, m - 1));
}
Console.WriteLine();
int accerman = AccermanRec(a, b);
Console.WriteLine(accerman);