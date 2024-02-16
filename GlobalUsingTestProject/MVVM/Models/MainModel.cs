using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalUsingTestProject.MVVM.Models
{
    public class MainModel
    {
        public int Id
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        } = string.Empty;

        public int Height
        {
            get;
            set;
        }

        public int Width
        {
            get;
            set;
        }

        public string Notes
        {
            get;
            set;
        } = string.Empty;

        public string Comments
        {
            get;
            set;
        } = string.Empty;
    }
}
