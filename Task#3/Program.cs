//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
void getTablDeg(int num, int deg)
{
    for (int i = 1; i <= num; i++)
    {
        Console.Write($"{Math.Pow(i, deg)} ");
    }
}



Console.WriteLine("Введите число N:");
int num = int.Parse(Console.ReadLine());
int deg = 3;
getTablDeg(num, deg);