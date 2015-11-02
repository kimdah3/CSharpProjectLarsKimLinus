using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace GUI2
{
    public class Validation
    {
        public static bool TextboxNotEmpty(string text)
        {
            if (!string.IsNullOrWhiteSpace(text))
            {
                return true;
            }

            else
            {
                throw new Exception("Text fields can't be left empty.");
            }

        }

        public static bool UrlCheck(string URL)
        {
            if(!string.IsNullOrWhiteSpace(URL))
            {
                string urlregex = @"^http://([a-zA-Z0-9_\-]+)([\.][a-zA-Z0-9_\-]+)+([/][a-zA-Z0-9\~\(\)_\-]*)+([\.][a-zA-Z0-9\(\)_\-]+)*$";

                if(Regex.IsMatch(URL, urlregex))
                {
                    return true;
                }

                else
                {
                    throw new Exception("Felaktig URL");
                }
            }

            else
            {
                throw new Exception("Du måste ange en URL.");
            }
              
        }

        public static bool NumberCheck(string TimeInterval)
        {
            int parseValue;

            if (!int.TryParse(TimeInterval, out parseValue))
            {
                throw new Exception("Update Interval måste anges i siffror.");
            }
            else
            {
                return true;
            }
        }

        public static bool ComboboxCheck(string selectedItem)
        {
            if (selectedItem != null)
            {
                return true;
            }

            else
            {
                throw new Exception("Nothing is selected.");
            }
        }

        public static bool ControlSelectionCheck(int selection)
        {
            if (selection != -1)
            {
                return true;
            }

            else
            {
                throw new Exception("Nothing is selected.");
            }
        }

    }
}
