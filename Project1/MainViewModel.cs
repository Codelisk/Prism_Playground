using System.Windows.Input;

namespace Project1
{
    public class MainViewModel : ViewModel
    {
        public MainViewModel(BaseServices services)
            : base(services) { }

        [Reactive]
        public string Property { get; set; }

        public ICommand NavigateCommand => new Command(() => OnNavigateAsync());

        private async Task OnNavigateAsync()
        {
            await Navigation.NavigateAsync("MauiPage1");
        }
    }
}
