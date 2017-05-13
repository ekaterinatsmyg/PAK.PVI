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
using Bsuir.PAK.PVI.DataServices.Interfaces;
using Bsuir.PAK.PVI.DataServices.Services;
using Ninject;

namespace Bsuir.PAK.PVI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Window1 _authorizationWindow;
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void layoutMain_nextButton_Click(object sender, RoutedEventArgs e)
        {
            _authorizationWindow = new Window1();
            _authorizationWindow.Show();
            this.Close();
        }
    }
}
