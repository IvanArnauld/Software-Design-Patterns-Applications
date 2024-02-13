using System;

namespace Project2
{
    class FancyPost : Post
    {
        public FancyPost(string t, string b) : base(t, b) {

        }

        public override string GetPrintableTitle()
        {
            return Title;
        }

        public override string GetPrintableBody()
        {
            return Body;
        }

        protected override void Print()
        {
            Console.WriteLine(GetPrintableTitle());
            Console.WriteLine("------------------");
            Console.WriteLine("~*~*~*~*~*~*~*~*~*");
            Console.WriteLine($":  {GetPrintableBody()}");
            Console.WriteLine("~*~*~*~*~*~*~*~*~*");
        }
    }
}
