using CalendarApp.Abstract;
using CalendarApp.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarApp.Entites
{
    internal class Meeting: Event, INotification
    {
        public List<string> Guests { get; set; }

        public void GetNotification()
        {
            foreach(var guest in Guests)
            {
                Console.WriteLine($"Inviting: {guest}");
            }
        }
    }
    
}   
