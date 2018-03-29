using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace bookingDateGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            //creates a zero'd out date for todays date
            //example 20/05/2018 00:00:00
            DateTime currentDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0);

            List<Booking> roomBookings = new List<Booking>();
            for (int i = 0; i < 10; i++)
            {

                // generates a random minute in increments of 15
                DateTime startTime = currentDate.AddMinutes(new Random().Next(0, 96) * 15);
                //generates a random endtime within 2 hours of the start date
                DateTime endTime = startTime.AddMinutes(new Random().Next(1, 8) * 15);

                roomBookings.Add(new Booking(startTime, endTime));
            }


            TextWriter tw = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop).ToString() + "\\booking.txt");
            foreach (Booking booking in roomBookings)
            {
                tw.WriteLine(booking.ToString());
            }
            tw.Close();
        }
    }
}
