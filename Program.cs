﻿// // See https://aka.ms/new-console-template for more information
//
//
// using data_structures;
//
// int num1 = 1;
// int num2 = 1;
// Console.WriteLine(num1 == num2);
// //             0   1    2
// int[] arr1 = { 17, 80, 67 };
// int[] arr2 = { 1, 2 };
// Console.WriteLine(arr1 == arr2);
// Console.WriteLine(arr1[2]);
//
// Console.WriteLine(Array1.CalculateAverage());
//
// int size = 15;
// int[] arr20 = new int[size];
// Array1.InitArray(arr20);
//
// int num3 = 100;
//
//
// object[] generalArray = { 1, "Omer", 6.7, true };
//
//
// //              variable    value
// //                num1        1
// //                num2        1
// //                arr1       00x0    
// //                arr2       00x8   
//
//
//
// // 00x0          arr1        17
// // 00x4                      80
// // 00x8                      67
// // 00x12         arr2         1
// // 00x12                      2
//
//
//
// // aliasing
// int num4 = 7;
// int num5 = num4;
// int[] myArr1 = { 5, 2, 99, 3 };
// int[] myArr2 = myArr1;
// myArr2[2] = -6;
// Console.WriteLine(myArr1[2]);
// // myArr1[4] = 4; // IndexOutOfRangeException: Index was outside the bounds of the array.
//
//
// Console.WriteLine("Starting ex1");
//
// int[] original = { 8, 9, 50, 13, 1000, -7 };
// Console.WriteLine("original is:");
// Array1.PrintArray(original);
// int[] reversed = Exercises.Ex1ReverseArray(original);
// Console.WriteLine("reversed is:");
// Array1.PrintArray(reversed);
//
// Console.WriteLine(reurrsion.fact(4));
//
// Console.WriteLine(5 >> 1);
// Console.WriteLine(4 >> 1);
// Console.WriteLine(3 >> 1);
// Console.WriteLine(2 >> 1);


// using data_structures;
//
// BinaryTree tree = new BinaryTree();
// tree.Insert(5);
// tree.Insert(7);
// tree.Insert(2);
// Console.WriteLine("hi");


// [      0  1  2
// 0     [_, _, _]
// 1     [_, _, _]
// 2     [_, _, _]
// ]

char[,] chars = new char[3,3];

for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        chars[i,j] = '_';
    }
}

char player1 = 'X';
char player2 = 'Y';

bool isWin = false;
int rounds = 0;
while (!isWin && rounds <= 9)
{
    
}




