using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using WpfApplication1.Entities;

namespace WpfApplication1.Converters
{
    public class StringConvertToHuman : TypeConverter
    {
        public override object ConvertFrom(ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value)
        {
            if (value is string)
            {
                Human human = new Human();
                human.Name = value as string;
                return human;
            }
            return base.ConvertFrom(context, culture, value);
        }
    }
}
