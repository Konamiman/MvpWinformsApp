using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

public class TestMultiBindingConverter : IMultiValueConverter
{
    public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
    {
        if (values[0] != null)
            return values[0].ToString();
        return DependencyProperty.UnsetValue;
    }

    public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
    {
        if (value != null)
        {
            double doubleValue;
            var stringValue = value.ToString();
            if (Double.TryParse(stringValue, out doubleValue))
            {
                object[] values = { doubleValue };
                return values;
            }

        }
        object[] values2 = { DependencyProperty.UnsetValue };
        return values2;
    }
}