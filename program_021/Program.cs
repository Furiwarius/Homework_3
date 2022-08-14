// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве

double SegmentLength (int x1, int y1, int z1, int x2, int y2, int z2){
    return Math.Sqrt((Math.Pow(Math.Abs(x1-x2), 2))+(Math.Pow(Math.Abs(y1-y2), 2))+ (Math.Pow(Math.Abs(z1-z2), 2)));
}



System.Console.Write("Введите координату x первой точки - ");
int x1 = int.Parse(System.Console.ReadLine()!);
System.Console.Write("Введите координату y первой точки - ");
int y1 = int.Parse(System.Console.ReadLine()!);
System.Console.Write("Введите координату z первой точки - ");
int z1 = int.Parse(System.Console.ReadLine()!);

System.Console.Write("Введите координату x второй точки - ");
int x2 = int.Parse(System.Console.ReadLine()!);
System.Console.Write("Введите координату y второй точки - ");
int y2 = int.Parse(System.Console.ReadLine()!);
System.Console.Write("Введите координату z второй точки - ");
int z2 = int.Parse(System.Console.ReadLine()!);

System.Console.WriteLine(SegmentLength(x1, y1, z1, x2, y2, z2));