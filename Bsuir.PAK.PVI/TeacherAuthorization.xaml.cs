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
using System.Windows.Shapes;

namespace Bsuir.PAK.PVI
{
    /// <summary>
    /// Interaction logic for TeacherAuthorization.xaml
    /// </summary>
    public partial class TeacherAuthorization : Window
    {
        private AuthorizationWindow _authorizationWindow;
        public TeacherAuthorization()
        {
            InitializeComponent();
        }

        private void _backToUserSelectionButton_Click(object sender, RoutedEventArgs e)
        {
            _authorizationWindow = new AuthorizationWindow();
            _authorizationWindow.Show();
            this.Close();
        }

        private void OnSelectionTestButtonClick(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
