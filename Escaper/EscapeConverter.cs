using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escaper
{
    class EscapeConverter
    {
        private String from_string;

        public EscapeConverter FromString(String s)
        {
            from_string = s;
            return this;
        }
        public String ToEscapedString()
        {
            var builder = new StringBuilder();

            foreach (var c in from_string)
            {
                var escaped = "";

                switch(c)
                {
                    case '\n':
                        escaped = "\\n";
                        break;
                    case '\r':
                        escaped = "\\r";
                        break;
                    case '\t':
                        escaped = "\\t";
                        break;
                    case '\\':
                        escaped = "\\\\";
                        break;
                    case '\"':
                        escaped = "\\\"";
                        break;
                    case '\'':
                        escaped = "\\\'";
                        break;
                    default: escaped = c.ToString();
                        break;
                }

                builder.Append(escaped);
            }

            return builder.ToString();
        }
    }
}
