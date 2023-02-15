namespace _009_base_keyword.BaseKeywordOnConstructors
{
    public class BaseClass
    {
        int _number;

        public BaseClass()
        {
            Console.WriteLine("in BaseClass() constructor");
        }

        public BaseClass(int i)
        {
            _number = i;
            Console.WriteLine("in BaseClass(int i) constructor - " + _number);
        }
    }
}
