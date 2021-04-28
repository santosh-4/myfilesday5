using System;
class Test 
{
   static void Main()
   {
      DateTime d = new DateTime(2018, 7, 23, 08, 20, 10, 09);
      Console.WriteLine (" year: "+d.Year);
      Console.WriteLine (" Month: "+d.Month);
      Console.WriteLine (" Day: "+d.Day);
      Console.WriteLine (" hours: "+d.Hour);
      Console.WriteLine (" Minutes: "+d.Minute);
      Console.WriteLine (" Seconds: "+d.Second);
      Console.WriteLine (" MilliSeconds: "+d.Millisecond);
      Console.WriteLine (String.Format("{0}",d));
      
      
      DateTime d =DateTime.Now;
      Console.WriteLine("Todays Date {0:dd/MM/yyyy}",d);
   }
}