using AsignmentDVT.Entities;
using AsignmentDVT.Service;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Media.Capture;
using Windows.Storage;
using Windows.Storage.Pickers;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace AsignmentDVT.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class RegisterForm : Page
    {
        private AccountService accountService = new AccountService();
        private FileService fileService = new FileService();
        private int choosedGender = 1;
        private string _avatarUrl;
        public RegisterForm()
        {
            this.InitializeComponent();
        }
        private async void Btn_Save(object sender, RoutedEventArgs e)
        {
            var account = new Account
            {
                firstName = FirstName.Text,
                lastName = LastName.Text,
                password = Password.Password.ToString(),
                avatar = _avatarUrl,
                phone = Phone.Text,
                address = Address.Text,
                email = Email.Text,
                introduction = Introduction.Text,
                gender = choosedGender,
                birthday = dataPicker.SelectedDate.Value.ToString("yyyy-MM-dd")
            };
            var result = await accountService.RegisterAsync(account);
            if (result)
            {
                ContentDialog contentDialog = new ContentDialog();
                contentDialog.Title = "Action success";
                contentDialog.Content = $"Register success. Your email is {account.email}";
                contentDialog.PrimaryButtonText = "Okie";
                await contentDialog.ShowAsync();
            }
            else
            {
                ContentDialog contentDialog = new ContentDialog();
                contentDialog.Title = "Action fails";
                contentDialog.Content = $"Register fails. Please try again!";
                contentDialog.PrimaryButtonText = "Okie";
                await contentDialog.ShowAsync();
            }
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            var currenTag = radioButton.Tag;
            switch (currenTag)
            {
                case "Male":
                    choosedGender = 1;
                    break;
                case "Famale":
                    choosedGender = 0;
                    break;
                case "Other":
                    choosedGender = 2;
                    break;
            }
        }

        private async void Handle_Camera(object sender, RoutedEventArgs e)
        {
            CameraCaptureUI captureUI = new CameraCaptureUI();
            captureUI.PhotoSettings.Format = CameraCaptureUIPhotoFormat.Jpeg;
            captureUI.PhotoSettings.CroppedSizeInPixels = new Size(200, 200);

            StorageFile photo = await captureUI.CaptureFileAsync(CameraCaptureUIMode.Photo);

            if (photo != null)
            {
                ProcessRing.IsActive = true;
                var result = await fileService.UploadFile(photo);
                if (result != null)
                {
                    _avatarUrl = result;
                    PreviewPhoto.ImageSource = new BitmapImage(new Uri(result));
                    PreviewPhoto.Stretch = Stretch.UniformToFill;
                }
                ProcessRing.IsActive = false;
            }
        }


        private async void Handle_Upload_Image(object sender, RoutedEventArgs e)
        {
            FileOpenPicker picker = new FileOpenPicker();
            picker.SuggestedStartLocation = PickerLocationId.PicturesLibrary;
            picker.FileTypeFilter.Add(".jpg");
            picker.FileTypeFilter.Add(".jpeg");
            picker.FileTypeFilter.Add(".png");
            picker.FileTypeFilter.Add(".mp3");
            picker.ViewMode = PickerViewMode.Thumbnail;
            Windows.Storage.StorageFile chooseFile = await picker.PickSingleFileAsync();
            if (chooseFile != null)
            {
                ProcessRing.IsActive = true;
                var result = await fileService.UploadFile(chooseFile);
                _avatarUrl = result;
                PreviewPhoto.ImageSource = new BitmapImage(new Uri(result));
                PreviewPhoto.Stretch = Stretch.UniformToFill;
                ProcessRing.IsActive = false;
            }
        }

        private void HyperLogin(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(LoginForm));
        }

        private void HyperMenu(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MenuBar));
            main.Background = new ImageBrush { ImageSource = new BitmapImage(new Uri("ms-appx:///MTG Life Counter/Assets/bea01.jpg")), Stretch = Stretch.None };
        }


    }
}
