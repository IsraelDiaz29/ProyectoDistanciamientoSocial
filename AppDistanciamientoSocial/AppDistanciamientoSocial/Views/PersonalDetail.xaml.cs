using AppDistanciamientoSocial.Model;
using AppDistanciamientoSocial.ViewModel;
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

        public PersonalDetail(Employee currentEmployee)
        {
            InitializeComponent();
            this.currentEmployee = currentEmployee;
            BindingContext = new PersonDetailViewModel(Navigation, currentEmployee);
        }
    }
}