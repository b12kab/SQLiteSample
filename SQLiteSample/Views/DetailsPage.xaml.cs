using System;
using System.Collections.Generic;
using SQLiteSample.ViewModels;
using Xamarin.Forms;

namespace SQLiteSample.Views
{
    public partial class DetailsPage : ContentPage
    {
        public DetailsPage(int contactID)
        {
            InitializeComponent();
            this.BindingContext = new DetailsViewModel(Navigation, contactID);  
        }
    }
}
