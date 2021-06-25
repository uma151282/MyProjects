using projectevents.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projectevents.Interfaces
{
    public interface ITotalbilling
    {
        BillingModel GetBillingDetailsbyBookingNo(string BookingNo);
        CompleteBookingModel ShowCompleteBookingDetailsbyBookingNo(string BookingNo);
    }
}
