﻿using Microsoft.AspNetCore.Builder;
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
                    Price = 9.95
                },

                new Books
                {
                    Title = "Team of Rivals",
                    Author = "Doris Kearns Goodwin",
                    Publisher = "Simon & Schuster",
                    ISBN = "978-0743270755",
                    ClassCategory = "Non-Fiction, Biography",
                    Price = 14.58
                },

                new Books
                {
                    Title = "The Snowball",
                    Author = "Alice Schroeder",
                    Publisher = "Bantam",
                    ISBN = "978-0553384611",
                    ClassCategory = "Non-Fiction, Biography",
                    Price = 21.54
                },

                new Books
                {
                    Title = "American Ulysses",
                    Author = "Ronald C. White",
                    Publisher = "Random House",
                    ISBN = "978-0812981254",
                    ClassCategory = "Non-Fiction, Biography",
                    Price = 11.61
                },

                new Books
                {
                    Title = "Unbroken",
                    Author = "Laura Hillenbrand",
                    Publisher = "Random House",
                    ISBN = "978-0812974492",
                    ClassCategory = "Non-Fiction, Historical",
                    Price = 13.33
                },

                new Books
                {
                    Title = "The Great Train Robbery",
                    Author = "Michael Crichton",
                    Publisher = "Vintage",
                    ISBN = "978-0804171281",
                    ClassCategory = "Fiction, Historical Fiction",
                    Price = 15.95
                },

                new Books
                {
                    Title = "Deep Work",
                    Author = "Cal Newport",
                    Publisher = "Grand Central Publishing",
                    ISBN = "978-1455586691",
                    ClassCategory = "Non-Fiction, Self-Help ",
                    Price = 14.99
                },

                new Books
                {
                    Title = "It's Your Ship",
                    Author = "Michael Abrashoff",
                    Publisher = "Grand Central Publishing",
                    ISBN = "978-1455523023",
                    ClassCategory = "Non-Fiction, Self-Help",
                    Price = 21.66
                },

                new Books
                {
                    Title = "The Virgin Way",
                    Author = "Richard Branson",
                    Publisher = "Portfolio",
                    ISBN = "978-1591847984",
                    ClassCategory = "Non-Fiction, Business",
                    Price = 29.16
                },

                new Books
                {
                    Title = "Sycamore Row",
                    Author = "John Grisham",
                    Publisher = "Bantam",
                    ISBN = "978-0553393613",
                    ClassCategory = "Fiction, Thrillers",
                    Price = 15.03
                }

                );

                context.SaveChanges();
            }
        }
    }
}
