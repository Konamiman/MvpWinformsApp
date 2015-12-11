using System;
using System.Globalization;
using System.Windows.Controls;

public class ValidateIsBiggerThanTen : ValidationRule
{
    private const string errorMessage = "The number must be bigger than 10";

    public ValidateIsBiggerThanTen()
    { }

    public override ValidationResult Validate(object value, CultureInfo cultureInfo)
    {
        var error = new ValidationResult(false, errorMessage);

        if (value == null)
            return new ValidationResult(true, null);

        var stringValue = value.ToString();
        double doubleValue;
        if (!Double.TryParse(stringValue, out doubleValue))
            return new ValidationResult(true, null);

        if (doubleValue <= 10)
            return error;
        return new ValidationResult(true, null);
    }
}