﻿using System;

namespace TestEndpoints
{
    internal class ReservationConfirmedEvent
    {
        public int ReservationId { get; set; }
        public Reservation Reservation { get; set; }
    }
}