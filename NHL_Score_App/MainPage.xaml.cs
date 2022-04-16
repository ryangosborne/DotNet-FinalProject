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
using NHL_Score_App.ViewModels;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace NHL_Score_App
{
    public sealed partial class MainPage : Page
    {
        public GameViewModel GameVM { get; set; }

        public MainPage()
        {
            this.InitializeComponent();
            this.GameVM = new GameViewModel();
        }

        private void AboutDetails_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(About));
        }

        private void ExtraDetails_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Details));
        }
    }
}
