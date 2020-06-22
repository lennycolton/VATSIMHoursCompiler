using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VATSIMHoursCompiler
{
    class ComboBoxItem
    {
        public string Text;
        public object Value;

        public ComboBoxItem(string _text, object _value)
        {
            Text = _text;
            Value = _value;
        }

        public override string ToString()
        {
            return Text;
        }
    }
}
