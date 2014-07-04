using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using WpfApplication1.Converters;

namespace WpfApplication1.Entities
{
    [TypeConverter(typeof(StringConvertToHuman))]
    public class Human
    {
        public string Name { get; set; }

        public Human Child { get; set; }
    }
}
