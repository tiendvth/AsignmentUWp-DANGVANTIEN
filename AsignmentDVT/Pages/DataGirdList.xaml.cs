using AsignmentDVT.Service;
using System;
using System.Collections.Generic;
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

namespace AsignmentDVT.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class DataGirdList : Page
    {
        private SongService songService = new SongService();
        public DataGirdList()
        {
            this.InitializeComponent();
            this.Loaded += DataGirdPage_Loaded;
        }

        private async void DataGirdPage_Loaded(object sender, RoutedEventArgs e)
        {
            var datagrid = await songService.GetLatestSongAsync();
            DataSong.ItemsSource = datagrid;
        }
    }
}