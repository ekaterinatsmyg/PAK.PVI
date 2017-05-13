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
using Bsuir.PAK.PVI.DataServices.Interfaces;
using Bsuir.PAK.PVI.DataServices.Services;
using Ninject;

namespace Bsuir.PAK.PVI
{
    /// <summary>
    /// Interaction logic for StudentAuthorization.xaml
    /// </summary>
    public partial class StudentAuthorization : Window
    {
        private AuthorizationWindow _authorizationWindow;
        private ChoosingExperiment _choosingExperiment;
        private readonly IExperimentService _experimentService;
        private readonly IKernel _kernel;

        public StudentAuthorization()
        {
            InitializeComponent();
            _kernel = new StandardKernel();
            _experimentService = _kernel.Get<ExperimentService>();
        }

        private void _choosingExperimentButton_Click(object sender, RoutedEventArgs e)
        {
            _choosingExperiment = new ChoosingExperiment(/*_experimentService*/);
            _choosingExperiment.Show();
            this.Close();

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
