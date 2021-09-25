using Bible.Models;
using Bible.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Bible.ViewModels
{
    [QueryProperty(nameof(Id), nameof(Id))]
    public class PastorInfoViewModel : ViewModelBase
    {
        private string id;
        public string Id
        {
            get { return id; }
            set { SetProperty(ref id, value); }
        }

        private Pastor pastor;
        public Pastor Pastor
        {
            get { return pastor; }
            set { SetProperty(ref pastor, value); }
        }

        public ICommand OnAppearingCommand { get; set; }

        private readonly IPastorService pastorService;

        public PastorInfoViewModel()
        {
            Title = "Pastor Info";
            pastorService = DependencyService.Get<IPastorService>();

            OnAppearingCommand = new Command(OnAppearing);
        }

        private void OnAppearing()
        {
            Pastor = pastorService.GetPastorById(Id);
        }
    }
}
