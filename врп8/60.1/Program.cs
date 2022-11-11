
// Задача 60: Сформируйте трёхмерный массив
// из неповторяющихся двузначных чисел.
// Напишите программу, которая будет
// построчно выводить массив, добавляя индексы каждого элемента.

Console.Clear();
Console.WriteLine($"\nВведите размер массива m x n x p");
Console.WriteLine("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите p: ");
int p = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($" ");

int[,,] array3D = new int[m, n, p];
InputArray(array3D);
ReleaseArray(array3D);

void ReleaseArray (int[,,] array3D)
{
  for (int i = 0; i < array3D.GetLength(0); i++)
  {
    for (int j = 0; j < array3D.GetLength(1); j++)
    {
      Console.Write($"m({i}) n({j}) ");
      for (int k = 0; k < array3D.GetLength(2); k++)
      {
        Console.Write( $"p({k})={array3D[i,j,k]}; ");
      }
      Console.WriteLine();
    }
    Console.WriteLine();
  }
}

void InputArray(int[,,] array3D)
{
  int[] temp = new int[array3D.GetLength(0) * array3D.GetLength(1) * array3D.GetLength(2)];
  int  number;
  for (int i = 0; i < temp.GetLength(0); i++)
  {
    temp[i] = new Random().Next(10, 100);
    number = temp[i];
    if (i >= 1)
    {
      for (int j = 0; j < i; j++)
      {
        while (temp[i] == temp[j])
        {
          temp[i] = new Random().Next(10, 100);
          j = 0;
          number = temp[i];
        }
          number = temp[i];
      }
    }
  }
  int count = 0; 
  for (int m = 0; m < array3D.GetLength(0); m++)
  {
    for (int n = 0; n < array3D.GetLength(1); n++)
    {
      for (int p = 0; p < array3D.GetLength(2); p++)
      {
        array3D[m, n, p] = temp[count];
        count++;
      }
    }
  }
}

