using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PickerSample.ViewModels
{
    public class MainPageViewModel : BindableBase, INavigationAware
    {
       
		public List<string> BinCodes
		{
			get; set;
		}

		public MainPageViewModel()
        {
           BindValues();

        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {

        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
            
        }

        public void OnNavigatingTo(NavigationParameters parameters)
        {
			
        }

		public void BindValues()
		{
            BinCodes = new List<string>();
			BinCodes.Add("1");
			BinCodes.Add("2");
			BinCodes.Add("3");
			BinCodes.Add("4");
			BinCodes.Add("5");

		}
    }
}

