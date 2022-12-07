Console.WriteLine("Введите первую точку: ");
Console.Write("Введите значение X: ");
double ax = double.Parse(Console.ReadLine());
Console.Write("Введите значение Y: ");
double ay = double.Parse(Console.ReadLine());
Console.Write("Введите значение Z: ");
double az = double.Parse(Console.ReadLine());
Console.WriteLine("Введите вторую точку: ");
Console.Write("Введите значение X: ");
double bx = double.Parse(Console.ReadLine());
Console.Write("Введите значение Y: ");
double by = double.Parse(Console.ReadLine());
Console.Write("Введите значение Z: ");
double bz = double.Parse(Console.ReadLine());

double ab = Math.Pow(bx - ax, 2) + Math.Pow(by - ay, 2) + Math.Pow(bz - az, 2); // Возведение в степень

ab = Math.Sqrt(ab); // Вычисление квадратного корня
ab = Math.Round(ab, 2);

Console.WriteLine(ab);