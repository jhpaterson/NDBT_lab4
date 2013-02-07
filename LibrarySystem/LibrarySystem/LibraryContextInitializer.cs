using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using LibrarySystem.Domain;


namespace LibrarySystem
{
    public class LibraryContextInitializer : DropCreateDatabaseAlways<LibraryContext>
    //public class LibraryContextInitializer : CreateDatabaseIfNotExists<LibraryContext>
    {
        protected override void Seed(LibraryContext context)
        {
            base.Seed(context);

            Shelf sh1 = new Shelf{
                ShelfCode = "005.7",
                Public = true,
                Campus = "Glasgow Caledonian University",
                PropertyNumber = 70,
                Street = "Cowcaddens Road",
                City = "Glasgow",
                Area = "G4",
                Property = "OBA"
            };

            Shelf sh2 = new Shelf
            {
                ShelfCode = "005.8",
                Public = false,
                Campus = "Another University",
                PropertyNumber = 140,
                Street = "University Road",
                City = "Glasgow",
                Area = "G13",
                Property = "8QQ"
            };

            Title bk1 = new Title{
                TitleName = "Programming Entity Framework",
                Author = "Julie Lerman",
                ISBN = "0596807260",
                Shelf = sh1,
                Category = Category.Thriller,
                Copies = new List<Copy>{
                    new Copy{
                        IsAvailable = true
                    },
                    new Copy{
                        IsAvailable = true
                    },
                    new Copy{
                        IsAvailable = true
                    },
                    new Copy{
                        IsAvailable = true
                    }
                }
            };

            Title bk2 = new Title
            {
                TitleName = "Programming Microsoft LINQ in Microsoft .NET Framework 4",
                Author = "Paolo Pialorsi",
                ISBN = "0735640572",
                Shelf = sh2,
                Category = Category.Horror,
                Copies = new List<Copy>{
                    new Copy{
                        IsAvailable = false
                    },
                    new Copy{
                        IsAvailable = true
                    },
                    new Copy{
                        IsAvailable = true
                    }
                }
            };

            Title bk3 = new Title
            {
                TitleName = "Entity Framework 4.1: Expert's Cookbook",
                Author = "Devlin Iles",
                ISBN = "1849684464",
                Shelf = sh1,
                Category = Domain.Category.Humour,
                Copies = new List<Copy>{
                    new Copy{
                        IsAvailable = false
                    },
                    new Copy{
                        IsAvailable = false
                    }
                }
            };

            Loan lo1 = new Loan
            {
                Copy = bk1.GetCopy(),
                LoanDate = new DateTime(2013, 2, 1)
            };

            Loan lo2 = new Loan
            {
                Copy = bk1.GetCopy(),
                LoanDate = new DateTime(2013, 2, 1)
            };

            Loan lo3 = new Loan
            {
                Copy = bk1.GetCopy(),
                LoanDate = new DateTime(2013, 2, 5)
            };

            Loan lo4 = new Loan
            {
                Copy = bk2.GetCopy(),
                LoanDate = new DateTime(2013, 2, 25)
            };

            Loan lo5 = new Loan
            {
                Copy = bk1.GetCopy(),
                LoanDate = new DateTime(2013, 2, 15)
            };

            Member mb1 = new Member
            {
                Name = "Fernando",
                Loans = new List<Loan>()
                    {
                        lo1,
                        lo2
                    }
            };

            Member mb2 = new Member
            {
                Name = "Felipe",
                Loans = new List<Loan>()
                {
                        lo3,
                        lo4             
                }
            };

            Member mb3 = new Member
            {
                Name = "Jenson",
                Loans = new List<Loan>()
                {
                    lo5
                }
            };

            Member mb4 = new Member
            {
                Name = "Checo",
                Loans = new List<Loan>()
            };

            Fine fi1 = new Fine
            {
                FineDate = new DateTime(2013, 2, 19),
                Amount = 1.20m,
                Loan = lo3
            };

            Fine fi2 = new Fine
            {
                FineDate = new DateTime(2013, 2, 29),
                Amount = 2.40m,
                Loan = lo5
            };

        }
    }
}
