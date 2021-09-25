using Bible.Models;
using Bible.Services.Contracts;
using Bible.Views;
using MvvmHelpers.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Bible.ViewModels
{
    public class PastorViewModel : ViewModelBase
    {     

        private readonly IPastorService pastorService;
        public AsyncCommand ViewPastorCommand { get; set; }

        public PastorViewModel()
        {
            Title = "Pastor Page";

            ViewPastorCommand = new AsyncCommand(ViewPastorInfoAsync);
            pastorService = DependencyService.Get<IPastorService>();

            Pastors = pastorService.GetPastors();
        }

        private async Task ViewPastorInfoAsync()
        {
            await Shell.Current.GoToAsync($"{nameof(PastorInfoPage)}?Id={SelectedPastor.Id}");
        }

        private ObservableCollection<Pastor> pastors;
        public ObservableCollection<Pastor> Pastors
        {
            get { return pastors; }
            set 
            {
                SetProperty(ref pastors, value);
            }
        }

        private Pastor selectedPastor;
        public Pastor SelectedPastor
        {
            get { return selectedPastor; }
            set { SetProperty(ref selectedPastor, value); }
        }


    }
}
