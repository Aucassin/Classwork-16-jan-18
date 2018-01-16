using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork_16_jan_18
{
    public abstract class Book
    {
        protected readonly string _author;
        protected readonly string _name;
        protected readonly int _pages;

        public Book()
        {
            //_author = "unknown";
            //_name = "unknown";
            //_pages = 0;
        }

        public Book(string author, string name)
        {
            _author = author;
            _name = name;
        }
        public Book(string author, string name, int pages)
        {
            _author = author;
            _name = name;
            _pages = pages;
        }
        public string authorProp
        {
            get
            {
                return _author;
            }
        }
        public string nameProp
        {
            get
            {
                return _name;
            }
        }

        public int pagesProp
        {
            get
            {
                return _pages;
            }
        }

        public abstract void Print();

    }
}
