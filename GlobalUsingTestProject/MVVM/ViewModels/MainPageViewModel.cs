using GlobalUsingTestProject.MVVM.Models;

using MvvmHelpers;
using MvvmHelpers.Commands;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

using Command = MvvmHelpers.Commands.Command;

namespace GlobalUsingTestProject.MVVM.ViewModels
{
    public class MainPageViewModel( GlobalViewModel global ) : BaseViewModel
    {
        public GlobalViewModel Global { get; } = global;

        private int count = 0;
        public int Count
        {
            get => count;
            set => SetProperty( ref count, value );
        }

        private readonly Random random = new();

        private ICommand addNewCommand;
        public ICommand AddNewCommand => addNewCommand ??= new Command( AddNew );

        private AsyncCommand goToDisplayPageCommand;
        public AsyncCommand GoToDisplayPageCommand => goToDisplayPageCommand ??= new AsyncCommand( GoToDisplayPage );

        private async Task GoToDisplayPage()
        {
            Dictionary<string, object> queryParams = new()
            {
                { "Test", "Test" }
            };

            await Shell.Current.GoToAsync( Routes.DisplayPage_PageName, true, queryParams );
        }

        private int GetBoundedRandom()
        {
            return random.Next( 0, 100 );
        }

        private void AddNew()
        {
            MainModel mm = new()
            {
                Id = count,
                Name = $"MainModel {count}",
                Height = GetBoundedRandom(),
                Width = GetBoundedRandom(),
                Notes = $"This is the note for Model {count}",
                Comments = $"This is the comment for Model {count}"
            };
            Count++;

            MainViewModel mvm = new( mm );

            Global.mainModels.Add( mm );
            Global.MainViewModels.Add( mvm );
        }
    }
}
