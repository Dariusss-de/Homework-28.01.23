// Написать программу масштабирования фигуры

void PrintArray(int[] array)
{
foreach(int N in array)
{
    Console.Write(N + " ");  
}
Console.WriteLine();
}

void FillArray(int[] array)
{
    for(int i=0; i<array.Length;i++)
    {
        array[i] = new Random().Next(1,25);
}
}

void Scalling(int[] array, float k)
{
    int numX =0, numY=0;
    float result;
    int[] ScallingPoint = new int[8];
    for(int i=0,j=4;i<4&&j<ScallingPoint.Length;i++,j++)
    {   
        numX = new Random().Next(0,array.Length);
        numY= new Random().Next(0,array.Length);
            Console.WriteLine("("+array[numX]+ ", "+array[numY]+")");
            ScallingPoint[i] = array[numX];
             ScallingPoint[j] = array[numY]; 
        }
        for(int j=0;j<ScallingPoint.Length;j++)
        {
        Console.Write(ScallingPoint[j]+" ");
        }
        Console.WriteLine();
        for(int v =0;v<ScallingPoint.Length;v++)
        {
            result = ScallingPoint[v]*k;
        Console.WriteLine("Значение точек = "+result);
        }
    }

Console.Write("Введите значение коэффициента масштабирования: ");
float kof = float.Parse(Console.ReadLine());
Console.Write("Введите размер массива: ");
int raz = int.Parse(Console.ReadLine());
int[]matrix = new int[raz];
FillArray(matrix);
PrintArray(matrix);
Scalling(matrix,kof);