namespace MobilePhone
{
    using System;

    public class GSMCallHistoryTest
    {
        static void Main()
        {
            GSM mobile = new GSM("Samsung", "Galaxy S5360", 330, "Evgeni Velikov");

            mobile.AddCall(new Call(300));
            mobile.AddCall(new Call(4000));
            mobile.AddCall(new Call(120));

            Console.WriteLine("Total Price: {0:C}", mobile.CalculateTotalPrice());

            mobile.RemoveCall(new Call(4000));

            Console.WriteLine("Total Price After Remove: {0:C}", mobile.CalculateTotalPrice());

            mobile.RemoveAllCall();

            Console.WriteLine("Remove Total Price: {0:C}", mobile.CalculateTotalPrice());

            Console.WriteLine();

            mobile.battery.HoursIdle = 340;
            mobile.battery.HoursTalk = 12;
            mobile.battery.Model = BatteryType.Li_Ion;
            mobile.display.Size = "320x480";
            mobile.display.Colors = 65895;

            Console.WriteLine(mobile);
        }
    }
}
