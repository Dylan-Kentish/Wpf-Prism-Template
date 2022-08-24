using System.Reflection;

namespace WpfApp.Shell
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public const string RegionName = "Root";
        public MainWindow()
        {
            DataContext = this;
            InitializeComponent();

            Title = "Wpf App";

            var version = Assembly.GetEntryAssembly()?.GetName().Version;

            if(version != null)
            {
                Title += $" v{version}";
            }
        }
    }
}
