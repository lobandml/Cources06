using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Cources06
{
    struct Notebook
    {
        public string Model { get; private set; }
        public string Manufacturer { get; private set; }
        public double Price { get; private set; }

        public Notebook(string model, string manufacturer, double price): this()
        {
            Model = model;
            Manufacturer = manufacturer;
            Price = price;
        }
        

        public override string ToString()
        {
            PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(this);
            StringBuilder builder = new StringBuilder(this.GetType().Name, 255);
            builder.Append(" (");

            foreach (PropertyDescriptor property in properties)
            {
                builder.Append(property.Name);
                builder.Append(" = ");
                builder.Append(property.GetValue(this).ToString());
                builder.Append("; ");
            }
            builder.Remove(builder.Length - 2, 2);
            builder.Append(")");

            return builder.ToString();
        }
    }
}
