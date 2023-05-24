using Dot_Box.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dot_Box.ViewModels
{
    internal class MainWindowViewModel : ViewModel
    {
        private string _Title = "Dotes&Boxes";

        public string Title
        {
            get => _Title;

            set => Set(ref _Title, value);
        }
    }
}
