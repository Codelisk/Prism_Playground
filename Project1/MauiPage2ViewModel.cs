using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    public class MauiPage2ViewModel : ViewModel
    {
        public MauiPage2ViewModel(BaseServices services)
            : base(services) { }

        public ICommand NavigateCommand => new Command(() => OnNavigateAsync());

        private async Task OnNavigateAsync()
        {
            await Navigation.GoBackAsync();
        }
    }
}
