using System.Windows.Controls;
using KMA.ProgrammingInCSharp.Lab2.Managers;
using KMA.ProgrammingInCSharp.Lab2.Tools;
using KMA.ProgrammingInCSharp.Lab2.ViewModels;
using System.Windows;

namespace KMA.ProgrammingInCSharp.Lab2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            var navigationModel = new NavigationModel(this);
            NavigationManager.Instance.Initialize(navigationModel);
            MainWindowViewModel mainWindowViewModel = new MainWindowViewModel();
            DataContext = mainWindowViewModel;
            mainWindowViewModel.StartApplication();
        }
    }
}
