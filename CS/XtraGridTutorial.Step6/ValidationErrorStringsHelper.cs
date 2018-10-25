using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XtraGridTutorial
{
    public static class ValidationErrorStringsHelper
    {
        public static string GetDateErrorMessage(string fieldName)
        {
            return string.Format("The {0} field cannot store the future date", fieldName);
        }

        public static string GetAccountErrorMessage(string fieldName)
        {
            return string.Format("You cannot leave the {0} field empty", fieldName);
        }

    }
}
