using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace BookStore3.Models
{
    public class BookDbInitializer : DropCreateDatabaseAlways<BookContext>
    {
        protected override void Seed(BookContext db)
        {
            IRepository rep = new BookRepository(db);
            rep.Create(new Book { Name = "Война и мир", Author = "Л. Толстой", Price = 220 });
            rep.Create(new Book { Name = "Отцы и дети", Author = "И. Тургенев", Price = 180 });
            rep.Create(new Book { Name = "Чайка", Author = "А. Чехов", Price = 150 });
            base.Seed(rep.GetContext());
        }
    }
}