using System;

namespace Project2
{
    class PostProxy : Content
    {
        private Post? _realPost;

        public PostProxy()
        {

        }

        public PostProxy(Post post)
        {
            _realPost = post;
        }

        public override Post Download()
        {
            if (_realPost == null)
            {
                _realPost = new Post();
            }
            return _realPost.Download();
        }

        public override void SetBody(string body)
        {
            if (_realPost == null)
            {
                Console.WriteLine("Error: Post needs to be downloaded first, to be modified.");
            }
            else
            {
                _realPost!.SetBody(body);
                Console.WriteLine("Done.");
            }
        }

        public override void SetTitle(string title)
        {
            if (_realPost == null)
            {
                Console.WriteLine("Error: Post needs to be downloaded first, to be modified.");
            }
            else
            {
                _realPost!.SetTitle(title);
                Console.WriteLine("Done.");
            }
        }

        public override void View()
        {
            if (_realPost == null)
            {
                Post post = new(GetPrintableTitle(), GetPrintableBody());
                post.View();
            }
            else
            {
                _realPost!.View();
            }
        }

        public override Post Clone()
        {
            if (_realPost == null)
            {
                _realPost = new Post();
            }

            return _realPost.Clone();
        }

        public string GetPrintableTitle()
        {
            if (_realPost == null)
            {
                return "Loading...";
            }
            return _realPost.GetPrintableTitle();
        }

        public string GetPrintableBody()
        {
            if (_realPost == null)
            {
                return "Loading...";
            }
            return _realPost.GetPrintableBody();
        }

    }
}
