using System.Windows;
using WordWide.UI.ViewModel;

namespace WordWide
{
    public partial class MainWindow : Window
    {
        private WordViewModel viewModel;

        public MainWindow(WordViewModel viewModel)
        {
            InitializeComponent();
            this.viewModel = viewModel;
            DataContext = this.viewModel;
            //TO DO Loaded
            Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            this.viewModel.Load();
        }
    }
}
