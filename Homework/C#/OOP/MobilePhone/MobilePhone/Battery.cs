namespace MobilePhone
{
    using System;

    public class Battery : Mobile
    {
        public uint hoursIdle;
        public uint hoursTalk;
        public BatteryType model;

        public BatteryType Model { get; set; }

        public uint HoursIdle { get; set; }

        public uint HoursTalk { get; set; }

        public Battery(BatteryType model, uint idle, uint talk)
        {
            this.Model = model;
            this.HoursIdle = idle;
            this.HoursTalk = talk;
        }

        public override string ToString()
        {
            string model = "Battery Model: " + this.Model;
            string idle = "Hours Idle: " + this.HoursIdle + " Hours";
            string talk = "Hours Talk: " + this.HoursTalk + " Hours";

            return model + "\n" + idle + "\n" + talk;
        }
    }
}
