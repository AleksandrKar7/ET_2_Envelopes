using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET_2_Envelopes
{
    static class ConsoleMenu
    {
        public static double? GetDoubleValue(string message)
        {
            double result;
            string text;
            
            Console.WriteLine(message);
            text = Console.ReadLine();

            if(Double.TryParse(text, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        public static bool? GetBoolValue(string message)
        {
            string text;
            string insturction;
            string[] trueArray = { "T", "TRUE" };
            string[] falseArray = { "F", "FALSE" };

            insturction = String.Format("For true: {0}; For false: '{1}'", 
                String.Join("', ", trueArray), String.Join("', ", falseArray));

            Console.WriteLine(message);
            Console.WriteLine(insturction);

            text = Console.ReadLine();
            text.Trim();
            text = text.ToUpper();

            if(text == null)
            {
                return null;
            }

            if (trueArray.Contains(text))
            {
                return true;
            }
            if (falseArray.Contains(text))
            {
                return false;
            }

            return null;
        }

        public static bool GetBoolValue(string message, string[] trueArray)
        {
            if (trueArray == null)
            {
                return false;
            }
            string text;
            string insturction;


            insturction = String.Format("For true: {0}; For false: '{1}'",
                String.Join("', ", trueArray), "Press enter");

            Console.WriteLine(message);
            Console.WriteLine(insturction);

            text = Console.ReadLine();
            text.Trim();
            text = text.ToUpper();

            if (text == null)
            {
                return false;
            }

            if (trueArray.Contains(text))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool? GetBoolValue(string message, string[] trueArray, string[] falseArray)
        {
            if (trueArray == null)
            {
                return null;
            }
            if (falseArray == null)
            {
                return null;
            }
            string text;
            string insturction;

            insturction = String.Format("For agree: {0}; For disagree: '{1}'",
                String.Join("', ", trueArray), String.Join("', ", falseArray));

            Console.WriteLine(message);
            Console.WriteLine(insturction);

            text = Console.ReadLine();
            text.Trim();
            text = text.ToUpper();

            if (text == null)
            {
                return null;
            }
            if (trueArray.Contains(text))
            {
                return true;
            }
            if (falseArray.Contains(text))
            {
                return false;
            }

            return null;
        }
    }
}
