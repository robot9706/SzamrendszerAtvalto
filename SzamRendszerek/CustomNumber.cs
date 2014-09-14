using System;
using System.Collections.Generic;
using System.Text;

namespace SzamRendszerek
{
    public struct CustomNumber
    {
        private string _value;
        public string Value
        {
            get { return _value; }
            set { _value = value; }
        }

        private int _system;
        public int System
        {
            get { return _system; }
            set { _system = value; }
        }

        private int _realValue;

        public static CustomNumber? CreateNumber(string value, int system)
        {
            CustomNumber? returnValue = null;
            try
            {
                returnValue = new CustomNumber(value, system);
            }
            catch
            {
                returnValue = null;
            }

            return returnValue;
        }

        public CustomNumber(string value, int system)
        {
            value = value.ToUpper();

            if (system < 2 || system > 36)
                throw new ArgumentOutOfRangeException("system");

            if (value.Length == 0)
                value = "0";

            if(!NumberSystem.CheckNumber(value, system))
                throw new ArgumentOutOfRangeException("value");

            _value = value;
            _system = system;
            _realValue = 0;

            CalculateRealValue();
        }

        private void CalculateRealValue()
        {
            if (_system == 10)
            {
                _realValue = Convert.ToInt32(_value);
            }
            else
            {
                for (int x = _value.Length-1; x >= 0; x--)
                {
                    int val = (int)Math.Pow(_system, (_value.Length - 1) - x);

                    char c = _value[x];
                    int charValue = NumberSystem.GetNumberValue(c);

                    _realValue += val * charValue;
                }
            }
        }

        public CustomNumber ConvertTo(int system)
        {
            if (system < 2 || system > 36)
                throw new ArgumentOutOfRangeException("system");

            if (system == _system)
                return CustomNumber.CreateNumber(_value, _system).Value;

            List<int> modsList = new List<int>();

            int calc = _realValue;
            while (calc > 0)
            {
                modsList.Add(calc % system);
                calc = calc / system;
            }

            int[] mods = modsList.ToArray();

            Array.Reverse(mods);

            string number = String.Empty;
            for (int x = 0; x < mods.Length; x++)
            {
                number += NumberSystem.GetCharacterValue(mods[x]);
            }

            return CustomNumber.CreateNumber(number, system).Value;
        }

        public override string ToString()
        {
            return String.Format("{0},{1}", _value, _system);
        }
    }
}
