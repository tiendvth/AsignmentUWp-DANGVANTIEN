using AsignmentDVT.Service;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace AsignmentDVT.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Profile : Page
    {
        private AccountService accountService = new AccountService();
        public Profile()
        {
            this.InitializeComponent();
            this.Loaded += ProfilePage_Loaded;
        }
        private async void ProfilePage_Loaded(object sender, RoutedEventArgs e)
        {
            var account = await accountService.GetInformationAsync();
            if (account == null)
            {
                ContentDialog contentDialog = new ContentDialog();
                contentDialog.Title = "Login required";
                contentDialog.Content = $"Please login to continue!";
                contentDialog.PrimaryButtonText = "Go it";
                await contentDialog.ShowAsync();
                Frame.Navigate(typeof(Pages.LoginForm));
            }
            else
            {
                Email.Text = account.email;
                FullName.Text = account.firstName + "" + account.lastName;
            }
        }

        private async void LogoutButton_Click(object sender, RoutedEventArgs e)
        {
            StorageFolder storageFolder = ApplicationData.Current.LocalFolder;
            StorageFile storageFile = await storageFolder.GetFileAsync("milt.txt");
            await storageFile.DeleteAsync();
            ContentDialog contentDialog = new ContentDialog();
            contentDialog.Title = "Success!.";
            contentDialog.Content = "logout Success!";
            contentDialog.PrimaryButtonText = "oke";
            await contentDialog.ShowAsync();
            this.Frame.Navigate(typeof(Pages.ListSong));

        }
    }
}
