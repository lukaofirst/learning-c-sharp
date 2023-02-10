/* --- Tuples and ValueTuples --- */

/* -- Tuples -- */

/* - Creating a tuple - */

// ** Syntax for a instanciated tuple
// Tuple<T1, T2, T3, T4, T5, T6, T7, TRest>

// *** TRest => We can nest tuples to increase, for example, from T8 to T10..., but it's cubersome
var tuple1 = new Tuple<int, string, string>(1, "Lorem", "Ipsum");

// ** Syntax for a static method
var tuple2 = Tuple.Create("hello");

// ** A extended tuple
var extendedTuple = Tuple.Create(1, 2, 3, 4, 5, 6, 7, Tuple.Create(8, 9, 10));

/* - Acessing Tuple's elements - */
var tupleItem1 = tuple1.Item1; // returns 1;
var tupleItem2 = tuple1.Item2; // returns lorem;

var restTupleItem8 = extendedTuple.Rest.Item1; // returns (8, 9, 10);
var restTupleItem9 = extendedTuple.Rest.Item1.Item2; // returns 9;

/* -- ValueTuples -- */

/* - Creating a ValueTuple - */
var valueTuple = (1, 2);

// ** Syntax for a static method
var valueTuple2 = ValueTuple.Create("hello");

var (lastYear, currentYear) = (2022, 2023);
var (personName, personAge) = ("Lorem", 25);

// * This is not a tuple
// var example = (10);

/* -- Back and forth from Tuple to ValueTuple -- */
var convertedTuple = valueTuple.ToTuple();
var convertedValueTuple = tuple1.ToValueTuple();