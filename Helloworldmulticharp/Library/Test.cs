using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Text.RegularExpressions;
using System.Windows.Forms;


namespace Helloworldmulticharp.Library
{
    public static class Test
    {
        /// <summary>
        /// Clean up the input string
        /// </summary>
        /// <param name="textboxString">String</param>
        /// <returns>string</returns>
        public static string RemoveSpaces(string textboxString)
        {
            textboxString = "Helloya" + "," + "Test1";
            return textboxString;
        }
    }
}