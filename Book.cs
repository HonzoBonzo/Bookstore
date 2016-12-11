using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetBookstore
{
    class Book
    {
        string 
            name,
            category,
            publisher,
            author;
        int yearOfRelease;

        public Book()
        {
            category = null;
            publisher = null;
            author = null;
            yearOfRelease = -1;
        }

        public Book(string nam, string cat, string pub, string aut, int year) {
            name = nam;
            category = cat;
            publisher = pub;
            author = aut;
            yearOfRelease = year;
        }

        public Book clone()
        {
            Book b = new Book(this.name, this.category, this.publisher, this.author, this.yearOfRelease);
            return b;
        }

        public void show() {
            Console.WriteLine("Book: {0}, Category: {1}, Publisher: {2}, Author: {3}, Year of release: {4}",name,category,publisher,author,yearOfRelease);
        }
    }
}
