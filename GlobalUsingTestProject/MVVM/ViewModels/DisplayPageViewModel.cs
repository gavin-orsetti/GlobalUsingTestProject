using MvvmHelpers;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalUsingTestProject.MVVM.ViewModels
{
    public class DisplayPageViewModel( GlobalViewModel global ) : BaseViewModel
    {
        public GlobalViewModel Global { get; } = global;

    }
}
