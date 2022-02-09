// Задача № 22. Найти расстояние между точками в пространстве 2D/3D

Console.Write("Введите в каком пространстве вы хотите посмотреть расстояние. Цифру 2 для 2D, цифру 3 для 3D -> ");
string aStr = Console.ReadLine();
int a = int.Parse(aStr);

if (a == 2) // Выбрано 2D пространство
{
    Console.WriteLine("Введите координаты для первой точки(x, y): ");
    string x1Str = Console.ReadLine();
    int x1 = int.Parse(x1Str);
    string y1Str = Console.ReadLine();
    int y1 = int.Parse(y1Str);

    Console.WriteLine("Введите координаты для второй точки(x, y): ");
    string x2Str = Console.ReadLine();
    int x2 = int.Parse(x2Str);
    string y2Str = Console.ReadLine();
    int y2 = int.Parse(y2Str);

    int xSum2D = (x1+x2)*(x1+x2);
    int ySum2D = (y1+y2)*(y1+y2);


    double distance2D = Math.Sqrt(xSum2D+ySum2D);
    Console.Write($"Расстояние между точками в 2D пространстве = {distance2D}");
}

if (a == 3) // Выбрано 3D пространство
{
    Console.WriteLine("Введите координаты для первой точки(x, y, z): ");
    string x13DStr = Console.ReadLine();
    int x13D = int.Parse(x13DStr);
    string y13DStr = Console.ReadLine();
    int y13D = int.Parse(y13DStr);
    string z1Str = Console.ReadLine();
    int z1 = int.Parse(z1Str);

    Console.WriteLine("Введите координаты для второй точки(x, y, z): ");
    string x23DStr = Console.ReadLine();
    int x23D = int.Parse(x23DStr);
    string y23DStr = Console.ReadLine();
    int y23D = int.Parse(y23DStr);
    string z2Str = Console.ReadLine();
    int z2 = int.Parse(z2Str);

     Console.WriteLine("Введите координаты для третьей точки(x, y, z): ");
    string x33DStr = Console.ReadLine();
    int x33D = int.Parse(x33DStr);
    string y33DStr = Console.ReadLine();
    int y33D = int.Parse(y33DStr);
    string z3Str = Console.ReadLine();
    int z3 = int.Parse(z3Str);

    int xSum3D = (x13D+x23D+x33D)*(x13D+x23D+x33D)*(y13D+y23D+y33D);
    int ySum3D = (y13D+y23D+y33D)*(y13D+y23D+y33D)*(y13D+y23D+y33D);
    int zSum3D = (z1+z2+z3)*(z1+z2+z3)*(z1+z2+z3);


    double distance3D = Math.Sqrt(xSum3D+ySum3D+zSum3D);
    Console.Write($"Расстояние между точками в 2D пространстве = {distance3D}");
}
else
Console.Write("Вы ввели неверное число пространства! Введите 2 либо 3");