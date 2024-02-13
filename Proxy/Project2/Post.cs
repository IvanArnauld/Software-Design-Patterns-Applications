using System;

namespace Project2
{
    class Post : Content
    {
        public string Title;
        public string Body;

        public Post(string t, string b) {
            this.Title = t;
            this.Body = b;
        }

        public Post()
        {
            this.Title = "Default Title";
            this.Body = "Default Body";
        }

        public override Post Clone()
        {
            Post post = new();
            post.Title = Title;
            post.Body = Body;
            return post;

        }

        public override Post Download()
        {
            return new FancyPost("***Downloaded***", "Downloaded Body");
        }

        public override void SetBody(string body)
        {
            this.Body = body;
        }

        public override void SetTitle(string title)
        {
            this.Title = title;
        }

        public override void View()
        {
            Print();
        }

        protected override void Print()
        {
            Console.WriteLine(Title);
            Console.WriteLine("------");
            Console.WriteLine(Body);
        }

        public virtual string GetPrintableTitle()
        {
            return Title;
        }

        public virtual string GetPrintableBody()
        {
            return Body;
        }
    }
}
