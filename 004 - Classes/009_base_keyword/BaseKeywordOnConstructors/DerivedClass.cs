namespace _009_base_keyword.BaseKeywordOnConstructors
{
    public class DerivedClass : BaseClass
    {
        // It's going to call the BaseClass.BaseClass()
        public DerivedClass() : base()
        {

        }

        // It's going to call the BaseClass.BaseClass(int i)
        public DerivedClass(int i) : base(i)
        {

        }
    }
}
