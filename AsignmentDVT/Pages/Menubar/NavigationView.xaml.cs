using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace AsignmentDVT.Pages.Menubar
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class NavigationView : Page
    {
        public NavigationView()
        {
            this.InitializeComponent();
            this.contentFrame.Navigate(typeof(Pages.RegisterForm));
        }

        private void NavigationView_SelectionChanged(Windows.UI.Xaml.Controls.NavigationView sender, NavigationViewSelectionChangedEventArgs args)
        {
            if (args.IsSettingsSelected)
            {
                //click
                Debug.WriteLine("Seclect Setting");
            }
            var navigationViewItem = args.SelectedItem as NavigationViewItem;
            switch (navigationViewItem.Tag)
            {
                case "Login":
                    this.contentFrame.Navigate(typeof(Pages.LoginForm));
                    break;
                case "Register":
                    this.contentFrame.Navigate(typeof(Pages.RegisterForm));
                    break;
                case "Profile":
                    this.contentFrame.Navigate(typeof(Pages.Profile));
                    break;
                case "ListSong":
                    this.contentFrame.Navigate(typeof(Pages.ListSong));
                    break;
                case "CreateSong":
                    this.contentFrame.Navigate(typeof(Pages.CreateSong));
                    break;
                case "DataGrid":
                    this.contentFrame.Navigate(typeof(Pages.DataGirdList));
                    break;
            }
        }
    }
}
