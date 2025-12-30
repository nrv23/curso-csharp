using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings.Exercises
{
    public class ReverseStringBuilder
    {
        private string _text;
        public ReverseStringBuilder(string text) { 
            
            _text = text;
        }

        public string Reverse()
        {
            var stringBuilder = new StringBuilder(_text.Length);
            for (int i = _text.Length - 1; i >= 0; i--)
            {
                stringBuilder.Append(_text[i]);
            }
            return stringBuilder.ToString();
        }
    }
}
