namespace MobilePhone
{
    using System;

    public class Display
    {
        public string size;
        public uint colors;

        public Display()
        {
            this.Size = size;
            this.Colors = colors;
        }

        public string Size
        {
            get
            {
                return this.size;
            }
            set
            {
                this.size = value;
            }
        }

        public uint Colors
        {
            get
            {
                return this.colors;
            }
            set
            {
                if (value < uint.MinValue)
                {
                    throw new ArgumentOutOfRangeException("The GSM cannot be Negative Number Colors!");
                }

                this.colors = value;
            }
        }

        public override string ToString()
        {
            string size = "Display Size: " + this.Size;
            string colors = "Display Colors: " + this.Colors;

            return size + "\n" + colors;
        }
    }
}
