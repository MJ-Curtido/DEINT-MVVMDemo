using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEINT_MVVMDemo.Converters
{
    public class BoolConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var respuesta = value.ToString();

            if (respuesta.Equals("si", StringComparison.OrdinalIgnoreCase))
            {
                return true;
            } else
            {
                return false;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var respuesta = (bool) value;

            if (respuesta)
            {
                return "Si";
            }
            else
            {
                return "No";
            }
        }
    }
}
