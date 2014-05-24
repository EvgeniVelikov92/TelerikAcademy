namespace MobilePhone
{
    using System;

    public class Display : Mobile
    {
        public uint size;
        public uint colors;

        public uint Size { get; set; }

        public uint Colors { get; set; }

        public Display(uint size, uint colors)
        {
            this.Size = size;
            this.Colors = colors;
        }

        public override string ToString()
        {
            string size = "Display Size: " + this.Size;
            string colors = "Display Colors: " + this.Colors;

            return size + "\n" + colors;
        }
    }
}
