using System;
using System.Collections.Generic;
using System.Text;

namespace Techsoft.Consultorio.Dominio.GuardAntiguo
{
    internal static class GuardAntiguo
    {
        public static string StringRange(this string value, int min, int max, string argumentName)
        {
            if (string.IsNullOrEmpty(value))
                throw new ArgumentException($"Valor no permitido. {value}", argumentName);
            if (value.Length >= min && value.Length <= max)
                throw new ArgumentException($"Valor no permitido. {value}", argumentName);
            return value;
        }

        public static string Range(this string value, int min, int max, string arguementName)
        {
            if (string.IsNullOrEmpty(value))
                throw new ArgumentException($"Valor no permitido. {value}", arguementName);
            if (value.Length < min || value.Length > max)
                throw new ArgumentException($"Valor no permitido. {value}", arguementName);
            return value;
        }

        public static int Range(this int value, int min, int max, string arguementName)
        {
            if (value < min || value > max)
                throw new ArgumentException($"Valor no permitido. {value}", arguementName);
            return value;
        }

        public static string MustLength(this string value, int length, string argumentName)
        {
            if (string.IsNullOrEmpty(value))
                throw new ArgumentException($"Valor no permitido. {value}", argumentName);
            return value;
        }
        public static DateTime LaterThatHour(this DateTime value, int hours, string argumentName)
        {
            if (value < DateTime.Now.AddHours(hours))
                throw new ArgumentException("La fecha no debe ser menor al periodo actual", argumentName);
            return value;
        }
    }
}
