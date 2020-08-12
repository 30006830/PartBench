using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI.ViewManagement;
using System.Threading.Tasks;
using Windows.Security.Cryptography.Core;
using System.Threading;
using Windows.ApplicationModel.Core;
using Windows.UI.Xaml.Media.Animation;



// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace PartBench
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class SplashScreen : Page
    {
        public SplashScreen()
        {
            this.InitializeComponent();
            Redirect();
            LogoFade();
        }

        private async void Redirect() 
        {
            await Task.Delay(3400);
            this.Frame.Navigate(typeof(MainPage));
        }

        private async void LogoFade()
        {
            for (int i = 0; i < 3000; i++)
            {
                await Task.Delay(50);
                _2ndlogo.Opacity += 0.05;
            }
        }
    }
}
