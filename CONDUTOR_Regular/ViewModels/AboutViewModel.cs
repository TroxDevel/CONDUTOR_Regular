using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace CONDUTOR_Regular.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "Início";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("http://www.transalvador.salvador.ba.gov.br/"));
        }

        public ICommand OpenWebCommand { get; }
    }
}