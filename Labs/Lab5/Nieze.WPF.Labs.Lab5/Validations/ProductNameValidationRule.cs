using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Controls;

namespace Nieze.WPF.Labs.Lab5.Desktop.Validations;

public class ProductNameValidationRule : ValidationRule
{
    public override ValidationResult Validate(object value, CultureInfo cultureInfo)
    {
        var pattern = @"^[a-zA-Z]+$";

        if (!Regex.IsMatch((string)value, pattern))
        {
            var message = $"{value} is not a valid, Input must contain only alphabetic characters (A-Z, a-z). No numbers, spaces, or special characters are allowed.";
            return new ValidationResult(false, message);
        }

        return new ValidationResult(true, null);
    }
}
