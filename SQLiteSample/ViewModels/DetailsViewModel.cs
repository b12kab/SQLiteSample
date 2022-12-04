using FluentValidation;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.PlatformConfiguration;
using Microsoft.Maui.Controls.PlatformConfiguration.iOSSpecific;
using Microsoft.Maui.Controls.Xaml;
using Splat;
using SQLiteSample.Models;
using SQLiteSample.Services;
using SQLiteSample.Validator;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SQLiteSample.ViewModels
{
    public class DetailsViewModel : BaseContactViewModel
    {
        public ICommand UpdateContactCommand { get; private set; }
        public ICommand DeleteContactCommand { get; private set; }

        public DetailsViewModel(INavigation navigation, int selectedContactID)
        {
            _navigation = navigation;
            _contactValidator = new ContactValidator();
            _contact = new ContactInfo();
            _contact.Id = selectedContactID;
            //_contactRepository = DependencyService.Get<IContactRepository>();
            _contactRepository = Locator.Current.GetService<ContactRepository>();

            UpdateContactCommand = new Command(async () => await UpdateContact());
            DeleteContactCommand = new Command(async () => await DeleteContact());

            FetchContactDetails();
        }

        void FetchContactDetails()
        {
            _contact = _contactRepository.GetContactData(_contact.Id);
        }

        async Task UpdateContact()
        {
            var context = new ValidationContext<ContactInfo>(_contact);
            var validationResults = _contactValidator.Validate(context);

            if (validationResults.IsValid)
            {
                bool isUserAccept = await Microsoft.Maui.Controls.Application.Current.MainPage.DisplayAlert("Contact Details", "Update Contact Details", "OK", "Cancel");
                if (isUserAccept)
                {
                    _contactRepository.UpdateContact(_contact);
                    await _navigation.PopAsync();
                }
            }
            else
            {
                await Microsoft.Maui.Controls.Application.Current.MainPage.DisplayAlert("Add Contact", validationResults.Errors[0].ErrorMessage, "Ok");
            }
        }

        async Task DeleteContact()
        {
            bool isUserAccept = await Microsoft.Maui.Controls.Application.Current.MainPage.DisplayAlert("Contact Details", "Delete Contact Details", "OK", "Cancel");
            if (isUserAccept)
            {
                int rowsDeleted = _contactRepository.DeleteContact(_contact.Id);
                await _navigation.PopAsync();
            }
        }
    }
}
