namespace MobilePhone
{
    using System;

    public class Call
    {
        private DateTime date;
        private ulong phoneNumber;
        private string duration;

        public Call()
        {
            duration = null;
        }

        public Call(string duration)
        {
            this.Duration = duration;
        }

        public Call(string duration, ulong phoneNumber)
            : this(duration)
        {
            this.PhoneNumber = phoneNumber;
        }

        public Call(string duration, ulong phoneNumber, DateTime date)
            : this(duration, phoneNumber)
        {
            this.Date = date;
        }

        public DateTime Date
        {
            get
            {
                return this.date;
            }
            set
            {
                this.date = value;
            }
        }

        public ulong PhoneNumber
        {
            get
            {
                return this.phoneNumber;
            }
            set
            {
                this.phoneNumber = value;
            }
        }

        public string Duration
        {
            get
            {
                return this.duration;
            }
            set
            {
                this.duration = value;
            }
        }
    }
}
