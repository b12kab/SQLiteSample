using System;
using System.Collections.Generic;
using SQLiteSample.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;

namespace SQLiteSample.Views
{
    public partial class DetailsPage : ContentPage
    {
        public DetailsPage(int contactID)
        {
            InitializeComponent();
            On<Xamarin.Forms.PlatformConfiguration.iOS>().SetUseSafeArea(true);
            this.BindingContext = new DetailsViewModel(Navigation, contactID);  
        }
    }
}
