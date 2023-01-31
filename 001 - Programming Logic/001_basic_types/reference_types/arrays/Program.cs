/* --- Basic Types --- */

/* - arrays - */
var array1 = new int[] { 1, 2 };
var array2 = array1;
array2[0] = 5;

Console.WriteLine(string.Join(", ", array1));
