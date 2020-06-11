using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppDistanciamientoSocial
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PrincipalPage : Application
    {
        public PrincipalPage()
        {
            InitializeComponent();
            MainPage = new AppShell();
        }
    }
}