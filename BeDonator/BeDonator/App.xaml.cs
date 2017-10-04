using BeDonator.Views;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace BeDonator
{
	public partial class App : Application
	{
        public App()
		{
			InitializeComponent();

			SetMainPage();
		}

		public static void SetMainPage()
		{
            Current.MainPage = new TabbedPage
            {
                Children =
                {
                    new NavigationPage(new ItemsPage())
                    {
                        Title = "Browse",
                        Icon =  GetFeedIcon()
                    },
                    new NavigationPage(new AboutPage())
                    {
                        Title = "About",
                        Icon = GetAboutIcon()
                    },
                }
            };

        }
        private static string GetFeedIcon(){
            switch (Device.RuntimePlatform){
                case Device.iOS:
                    return "tab_feed.png";
                default:
                    return null;
            }
        }
        private static string GetAboutIcon()
        {
            switch (Device.RuntimePlatform)
            {
                case Device.iOS:
                    return "tab_about.png";
                default:
                    return null;
            }
        }

	}
}
