// Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы

void Intersection(int arg1,int arg2,int arg3,int arg4)
{
   float x=0, exp =0, y=0;
    x = arg1 - arg3;
    exp = arg4 - arg2;
    if(x>1 || x<0) x = exp/x;
    else if(x==0) x = exp;
    y = arg3 *x +arg4;
    Console.Write($"Координаты точки пересечения: ({x},{y})");
}

    Console.Write("Введите значение К1: ");
    int k1 = int.Parse(Console.ReadLine());
      Console.Write("Введите значение b1: ");
    int b1 = int.Parse(Console.ReadLine());
      Console.Write("Введите значение K2: ");
    int k2 = int.Parse(Console.ReadLine());
      Console.Write("Введите значение b2: ");
    int b2 = int.Parse(Console.ReadLine());

Intersection(k1,b1,k2,b2);
