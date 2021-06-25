using projectevents.Interfaces;
using projectevents.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projectevents.Data
{
    public class BookEquipmentConcrete : IBookEquipment
    {
        private uma_testContext _context;

        public BookEquipmentConcrete(uma_testContext context)
        {
            _context = context;
        }
        public int BookEquipment(BookingEquipment BookingEquipment)
        {
            try
            {
                if (BookingEquipment != null)
                {
                    _context.BookingEquipment.Add(BookingEquipment);
                    _context.SaveChanges();
                    return BookingEquipment.BookingID
                    ;
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
