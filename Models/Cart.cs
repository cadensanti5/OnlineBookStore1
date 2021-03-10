using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBookStore.Models
{
    public class Cart
    {
        //Build a list of lines in the cart
        public List<CartLine> Lines { get; set; } = new List<CartLine>();

        public virtual void AddItem (Books book, int qty)
        {
            //See if the ID matches up, if so select that from the group. Building a new cartline
            CartLine line = Lines
                .Where(p => p.Books.BookId == book.BookId)
                .FirstOrDefault();

            //If there is no match, if it's null then we'll add a new line and update books and quantity
            if (line == null)
            {
                Lines.Add(new CartLine
                {
                    Books = book,
                    Quantity = qty
                });
            }
            //otherwise we will update the quanity to reflect that we found a match
            else
            {
                line.Quantity += qty;
            }
        }

        //remove one of the books in the cart
        public virtual void RemoveLine(Books book) =>
            Lines.RemoveAll(x => x.Books.BookId == book.BookId);

        //Remove all books in cart
        public virtual void Clear() => Lines.Clear();

        //returns the total price on books in your cart
        public double ComputeTotalSum() => Lines.Sum(e => e.Quantity * e.Books.Price);

        //Create a list or bundle of things you want to show, then above we created a list to put them all together
        public class CartLine
        {
            public int CartLineID { get; set; }
            public Books Books { get; set; }
            public int Quantity { get; set; }
        }
    }
}
