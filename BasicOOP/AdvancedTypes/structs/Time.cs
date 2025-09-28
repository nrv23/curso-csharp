using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedTypes.structs
{
    public struct Time
    {
        public int Hour { get; }
        public int Minute { get; }

        public Time(int hour, int minute)
        {
            if (hour < 0 || hour > 23)
            {
                throw new ArgumentOutOfRangeException(nameof(hour), "hour must be between 0 and 23");
            }
            if (minute < 0 || minute > 59)
            {
                throw new ArgumentOutOfRangeException(nameof(minute), "minute must be between 0 and 59");
            }
            Hour = hour;
            Minute = minute;
        }

        public override string ToString() => $"{Hour:D2}:{Minute:D2}";
        // con D2 indica que debe tener 2 digitos, si no tiene rellena con 0 a la izquierda
    }
}
