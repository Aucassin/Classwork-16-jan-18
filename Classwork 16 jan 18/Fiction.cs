using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork_16_jan_18
{
    class Fiction : Book
    {
        private readonly string _fictionGenre;
        public Fiction(string author, string name, int pages, string fictionGenre)
            :base(author, name, pages)
        {
            _fictionGenre = fictionGenre;
        }
        public string genreProp
        {
            get
            {
                return _fictionGenre;
            }
        }
        public override void Print()
        {
            Console.WriteLine($"{nameProp} by {authorProp}, {pagesProp} pages ({genreProp})");
        }
    }
}
