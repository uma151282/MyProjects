using projectevents.Interfaces;
using projectevents.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projectevents.Data
{
    public class BookingLightConcrete : IBookingLight
    {
        private uma_testContext _context;

        public BookingLightConcrete(uma_testContext context)
        {
            _context = context;
        }

        public int BookingLight(BookingLight bookinglight)
        {
            try
            {
                if (bookinglight != null)
                {
                    _context.BookingLight.Add(bookinglight);
                    _context.SaveChanges();
                    return bookinglight.BookLightID;
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
