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

namespace WpfApp1
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void mainfield_TextChanged(object sender, TextChangedEventArgs e)
        {
            string str = mainfield.Text;

            string vowels = "уеыаоэяиёю";
            string consonants = "цкнгшщзхфвпрлджчсмтб";

            IEnumerable<int> counts = Enumerable.Range(0, 2)
                .Select((_, i) => (i & 1) == 0
                    ? str.Count(c => (vowels + vowels.ToUpper()).Contains(c))
                    : str.Count(c => (consonants + consonants.ToUpper()).Contains(c)));

            result1.Text = "Количество гласных: " + $"{counts.ElementAt(0)}";
            result2.Text = "Количество согласных: " + $"{counts.ElementAt(1)}";
        }
    }
}
