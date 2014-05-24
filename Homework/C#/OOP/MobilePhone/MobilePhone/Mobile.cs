namespace MobilePhone
{
    using System;

    public class Mobile
    {
        private string model;
        private ModelType manufacturer;
        private double price;
        private readonly string owner;
        private Battery battery;
        private Display display;

        public Mobile()
        {

        }

        public Mobile(ModelType manufacturer, string model, double price, string owner, Battery battery, Display display)
        {
            this.manufacturer = manufacturer;
            this.Model = model;
            this.price = price;
            this.owner = owner;
            this.battery = battery;
            this.display = display;
        }

        public string Model 
        {
            get
            {
                return this.model;
            }
            protected set
            {
                this.model = value;
            }
        }

        public override string ToString()
        {
            string manuf = "Manufacturer: " + this.manufacturer;
            string model = "Model: " + this.model;
            string price = "Price: " + this.price;
            string owner = "Owner: " + this.owner;

            return manuf + "\n" + model + "\n" + price + "\n" + owner + "\n" + this.battery + "\n" + this.display;
        }
    }
}
