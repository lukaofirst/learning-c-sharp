/* --- Basic Types --- */

/* - numbers - */

// integer types
byte minByte = byte.MinValue;
byte maxByte = byte.MaxValue;
Console.WriteLine($"byte goes from {minByte} to {maxByte}");

short minShort = short.MinValue;
short maxShort = short.MaxValue;
Console.WriteLine($"short goes from {minShort} to {maxShort}");

// most used
int minInt = int.MinValue;
int maxInt = int.MaxValue;
Console.WriteLine($"(most used) int goes from {minInt} to {maxInt}");

long minLong = long.MinValue;
long maxLong = long.MaxValue;
Console.WriteLine($"long goes from {minLong} to {maxLong}");
Console.WriteLine();

// integer types (unsigned version)
ushort minUShort = ushort.MinValue;
ushort maxUShort = ushort.MaxValue;
Console.WriteLine($"ushort goes from {minUShort} to {maxUShort}");

uint minUInt = uint.MinValue;
uint maxUInt = uint.MaxValue;
Console.WriteLine($"uint goes from {minUInt} to {maxUInt}");

ulong minULong = ulong.MinValue;
ulong maxULong = ulong.MaxValue;
Console.WriteLine($"ulong goes from {minULong} to {maxULong}");
Console.WriteLine();

// floating point types
float minFloat = float.MinValue;
float maxFloat = float.MaxValue;
Console.WriteLine($"float goes from {minFloat} to {maxFloat}");

// most used
double minDouble = double.MinValue;
double maxDouble = double.MaxValue;
Console.WriteLine($"(most used) double goes from {minDouble} to {maxDouble}");

decimal minDecimal = decimal.MinValue;
decimal maxDecimal = decimal.MaxValue;
Console.WriteLine($"decimal goes from {minDecimal} to {maxDecimal}");
