using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Dictionary<string, List<UnitConverter>> converters;
        private UnitConverter currentConverter;
        public MainWindow()
        {
            InitializeComponent();
            InitializeConverters();
        }
        private void InitializeConverters()
        {
            converters = new Dictionary<string, List<UnitConverter>>
            {
                {
                    "Вага", new List<UnitConverter>
                    {

                        new KgToLbsConverter(),
                        new KgToGConverter(),
                        new KgToMgConverter(),
                        new KgToKgConverter(),
                        new LbsToLbsConverter(),
                        new LbsToKgConverter(),
                        new LbsToGConverter(),
                        new LbsToMgConverter(),
                        new GToKgConverter(),
                        new GToMgConverter(),
                        new GToLbsConverter(),
                        new GToGConverter(),
                        new MgToKgConverter(),
                        new MgToGConverter(),
                        new MgToLbsConverter(),
                        new MgToMgConverter(),
                    }
                },
                {
                    "Кут", new List<UnitConverter>
                    {
                        new DegreesToRadiansConverter(),
                        new DegreesToGradiansConverter(),
                        new DegreesToDegreesConverter(),
                        new RadiansToDegreesConverter(),
                        new RadiansToGradiansConverter(),
                        new RadiansToRadiansConverter(),
                        new GradiansToDegreesConverter(),
                        new GradiansToRadiansConverter(),
                        new GradiansToGradiansConverter(),
                    }
                },
                {
                    "Об'єм", new List<UnitConverter>
                    {
                        new MlToCm3Converter(),
                        new MlToM3Converter(),
                        new MlToLConverter(),
                        new MlToMlConverter(),
                        new Cm3ToMlConverter(),
                        new Cm3ToM3Converter(),
                        new Cm3ToLConverter(),
                        new Cm3ToCm3Converter(),
                        new LToMlConverter(),
                        new LToCm3Converter(),
                        new LToM3Converter(),
                        new LToLConverter(),
                        new M3ToLConverter(),
                        new M3ToCm3Converter(),
                        new M3ToM3Converter(),
                        new M3ToMlConverter()
                    }
                },
                {
                    "Довжина", new List<UnitConverter>
                    {
                        new MmToCmConverter(),
                        new MmToMConverter(),
                        new MmToKmConverter(),
                        new MmToInchConverter(),
                        new MmToFtConverter(),
                        new MmToMmConverter(),
                        
                        new CmToMmConverter(),
                        new CmToMConverter(),
                        new CmToKmConverter(),
                        new CmToInchConverter(),
                        new CmToFtConverter(),
                        new CmToCmConverter(),
                        
                        new MToMmConverter(),
                        new MToCmConverter(),
                        new MToKmConverter(),
                        new MToInchConverter(),
                        new MToFtConverter(),
                        new MToMConverter(),
                        
                        new KmToMmConverter(),
                        new KmToCmConverter(),
                        new KmToMConverter(),
                        new KmToInchConverter(),
                        new KmToFtConverter(),
                        new KmToKmConverter(),
                        
                        new InchToMmConverter(),
                        new InchToCmConverter(),
                        new InchToMConverter(),
                        new InchToKmConverter(),
                        new InchToFtConverter(),
                        new InchToInchConverter(),
                        
                        new FtToMmConverter(),
                        new FtToCmConverter(),
                        new FtToMConverter(),
                        new FtToKmConverter(),
                        new FtToInchConverter(),
                        new FtToFtConverter(),
                    }
                },
                {
                    "Температура", new List<UnitConverter>
                    {
                        new CelsiusToFahrenheitConverter(),
                        new CelsiusToKelvinConverter(),
                        new CelsiusToCelsiusConverter(),
                        new FahrenheitToFahrenheitConverter(),
                        new FahrenheitToKelvinConverter(),
                        new FahrenheitToCelsiusConverter(),
                        new KelvinToKelvinConverter(),
                        new KelvinToCelsiusConverter(),
                        new KelvinToFahrenheitConverter()
                    }
                }
            };

            comboBoxCategory.ItemsSource = converters.Keys;
        }
        // Обробка події вибору категорії конвертера в комбінованому списку
        private void ComboBoxCategory_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Отримання вибраної категорії з комбінованого списку
            string selectedCategory = comboBoxCategory.SelectedItem.ToString();

            // Перевірка, чи існують конвертери для вибраної категорії
            if (converters.TryGetValue(selectedCategory, out List<UnitConverter> selectedConverters))
            {
                // Встановлення джерела даних для комбінованих списків вибору вхідних і вихідних одиниць
                comboBoxFrom.ItemsSource = selectedConverters.SelectMany(c => c.GetUnits()).Distinct().ToArray();
                comboBoxTo.ItemsSource = selectedConverters.SelectMany(c => c.GetUnits()).Distinct().ToArray();
            }
        }

        private void comboBoxFrom_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ConvertUnits();
        }

        private void comboBoxTo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ConvertUnits();
        }

        private void TextBoxInput_TextChanged(object sender, TextChangedEventArgs e)
        {
            ConvertUnits();
        }

        private void textBoxOutput_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void ConvertUnits()
        {
            if (comboBoxCategory.SelectedItem != null && comboBoxFrom.SelectedItem != null && comboBoxTo.SelectedItem != null && double.TryParse(textBoxInput.Text, out double value))
            {
                string selectedCategory = comboBoxCategory.SelectedItem.ToString();
                string unitFrom = comboBoxFrom.SelectedItem.ToString();
                string unitTo = comboBoxTo.SelectedItem.ToString();

                if (converters.TryGetValue(selectedCategory, out List<UnitConverter> selectedConverters))
                {
                    // Знаходимо поточний конвертер
                    currentConverter = selectedConverters
                       .FirstOrDefault(c => c.GetUnits().First() == unitFrom && c.GetUnits().Last() == unitTo);

                    if (currentConverter != null)
                    {
                        // Конвертуємо значення з використанням поточного конвертера тільки один раз

                        double convertedValue = currentConverter.Convert(value);
                        textBoxOutput.Text = convertedValue.ToString();
                        string convertedValue1 = currentConverter.GetConversionResult(convertedValue);
                        return;
                    }
                }
            }

            // Якщо щось пішло не так або конвертер не знайдено, очистимо вихідне поле
            textBoxOutput.Text = "";
        }
    }
}
