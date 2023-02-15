/* --- base Keyword --- */

using _009_base_keyword.BaseKeywordOnConstructors;
using _009_base_keyword.BaseKeywordOnDerivedMethods;

var person1 = new Person();
person1.Print();

var employee = new Employee();
employee.Print();

Console.WriteLine();

var baseClass = new BaseClass();
var derivedClass = new DerivedClass(10);
