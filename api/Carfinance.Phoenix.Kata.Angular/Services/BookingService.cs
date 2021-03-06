﻿using Carfinance.Phoenix.Kata.Angular.Models;
using Carfinance.Phoenix.Kata.Angular.Services.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Carfinance.Phoenix.Kata.Angular.Services
{
    public class BookingService : IBookingService
    {
        private static IList<Booking> bookings;

        public BookingService() : this(new DataService())
        {
        }

        public BookingService(IDataService dataService)
        {
            bookings = dataService.Initialize();
        }

        public IList<Booking> GetAllBookings()
        {
            return bookings;
        }

        public void CreateBooking(Booking booking)
        {
            if (booking.BookingId > 0)
            {
                var existing = bookings.First(x => x.BookingId == booking.BookingId);
                var index = bookings.IndexOf(existing);
                bookings[index] = booking;
            }
            else
            {
                booking.BookingId = bookings.Max(b => b.BookingId) + 1;
                bookings.Add(booking);
            }
        }
    }
}