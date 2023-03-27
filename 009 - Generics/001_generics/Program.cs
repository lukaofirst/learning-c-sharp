/* --- Generics --- */

using System.Collections;

// Without Generics
// They are more costly, because they have to perform boxing and unboxing
var arrayList = new ArrayList();

arrayList.Add(10);
arrayList.Add("lorem");
arrayList.Add(true);

// With Generics
// It performs better because the compiler already know which type 
// we are working with, not allowing adding "any" type
var list = new List<string>();

list.Add("lorem");
list.Add("10");
list.Add("true");