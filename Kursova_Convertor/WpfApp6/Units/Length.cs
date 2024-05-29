using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp6
{
    public class MmToCmConverter : UnitConverter
    {
        private const double conversionFactor = 0.1;

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
            return new List<string> { "Міліметри", "Сантиметри" };
        }
    }

    public class MmToMConverter : UnitConverter
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
            return new List<string> { "Міліметри", "Метри" };
        }
    }
    public class MmToMmConverter : UnitConverter
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
            return new List<string> { "Міліметри", "Міліметри" };
        }
    }

    public class CmToMmConverter : UnitConverter
    {
        private const double conversionFactor = 10;

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
            return new List<string> { "Сантиметри", "Міліметри" };
        }
    }

    public class CmToMConverter : UnitConverter
    {
        private const double conversionFactor = 0.01;

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
            return new List<string> { "Сантиметри", "Метри" };
        }
    }
    public class CmToCmConverter : UnitConverter
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
            return new List<string> { "Сантиметри", "Сантиметри" };
        }
    }
    public class MToCmConverter : UnitConverter
    {
        private const double conversionFactor = 100;

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
            return new List<string> { "Метри", "Сантиметри" };
        }
    }

    public class MToMmConverter : UnitConverter
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
            return new List<string> { "Метри", "Міліметри" };
        }
    }
    public class MToMConverter : UnitConverter
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
            return new List<string> { "Метри", "Метри" };
        }
    }
    public class KmToMConverter : UnitConverter
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
            return new List<string> { "Кілометри", "Метри" };
        }
    }

    public class KmToCmConverter : UnitConverter
    {
        private const double conversionFactor = 100000;

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
            return new List<string> { "Кілометри", "Сантиметри" };
        }
    }

    public class KmToMmConverter : UnitConverter
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
            return new List<string> { "Кілометри", "Міліметри" };
        }
    }
    public class KmToKmConverter : UnitConverter
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
            return new List<string> { "Кілометри", "Кілометри" };
        }
    }
    public class MmToKmConverter : UnitConverter
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
            return new List<string> { "Міліметри", "Кілометри" };
        }
    }

    public class CmToKmConverter : UnitConverter
    {
        private const double conversionFactor = 0.00001;

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
            return new List<string> { "Сантиметри", "Кілометри" };
        }
    }

    public class MToKmConverter : UnitConverter
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
            return new List<string> { "Метри", "Кілометри" };
        }
    }
    public class InchToMmConverter : UnitConverter
    {
        private const double conversionFactor = 25.4;

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
            return new List<string> { "Дюйми", "Міліметри" };
        }
    }

    public class InchToCmConverter : UnitConverter
    {
        private const double conversionFactor = 2.54;

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
            return new List<string> { "Дюйми", "Сантиметри" };
        }
    }

    public class InchToMConverter : UnitConverter
    {
        private const double conversionFactor = 0.0254;

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
            return new List<string> { "Дюйми", "Метри" };
        }
    }

    public class InchToKmConverter : UnitConverter
    {
        private const double conversionFactor = 0.0000254;

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
            return new List<string> { "Дюйми", "Кілометри" };
        }
    }
    public class InchToInchConverter : UnitConverter
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
            return new List<string> { "Дюйми", "Дюйми" };
        }
    }
    public class MmToInchConverter : UnitConverter
    {
        private const double conversionFactor = 0.0393701;

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
            return new List<string> { "Міліметри", "Дюйми" };
        }
    }

    public class CmToInchConverter : UnitConverter
    {
        private const double conversionFactor = 0.393701;

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
            return new List<string> { "Сантиметри", "Дюйми" };
        }
    }

    public class MToInchConverter : UnitConverter
    {
        private const double conversionFactor = 39.3701;

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
            return new List<string> { "Метри", "Дюйми" };
        }
    }

    public class KmToInchConverter : UnitConverter
    {
        private const double conversionFactor = 39370.1;

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
            return new List<string> { "Кілометри", "Дюйми" };
        }
    }
    public class MmToFtConverter : UnitConverter
    {
        private const double conversionFactor = 0.00328084;

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
            return new List<string> { "Міліметри", "Фути" };
        }
    }

    public class CmToFtConverter : UnitConverter
    {
        private const double conversionFactor = 0.0328084;

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
            return new List<string> { "Сантиметри", "Фути" };
        }
    }

    public class MToFtConverter : UnitConverter
    {
        private const double conversionFactor = 3.28084;

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
            return new List<string> { "Метри", "Фути" };
        }
    }

    public class KmToFtConverter : UnitConverter
    {
        private const double conversionFactor = 3280.84;

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
            return new List<string> { "Кілометри", "Фути" };
        }
    }

    public class InchToFtConverter : UnitConverter
    {
        private const double conversionFactor = 0.0833333;

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
            return new List<string> { "Дюйми", "Фути" };
        }
    }
    public class FtToFtConverter : UnitConverter
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
            return new List<string> { "Фути", "Фути" };
        }
    }
    public class FtToMmConverter : UnitConverter
    {
        private const double conversionFactor = 304.8;

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
            return new List<string> { "Фути", "Міліметри" };
        }
    }

    public class FtToCmConverter : UnitConverter
    {
        private const double conversionFactor = 30.48;

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
            return new List<string> { "Фути", "Сантиметри" };
        }
    }

    public class FtToMConverter : UnitConverter
    {
        private const double conversionFactor = 0.3048;

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
            return new List<string> { "Фути", "Метри" };
        }
    }

    public class FtToKmConverter : UnitConverter
    {
        private const double conversionFactor = 0.0003048;

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
            return new List<string> { "Фути", "Кілометри" };
        }
    }

    public class FtToInchConverter : UnitConverter
    {
        private const double conversionFactor = 12;

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
            return new List<string> { "Фути", "Дюйми" };
        }
    }
}
