// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.Clear();
Console.WriteLine ("Введите число N");
int N = int.Parse (Console.ReadLine());
int i = 2;
Console.WriteLine ("Чётные числа от 1 до N:");
while (i<=N) {
    if (i%2==0) Console.WriteLine (i);
    i++;
}
