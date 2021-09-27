using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CONDUTOR_Regular.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class IncluirAutoPage : ContentPage
    {
        public IncluirAutoPage()
        {
            InitializeComponent();
        }
        async void OnNextPageButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AboutPage());
        }
    }
}