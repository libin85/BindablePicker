using Xamarin.Forms;
using Prism.Unity;
using PickerSample.Views;
using System.Threading.Tasks;
using Prism.Logging;
using System;

namespace PickerSample
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer initializer = null) : base(initializer) { }

        protected async override void OnInitialized()
        {
            InitializeComponent();
			try
			{
				TaskScheduler.UnobservedTaskException += (sender, e) => {
					Logger.Log(e.Exception.ToString(), Category.Exception, Priority.High);
				};
				await NavigationService.NavigateAsync("MainPage"); ;
			}
			catch (Exception e)
			{
				Logger.Log(e.ToString(), Category.Exception, Priority.High);
			}


        }

        protected override void RegisterTypes()
        {
            Container.RegisterTypeForNavigation<MainPage>();
        }
    }
}

