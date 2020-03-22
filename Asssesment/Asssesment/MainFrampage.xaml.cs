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

namespace Asssesment
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainFrampage : Page
    {
        public MainFrampage()
        {
            this.InitializeComponent();
            Back.Visibility = Visibility.Collapsed;
            MyFrame.Navigate(typeof(Home));
            TitleTextBlock.Text = "";
            Home.IsSelected = true;
        }

        private void Iconslistbox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Home.IsSelected)
            {
                Back.Visibility = Visibility.Collapsed;
                MyFrame.Navigate(typeof(Home));
            }
            else if (Report.IsSelected)
            {
                Back.Visibility = Visibility.Visible;
                MyFrame.Navigate(typeof(Report));
            }
            else if (Back.IsSelected)
            {
                if (MyFrame.CanGoBack)
                {
                    MyFrame.GoBack();
                    Home.IsSelected = true;
                }
            }
        }


        private void HamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
        }
        public class SearchParams
        {
            public SearchParams() { }
            public string Name { get; set; }
            public string Value { get; set; }
        }

        
        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void searchclick(object sender, RoutedEventArgs e)
        {
            Back.Visibility = Visibility.Visible;
            var parameters = new SearchParams();
            parameters.Name = "SearchParameter";
            parameters.Value = SearchTextBox.Text;
            // ...

            MyFrame.Navigate(typeof(SerachPage), parameters);
        }
    }
}
