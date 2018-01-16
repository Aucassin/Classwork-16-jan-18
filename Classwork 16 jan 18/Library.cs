using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork_16_jan_18
{
    public static class Library
    {
        private static List<Book> LIB;
        static Library()
        {
            LIB = new List<Book>();
        }
        public static void Add(Book book)
        {
            LIB.Add(book);
        }
        public static void LibraryPrint()
        {
            foreach (var item in LIB)
            {
                item.Print();
            }
        }
    }
}
