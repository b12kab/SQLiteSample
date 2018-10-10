using System;
using System.Collections.Generic;
using SQLiteSample.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;

namespace SQLiteSample.Views
{
    public partial class ContactList : ContentPage
    {
        public ContactList()
        {
            InitializeComponent();
            On<Xamarin.Forms.PlatformConfiguration.iOS>().SetUseSafeArea(true);
        }

        protected override void OnAppearing() {  
            this.BindingContext = new ContactListViewModel(Navigation);  
        }  
    }
}
