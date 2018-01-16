using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork_16_jan_18
{
    class Technical_book : Fiction
    {
        private readonly string _techGenre;
        public Technical_book(string author, string name, int pages, string techGenre)
            :base(author, name, pages, techGenre)
        {
            _techGenre = techGenre;
        }
        //public string genreProp
        //{
        //    get
        //    {
        //        return _techGenre;
        //    }
        //}
        public override void Print()
        {
            Console.WriteLine($"{nameProp} by {authorProp}, {pagesProp} pages ({genreProp})");
        }
    }
}
