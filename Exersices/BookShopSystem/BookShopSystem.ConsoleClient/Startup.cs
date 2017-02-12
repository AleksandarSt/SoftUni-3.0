using System;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using BookShopSystem.Data;
using BookShopSystem.Models;

namespace BookShopSystem.ConsoleClient
{
    class Startup
    {
        static void Main()
        {
            try
            {
                var context = new BookShopContext();
                var bookCount = context.Books.Count();
            }
            catch (DbEntityValidationException ex)
            {
                foreach (DbEntityValidationResult dbEntityValidationResult in ex.EntityValidationErrors)
                {
                    foreach (DbValidationError dbValidationError in dbEntityValidationResult.ValidationErrors)
                    {
                        Console.WriteLine(dbValidationError.ErrorMessage);
                    }
                }
            }
        }
    }
}
