using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace NIPWebAppBase.Helpers
{
    public class TextOperations
    {
        #region Public methods
        /// <summary>
        /// Removes non alhpanumeric characters at the beginning of string and also removes dashes from string
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string RectifyValueToFind(string value)
        {
            value = value.Replace("-", "");
            value = value.Substring(value.IndexOfAny("0123456789".ToCharArray()));

            return value;
        }

        #endregion
    }
}
