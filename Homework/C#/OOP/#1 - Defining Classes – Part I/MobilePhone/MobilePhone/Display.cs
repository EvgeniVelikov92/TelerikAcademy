namespace MobilePhone
{
    using System;

    public class Display : Mobile
    {
        public uint size;
        public uint colors;

        public Display(uint size, uint colors)
        {
            this.Size = size;
            this.Colors = colors;
        }

        public uint Size
        {
            get
            {
                return this.size;
            }
            set
            {
                if (value < uint.MinValue)
                {
                    throw new ArgumentOutOfRangeException("The GSM cannot be Negative Size!");
                }

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
