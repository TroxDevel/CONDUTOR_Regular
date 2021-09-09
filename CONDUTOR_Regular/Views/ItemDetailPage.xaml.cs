using CONDUTOR_Regular.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace CONDUTOR_Regular.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}