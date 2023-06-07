// Задача 54: Задайте двумерный массив.
//  Напишите программу, которая упорядочит 
//  по убыванию элементы каждой строки 
//  двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// int[,] Creat2DArray(int[,] array, int minValue, int maxValue)
// {

//    for (int i = 0; i < array.GetLength(0); i++)
//    {
//       for (int j = 0; j < array.GetLength(1); j++)
//       {
//          array[i, j] = new Random().Next(minValue, maxValue);
//       }
//    }
//    return array;
// }

// void Print2DArray(int[,] array)
// {
//    for (int i = 0; i < array.GetLength(0); i++)
//    {
//       for (int j = 0; j < array.GetLength(1); j++)
//       {
//          System.Console.Write(array[i, j] + " ");
//       }
//       System.Console.WriteLine();
//    }
// }

// int[,] Sort2DArray(int[,] array)
// {
//    int maxValue;
//    bool flag = true;

//    for (int k = 0; flag; k++)
//    {
//       for (int i = 0; i < array.GetLength(0); i++)
//       {
//          for (int j = 0; j < array.GetLength(1) - 1; j++)
//          {
//             if (array[i, j] < array[i, j + 1])
//             {
//                maxValue = array[i, j];
//                array[i, j] = array[i, j + 1];
//                array[i, j + 1] = maxValue;
//                flag = false;
//             }
//          }
//       }
//       if (flag)
//       {
//          break;
//       }
//       flag = true;

//    }
//    return array;
// }

// System.Console.WriteLine("Input Array size Row ");
// int row = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input Array size Column ");
// int col = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input Array minValue ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input Array maxValue ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[,] array = new int[row, col];
// array = Creat2DArray(array, minValue, maxValue);
// Print2DArray(array);
// System.Console.WriteLine();
// array = Sort2DArray(array);
// Print2DArray(array);


// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер
// строки с наименьшей суммой элементов: 1 строка

// int[,] Creat2DArray(int[,] array, int minValue, int maxValue)
// {

//    for (int i = 0; i < array.GetLength(0); i++)
//    {
//       for (int j = 0; j < array.GetLength(1); j++)
//       {
//          array[i, j] = new Random().Next(minValue, maxValue);
//       }
//    }
//    return array;
// }

// void Print2DArray(int[,] array)
// {
//    for (int i = 0; i < array.GetLength(0); i++)
//    {
//       for (int j = 0; j < array.GetLength(1); j++)
//       {
//          System.Console.Write(array[i, j] + " ");
//       }
//       System.Console.WriteLine();
//    }
// }

// void Sum2DArray(int[,] array)
// {
//    int[] sum = new int[array.GetLength(0)];

//    for (int i = 0; i < array.GetLength(0); i++)
//    {
//       for (int j = 0; j < array.GetLength(1); j++)
//       {
//          sum[i] += array[i, j];
//       }
//    }
//    int minRow = 0;
//    int minSum = sum[0];
//    for (int i = 0; i < sum.Length; i++)
//    {
//       if (minSum > sum[i])
//       {
//          minSum = sum[i];
//          minRow = i;
//       }
//    }

//    System.Console.WriteLine($" Номер строки {minRow + 1} с наименьшей суммой");

// }


// System.Console.WriteLine("Input Array size Row ");
// int row = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input Array size Column ");
// int col = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input Array minValue ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input Array maxValue ");
// int maxValue = Convert.ToInt32(Console.ReadLine());
// int[,] array = new int[row, col];
// array = Creat2DArray(array, minValue, maxValue);
// Print2DArray(array);
// System.Console.WriteLine();
// Sum2DArray(array);


/*
  ДОДЕЛАТЬ!!!!
*/
// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить 
// произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// int[,] Creat2DArray(int[,] array, int minValue, int maxValue)
// {

//    for (int i = 0; i < array.GetLength(0); i++)
//    {
//       for (int j = 0; j < array.GetLength(1); j++)
//       {
//          array[i, j] = new Random().Next(minValue, maxValue);
//       }
//    }
//    return array;
// }

// // void Print2DArray(int[,] array)
// // {
// //    for (int i = 0; i < array.GetLength(0); i++)
// //    {
// //       for (int j = 0; j < array.GetLength(1); j++)
// //       {
// //          System.Console.Write(array[i, j] + " ");
// //       }
// //       System.Console.WriteLine();
// //    }
// // }

// void Display(int[,] array, int[,] mas)
// {
//    int width = array.GetLength(1) * 3;

//    for (int i = 0; i < array.GetLength(0); i++)
//    {
//       for (int j = 0; j < width; j++)
//       {
//          if (j < array.GetLength(1) - 1)
//          {
//             System.Console.Write(array[i, j] + " ");
//          }
//          else if (j > array.GetLength(1) - 1 && j < width - array.GetLength(1))
//          {
//             System.Console.Write(" ");
//          }
//          else
//          {

//             System.Console.Write(mas[i, j % array.GetLength(1)] + " ");

//          }
//       }
//       Console.WriteLine();
//    }
// }

// void ProductOfTwoMatrices(int[,] array, int[,] mas)
// {
//    int[,] matrix = new int[array.GetLength(0), array.GetLength(1)];

//    for (int i = 0; i < array.GetLength(0); i++)
//    {
//       for (int j = 0; j < array.GetLength(1); j++)
//       {

//          for (int k = 0; k < array.GetLength(1); k++)
//          {
//             matrix[i, j] = array[i, k] * mas[k, j];

//          }
//       }
//    }

//    for (int i = 0; i < matrix.GetLength(0); i++)
//    {
//       for (int j = 0; j < matrix.GetLength(1); j++)
//       {
//          System.Console.Write(matrix[i, j] + " ");
//       }
//       System.Console.WriteLine();
//    }
// }

// int row, row2, col, col2;
// int minValue;
// int maxValue;
// do
// {
//    System.Console.WriteLine("Input Array1 size Row ");
//    row = Convert.ToInt32(Console.ReadLine());
//    System.Console.WriteLine("Input Array1 size Column ");
//    col = Convert.ToInt32(Console.ReadLine());
//    System.Console.WriteLine("Input Array2 size Row ");
//    row2 = Convert.ToInt32(Console.ReadLine());
//    System.Console.WriteLine("Input Array2 size Column ");
//    col2 = Convert.ToInt32(Console.ReadLine());
//    if ((row != col || row2 != col2) || (row != col2 || col != row2))
//    {
//       System.Console.WriteLine("Error input ");
//    }
// } while ((row != col || row2 != col2) || (row != col2 || col != row2));
// System.Console.WriteLine("Input Array minValue ");
// minValue = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input Array maxValue ");
// maxValue = Convert.ToInt32(Console.ReadLine());
// int[,] array = new int[row, col];
// int[,] mas = new int[row2, col2];
// array = Creat2DArray(array, minValue, maxValue);
// mas = Creat2DArray(mas, minValue, maxValue);
// System.Console.WriteLine();
// Display(array, mas);
// System.Console.WriteLine();
// ProductOfTwoMatrices(array, mas);


// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)
// int[,,] Creat3DArray(int[,,] array)
// {
//    int minValue = 10;
//    int maxValue = 100;

//    for (int i = 0; i < array.GetLength(0); i++)
//    {
//       for (int j = 0; j < array.GetLength(1); j++)
//       {
//          for (int k = 0; k < array.GetLength(2); k++)
//          {
//             array[i, j, k] = new Random().Next(minValue, maxValue);
//             for (int l = 0; l < k; l++)
//             {
//                if (array[i, j, k] == array[j, k, l])
//                {
//                   k--;
//                }
//             }
//          }
//       }
//    }
//    return array;
// }

// void Print3DArray(int[,,] array)
// {
//    for (int i = 0; i < array.GetLength(0); i++)
//    {
//       for (int j = 0; j < array.GetLength(1); j++)
//       {
//          for (int k = 0; k < array.GetLength(2); k++)
//          {
//             System.Console.Write($"{array[i, j, k]} ({i},{j},{k}) ");
//          }
//          System.Console.WriteLine();
//       }

//    }
// }

// System.Console.WriteLine("Input Array size Row ");
// int row = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input Array size Column ");
// int col = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input Array size Depth ");
// int depth = Convert.ToInt32(Console.ReadLine());
// int[,,] array = new int[row, col, depth];
// array = Creat3DArray(array);
// Print3DArray(array);




// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] Creat2DArray(int[,] array)
{
   int SizeX = array.GetUpperBound(0);
   int SizeY = array.GetUpperBound(1);
   int maxX = SizeX;
   int maxY = SizeY + 1;
   int dirX = 1;
   int dirY = 1;

   int x = 0;
   int y = -1;
   int val = 1;
   while ((maxX >= 0) && (maxY >= 0))
   {
      for (int yval = 1; yval <= maxY; yval++)
      {
         array[x, y + dirY * yval] = val;
         val++;
      }
      y = y + dirY * maxY;
      dirY = -dirY;
      maxY--;
      for (int xval = 1; xval <= maxX; xval++)
      {
         array[x + dirX * xval, y] = val;
         val++;
      }
      x = x + dirX * maxX;
      dirX = -dirX;
      maxX--;
   }
   return array;
}



void Print2DArray(int[,] array)
{
   int minValue = 10;
   for (int i = 0; i < array.GetLength(0); i++)
   {
      for (int j = 0; j < array.GetLength(1); j++)
      {
         if (array[i, j] < minValue)
         {
            System.Console.Write($"0{array[i, j]} ");
         }
         else System.Console.Write($"{array[i, j]} ");
      }
      System.Console.WriteLine();
   }
}

System.Console.WriteLine("Input Array size Row ");
int row = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input Array size Column ");
int col = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[row, col];
array = Creat2DArray(array);
Print2DArray(array);
System.Console.WriteLine();


