using System;

namespace Project2
{
    abstract class Content
    {
        public abstract Post Clone();
        public abstract Post Download();
        public abstract void SetTitle(string title);
        public abstract void SetBody(string body);
        public abstract void View();
        protected virtual void Print()
        {

        }

    }
}
