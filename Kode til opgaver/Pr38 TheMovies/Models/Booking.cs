﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr38_TheMovies.Models
{
    public class Booking
    {
        public int TicketAmount { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public Booking(int ticketAmount, string email, string phoneNumber)
        {
            TicketAmount = ticketAmount;
            Email = email;
            PhoneNumber = phoneNumber;
        }
    }
}
