using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lab_1_versaler
{
    public static class TextAnalyzer
    {
        public static int GetNumberOfCapitals(string text) {
            return text.Count(c => Char.IsUpper(c));
        }
    }
}