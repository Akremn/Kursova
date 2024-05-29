using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp6
{
    public class DegreesToRadiansConverter : UnitConverter
    {
        private const double ConversionFactor = Math.PI / 180;

        public override double Convert(double value)
        {
            return value * ConversionFactor;
        }

        public override string GetConversionResult(double value)
        {
            double result = Convert(value);
            return $"{result:F2}";
        }

        public override List<string> GetUnits()
        {
            return new List<string> { "Градуси", "Радіани" };
        }
    }
    public class RadiansToDegreesConverter : UnitConverter
    {
        private const double ConversionFactor = 180 / Math.PI;

        public override double Convert(double value)
        {
            return value * ConversionFactor;
        }

        public override string GetConversionResult(double value)
        {
            double result = Convert(value);
            return $"{result:F2}";
        }

        public override List<string> GetUnits()
        {
            return new List<string> { "Радіани", "Градуси" };
        }
    }
    public class DegreesToGradiansConverter : UnitConverter
    {
        private const double ConversionFactor = 200.0 / 180.0;
        public override double Convert(double value)
        {
            return value * ConversionFactor;
        }

        public override string GetConversionResult(double value)
        {
            double result = Convert(value);
            return $"{result:F2}";
        }

        public override List<string> GetUnits()
        {
            return new List<string> { "Градуси", "Гради" };
        }
    }
    public class DegreesToDegreesConverter : UnitConverter
    {
        private const double ConversionFactor = 1.0;

        public override double Convert(double value)
        {
            return value * ConversionFactor;
        }

        public override string GetConversionResult(double value)
        {
            double result = Convert(value);
            return $"{result:F2}";
        }

        public override List<string> GetUnits()
        {
            return new List<string> { "Градуси", "Градуси" };
        }
    }
    public class GradiansToDegreesConverter : UnitConverter
    {
        private const double ConversionFactor = 180.0 / 200.0;

        public override double Convert(double value)
        {
            return value * ConversionFactor;
        }

        public override string GetConversionResult(double value)
        {
            double result = Convert(value);
            return $"{result:F2}";
        }

        public override List<string> GetUnits()
        {
            return new List<string> { "Гради", "Градуси" };
        }
    }
    public class RadiansToGradiansConverter : UnitConverter
    {
        private const double ConversionFactor = 200.0 / Math.PI;

        public override double Convert(double value)
        {
            return value * ConversionFactor;
        }

        public override string GetConversionResult(double value)
        {
            double result = Convert(value);
            return $"{result:F2}";
        }

        public override List<string> GetUnits()
        {
            return new List<string> { "Радіани", "Гради" };
        }
    }
    public class RadiansToRadiansConverter : UnitConverter
    {
        private const double ConversionFactor = 1.0;

        public override double Convert(double value)
        {
            return value * ConversionFactor;
        }

        public override string GetConversionResult(double value)
        {
            double result = Convert(value);
            return $"{result:F2}";
        }

        public override List<string> GetUnits()
        {
            return new List<string> { "Радіани", "Радіани" };
        }
    }
    public class GradiansToRadiansConverter : UnitConverter
    {
        private const double ConversionFactor = Math.PI / 200.0;

        public override double Convert(double value)
        {
            return value * ConversionFactor;
        }

        public override string GetConversionResult(double value)
        {
            double result = Convert(value);
            return $"{result:F2}";
        }

        public override List<string> GetUnits()
        {
            return new List<string> { "Гради", "Радіани" };
        }
    }
    public class GradiansToGradiansConverter : UnitConverter
    {
        // Приватне поле для демонстрації інкапсуляції
        private const double ConversionFactor = 1.0;

        public override double Convert(double value)
        {
            return value * ConversionFactor;
        }

        public override string GetConversionResult(double value)
        {
            double result = Convert(value);
            return $"{result:F2}";
        }

        public override List<string> GetUnits()
        {
            return new List<string> { "Гради", "Гради" };
        }
    }
}
