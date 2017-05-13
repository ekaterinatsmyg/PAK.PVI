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
    /// Interaction logic for AuthorizationWindow.xaml
    /// </summary>
    public partial class AuthorizationWindow : Window
    {
        private StudentAuthorization _studentAuthorizationWindow;
        private TeacherAuthorization _teacherAuthorizationWindow;

        public AuthorizationWindow()
        {
            InitializeComponent();
        }

        private void _choosingExperimentButton_Click(object sender, RoutedEventArgs e)
        {
            if (_student.IsChecked != null && _student.IsChecked.Value)
            {
                _studentAuthorizationWindow = new StudentAuthorization();
                _studentAuthorizationWindow.Show();
            }
            else
            {
                _teacherAuthorizationWindow = new TeacherAuthorization();
                _teacherAuthorizationWindow.Show();
            }
            this.Close();
        }
    }
}
