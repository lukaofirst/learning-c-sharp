namespace _009_base_keyword.BaseKeywordOnDerivedMethods
{
    public class Employee : Person
    {
        public override void Print()
        {
            base.Print();
            Console.WriteLine("And I'm the Employee's class");
        }
    }
}
