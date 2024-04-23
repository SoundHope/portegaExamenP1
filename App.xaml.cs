using portegaExamenP1.views;

namespace portegaExamenP1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new vLogin());
        }
    }
}
