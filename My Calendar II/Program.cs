using My_Calendar_II;

MyCalendarTwo myCalendarTwo = new MyCalendarTwo();
Console.WriteLine(myCalendarTwo.Book(10, 20)); // return True, The event can be booked. 
Console.WriteLine(myCalendarTwo.Book(50, 60)); // return True, The event can be booked. 
Console.WriteLine(myCalendarTwo.Book(10, 40)); // return True, The event can be double booked. 
Console.WriteLine(myCalendarTwo.Book(5, 15));  // return False, The event cannot be booked, because it would result in a triple booking.
Console.WriteLine(myCalendarTwo.Book(5, 10)); // return True, The event can be booked, as it does not use time 10 which is already double booked.
Console.WriteLine(myCalendarTwo.Book(25, 55)); // return True,
