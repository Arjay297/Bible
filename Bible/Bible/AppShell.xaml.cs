using Bible.ViewModels;
using Bible.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Bible
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(InfoPage), typeof(InfoPage));
            Routing.RegisterRoute(nameof(PastorInfoPage), typeof(PastorInfoPage));
        }

    }
}
