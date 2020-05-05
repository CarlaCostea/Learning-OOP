using System;
using System.Collections.Generic;
using System.Text;

namespace CircularDoublyLinkedList
{
    public class RegisterEvent
    {
        private DateTime eventTimeStamp;
        private string eventTitle;
        private string eventDetails;

        public RegisterEvent(DateTime eventTimeStamp, string eventTitle, string eventDetails)
        {
            this.eventTimeStamp = eventTimeStamp;
            this.eventTitle = eventTitle;
            this.eventDetails = eventDetails;
        }

        public string Event()
        {
            return eventTimeStamp + "\n" + eventTitle + "\n" + eventDetails;
        }
    }
}
