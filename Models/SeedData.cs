using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBookStore.Models
{
    public class SeedData
    {
        public static void EnsurePopulated (IApplicationBuilder application)
        {
            ProjectDbContext context = application.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<ProjectDbContext>();

            if(context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if(!context.Books.Any())
            {
                context.Books.AddRange(
                    
                new Books
                {
                    Title = "Les Miserables",
                    AuthorFirstName = "Victor",
                    AuthorLastName = "Hugo",
                    Publisher = "Signet",
                    ISBN = "978-0451419439",
                    Class = "Fiction",
                    Category = "Classic",
                    Price = 9.95,
                    Pages = 1488
                },

                new Books
                {
                    Title = "Team of Rivals",
                    AuthorFirstName = "Doris Kearns",
                    AuthorLastName = "Goodwin",
                    Publisher = "Simon & Schuster",
                    ISBN = "978-0743270755",
                    Class = "Non-Fiction",
                    Category = "Biography",
                    Price = 14.58,
                    Pages = 944
                },

                new Books
                {
                    Title = "The Snowball",
                    AuthorFirstName = "Alice",
                    AuthorLastName = "Schroeder",
                    Publisher = "Bantam",
                    ISBN = "978-0553384611",
                    Class = "Non-Fiction",
                    Category = "Biography",
                    Price = 21.54,
                    Pages = 832
                },

                new Books
                {
                    Title = "American Ulysses",
                    AuthorFirstName = "Ronald C.",
                    AuthorLastName = "White",
                    Publisher = "Random House",
                    ISBN = "978-0812981254",
                    Class = "Non-Fiction",
                    Category = "Biography",
                    Price = 11.61,
                    Pages = 864
                },

                new Books
                {
                    Title = "Unbroken",
                    AuthorFirstName = "Laura",
                    AuthorLastName = "Hillenbrand",
                    Publisher = "Random House",
                    ISBN = "978-0812974492",
                    Class = "Non-Fiction",
                    Category = "Historical",
                    Price = 13.33,
                    Pages = 528
                },

                new Books
                {
                    Title = "The Great Train Robbery",
                    AuthorFirstName = "Michael",
                    AuthorLastName = "Crichton",
                    Publisher = "Vintage",
                    ISBN = "978-0804171281",
                    Class = "Fiction",
                    Category = "Historical Fiction",
                    Price = 15.95,
                    Pages = 288
                },

                new Books
                {
                    Title = "Deep Work",
                    AuthorFirstName = "Cal",
                    AuthorLastName = "Newport",
                    Publisher = "Grand Central Publishing",
                    ISBN = "978-1455586691",
                    Class = "Non-Fiction",
                    Category = "Self-Help",
                    Price = 14.99,
                    Pages = 304
                },

                new Books
                {
                    Title = "It's Your Ship",
                    AuthorFirstName = "Michael",
                    AuthorLastName = "Abrashoff",
                    Publisher = "Grand Central Publishing",
                    ISBN = "978-1455523023",
                    Class = "Non-Fiction",
                    Category = "Self-Help",
                    Price = 21.66,
                    Pages = 240
                },

                new Books
                {
                    Title = "The Virgin Way",
                    AuthorFirstName = "Richard",
                    AuthorLastName = "Branson",
                    Publisher = "Portfolio",
                    ISBN = "978-1591847984",
                    Class = "Non-Fiction",
                    Category = "Business",
                    Price = 29.16,
                    Pages = 400
                },

                new Books
                {
                    Title = "Sycamore Row",
                    AuthorFirstName = "John",
                    AuthorLastName = "Grisham",
                    Publisher = "Bantam",
                    ISBN = "978-0553393613",
                    Class = "Fiction",
                    Category = "Thrillers",
                    Price = 15.03,
                    Pages = 642
                },

                new Books
                {
                    Title = "Fabelhaven",
                    AuthorFirstName = "Brandon",
                    AuthorLastName = "Mull",
                    Publisher = "Deseret Book Company",
                    ISBN = "978-1442032699",
                    Class = "Fantasy",
                    Category = "Fiction",
                    Price = 19.99,
                    Pages = 368
                },

                new Books
                {
                    Title = "How to Win Friends and Influence People",
                    AuthorFirstName = "Dale",
                    AuthorLastName = "Carnegie",
                    Publisher = "Simon & Schuster",
                    ISBN = "978-1442344815",
                    Class = "Self-Help",
                    Category = "Self-Help",
                    Price = 11.85,
                    Pages = 291
                },

                new Books
                {
                    Title = "Can't Hurt Me",
                    AuthorFirstName = "David",
                    AuthorLastName = "Goggins",
                    Publisher = "Lioncrest",
                    ISBN = "978-1544507859",
                    Class = "Self-Help",
                    Category = "Self-Help",
                    Price = 7.99,
                    Pages = 364
                }

                );

                context.SaveChanges();
            }
        }
    }
}
