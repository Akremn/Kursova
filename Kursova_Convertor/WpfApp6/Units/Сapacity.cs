using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp6
{
    public class MlToCm3Converter : UnitConverter
    {
        private const double conversionFactor = 0.001;

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
            return new List<string> { "Мілілітри", "Кубічні сантиметри" };
        }
    }

    public class Cm3ToMlConverter : UnitConverter
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
            return new List<string> { "Кубічні сантиметри", "Мілілітри" };
        }
    }
    public class Cm3ToCm3Converter : UnitConverter
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
            return new List<string> { "Кубічні сантиметри", "Кубічні сантиметри" };
        }
    }
    public class MlToMlConverter : UnitConverter
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
            return new List<string> { "Мілілітри", "Мілілітри" };
        }
    }
    public class LToMlConverter : UnitConverter
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
            return new List<string> { "Літри", "Мілілітри" };
        }
    }

    public class LToCm3Converter : UnitConverter
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
            return new List<string> { "Літри", "Кубічні сантиметри" };
        }
    }

    public class MlToLConverter : UnitConverter
    {
        private const double conversionFactor = 0.001;

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
            return new List<string> { "Мілілітри", "Літри" };
        }
    }

    public class Cm3ToLConverter : UnitConverter
    {
        private const double conversionFactor = 0.001;

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
            return new List<string> { "Кубічні сантиметри", "Літри" };
        }
    }
    public class LToLConverter : UnitConverter
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
            return new List<string> { "Літри", "Літри" };
        }
    }
    public class M3ToLConverter : UnitConverter
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
            return new List<string> { "Кубічні метри", "Літри" };
        }
    }
    public class M3ToM3Converter : UnitConverter
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
            return new List<string> { "Кубічні метри", "Кубічні метри" };
        }
    }
    public class M3ToCm3Converter : UnitConverter
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
            return new List<string> { "Кубічні метри", "Кубічні сантиметри" };
        }
    }

    public class LToM3Converter : UnitConverter
    {
        private const double conversionFactor = 0.001;

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
            return new List<string> { "Літри", "Кубічні метри" };
        }
    }

    public class Cm3ToM3Converter : UnitConverter
    {
        private const double conversionFactor = 0.0000001;

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
            return new List<string> { "Кубічні сантиметри", "Кубічні метри" };
        }
    }
    public class MlToM3Converter : UnitConverter
    {
        private const double conversionFactor = 0.000001;

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
            return new List<string> { "Мілілітри", "Кубічні метри" };
        }
    }
    
    public class M3ToMlConverter : UnitConverter
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
            return new List<string> { "Кубічні метри", "Мілілітри" };
        }
    }

}
