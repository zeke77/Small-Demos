using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TimeSpanDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime startEmailing = DateTime.Now;
            int sleeptime = 90 * 1000;

            sleeptime = 10000;

            Thread.Sleep(sleeptime);
            DateTime doneEmailing = DateTime.Now;
            TimeSpan timeEmailing = doneEmailing.Subtract(startEmailing);

            string elapsed_time1 = string.Format(
                 "Emails took {0} Days : {1} Hours : {2} Minutes : {3} Seconds to run.",
                 timeEmailing.ToString("dd"),
                 timeEmailing.ToString("hh"),
                 timeEmailing.ToString("mm"),
                 timeEmailing.ToString("ss")
                 );

            MyTime tmptime = new MyTime();

            tmptime.days = timeEmailing.TotalDays.ToString("0");
            tmptime.hours = timeEmailing.TotalHours.ToString("0");
            tmptime.minutes = timeEmailing.TotalMinutes.ToString("0");
            tmptime.seconds = timeEmailing.TotalSeconds.ToString("0");

            string elapsed_time = string.Format(
                 "Emails took {0} Days : {1} Hours : {2} Minutes : {3} Seconds to run.",
                 tmptime.days,
                 tmptime.hours,
                 tmptime.minutes,
                 tmptime.seconds
                 );

            Console.WriteLine(elapsed_time1);
            Console.WriteLine(elapsed_time);

            Console.ReadLine();

        }
    }
}
