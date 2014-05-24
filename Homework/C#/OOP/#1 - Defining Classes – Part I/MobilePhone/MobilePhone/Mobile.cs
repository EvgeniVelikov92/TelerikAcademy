namespace MobilePhone
{
    using System;

    public class Mobile
    {
        private string model;
        private string manufacturer;
        private double price;
        private string owner;
        
        private static string IPhone4S = null;

        public Battery battery = new Battery();
        public Display display = new Display();

        public Mobile(string manufacturer, string model) {
            this.Manufacturer = manufacturer;
            this.Model = model;
            this.Price = 0.0;
            this.owner = null;
            IPhone4S = null;
        }

        public Mobile(string manufacturer, string model, double price, string owner)
            : this(manufacturer, model)
        {
            this.Price = price;
            this.Owner = owner;
        }

        public Mobile(string manufacturer, string model, double price, string owner, string iPhone)
            : this(manufacturer, model, price, owner)
        {
            IPhone4S = iPhone;
        }

        public string Owner
        {
            get
            {
                return this.owner;
            }
            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentOutOfRangeException("The Name most be longer than 3 symbols");
                }

                this.owner = value;
            }
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
                    throw new ArgumentNullException("The Model cannot null or empty");
                }

                if (value.Length < 3)
                {
                    throw new ArgumentOutOfRangeException("The Model most be longer than 3 symbols");
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
