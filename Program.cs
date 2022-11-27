// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// double [,] CreateNewArray () 
// { 
//     Console.Write( "Input numbers of rows: "); 
//     int rows = Convert.ToInt32(Console. ReadLine()); 
 
//     Console.Write( "Input numbers of column: "); 
//     int columns = Convert.ToInt32(Console. ReadLine()); 

//     double [,] FilledArray = new double [rows, columns];

//     for (int i = 0; i<rows; i++)
//         for (int j = 0; j < columns; j++)
        
//         { 
//           FilledArray[i, j] = Convert.ToDouble(new Random().Next(-10, 10)) / 10;
//         }

//     return FilledArray;
// }

// void Show2dArray (double [,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++){
//         for (int j = 0; j < array.GetLength(1); j++){
//             Console.Write(array[i, j] + " ");}
//     Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// double [,] newArray = CreateNewArray();
// Show2dArray(newArray);


// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет



// int [,] CreateArray () 
// { 
//     Console.Write( "Input numbers of rows: "); 
//     int rows = Convert.ToInt32(Console. ReadLine()); 
 
//     Console.Write( "Input numbers of column: "); 
//     int columns = Convert.ToInt32(Console. ReadLine()); 

//     Console.Write( "Input min possible value: "); 
//     int minValue = Convert.ToInt32(Console. ReadLine());

//     Console.Write( "Input max possible value:"); 
//     int maxValue = Convert.ToInt32(Console. ReadLine());

//     int [,] Array = new int [rows, columns];


//     for (int i = 0; i<rows; i++)
//         for (int j = 0; j < columns; j++)
        
//         { 
//           Array[i,j] = new Random().Next(minValue, maxValue + 1);
//         }

//     return Array;
// }

// void Show2dArray (int [,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++){
//         for (int j = 0; j < array.GetLength(1); j++){
//             Console.Write(array[i, j] + " ");}
//     Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// void ShowNumInArray (int [,] array)
// {
//     Console.WriteLine("Input column's number");
//     int n = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("Input row's number");
//     int m = Convert.ToInt32(Console.ReadLine());
//     for (int i = 0; i < array.GetLength(0); i++){
//         for (int j = 0; j < array.GetLength(1); j++){
//             if (n > array.GetLength(0) || m > array.GetLength(1))
//             {
//                 Console.WriteLine("there is NO such element");
//                 break;
//             }
//             else
//             {
//                 Console.WriteLine($"element of column {n} and row {m} is {array[n-1,m-1]}");
//             }
//     }
// }
// }

// int [,] newArray = CreateArray();
// Show2dArray(newArray);
// ShowNumInArray(newArray);


// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


// int [,] CreateArray () 
// { 
//     Console.Write( "Input numbers of rows: "); 
//     int rows = Convert.ToInt32(Console. ReadLine()); 
 
//     Console.Write( "Input numbers of column: "); 
//     int columns = Convert.ToInt32(Console. ReadLine()); 

//     Console.Write( "Input min possible value: "); 
//     int minValue = Convert.ToInt32(Console. ReadLine());

//     Console.Write( "Input max possible value:"); 
//     int maxValue = Convert.ToInt32(Console. ReadLine());

//     int [,] Array = new int [rows, columns];


//     for (int i = 0; i<rows; i++)
//         for (int j = 0; j < columns; j++)
        
//         { 
//           Array[i,j] = new Random().Next(minValue, maxValue + 1);
//         }

//     return Array;
// }

// void Show2dArray (int [,] Array)
// {
//     for (int i = 0; i < Array.GetLength(0); i++){
//         for (int j = 0; j < Array.GetLength(1); j++){
//             Console.Write(Array[i, j] + " ");}
//     Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// double Srednee (int [,] array)
// { 
//     double result = 0;
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         for (int i = 0; i < array.GetLength(0); i++)
//              {
//                 result = result + array[i,j];
//              }
//     result = result/array.GetLength(0);
//     Console.WriteLine(result + "; ");
//     result = 0;
//     }
//     return result;
// }
// int [,] newArray = CreateArray();
// Show2dArray(newArray);
// double result = Srednee(newArray);