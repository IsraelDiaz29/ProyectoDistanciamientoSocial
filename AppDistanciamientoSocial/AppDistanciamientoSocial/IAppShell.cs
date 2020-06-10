using System;
using System.Collections.Generic;
using System.Windows.Input;

namespace AppDistanciamientoSocial
{
    public interface IAppShell
    {
        ICommand HelpCommand { get; }
        ICommand RandomPageCommand { get; }
        Dictionary<string, Type> Routes { get; }
    }
}