using System.ComponentModel.DataAnnotations;

namespace BasicMVC.CustomValidators
{
    public class CustomValidatorAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value == null)
            {
                return false;
            }
            else {
                return true;
            }
        }

    }
}