using System;
using System.Windows;

namespace KMA.ProgrammingInCSharp.Lab2.Tools
{
    internal enum ModesEnum
    {
        Main
    }
    class NavigationModel
    {
        private readonly Window _contentWindow;
        private MainView _mainView;

        internal NavigationModel(Window contentWindow)
        {
            _contentWindow = contentWindow;
        }

        internal void Navigate(ModesEnum mode)
        {
            switch (mode)
            {
                case ModesEnum.Main:
                    _contentWindow.Content = _mainView ?? (_mainView = new MainView());
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(mode), mode, null);
            }
        }
    }
}
