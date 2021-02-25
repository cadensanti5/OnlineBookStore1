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
                    Author = "Victor Hugo",
                    Publisher = "Signet",
                    ISBN = "978-0451419439",
                    ClassCategory = "Fiction, Classic",
                    Price = 9.95,
                    Pages = 1488
                },

                new Books
                {
                    Title = "Team of Rivals",
                    Author = "Doris Kearns Goodwin",
                    Publisher = "Simon & Schuster",
                    ISBN = "978-0743270755",
                    ClassCategory = "Non-Fiction, Biography",
                    Price = 14.58,
                    Pages = 944
                },

                new Books
                {
                    Title = "The Snowball",
                    Author = "Alice Schroeder",
                    Publisher = "Bantam",
                    ISBN = "978-0553384611",
                    ClassCategory = "Non-Fiction, Biography",
                    Price = 21.54,
                    Pages = 832
                },

                new Books
                {
                    Title = "American Ulysses",
                    Author = "Ronald C. White",
                    Publisher = "Random House",
                    ISBN = "978-0812981254",
                    ClassCategory = "Non-Fiction, Biography",
                    Price = 11.61,
                    Pages = 864
                },

                new Books
                {
                    Title = "Unbroken",
                    Author = "Laura Hillenbrand",
                    Publisher = "Random House",
                    ISBN = "978-0812974492",
                    ClassCategory = "Non-Fiction, Historical",
                    Price = 13.33,
                    Pages = 528
                },

                new Books
                {
                    Title = "The Great Train Robbery",
                    Author = "Michael Crichton",
                    Publisher = "Vintage",
                    ISBN = "978-0804171281",
                    ClassCategory = "Fiction, Historical Fiction",
                    Price = 15.95,
                    Pages = 288
                },

                new Books
                {
                    Title = "Deep Work",
                    Author = "Cal Newport",
                    Publisher = "Grand Central Publishing",
                    ISBN = "978-1455586691",
                    ClassCategory = "Non-Fiction, Self-Help ",
                    Price = 14.99,
                    Pages = 304
                },

                new Books
                {
                    Title = "It's Your Ship",
                    Author = "Michael Abrashoff",
                    Publisher = "Grand Central Publishing",
                    ISBN = "978-1455523023",
                    ClassCategory = "Non-Fiction, Self-Help",
                    Price = 21.66,
                    Pages = 240
                },

                new Books
                {
                    Title = "The Virgin Way",
                    Author = "Richard Branson",
                    Publisher = "Portfolio",
                    ISBN = "978-1591847984",
                    ClassCategory = "Non-Fiction, Business",
                    Price = 29.16,
                    Pages = 400
                },

                new Books
                {
                    Title = "Sycamore Row",
                    Author = "John Grisham",
                    Publisher = "Bantam",
                    ISBN = "978-0553393613",
                    ClassCategory = "Fiction, Thrillers",
                    Price = 15.03,
                    Pages = 642
                },

                new Books
                {
                    Title = "Fabelhaven",
                    Author = "Brandon Mull",
                    Publisher = "Deseret Book Company",
                    ISBN = "978-1442032699",
                    ClassCategory = "Fantasy Fiction",
                    Price = 19.99,
                    Pages = 368
                },

                new Books
                {
                    Title = "How to Win Friends and Influence People",
                    Author = "Dale Carnegie",
                    Publisher = "Simon & Schuster",
                    ISBN = "978-1442344815",
                    ClassCategory = "Self-Help",
                    Price = 11.85,
                    Pages = 291
                },

                new Books
                {
                    Title = "Can't Hurt Me",
                    Author = "David Goggins",
                    Publisher = "Lioncrest",
                    ISBN = "978-1544507859",
                    ClassCategory = "Self-Help",
                    Price = 7.99,
                    Pages = 364
                }

                );

                context.SaveChanges();
            }
        }
    }
}
