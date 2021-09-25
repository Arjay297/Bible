using Bible.Models;
using Bible.Views;
using MvvmHelpers.Commands;
using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Bible.ViewModels
{
    public class AboutViewModel : ViewModelBase
    {
        public ObservableCollection<Verse> Verses { get; set; }

        private Verse verse;
        public Verse Verse
        {
            get { return verse; }
            set { verse = value; }
        }

        public ICommand SelectionChangedCommand { get; set; }

        public AboutViewModel()
        {
            Title = "Verses";
            Verses = new ObservableCollection<Verse>()
            {
                new Verse(){ VerseNumber = 1, VerseInfo = "The best thing in life comes to those people who wait patiently"},
                new Verse(){ VerseNumber = 2, VerseInfo = "The best thing in life comes to those people who wait patiently"},
                new Verse(){ VerseNumber = 3, VerseInfo = "The best thing in life comes to those people who wait patiently"},
                new Verse(){ VerseNumber = 4, VerseInfo = "The best thing in life comes to those people who wait patiently"},
                new Verse(){ VerseNumber = 5, VerseInfo = "The best thing in life comes to those people who wait patiently"},
                new Verse(){ VerseNumber = 6, VerseInfo = "The best thing in life comes to those people who wait patiently"},
                new Verse(){ VerseNumber = 7, VerseInfo = "The best thing in life comes to those people who wait patiently"},
                new Verse(){ VerseNumber = 8, VerseInfo = "The best thing in life comes to those people who wait patiently"},
                new Verse(){ VerseNumber = 9, VerseInfo = "The best thing in life comes to those people who wait patiently"},
            };

            SelectionChangedCommand = new AsyncCommand(SelectionChangedAsync);
        }

        private async Task SelectionChangedAsync()
        {
            await Shell.Current.GoToAsync($"{nameof(InfoPage)}?Number={Verse.VerseNumber}&Info={Verse.VerseInfo}");
        }    
    }
}