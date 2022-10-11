// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7) -> 15.84
// A (7,-5,0); B (1,-1,9) -> 11.53

Console.Clear();
Console.WriteLine("Введите X координаты точки A: ");
int x1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите Y координаты точки A: ");
int y1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите Z координаты точки A: ");
int z1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите X координаты точки B: ");
int x2 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите Y координаты точки B: ");
int y2 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите Z координаты точки B: ");
int z2 = int.Parse(Console.ReadLine()!);
double result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
Console.WriteLine($"Длина отрезка AB равна : {result:f2}");
