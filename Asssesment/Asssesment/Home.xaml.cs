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
    public sealed partial class Home : Page
    {
        

        private void Image1_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            Frame.Navigate(typeof(DiseaseDetail));
        }
        private void Image2_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            Frame.Navigate(typeof(DiseaseDetail));
        }
        private void Image3_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            Frame.Navigate(typeof(DiseaseDetail));
        }
    }
}
