using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.PlatformConfiguration;
using Microsoft.Maui.Controls.PlatformConfiguration.iOSSpecific;
using Microsoft.Maui.Controls.Xaml;
using System;
using System.Collections.Generic;
using SQLiteSample.ViewModels;
//using Xamarin.Forms;
//using Xamarin.Forms.PlatformConfiguration.iOSSpecific;

namespace SQLiteSample.Views
{
    public partial class ContactList : ContentPage
    {
        public ContactList()
        {
            InitializeComponent();
            On<iOS>().SetUseSafeArea(true);
        }

        protected override void OnAppearing() {  
            this.BindingContext = new ContactListViewModel(Navigation);  
        }  
    }
}
