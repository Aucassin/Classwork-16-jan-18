using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork_16_jan_18
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Fiction("M. Rogers", "Valiant Hearts", 255, "fiction");
            book1.Print();
            Book book2 = new Technical_book("B. Briant", "Gloomy forest of C#", 767, "technical book");
            book2.Print();

            Library.Add(book1);
            Library.Add(book2);
            Library.LibraryPrint();
        }
    }
}
