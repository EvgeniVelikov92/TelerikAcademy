namespace MobilePhone
{
    using System;

    public class Battery
    {
        public double hoursIdle;
        public double hoursTalk;
        public BatteryType model;

        public BatteryType Model 
        {
            get
            {
                return this.model;
            }
            set
            {
                this.model = value;
            }
        }

        public double HoursIdle 
        {
            get
            {
                return this.hoursIdle;
            }
            set
            {
                if (double.IsNegativeInfinity(value))
                {
                    throw new ArgumentOutOfRangeException("The GSM Battery cannot be Negative Hours Idle!");
                }

                this.hoursIdle = value;
            }
        }

        public double HoursTalk 
        {
            get
            {
                return this.hoursTalk;
            }
            set
            {
                if (double.IsNegativeInfinity(value))
                {
                    throw new ArgumentOutOfRangeException("The GSM Battery cannot be Negative Hours Talk!");
                }

                this.hoursTalk = value;
            }
        }

        public Battery()
        {
            this.Model = model;
            this.HoursIdle = 0;
            this.HoursTalk = 0;
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
