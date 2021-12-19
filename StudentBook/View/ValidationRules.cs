using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Windows.Controls;

namespace StudentBook.View
{
    public class NotEmptyValidationRule : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            if (String.IsNullOrWhiteSpace((value ?? "").ToString()))
                return new ValidationResult(false, "Field is required.");
            return ValidationResult.ValidResult;
        }
    }
}
