﻿using FluentValidation;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Xaml;
using SQLiteSample.Helpers;
using SQLiteSample.Models;
using SQLiteSample.Services;
using SQLiteSample.Validator;
using SQLiteSample.Views;
using Splat;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SQLiteSample.ViewModels
{
    public class AddContactViewModel : BaseContactViewModel
    {
        public ICommand AddContactCommand { get; private set; }

        public AddContactViewModel(INavigation navigation)
        {
            _navigation = navigation;
            _contactValidator = new ContactValidator();
            _contact = new ContactInfo();
            //_contactRepository = DependencyService.Get<IContactRepository>();
            _contactRepository = Locator.Current.GetService<ContactRepository>();

            AddContactCommand = new Command(async () => await AddContact());
        }

        async Task AddContact()
        {
            var context = new ValidationContext<ContactInfo>(_contact);
            var validationResults = _contactValidator.Validate(context);

            if (validationResults.IsValid)
            {
                bool isUserAccept = await Application.Current.MainPage.DisplayAlert("Add Contact", "Do you want to save Contact details?", "OK", "Cancel");
                if (isUserAccept)
                {
                    int rowsAdded = _contactRepository.InsertContact(_contact);
                    await _navigation.PopAsync();
                }
            }
            else
            {
                await Application.Current.MainPage.DisplayAlert("Add Contact", validationResults.Errors[0].ErrorMessage, "Ok");
            }
        }

        async Task ShowContactList()
        {
            await _navigation.PushAsync(new ContactList());
        }

        public bool IsViewAll => _contactRepository.GetAllContactsData().Count > 0 ? true : false;
    }
}