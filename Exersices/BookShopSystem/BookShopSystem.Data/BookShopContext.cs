using BookShopSystem.Models;

namespace BookShopSystem.Data
{
    using System.Data.Entity;

    public class BookShopContext : DbContext
    {
        // Your context has been configured to use a 'BookShopContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'BookShopSystem.Data.BookShopContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'BookShopContext' 
        // connection string in the application configuration file.
        public BookShopContext()
            : base("name=BookShopContext")
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<BookShopContext>());
        }

        public IDbSet<Book> Books { get; set; }

        public IDbSet<Author> Authors { get; set; }

        public IDbSet<Category> Categories { get; set; }
    }
}