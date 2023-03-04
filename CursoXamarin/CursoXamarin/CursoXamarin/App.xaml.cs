using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CursoXamarin
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new MainPage(); //Cambiar pagina principal de nuestra app
            //MainPage = new NavigationPage(new Page1()); //new NavigationPages es para que android reconozca el constructor
            //MainPage = new FlyoutPage1(); //Cambia vista definible
            //MainPage = new NavigationPage(new FlyoutPage1());
            MainPage = new TabbedPage1 (); //Pagina con pestañas
            //MainPage = new NavigationPage(new TabbedPage1());
            //MainPage = new Carousel();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
