using System;
using System.Globalization;
using System.Windows.Controls;

public class ValidateIsNot : ValidationRule
{
    private const string errorMessage = "The number must be different to {0}";
    private int invalidNumber;
    public ValidateIsNot(int number)
    {
        invalidNumber = number;
    }

    public override ValidationResult Validate(object value, CultureInfo cultureInfo)
    {
        var message = string.Format(errorMessage, invalidNumber);
        var error = new ValidationResult(false, message);

        if (value == null)
            return new ValidationResult(true, null);

        var stringValue = value.ToString();
        double doubleValue;
        if (!Double.TryParse(stringValue, out doubleValue))
            return new ValidationResult(true, null);

        if (doubleValue == invalidNumber)
            return error;
        return new ValidationResult(true, null);
    }
}