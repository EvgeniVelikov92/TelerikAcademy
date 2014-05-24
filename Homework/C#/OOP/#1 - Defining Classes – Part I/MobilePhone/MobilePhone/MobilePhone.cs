namespace MobilePhone
{
    using System;

    public class MobilePhone
    {
        static void Main()
        {
            Mobile first = new Mobile("Samsung", "Galaxy S5660", 179, "Velikov");
            Mobile second = new Mobile("Prestigio", "Galaxy S57", 220, "Ivanov");

            first.battery.HoursIdle = 340;
            second.battery.HoursIdle = 360;

            first.battery.HoursTalk = 12;
            second.battery.HoursTalk = 10;

            first.battery.Model = BatteryType.Li_Ion;
            second.battery.Model = BatteryType.Li_Ion;

            first.display.Size = "320x480";
            second.display.Size = "480x800";

            first.display.Colors = 65895;
            second.display.Colors = 84576;

            Console.WriteLine("-----------------------------First Client-----------------------------");
            Console.WriteLine(first);

            Console.WriteLine("\n-----------------------------Second Client----------------------------");
            Console.WriteLine(second);



            Console.WriteLine();
        }
    }
}