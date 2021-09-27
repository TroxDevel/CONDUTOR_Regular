using CONDUTOR_Regular.ViewModels;
using CONDUTOR_Regular.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace CONDUTOR_Regular
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NovoUserPage), typeof(NovoUserPage));
        }

    }
}
