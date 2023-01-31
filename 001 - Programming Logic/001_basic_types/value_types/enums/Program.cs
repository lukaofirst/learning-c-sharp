using enums;

/* --- Basic Types --- */

/* - enums - */

var sunday = WeekDayEnum.Sunday;
var parsedIntToEnum = (WeekDayEnum) 2;
var parsedStringToEnum = Enum.Parse<WeekDayEnum>("3");

Console.WriteLine(sunday);
Console.WriteLine((int) sunday);

Console.WriteLine(parsedIntToEnum);
Console.WriteLine((int) parsedIntToEnum);

Console.WriteLine(parsedStringToEnum);
Console.WriteLine((int) parsedStringToEnum);