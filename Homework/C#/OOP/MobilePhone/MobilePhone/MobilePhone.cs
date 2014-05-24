namespace MobilePhone
{
    using System;

    public class MobilePhone
    {
        static void Main()
        {
            Battery batt = new Battery(BatteryType.Li_Ion, 480, 17);

            Display dis = new Display(320, 2400000);

            Mobile samsung = new Mobile("Samsung", "Galaxy S5366", 179, "Evgeni Velikov", batt, dis);

            Console.WriteLine(samsung);
        }
    }
}