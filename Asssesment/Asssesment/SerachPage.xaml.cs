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
    public sealed partial class SerachPage : Page
    {
        public SerachPage()
        {
            this.InitializeComponent();
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            var parameters = (MainFrampage.SearchParams)e.Parameter;
            SearchElement.Text = parameters.Value;
           
        }

        

        

        private void button_viewmore1_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(DiseaseDetail));
            

        }

        private void button_viewmore2_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(DiseaseDetail));
        }
    }
}
