using System;
using SQLiteSample.Services;
using SQLiteSample.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace SQLiteSample
{
    public partial class App : Application
    {
        IContactRepository _contactRepository;
        public App()
        {
            InitializeComponent();

            _contactRepository = new ContactRepository();
            OnAppStart();
        }

        public void OnAppStart()
        {
            var getLocalDB = _contactRepository.GetAllContactsData();

            //if (getLocalDB.Count > 0)
            //{
                MainPage = new NavigationPage(new ContactList());
            //}
            //else
            //{
            //    MainPage = new NavigationPage(new AddContact());
            //}

        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}