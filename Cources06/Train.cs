using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Cources06
{
    struct Train : IComparable<Train>
    {
        public string Point { get; private set; }
        public int Sign { get; private set; }
        public DateTime DepartureTime { get; private set; }

        public Train(string point, int sign, DateTime departureTime):this()
        {
            
            Point = point;
            Sign = sign;
            DepartureTime = departureTime;
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

        public int CompareTo( Train tr2)
        {
            return this.Sign.CompareTo(tr2.Sign);
        }
        
    }
}
