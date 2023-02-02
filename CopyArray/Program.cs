// Написать программу копирования массива

void FillArray(int[] array, int[] carray)
{
    for(int i=0; i<array.Length;i++)
    {  
            array[i] = new Random().Next(1,20);
            carray[i] = new Random().Next(1,100);
    }
}

void PrintArray(int[] array, int[] carray)
{
foreach(int num in array)
{
    Console.Write(num + " ");
   
}
Console.WriteLine("\nВывод массива который перезапишим");
foreach(int ind in carray)
{
    Console.Write(ind + " ");
}
Console.WriteLine();
}
/*
void CopyArr(int[] array, int arg)
{
    int[] copyarr = new int[arg];
    for(int i =0; i<array.Length;i++)
    {
       copyarr[i] =  array[i]; 
       Console.Write($"{copyarr[i]} , ");
    }
    
}

Console.Write("Введите размер массива: ");
int index = int.Parse(Console.ReadLine());
int[] Array = new int [index];
FillArray(Array);
PrintArray(Array);
CopyArr(Array,index);
*/

// Второй вариант копирования массива
/*
void CopyArr(int[] array, int arg)
{
    int[] copyarr = new int[arg];
    for(int i =0; i<array.Length;i++)
    {
       array.CopyTo(copyarr, 0);
       Console.Write($"{copyarr[i]} ");
    }
    
}

Console.Write("Введите размер массива: ");
int index = int.Parse(Console.ReadLine());
int[] Array = new int [index];
FillArray(Array);
PrintArray(Array);
CopyArr(Array,index);
*/
// Третий вариант копирования массива

void CopyArr(int[] array, int arg)
{
    int[] copyarr = new int[arg];
    for(int i =0; i<array.Length;i++)
    {
       copyarr = array.Take(array.Length).ToArray();
       Console.Write($"{copyarr[i]} ");
    }
    
}

Console.Write("Введите размер массива: ");
int index = int.Parse(Console.ReadLine());
int[] Array = new int [index];
int[] CopyArray = new int [index];
FillArray(Array,CopyArray);
PrintArray(Array, CopyArray);
CopyArr(Array,index);

