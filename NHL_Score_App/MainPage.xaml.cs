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
using System.Diagnostics;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace NHL_Score_App
{
    public sealed partial class MainPage : Page
    {
        public static TextBlock VisitorScoreTextBlock { get; set; }
        public static TextBlock StatusTextBlock { get; set; }
        public static TextBlock HomeScoreTextBlock { get; set; }

        public static Image VisitorLogoImage { get; set; }
        public GameViewModel GameVM { get; set; }

        public MainPage()
        {
            this.InitializeComponent();
            this.GameVM = new GameViewModel();

            VisitorScoreTextBlock = visitor_score_text;
            StatusTextBlock = game_status_text;
            HomeScoreTextBlock = home_score_text;

            VisitorLogoImage = visitor_logo_image;
        }

        private void AboutDetails_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(About));
        }

        private void ExtraDetails_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Details));
        }

        private void goal_scorers_button_Click(object sender, RoutedEventArgs e)
        {
            GameVM.DisplayDialogStats();
        }
    }
}
