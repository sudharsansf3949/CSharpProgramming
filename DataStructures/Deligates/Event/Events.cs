using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Event
{
    public delegate void EventManager();    //user defined deligate
    public class Events
    {
        private string _eventName;
        public static event EventManager eventlink=null;     //user defined event
        static int i;
        public Events(string eventName)
        {
            _eventName=eventName;
        }
        public static void HandleEvent()
        {
            i=0;
            System.Console.WriteLine("User Registration");
            System.Console.WriteLine("Starting the following Events");
            eventlink();
        }

        public void ShowEvenet()
        {
            ++i;
            System.Console.WriteLine("Event No " +i+ " is: " +_eventName+ " Started");
        }
    }   
}