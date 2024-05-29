using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp6
{
    public abstract class UnitConverter
    {
        public abstract double Convert(double value);

        public abstract string GetConversionResult(double value);

        public abstract List<string> GetUnits();
    }
}
