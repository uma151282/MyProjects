using projectevents.Interfaces;
using projectevents.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projectevents.Data
{
    public class BookFlowerConcrete : IBookFlower
    {
        private uma_testContext _context;

        public BookFlowerConcrete(uma_testContext context)
        {
            _context = context;
        }

        public int BookFlower(BookingFlower bookingflower)
        {
            try
            {
                if (bookingflower != null)
                {
                    _context.BookingFlower.Add(bookingflower);
                    _context.SaveChanges();
                    return bookingflower.BookingFlowerID;
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }


    }
}
