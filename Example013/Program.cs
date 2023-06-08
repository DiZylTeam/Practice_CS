﻿// string[,] table = new string[2, 5]; // создаем двумерный массив типа string (первая цифра - кол-во строк, вторая - кол-во столбцов)
// // String.Empty - функционал, который содержится по умолчанию для новых строк, т.е. пустые строки

// int[,] matrix = new int[5, 8];   // создаем двумерный массив типа int (первая цифра - кол-во строк, вторая - кол-во столбцов)
                                    // количество строк -> matrix.GetLength(0), количество стобцов -> matrix.GetLength(1)


// table[1, 2] = "word";  // обращаемся к нужному элементу созданного массива, в скобках указываем сначала индекс строки, затем индекс столбца
// // при обращении к строкам и столбцам - их индексы также исчисляются от 0 (т.е. 0 - индекс первого столбца или строки, 1 - второго и т.д.)

// for (int rows = 0; rows < 2; rows++)
// {
//     for (int columns = 0; columns < 5; columns++)
//     {
//         Console.WriteLine($"-{table[rows, columns]}-");
//     }
// }




void PrintArray(int[,] matr)    // создали метод для вывода массива на консоль со значениями по умолчанию (0)
{
// for (int i = 0; i < 3; i++)
for (int i = 0; i < matr.GetLength(0); i++)   // можно писать ч/з функционал GetLength(), к-й обозначает изначально заданное кол-во строк или столбцов 
                                                // (0 - обозначает заданное кол-во строк, 1 - заданное кол-во столбцов)
{
    //for (int j = 0; j < 4; j++)
    for (int j = 0; j < matr.GetLength(1); j++)

    {
        Console.Write($"{matr[i, j]} ");  // вывод нашего массива на консоль
    }
Console.WriteLine();    // дополнительная команда вывода пустой строки с нового абзаца -> для того, чтобы массив принял форму таблицы при выводе на консоль
}
}


void FillArray(int[,] matr) // создали метод для заполнения массива рандомными числами
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1,10);   // присвоили строкам и столбцам i, j значения рандомных чисел
        }
    }
}


int[,] matrix = new int[3, 4];  // создание многомерного массива типа int (строки - 3, столбцов - 4)
PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);


