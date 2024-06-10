using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Project1
{
    public class MauiPage1ViewModel : ViewModel
    {
        public MauiPage1ViewModel(BaseServices services)
            : base(services) { }

        public ICommand NavigateCommand => new Command(() => OnNavigateAsync());

        private async Task OnNavigateAsync()
        {
            await Navigation.NavigateAsync("MauiPage2");
        }
    }
}
