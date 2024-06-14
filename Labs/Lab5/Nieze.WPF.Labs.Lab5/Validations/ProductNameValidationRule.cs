using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Controls;

namespace Nieze.WPF.Labs.Lab5.Desktop.Validations;

public class ProductNameValidationRule : ValidationRule
{
    public override ValidationResult Validate(object value, CultureInfo cultureInfo)
    {
        var pattern =
            @"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*([,;]\s*\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*)*";
        if (!Regex.IsMatch((string)value, pattern))
        {
            var msg = $"{value} is not a valid email address.";
            return new ValidationResult(false, msg);
        }

        return new ValidationResult(true, null);
    }
}
