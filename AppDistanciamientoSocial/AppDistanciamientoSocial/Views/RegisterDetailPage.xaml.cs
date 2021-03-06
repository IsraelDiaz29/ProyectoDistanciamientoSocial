﻿using AppDistanciamientoSocial.Model;
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
    public partial class RegisterDetailPage : ContentPage
    {
        public RegisterDetailPageViewModel ViewModel { get; set; }
        public RegisterDetailPage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            ViewModel = new RegisterDetailPageViewModel();
            await ViewModel.LoadEmployees();
            this.BindingContext = ViewModel;
        }

        async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            BindingContext = e.SelectedItem as Employee;
            await Navigation.PushAsync(new PersonalDetail(e.SelectedItem as Employee));
           
        }
        private async void Cell_OnAppearing(object sender, EventArgs e)
        {
            var cell = sender as ViewCell;
            var view = cell.View;


            view.TranslationX = -100;
            view.Opacity = 0;

            await Task.WhenAny<bool>
                (
                    view.TranslateTo(0, 0, 250, Easing.SinIn),
                    view.FadeTo(1, 500, Easing.BounceIn)
                );

        }

       
    }
}