using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using LibrarySystem.Domain;



namespace LibrarySystem
{
    class Program
    {
        static void Main(string[] args)
        {
            // set database initializer
            Database.SetInitializer<LibraryContext>(new LibraryContextInitializer());

            //LibraryContext db = new LibraryContext();
            //db.Configuration.LazyLoadingEnabled = false;
            //db.Configuration.ProxyCreationEnabled = false;

            

            Console.ReadLine();
        }
    }
}
