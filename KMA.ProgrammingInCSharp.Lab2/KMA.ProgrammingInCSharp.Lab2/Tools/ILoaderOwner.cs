
using System.ComponentModel;
using System.Windows;

namespace KMA.ProgrammingInCSharp.Lab2.Tools
{
    internal interface ILoaderOwner : INotifyPropertyChanged
    {
        Visibility LoaderVisibility { get; set; }
        bool IsEnabled { get; set; }
    }
}
