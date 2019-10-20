using TesteDrive.View;
using Xamarin.Forms;

namespace TesteDrive
{
    public partial class App : Application
    {
        public App()
        {
            //Entrada da aplicação
            InitializeComponent();

            //permite o empilhamento de páginas
            MainPage = new NavigationPage(new ListagemView());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
