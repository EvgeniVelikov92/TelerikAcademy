namespace MobilePhone
{
    using System;

    public class Mobile
    {
        private string model;
        private string manufacturer;
        private double price;
        private readonly string owner;
        private Battery battery;
        private Display display;

        public Mobile()
        {

        }

        public Mobile(string manufacturer, string model) {
            this.Manufacturer = manufacturer;
            this.Model = model;
            this.Price = 0;
            this.owner = null;
            this.battery = null;
            this.display = null;
        }

        public Mobile(string manufacturer, string model, double price, string owner, Battery battery, Display display)
            : this(manufacturer, model)
        {
            this.Price = price;
            this.owner = owner;
            this.battery = battery;
            this.display = display;
        }

        public double Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (double.IsNegativeInfinity(value))
                {
                    throw new ArgumentOutOfRangeException("GSM cannot be Negative Price!");
                }

                this.price = value;
            }
        }

        public string Model 
        {
            get
            {
                return this.model;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Model cannot null or empty");
                }

                this.model = value;
            }
        }

        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }
            set {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Manufacturer cannot null or empty");
                }

                if (value.Length < 3)
                {
                    throw new ArgumentOutOfRangeException("Manufacturer most be longer than 3 symbols");
                }

                this.manufacturer = value;
            }
        }

        public override string ToString()
        {
            string manuf = "Manufacturer: " + this.manufacturer;
            string model = "Model: " + this.model;
            string price = "Price: " + this.price + "$";
            string owner = "Owner: " + this.owner;
            string battery = "\nBattery:\n" + this.battery;
            string display = "\nDisplay:\n" + this.display;

            return manuf + "\n" + model + "\n" + price + "\n" + owner + "\n" + battery + "\n" + display;
        }
    }
}
