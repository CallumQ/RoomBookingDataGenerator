using System;

namespace bookingDateGenerator
{
    class Booking
    {
        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public Booking(DateTime startTime, DateTime endTime)
        {
            this.StartTime = startTime;
            this.EndTime = endTime;
        }

        public override string ToString()
        {
            return StartTime.ToString() + " , " + EndTime.ToString();
        }


    }
}
