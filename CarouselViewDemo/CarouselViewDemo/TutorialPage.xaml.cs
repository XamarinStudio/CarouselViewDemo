using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CarouselViewDemo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TutorialPage : ContentPage
    {
        public TutorialPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        void GoHomePage(object sender, EventArgs args)
        {
            DependencyService.Get<IDarkService>().SetWindowGray();
            App.Current.MainPage = new MainPage();
        }
        private void OnCurrentChange(object sender, EventArgs args)
        {
            arrowLeft.IsVisible = carouseView.Position != 0;
            arrowRight.IsVisible = carouseView.Position != 3;
            button.IsVisible = carouseView.Position == 3;
        }
    }
}