using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
//Using Microcharts
using Microcharts;
//Especificar que los entrys son los del nuget
using Entry = Microcharts.Entry;
//Using a SkiaSharp para los colores de los gráficos
using SkiaSharp;
using AppDistanciamientoSocial.ViewModel;

namespace AppDistanciamientoSocial.Views
{
    public partial class ReporteGrupal : ContentPage
    {
        public ReportViewModel ViewModel { get; set; }

        public ReporteGrupal()
        {
            InitializeComponent();
            donutChartFirst.Chart = new DonutChart()
            {
                Entries = LoadEntriesDonut("#7CE5ED", "#CFDBD5")
            };
            donutChartSecond.Chart = new DonutChart()
            {
                Entries = LoadEntriesDonut("#CFDBD5", "#E92E00")
            };
            lineChartPrimero.Chart = new LineChart()
            {
                Entries = LoadLine("#7CE5ED")
            };
            lineChartSegundo.Chart = new LineChart()
            {
                Entries = LoadLine("#E92E00")
            };
        }
        private List<Entry> LoadEntriesDonut(String _colorUno, String _colorDos)
        {
            List<Entry> entryList = new List<Entry>();
            Entry e1 = new Entry(60)
            {
                Color = SKColor.Parse(_colorUno)
            };
            Entry e2 = new Entry(40)
            {
                Color = SKColor.Parse(_colorDos)
            };
            entryList.Add(e2);
            entryList.Add(e1);
            return entryList;
        }

        private List<Entry> LoadLine(String _color)
        {
            List<Entry> entryList = new List<Entry>();
            Entry e1 = new Entry(1)
            {
                Label = "-1",
                ValueLabel = "70",
                Color = SKColor.Parse(_color)
            };
            Entry e2 = new Entry(71)
            {
                Label = "-2",
                ValueLabel = "71",
                Color = SKColor.Parse(_color)
            };
            Entry e3 = new Entry(72)
            {
                Label = "-3",
                ValueLabel = "72",
                Color = SKColor.Parse(_color)
            };
            Entry e4 = new Entry(73)
            {
                Label = "-4",
                ValueLabel = "73",
                Color = SKColor.Parse(_color)
            };
            entryList.Add(e1);
            entryList.Add(e2);
            entryList.Add(e3);
            entryList.Add(e4);
            entryList.Add(e2);
            return entryList;
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            //ViewModel = new ReportViewModel();
            //this.BindingContext = ViewModel;
            //var valor = await ViewModel.LoadIncidencias();

        }
    }
}