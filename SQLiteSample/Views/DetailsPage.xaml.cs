using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.PlatformConfiguration;
using Microsoft.Maui.Controls.PlatformConfiguration.iOSSpecific;
using Microsoft.Maui.Controls.Xaml;

using SQLiteSample.ViewModels;

using System;
using System.Collections.Generic;

namespace SQLiteSample.Views
{
    public partial class DetailsPage : ContentPage
    {
        public DetailsPage(int contactID)
        {
            InitializeComponent();
            On<iOS>().SetUseSafeArea(true);
            this.BindingContext = new DetailsViewModel(Navigation, contactID);  
        }
    }
}
