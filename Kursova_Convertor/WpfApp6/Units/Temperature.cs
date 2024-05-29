using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp6
{
    public class CelsiusToFahrenheitConverter : UnitConverter
    {
        private const double conversionFactor = 9.0 / 5.0;
        private const double offset = 32.0;

        public override double Convert(double value)
        {
            return (value * conversionFactor) + offset;
        }

        public override string GetConversionResult(double value)
        {
            double result = Convert(value);
            return $"{result:F2}";
        }

        public override List<string> GetUnits()
        {
            return new List<string> { "Цельсій", "Фаренгейт" };
        }
    }
    public class CelsiusToKelvinConverter : UnitConverter
    {
        private const double offset = 273.15;

        public override double Convert(double value)
        {
            return value + offset;
        }

        public override string GetConversionResult(double value)
        {
            double result = Convert(value);
            return $"{result:F2}";
        }

        public override List<string> GetUnits()
        {
            return new List<string> { "Цельсій", "Кельвін" };
        }
    }
    public class CelsiusToCelsiusConverter : UnitConverter
    {
        public override double Convert(double value)
        {
            return (value);
        }

        public override string GetConversionResult(double value)
        {
            double result = Convert(value);
            return $"{result:F2}";
        }

        public override List<string> GetUnits()
        {
            return new List<string> { "Цельсій", "Цельсій" };
        }
    }

    public class FahrenheitToCelsiusConverter : UnitConverter
    {
        private const double conversionFactor = 5.0 / 9.0;
        private const double offset = 32.0;

        public override double Convert(double value)
        {
            return (value - offset) * conversionFactor;
        }

        public override string GetConversionResult(double value)
        {
            double result = Convert(value);
            return $"{result:F2}";
        }

        public override List<string> GetUnits()
        {
            return new List<string> { "Фаренгейт", "Цельсій" };
        }
    }
    public class FahrenheitToKelvinConverter : UnitConverter
    {
        private const double conversionFactor = 5.0 / 9.0;
        private const double offset = 32.0;
        private const double kelvinOffset = 273.15;

        public override double Convert(double value)
        {
            return (value - offset) * conversionFactor + kelvinOffset;
        }

        public override string GetConversionResult(double value)
        {
            double result = Convert(value);
            return $"{result:F2}";
        }

        public override List<string> GetUnits()
        {
            return new List<string> { "Фаренгейт", "Кельвін" };
        }
    }
    public class FahrenheitToFahrenheitConverter : UnitConverter
    {
        public override double Convert(double value)
        {
            return (value);
        }

        public override string GetConversionResult(double value)
        {
            double result = Convert(value);
            return $"{result:F2}";
        }

        public override List<string> GetUnits()
        {
            return new List<string> { "Фаренгейт", "Фаренгейт" };
        }
    }
    public class KelvinToFahrenheitConverter : UnitConverter
    {
        private const double conversionFactor = 9.0 / 5.0;
        private const double offset = 32.0;
        private const double kelvinOffset = 273.15;

        public override double Convert(double value)
        {
            return (value - kelvinOffset) * conversionFactor + offset;
        }

        public override string GetConversionResult(double value)
        {
            double result = Convert(value);
            return $"{result:F2}";
        }

        public override List<string> GetUnits()
        {
            return new List<string> { "Кельвін", "Фаренгейт" };
        }
    }
    public class KelvinToCelsiusConverter : UnitConverter
    {
        private const double offset = 273.15;

        public override double Convert(double value)
        {
            return value - offset;
        }

        public override string GetConversionResult(double value)
        {
            double result = Convert(value);
            return $"{result:F2}";
        }

        public override List<string> GetUnits()
        {
            return new List<string> { "Кельвін", "Цельсій" };
        }
    }
    public class KelvinToKelvinConverter : UnitConverter
    {
        public override double Convert(double value)
        {
            return (value);
        }

        public override string GetConversionResult(double value)
        {
            double result = Convert(value);
            return $"{result:F2}";
        }

        public override List<string> GetUnits()
        {
            return new List<string> { "Кельвін", "Кельвін" };
        }
    }
}
