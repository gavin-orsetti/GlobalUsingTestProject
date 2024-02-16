using GlobalUsingTestProject.MVVM.Models;

using MvvmHelpers;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalUsingTestProject.MVVM.ViewModels
{
    public class GlobalViewModel : BaseViewModel
    {
        private ObservableRangeCollection<MainViewModel> mainViewModels;
        public ObservableRangeCollection<MainViewModel> MainViewModels => mainViewModels ??= [];

        public List<MainModel> mainModels = [];
    }
}
