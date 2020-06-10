using AppDistanciamientoSocial.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppDistanciamientoSocial.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PersonalDetail : ContentPage
    {
        private Employee currentEmployee;

        public PersonalDetail()
        {
            InitializeComponent();
        }

        public PersonalDetail(Employee currentEmployee)
        {
            this.currentEmployee = currentEmployee;
        }
    }
}