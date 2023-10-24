using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> myList = new MyList<string>();
            myList.Add("İkbal");
            myList.Add("Osman");
            myList.Add("İkbal");
            myList.Add("İkbal");
        }
    }
}
