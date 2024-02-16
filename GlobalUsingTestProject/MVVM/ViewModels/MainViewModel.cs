using GlobalUsingTestProject.MVVM.Models;

using MvvmHelpers;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalUsingTestProject.MVVM.ViewModels
{
    public class MainViewModel( MainModel model ) : BaseViewModel
    {

        private MainModel model = model;

        private int id = model.Id;
        public int Id
        {
            get => id;
            set => SetProperty( ref id, value );
        }

        private string name = model.Name;
        public string Name
        {
            get => name;
            set => SetProperty( ref name, value );
        }

        private int height = model.Height;
        public int Height
        {
            get => height;
            set => SetProperty( ref height, value );
        }

        private int width = model.Width;
        public int Width
        {
            get => width;
            set => SetProperty( ref width, value );
        }

        private string notes = model.Notes;
        public string Notes
        {
            get => notes;
            set => SetProperty( ref notes, value );
        }

        private string comments = model.Comments;
        public string Comments
        {
            get => comments;
            set => SetProperty( ref comments, value );
        }
    }
}
