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


namespace Bsuir.PAK.PVI
{
    /// <summary>
    /// Interaction logic for ChoosingExperiment.xaml
    /// </summary>
    public partial class ChoosingExperiment : Window
    {
        private readonly IExperimentService _experimentService;

        public ChoosingExperiment(/*IExperimentService experimentService*/)
        {
            //_experimentService = experimentService;
            InitializeComponent();
        }

        private void OnExperimentsListLoaded(object sender, RoutedEventArgs e)
        {
            //var experiments =  _experimentService.GetAllExperiments().Select(experiment => experiment.ExperimentName);
            //_experimentsList.ItemsSource = experiments;
            //_experimentsList.SelectedItem = _experimentsList.Items[0];
        }

        private void OnSelectionTestButtonClick(object sender, RoutedEventArgs e)
        {

        }
    }
}
