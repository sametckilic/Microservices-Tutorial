using Reservation.API.Infrastructure;
using Reservation.API.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reservation.API.Services
{
    public class ReservationService : IReservationService
    {
        public ReservationDTO GetResByBkgNumber(int BkgNumber)
        {
            return new ReservationDTO
            {
                Id = (new Random().Next(100)),
                Amount = (new Random().Next(1000)),
                BkgDate = DateTime.Now,
                CheckInDate = DateTime.Now.AddDays(10),
                CheckoutDate = DateTime.Now.AddDays(20),
                BkgNumber = BkgNumber

            };
        }
    }
}
