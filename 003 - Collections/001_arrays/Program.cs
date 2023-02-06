using System.Collections;

/* --- Arrays --- */

var arr = new int[] { 1, 31, 203, 9029, 293 };

foreach (var item in arr)
{
    Console.WriteLine(item);
}

Console.WriteLine();

// Invalid array creation

// int[] numbers = new int[]; // you need specify the size

// int[] numbers2 = new int[5] { 10, 20 }; // the number of elements must be equal to the array's size

// var numbers3 = { 2, 5, 7, 9 }; // cannot use var with array initializer

/* - ArrayList - */
var arrList = new ArrayList();

arrList.Add(1);
arrList.Add("2");
arrList.Add("hello world");


foreach (var item in arrList)
{
    Console.WriteLine(item);
}