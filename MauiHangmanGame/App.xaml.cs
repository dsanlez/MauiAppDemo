using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MauiHangmanGame
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
    }
}
