// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

double[] cube (int number){
    double[] array = new double[number];
    for (int i = 0; i < number; i++)
    {
        array[i] = Math.Pow(i+1, 3);
    }
    return array;
}

System.Console.Write("Ведите число - ");
int n = int.Parse(System.Console.ReadLine()!);
double[] array1 = cube(n);

foreach (double i in array1)
{
    if (i==1) System.Console.Write($"{i}");
    else System.Console.Write($",{i}");
}

