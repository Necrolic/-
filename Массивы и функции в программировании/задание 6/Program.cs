// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

double Distance(float x1, float y1, float z1, float x2, float y2, float z2)
{
    return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));    
}

Console.WriteLine(Distance(3, 6, 8, 2, 1, -7));
Console.WriteLine(Distance(7, -5, 0, 1, -1, 9));
