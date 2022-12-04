
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Xaml;

using System;
using System.Collections.Generic;
using SQLiteSample.ViewModels;

namespace SQLiteSample.Views
{
    public partial class AddContact : ContentPage
    {
        public AddContact()
        {
            InitializeComponent();
            BindingContext = new AddContactViewModel(Navigation);
        }
    }
}
