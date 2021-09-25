using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Bible.ViewModels
{
    [QueryProperty(nameof(Number), nameof(Number))]
    [QueryProperty(nameof(Info), nameof(Info))]
    public class InfoViewModel : ViewModelBase
    {
        private string number;
        public string Number 
        { 
            get => number; 
            set => SetProperty(ref number, value); 
        }

        private string info;
        public string Info 
        { 
            get => info; 
            set => SetProperty(ref info, value); 
        }

        public InfoViewModel()
        {
            Title = "Info Page";
        }


    }


}
