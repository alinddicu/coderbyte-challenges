﻿namespace CoderbyteChallenges.Medium
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using NFluent;

    [TestClass]
    public class MostFreeTimeTest
    {
        /*
         
            have the function MostFreeTime(strArr) read the strArr parameter being passed which 
            will represent a full day and will be filled with events that span from time X to time Y 
            in the day. The format of each event will be hh:mmAM/PM-hh:mmAM/PM. 
             
            For example, strArr may be ["10:00AM-12:30PM","02:00PM-02:45PM","09:10AM-09:50AM"]. 
            Your program will have to output the longest amount of free time available between 
            the start of your first event and the end of your last event in the format: hh:mm. 
             
            The start event should be the earliest event in the day and the latest event should be the latest event in the day. 
            The output for the previous input would therefore be 01:30 
            (with the earliest event in the day starting at 09:10AM and the latest event ending at 02:45PM). The input 
            will contain at least 3 events and the events may be out of order.          
         
         */

        [TestMethod]
        public void GivenTest1WhenMostFreeTimeThenResultIsOk()
        {
            var events = new[] { "09:00AM-10:00AM", "10:30AM-12:00PM", "12:15PM-02:00PM" };
            Check.That(new MostFreeTime().Execute(events)).IsEqualTo("00:45");
        }
    }
}
