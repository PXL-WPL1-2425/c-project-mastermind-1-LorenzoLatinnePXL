using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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

namespace MasterMind
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // Variables
        StringBuilder sb = new StringBuilder();
        Random rnd = new Random();
        string color1, color2, color3, color4;
        string[] solution;
        string[] options = { "Red", "Yellow", "Orange", "White", "Green", "Blue" };

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            // Set current Title in the StringBuilder.
            sb.Append(this.Title);

            // Randomize colors.
            color1 = GenerateRandomColor();
            color2 = GenerateRandomColor();
            color3 = GenerateRandomColor();
            color4 = GenerateRandomColor();
            solution = new string[] { color1, color2, color3, color4 };

            // Set randomized colors in the StringBuilder.
            sb.Append($" {color1}, {color2}, {color3}, {color4}");

            // Change Title to data from the StringBuilder.
            this.Title = sb.ToString();

            // Generate 6 available colors for each ComboBox (from the options array variable)
            AddComboBoxItems(ComboBoxOption1);
            AddComboBoxItems(ComboBoxOption2);
            AddComboBoxItems(ComboBoxOption3);
            AddComboBoxItems(ComboBoxOption4);

        }

        private string GenerateRandomColor()
        {
            int randomColor = rnd.Next(0, 6);

            switch (randomColor)
            {
                case 0:
                    return options[0];

                case 1:
                    return options[1];

                case 2:
                    return options[2];

                case 3:
                    return options[3];

                case 4:
                    return options[4];

                case 5:
                    return options[5];

                default:
                    return "Color choice out of range.";
            }
        }

        private ComboBox AddComboBoxItems(ComboBox ComboBox)
        {
            for (int i = 0; i < options.Length; i++)
            {
                ComboBox.Items.Add(options[i]);
            }
            return ComboBox;
        }
    }
}
