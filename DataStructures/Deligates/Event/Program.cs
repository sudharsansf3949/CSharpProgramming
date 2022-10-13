using System;
namespace Event;
class program{
    public static void Main(string[] args)
    {
        Events event1=new Events("Quiz");
        Events event2=new Events("Debugging");
        Events event3=new Events("Presentation");
        Events event4=new Events("Games");

        //Event registration by management
        //Subscribe to events
        Events.eventlink+=new EventManager(event1.ShowEvenet);
        Events.eventlink+=new EventManager(event2.ShowEvenet);
        Events.eventlink+=new EventManager(event3.ShowEvenet);
        Events.eventlink+=new EventManager(event4.ShowEvenet);

        //process Initiation
        Events.HandleEvent();

        //Event cancellation//unsubcribe from events

        Events.eventlink-=new EventManager(event4.ShowEvenet);
        Events.HandleEvent();
    }
}