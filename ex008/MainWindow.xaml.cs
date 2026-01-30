using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ex008
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponet();
        
            }

        private void btnSorteio_Click(object sender, RoutedEventArgs e)
        {
            int ini, fim;
            int.TryParse(txtIni.Text, out ini);
            int.TryParse(txtFim.Text, out fim);
            
            
            Random gerador = new Random();
            int num = gerador.Next(ini, fim + 1);

            lblSorteio.Content = $"Sorteei o valor {num}";

        }
    }
}