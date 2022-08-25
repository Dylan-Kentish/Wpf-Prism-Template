using Prism.Mvvm;

namespace WpfApp.Module1.ViewModels
{
    public class MainViewVM : BindableBase
    {
        private string _message;

        public MainViewVM()
        {
            Message = "I am the Main View from Module 1.";
        }

        public string Message
        {
            get => _message;
            set => SetProperty(ref _message, value);
        }
    }
}
