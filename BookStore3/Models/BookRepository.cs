using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BookStore3.Models;
using System.Data.Entity;


 

namespace BookStore3.Models 
{
    public interface IRepository : IDisposable
    {
        List<Book> GetBookList();
        IEnumerable<Book> GetBookList2();
        Book GetBook(int id);
        void Create(Book item);
        void Update(Book item);
        void Delete(int id);
        void Save();
        BookContext GetContext();
    }

    public class BookRepository : IRepository
    {
       
        public BookContext db;

        public BookRepository()
        {
            this.db = new BookContext();
        }
        public BookRepository(BookContext db)
        {
            this.db = db;
        }
        public List<Book> GetBookList()
        {
            return db.Books.ToList();
        }
        public IEnumerable<Book> GetBookList2()
        {
            return db.Books;
        }
        public Book GetBook(int id)
        {
            return db.Books.Find(id);
        }
        public void Create(Book b)
        {
            db.Books.Add(b);
        }
        public void Update(Book b)
        {
            db.Entry<Book>(b).State = EntityState.Modified;
        }
        public void Delete(int id)
        {
            Book b = db.Books.Find(id);
            if (b != null)
                db.Books.Remove(b);
        }
        public void Save()
        {
            db.SaveChanges();

        }
        public BookContext GetContext()
        {
            return this.db;
        }
        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}