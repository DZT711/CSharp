using System;
using System.Linq;//for Max Min Sum functions

//all method to create an array
//Method 1
string[] m1;

//Method 2
string[] m2 = new string[5];
string[] m6 = new string[5] { "apple", "banana", "orange", "mango", "pineapple" };

//Method 3
string[] m3 = new string[] { "apple", "banana", "orange", "mango", "pineapple" };

//Method 4
string[] m4 = ["apple", "banana", "orange", "mango", "pineapple"];
string[] m5 = { "apple", "banana", "orange", "mango", "pineapple" };

// sorting an array

Array.Sort(m5);
foreach (string item in m5)
{
    Console.Write(item + "    ");
}
Console.WriteLine();
int[] numbers = { 1, 2, 3, 4, 5 };
int max = numbers.Max();
int min = numbers.Min();
int sum = numbers.Sum();
Console.WriteLine($"Max: {max}, Min: {min}, Sum: {sum}");

// 2D array

//Method 1
int[,] n = { { 1, 2 }, { 3, 4 } };
Console.WriteLine(n[0, 0]);

//Method 2
int[,] n2 = new int[2, 2];
n2[0, 0] = 1;
n2[0, 1] = 2;
n2[1, 0] = 3;
n2[1, 1] = 4;
Console.WriteLine(n2[0, 0]);

foreach (var item in n)
{
    Console.WriteLine(item);
}
//dung 2 vong lap for se xuat ra de nhin hon

//GetLength(dimension) Trả về số phần tử của một chiều cụ thể trong mảng đa chiều.
// GetLength(0) là số phần tử ở chiều đầu tiên (thông thường là số hàng).
// GetLength(1) là số phần tử ở chiều thứ hai (số cột), v.v.
for (int i = 0; i < n.GetLength(0); i++)

{
    for (int j = 0; j < n.GetLength(1); j++)
    {
        Console.Write(n[i, j] + " ");
    }
    Console.WriteLine();
}