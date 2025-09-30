using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedTypes.structs
{
    using System;

    public struct Time
    {
        public int Hour { get; }
        public int Minute { get; }

        public Time(int hour, int minute)
        {
            if (hour < 0 || hour > 23)
                throw new ArgumentOutOfRangeException(nameof(hour), "Hour must be between 0 and 23");
            if (minute < 0 || minute > 59)
                throw new ArgumentOutOfRangeException(nameof(minute), "Minute must be between 0 and 59");

            Hour = hour;
            Minute = minute;
        }

        // ✅ Sobrecarga del operador ==
        public static bool operator ==(Time t1, Time t2)
        {
            return t1.Hour == t2.Hour && t1.Minute == t2.Minute;
        }

        // ✅ Sobrecarga del operador !=
        public static bool operator !=(Time t1, Time t2)
        {
            return !(t1 == t2);
        }

        // ✅ Sobrecarga del operador +
        public static Time operator +(Time t1, Time t2)
        {
            int totalMinutes = t1.Minute + t2.Minute;
            int extraHours = totalMinutes / 60; // cuántas horas se forman con los minutos extra
            int finalMinutes = totalMinutes % 60;

            int totalHours = (t1.Hour + t2.Hour + extraHours) % 24; // ajustar si pasa de 23

            return new Time(totalHours, finalMinutes);
        }

        // ✅ Sobrescribimos Equals y GetHashCode (buenas prácticas)
        public override bool Equals(object obj)
        {
            return obj is Time t &&
                this == t;

        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Hour, Minute);
        }

        public override string ToString()
        {
            return $"{Hour:D2}:{Minute:D2}";
        }
    }

}
