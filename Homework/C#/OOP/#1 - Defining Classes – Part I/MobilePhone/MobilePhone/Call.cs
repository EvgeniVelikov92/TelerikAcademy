namespace MobilePhone
{
    using System;

    public class Call
    {
        private DateTime date;
        private ulong phoneNumber;
        private long duration;

        public Call()
        {
            duration = 0;
        }

        public Call(long duration)
        {
            this.Duration = duration;
        }

        public Call(long duration, ulong phoneNumber)
            : this(duration)
        {
            this.PhoneNumber = phoneNumber;
        }

        public Call(long duration, ulong phoneNumber, DateTime date)
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

        public long Duration
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
