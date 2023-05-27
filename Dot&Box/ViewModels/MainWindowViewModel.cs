using Dot_Box.Infrastructure.Commands;
using Dot_Box.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Dot_Box.ViewModels
{
    internal class MainWindowViewModel : ViewModel
    {
        #region Заголовок окна
        private string _Title = "Dotes&Boxes";

        public string Title
        {
            get => _Title;

            set => Set(ref _Title, value);
        }

        #endregion
        #region Комманды

        #region CloseApplicationCommand
        public ICommand CloseApplicationCommand { get; }

        private void OnCloseApplicationCommandExecuted(object p)
        {
            Application.Current.Shutdown();

        }

        private bool CanCloseApplicationCommandExecute(object p) => true;
        #endregion

        #region
        


        #endregion

        #endregion
        public MainWindowViewModel()
        {
            #region Комманды
            CloseApplicationCommand = new LambdaCommand(OnCloseApplicationCommandExecuted, CanCloseApplicationCommandExecute);
            #endregion

        }
    }
}
