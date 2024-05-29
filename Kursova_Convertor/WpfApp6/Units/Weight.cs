using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp6
{
    public class KgToLbsConverter : UnitConverter
    {
        private const double conversionFactor = 2.20462;

        public override double Convert(double value)
        {
            return value * conversionFactor;
        }

        public override string GetConversionResult(double value)
        {
            double result = Convert(value);
            return $"{result:F2}";
        }

        public override List<string> GetUnits()
        {
            return new List<string> { "Кілограмів", "Фунтів" };
        }
    }
    public class KgToKgConverter : UnitConverter
    {
        public override double Convert(double value)
        {
            return value;
        }

        public override string GetConversionResult(double value)
        {
            double result = Convert(value);
            return $"{result:F2}";
        }

        public override List<string> GetUnits()
        {
            return new List<string> { "Кілограмів", "Кілограмів" };
        }
    }
    public class LbsToKgConverter : UnitConverter
    {
        private const double conversionFactor = 2.20462;

        public override double Convert(double value)
        {
            return value / conversionFactor;
        }

        public override string GetConversionResult(double value)
        {
            double result = Convert(value);
            return $"{result:F2}";
        }

        public override List<string> GetUnits()
        {
            return new List<string> { "Фунтів", "Кілограмів" };
        }
    }
    public class LbsToLbsConverter : UnitConverter
    {
        public override double Convert(double value)
        {
            return value;
        }

        public override string GetConversionResult(double value)
        {
            double result = Convert(value);
            return $"{result:F2}";
        }

        public override List<string> GetUnits()
        {
            return new List<string> { "Фунтів", "Фунтів" };
        }
    }
    public class KgToGConverter : UnitConverter
    {
        private const double conversionFactor = 1000;

        public override double Convert(double value)
        {
            return value * conversionFactor;
        }

        public override string GetConversionResult(double value)
        {
            double result = Convert(value);
            return $"{result:F2}";
        }

        public override List<string> GetUnits()
        {
            return new List<string> { "Кілограмів", "Грамів" };
        }
    }

    public class GToKgConverter : UnitConverter
    {
        private const double conversionFactor = 1000;

        public override double Convert(double value)
        {
            return value / conversionFactor;
        }

        public override string GetConversionResult(double value)
        {
            double result = Convert(value);
            return $"{result:F2}";
        }

        public override List<string> GetUnits()
        {
            return new List<string> { "Грамів", "Кілограмів" };
        }
    }
    public class GToGConverter : UnitConverter
    {
        public override double Convert(double value)
        {
            return value; // 1 г 
        }

        public override string GetConversionResult(double value)
        {
            double result = Convert(value);
            return $"{result:F2}";
        }

        public override List<string> GetUnits()
        {
            return new List<string> { "Грамів", "Грамів" };
        }
    }

    public class KgToMgConverter : UnitConverter
    {
        private const double conversionFactor = 1000000;

        public override double Convert(double value)
        {
            return value * conversionFactor;
        }

        public override string GetConversionResult(double value)
        {
            double result = Convert(value);
            return $"{result:F2}";
        }

        public override List<string> GetUnits()
        {
            return new List<string> { "Кілограмів", "Міліграмів" };
        }
    }

    public class MgToKgConverter : UnitConverter
    {
        private const double conversionFactor = 1000000;

        public override double Convert(double value)
        {
            return value / conversionFactor;
        }

        public override string GetConversionResult(double value)
        {
            double result = Convert(value);
            return $"{result:F2}";
        }

        public override List<string> GetUnits()
        {
            return new List<string> { "Міліграмів", "Кілограмів" };
        }
    }
    public class MgToMgConverter : UnitConverter
    {
        public override double Convert(double value)
        {
            return value; // 1 мг
        }

        public override string GetConversionResult(double value)
        {
            double result = Convert(value);
            return $"{result:F2}";
        }

        public override List<string> GetUnits()
        {
            return new List<string> { "Міліграмів", "Міліграмів" };
        }
    }

    public class GToMgConverter : UnitConverter
    {
        private const double conversionFactor = 1000;

        public override double Convert(double value)
        {
            return value * conversionFactor;
        }

        public override string GetConversionResult(double value)
        {
            double result = Convert(value);
            return $"{result:F2}";
        }

        public override List<string> GetUnits()
        {
            return new List<string> { "Грамів", "Міліграмів" };
        }
    }

    public class MgToGConverter : UnitConverter
    {
        private const double conversionFactor = 1000;

        public override double Convert(double value)
        {
            return value / conversionFactor;
        }

        public override string GetConversionResult(double value)
        {
            double result = Convert(value);
            return $"{result:F2}";
        }

        public override List<string> GetUnits()
        {
            return new List<string> { "Міліграмів", "Грамів" };
        }
    }
    public class LbsToGConverter : UnitConverter
    {
        private const double conversionFactor = 453.592;

        public override double Convert(double value)
        {
            return value * conversionFactor;
        }

        public override string GetConversionResult(double value)
        {
            double result = Convert(value);
            return $"{result:F2}";
        }

        public override List<string> GetUnits()
        {
            return new List<string> { "Фунтів", "Грамів" };
        }
    }

    public class GToLbsConverter : UnitConverter
    {
        private const double conversionFactor = 453.592;

        public override double Convert(double value)
        {
            return value / conversionFactor;
        }

        public override string GetConversionResult(double value)
        {
            double result = Convert(value);
            return $"{result:F2}";
        }

        public override List<string> GetUnits()
        {
            return new List<string> { "Грамів", "Фунтів" };
        }
    }

    public class LbsToMgConverter : UnitConverter
    {
        private const double conversionFactor = 453592;

        public override double Convert(double value)
        {
            return value * conversionFactor;
        }

        public override string GetConversionResult(double value)
        {
            double result = Convert(value);
            return $"{result:F2}";
        }

        public override List<string> GetUnits()
        {
            return new List<string> { "Фунтів", "Міліграмів" };
        }
    }

    public class MgToLbsConverter : UnitConverter
    {
        private const double conversionFactor = 453592;

        public override double Convert(double value)
        {
            return value / conversionFactor;
        }

        public override string GetConversionResult(double value)
        {
            double result = Convert(value);
            return $"{result:F2}";
        }

        public override List<string> GetUnits()
        {
            return new List<string> { "Міліграмів", "Фунтів" };
        }
    }
}
