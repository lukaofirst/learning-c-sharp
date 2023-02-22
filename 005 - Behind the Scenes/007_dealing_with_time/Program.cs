/* --- Dealing with Time --- */

/* - DateTime - */
// month starts at 1

// constructors
using System.Globalization;
Thread.CurrentThread.CurrentCulture = new CultureInfo("pt-BR");

var date1 = new DateTime(2023, 1, 5);
var date2 = new DateTime(2023, 10, 30, 5, 30, 30);

// static methods
var date3 = DateTime.Now;
var date4 = DateTime.UtcNow;
var date5 = DateTime.Today;
var date6 = DateTimeOffset.Now;
var date7 = DateTimeOffset.UtcNow;

// parsed DateTime
var date8 = DateTime.Parse("Jan 30, 2022");
var date9 = DateTime.Parse("2023-02-22T11:33:10.0000000Z");

Console.WriteLine(date1);
Console.WriteLine(date2);
Console.WriteLine(date3);
Console.WriteLine(date4);
Console.WriteLine(date5);
Console.WriteLine(date6);
Console.WriteLine(date7);
Console.WriteLine(date8);
Console.WriteLine(date9);
Console.WriteLine();

/* - TimeSpan - */

// construtors
var timeSpan1 = new TimeSpan();
var timeSpan2 = new TimeSpan(1000); // ticks => a time period expressed in 100-nanosecond units
var timeSpan3 = new TimeSpan(1, 30, 10); 
var timeSpan4 = new TimeSpan(2, 1, 30, 10);

// static methods
var timeSpan5 = TimeSpan.FromDays(1.5);	
var timeSpan6 = TimeSpan.FromHours(1.5);
var timeSpan7 = TimeSpan.FromMinutes(1.5);
var timeSpan8 = TimeSpan.FromSeconds(1.5);
var timeSpan9 = TimeSpan.FromMilliseconds(1.5);	// 1.5 will be rounded up 
var timeSpan10 = TimeSpan.FromTicks(900000000L);

Console.WriteLine(timeSpan1);
Console.WriteLine(timeSpan2);
Console.WriteLine(timeSpan3);
Console.WriteLine(timeSpan4);
Console.WriteLine(timeSpan5);
Console.WriteLine(timeSpan6);
Console.WriteLine(timeSpan7);
Console.WriteLine(timeSpan8);
Console.WriteLine(timeSpan9);
Console.WriteLine(timeSpan10);



