using System.Collections.Generic;
using System.Windows;

namespace FamilieLists.Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<string> familieleden = new List<string>()
       {
           "Jan|Mijne Man",
           "Jeanien|Mijn Trien",
           "Sid|Mijn kid"
       };
        public MainWindow()
        {
            InitializeComponent();
        }


        private void txtVoornaam_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            string voornaam = txtVoornaam.Text;
        }

        private void txtAchternaam_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {

        }
    }
}
